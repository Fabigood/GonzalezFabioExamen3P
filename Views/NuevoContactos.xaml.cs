using GonzalezFabioExamen3P.ViewModels;

namespace GonzalezFabioExamen3P.Views
{
    public partial class NuevoContacto : ContentPage
    {
        public NuevoContacto(NuevoContactoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;  // Asignamos el ViewModel al BindingContext
        }
    }
}
