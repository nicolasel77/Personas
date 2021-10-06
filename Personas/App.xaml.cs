using Personas.Vistas;
using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Personas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new vw_Personas();
        }

        protected override void OnStart()
        {
            var userSelectedCulture = new CultureInfo("es-AR");
            Thread.CurrentThread.CurrentCulture = userSelectedCulture;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
