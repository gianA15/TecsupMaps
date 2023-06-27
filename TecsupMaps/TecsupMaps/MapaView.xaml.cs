using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TecsupMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapaView : ContentPage
    {
        public MapaView()
        {
            InitializeComponent();


        }
        private async void OnButton2Clicked(object sender, EventArgs e)
        {
            // Navegar a otra página
            await Navigation.PushAsync(new CalendarView());
        }
        private async void OnButton3Clicked(object sender, EventArgs e)
        {
            // Navegar a otra página
            await Navigation.PushAsync(new ContactView());
        }

    }
}