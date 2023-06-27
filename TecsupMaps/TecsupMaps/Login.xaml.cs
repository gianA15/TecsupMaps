using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TecsupMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            // Envuelve la página Login dentro de una NavigationPage
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetBackButtonTitle(this, "Atrás");
            var navPage = new NavigationPage(this);
            Application.Current.MainPage = navPage;
        }
        private async void OnIngresarButtonClicked(object sender, EventArgs e)
        {
            // Navega a la página MapaView
            await Navigation.PushAsync(new MapaView());
        }
    }
}