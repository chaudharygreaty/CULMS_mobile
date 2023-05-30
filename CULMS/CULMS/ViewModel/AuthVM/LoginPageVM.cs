using CULMS.Helpers;
using CULMS.View.Auth;
using CULMS.View.Dashboard;
using Microsoft.AppCenter.Crashes;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CULMS.ViewModel.AuthVM
{
    public class LoginPageVM : ObservableObject
    {
        #region Private Properties

        private bool isPassword;
        private string passwordImage;
        private string password;
        private bool isVisibleTxtEmailError;
        private string msgEmailError;
        private string email;
        #endregion

        #region Public Properties


        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                if (email != null)
                {
                    IsVisibleTxtEmailError = false;
                }
            }
        }

        public string MsgEmailError
        {
            get { return msgEmailError; }
            set { msgEmailError = value; OnPropertyChanged(nameof(MsgEmailError)); }
        }

        public bool IsVisibleTxtEmailError
        {
            get { return isVisibleTxtEmailError; }
            set { isVisibleTxtEmailError = value; OnPropertyChanged(nameof(IsVisibleTxtEmailError)); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public string PasswordImage
        {
            get { return passwordImage; }
            set { passwordImage = value; OnPropertyChanged(nameof(PasswordImage)); }
        }

        public bool IsPassword
        {
            get { return isPassword; }
            set { isPassword = value; OnPropertyChanged(nameof(IsPassword)); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor to login page
        /// </summary>
        public LoginPageVM()
        {
            PasswordImage = "showPasswordIcon";
            IsPassword = true;
        }
        private bool SignInClicked()
        {
            bool IsValid = true;
            try
            {
                StringConstant.IsValidEmail = Preferences.Get("ValidEmail", false);
                if (string.IsNullOrWhiteSpace(Email))
                {
                    IsVisibleTxtEmailError = true;
                    MsgEmailError = "*Enter Email";
                    IsValid = false;
                }
                else if (StringConstant.IsValidEmail != true)
                {
                    IsVisibleTxtEmailError = true;
                    MsgEmailError = "Please enter valid email id";
                    IsValid = false;
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
            return IsValid;
        }
        #endregion

        #region Commands
        /// <summary>
        /// Command for navigate to back page
        /// </summary>
        public Command FogotPasswordCommand => new Command(async () =>
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new ForgotPasswordPage());
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        });

        /// <summary>
        /// Command for show and hide password
        /// </summary>
        public Command ShowPasswordCommand => new Command(() =>
        {
            try
            {
                if (PasswordImage == "showPasswordIcon")
                {
                    IsPassword = false;
                    PasswordImage = "hidePasswordIcon";
                }
                else if (PasswordImage == "hidePasswordIcon")
                {
                    IsPassword = true;
                    PasswordImage = "showPasswordIcon";
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        });

        public Command LoginCommand => new Command(async () =>
        {
            try
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    IsLoading = true;
                    Task.Delay(1000);
                });
                if (SignInClicked())
                {
                    Preferences.Set(StringConstant.TabIdKey, 1);
                    Preferences.Set(StringConstant.IsLogin, true);
                    Application.Current.MainPage = new HomePage();
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
            finally
            {
                IsLoading = true;
            }
        });
        #endregion
    }
}
