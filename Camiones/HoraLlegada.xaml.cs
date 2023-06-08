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
    public partial class HoraLlegada : ContentPage
    {
        public HoraLlegada(int Parada)
        {
            InitializeComponent();
        }
    }
}