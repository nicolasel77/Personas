using Personas.Clases;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Personas.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vw_Personas : ContentPage
    {
        public vw_Personas()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }
    }
}