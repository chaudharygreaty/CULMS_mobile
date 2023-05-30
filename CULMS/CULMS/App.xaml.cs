using CULMS.Helpers;
using CULMS.View.Auth;
using CULMS.View.Dashboard;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                MainPage = new AllCoursePage();
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
