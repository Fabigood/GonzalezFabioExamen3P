using GonzalezFabioExamen3P.Services;
using GonzalezFabioExamen3P.ViewModels;
using GonzalezFabioExamen3P.Views;

namespace GonzalezFabioExamen3P
{
    public partial class App : Application
    {
        public App(DatabaseService dbService, LogService logService)
        {
            InitializeComponent();

            var viewModel = new NuevoContactoViewModel(dbService, logService);

            MainPage = new NavigationPage(new NuevoContacto(viewModel));
        }
    }
}
