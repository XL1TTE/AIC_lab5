using AIC_LAB5.Client.Commands;
using AIC_LAB5.Client.MVVM.View;
using AIC_LAB5.Client.MVVM.ViewModel;
using AIC_LAB5.Client.Services;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AIC_LAB5.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IViewModelFactory _viewModelFactory;
        private readonly INavigationService _navigationService;

        private App()
        {
            // Регистрируем необходимые viewmodels.
            #region ViewModelFactory

            _viewModelFactory = new ViewModelFactory();

            _viewModelFactory.Register<StudentsViewModel>(() => new StudentsViewModel());
            _viewModelFactory.Register<SpecialitiesHistoViewModel>(() => new SpecialitiesHistoViewModel());

            #endregion


            // Создаем сервис навигации для viewmodel factory
            _navigationService = NavigationService.Create(_viewModelFactory);

        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            #region StartUpWindow

            var StartUpWindow = new MainWindow();
            // По умолчанию отображаем страницу со студентами.
            _navigationService.NavigateTo<StudentsViewModel>();

            StartUpWindow.DataContext = new
            {
                NavigationService = _navigationService,
                NavigateToStudentsCommand = new RelayCommand(o => _navigationService.NavigateTo<StudentsViewModel>(), o => true),
                NavigateToSpecialitiesHistCommand = new RelayCommand(o => _navigationService.NavigateTo<SpecialitiesHistoViewModel>(), o => true),
            };

            StartUpWindow.Show();

            #endregion
        }
    }

}
