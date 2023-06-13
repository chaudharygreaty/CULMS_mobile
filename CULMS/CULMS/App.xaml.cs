using CULMS.Helpers;
using CULMS.View.Auth;
using CULMS.View.Dashboard;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CULMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var isLogin = Preferences.Get(StringConstant.IsLogin, false);
            if (isLogin)
            {
                MainPage = new HomePage();
               // MainPage = new TestPage();
            }
            else
            {
                MainPage= new LoginPage();
            }
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
