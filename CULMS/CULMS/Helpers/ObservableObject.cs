using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;

namespace CULMS.Helpers
{
    public class ObservableObject : BindableObject
    {
        #region private Properties

        private bool isLoading;
        #endregion

        #region Public Properties

        public bool IsLoading
        {
            get { return isLoading; }
            set { isLoading = value;OnPropertyChanged(nameof(IsLoading)); }
        }

        #endregion

        #region Commands

        #endregion

        #region Methods
        public Command BackCommand => new Command(() =>
        {
            try
            {
                App.Current.MainPage.Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        });

        #endregion
    }
}
