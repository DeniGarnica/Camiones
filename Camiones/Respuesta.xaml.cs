using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Camiones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Respuesta : ContentPage
    {
        public Respuesta()
        {
            InitializeComponent();
            _ = MostrarHorasAsync();
        }

        private async Task MostrarHorasAsync()
        {
            HttpClient client = new HttpClient();
            var url = "https://localhost:1433/Login.Api/Controllers/DataAccess.cs";
            var horasSalida = await ObtenerHora();

            horaListView.ItemsSource = horasSalida;
        }
    }
}