using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Octane.Xamarin.Forms.VideoPlayer.Android;
using Xamarin.Forms;
using CULMS.ViewModel.DashboardVM;

namespace CULMS.Droid
{
    [Activity(Label = "CULMS", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            FormsVideoPlayer.Init();
            LoadApplication(new App());
            MessagingCenter.Subscribe<VideoPageVM>(this, "SetLandscapeModeOn", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });
            MessagingCenter.Subscribe<VideoPageVM>(this, "SetLandscapeModeOff", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}