using Personas.Vistas;
using System;
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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
