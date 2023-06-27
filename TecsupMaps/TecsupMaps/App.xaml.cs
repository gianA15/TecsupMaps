using Xamarin.Forms;

namespace TecsupMaps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Establece la página inicial como una NavigationPage que envuelve la página Login
            MainPage = new NavigationPage(new Login());
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
