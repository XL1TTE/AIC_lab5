using AIC_LAB5.Client.MVVM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AIC_LAB5.Client.MVVM.ViewModel
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        void OnPropertyChanged(string propertyName);
    }

    /// <summary>
    /// Класс который использутеся для создания viewmodel. Автоматически устанавливает DataContext у view на себя.
    /// </summary>
    /// <typeparam name="ViewType"></typeparam>
    public abstract class ViewModelBase<ViewType>: IViewModelBase, INotifyPropertyChanged where ViewType : UserControl, IView, new()
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ViewType _view = null!;
        public ViewType View
        {
            get => _view;
            set
            {
                _view = value;
                OnPropertyChanged();
            }
        }

        public ViewModelBase()
        {
            View = new ViewType();

            try
            {
                View.DataContext = this;

            }
            catch
            {
                throw new Exception("ViewModel должна создаваться на основе view типа Control.");
            }

        }

        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
