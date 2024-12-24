using AIC_LAB5.Client.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace AIC_LAB5.Client.Services
{
    public interface INavigationService : INotifyPropertyChanged
    {
        public IViewModelBase ActiveViewModel { get; set; }
        public void OnPropertyChanged(string propName);

        public void NavigateTo<ViewModelType>();

    }

    public class NavigationService : INavigationService, INotifyPropertyChanged
    {
        private IViewModelBase _activeViewModel = null!;
        public IViewModelBase ActiveViewModel
        {
            get => _activeViewModel;
            set
            {
                _activeViewModel = value;
                OnPropertyChanged();
            }
        }

        private readonly IViewModelFactory _viewModelFactory;

        #region Constructor
        private NavigationService(IViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        #endregion


        /// <summary>
        /// Фабричный метод создания сервиза навигации.
        /// </summary>
        public static INavigationService Create(IViewModelFactory viewModelFactory)
        {
            return new NavigationService(viewModelFactory);
        }

        public void NavigateTo<ViewModelType>()
        {
            ActiveViewModel = _viewModelFactory.ViewModels[typeof(ViewModelType)];
        }


        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #endregion

    }
}
