using AIC_LAB5.Client.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_LAB5.Client.Services
{
    public interface IViewModelFactory
    {
        /// <summary>
        /// Словарь, в котором будем хранить объекты ViewModels по типу ViewModel.
        /// </summary>
        public Dictionary<Type, IViewModelBase> ViewModels { get; set; }

        /// <summary>
        /// Регестрирует объект viewmodel по его типу.
        /// </summary>
        /// <typeparam name="TViewModel"> Тип ViewModel, которую необходимо зарегистрировать.</typeparam>
        /// <param name="factory"> Делегат, который содержит функцию создания объекта ViewModel.</param>
        public void Register<TViewModel>(Func<TViewModel> factory) where TViewModel : IViewModelBase;
    }

    public class ViewModelFactory : IViewModelFactory
    {
        private Dictionary<Type, IViewModelBase> _viewModels = new Dictionary<Type, IViewModelBase>();

        public Dictionary<Type, IViewModelBase> ViewModels 
        {
            get => _viewModels;
            set => _viewModels = value;
        }

        #region constructor

        public ViewModelFactory()
        {

        }

        #endregion

        public void Register<TViewModel>(Func<TViewModel> factory) where TViewModel : IViewModelBase
        {
            try
            {
                var viewModel = factory();
                ViewModels.TryAdd(typeof(TViewModel), viewModel);
            }
            catch
            {
                throw new Exception($"Не удалось зарегестрировать ViewModel типа: {typeof(TViewModel)}.");
            }
        }   


    }
}
