using CommunityToolkit.Mvvm.ComponentModel;
using GonzalezFabioExamen3P.Models;
using GonzalezFabioExamen3P.Services;

namespace GonzalezFabioExamen3P.ViewModels
{
    public partial class ListaContactosViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Contacto> contactos;

        private readonly DatabaseService dbService;

        public ListaContactosViewModel(DatabaseService db)
        {
            dbService = db;
            LoadData();
        }

        async void LoadData()
        {
            Contactos = await dbService.GetContactos();
        }
    }
}
