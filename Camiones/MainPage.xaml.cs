using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Camiones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;


            if (email != null && password != null)
            {
                await Navigation.PushAsync(new ElegirPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Ingrese los datos requeridos", "Continuar");
            }

        }
    }
}
