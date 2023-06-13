using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CULMS.View.Auth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //private async void LoginFrame_Tapped(object sender, EventArgs e)
        //{
        //    await LoginFrame.ScaleTo(0.75, 100);
        //    await LoginFrame.ScaleTo(1, 100);
        //}

        private async void ForgotPassword_Clicked(object sender, EventArgs e)
        {
            await ForgotPasswordLabel.ScaleTo(0.75, 100);
            await ForgotPasswordLabel.ScaleTo(1, 100);
        }
    }
}