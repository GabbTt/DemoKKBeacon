
using Xamarin.Forms;


namespace DemoKKBeacon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SolicitarCodigo());
            //MainPage = new NavigationPage(new RegistroKKBeacon());
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
