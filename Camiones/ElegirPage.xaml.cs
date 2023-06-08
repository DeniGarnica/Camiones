using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Camiones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElegirPage : ContentPage
    {
        public ElegirPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LlegarValenciana());
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalirValenciana());
        }
    }
}