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
    public partial class HoraSalida : ContentPage
    {
        public HoraSalida(int parada)
        {
            InitializeComponent();
        }
    }
}