using CommunityToolkit.Mvvm.ComponentModel;  
using CommunityToolkit.Mvvm.Input;
using GonzalezFabioExamen3P.Models;         
using GonzalezFabioExamen3P.Services;     
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GonzalezFabioExamen3P.ViewModels
{
    public partial class NuevoContactoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string correo;

        [ObservableProperty]
        private string telefono;

        [ObservableProperty]
        private bool favorito;

        private readonly DatabaseService dbService;
        private readonly LogService logService;

        public NuevoContactoViewModel(DatabaseService db, LogService log)
        {
            dbService = db;
            logService = log;
        }

        [RelayCommand]
        public async Task GuardarAsync()
        {
            if (!Telefono.StartsWith("+593"))
            {
                await Shell.Current.DisplayAlert("Error", "El teléfono debe iniciar con +593", "OK");
                return;
            }

            var contacto = new Contacto
            {
                Nombre = Nombre,
                Correo = Correo,
                Telefono = Telefono,
                Favorito = Favorito
            };

            await dbService.AddContacto(contacto);

            await logService.AppendLogAsync(Nombre);

            await Shell.Current.DisplayAlert("Éxito", "Contacto guardado", "OK");

       
            Nombre = Correo = Telefono = string.Empty;
            Favorito = false;
        }
    }
}
