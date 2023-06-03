using CULMS.Helpers;
using Octane.Xamarin.Forms.VideoPlayer.Constants;
using Xamarin.Forms;

namespace CULMS.ViewModel.DashboardVM
{
    public class VideoPageVM : ObservableObject
    {

        #region Private Properties

        private LayoutOptions videoVerticalOption;
        private string zoomImage;
        private FillMode videoFillMode;
        #endregion

        #region Public Properties

        public string ZoomImage
        {
            get { return zoomImage; }
            set { zoomImage = value; OnPropertyChanged(nameof(ZoomImage)); }
        }

        public LayoutOptions VideoVerticalOption
        {
            get { return videoVerticalOption; }
            set { videoVerticalOption = value; OnPropertyChanged(nameof(VideoVerticalOption)); }
        }
        public FillMode VideoFillMode
        {
            get { return videoFillMode; }
            set { videoFillMode = value; OnPropertyChanged(nameof(VideoFillMode)); }
        }

        #endregion

        #region Methods

        public VideoPageVM()
        {
            ZoomImage = "zoom_in";
            VideoVerticalOption = LayoutOptions.StartAndExpand;
        }
        #endregion

        #region Commands
        public Command ZoomCommand => new Command(() =>
        {
            if (ZoomImage == "zoom_in")
            {
                if (Device.Idiom == TargetIdiom.Phone)
                {
                    MessagingCenter.Send(this, "SetLandscapeModeOn");
                    VideoVerticalOption = LayoutOptions.FillAndExpand;
                    VideoFillMode = FillMode.Resize;
                    // MessagingCenter.Send<MainPageVM>(this, "SetLandscapeModeOn");
                }
                ZoomImage = "zoom_out";
            }
            else
            {
                MessagingCenter.Send(this, "SetLandscapeModeOff");
                VideoVerticalOption = LayoutOptions.StartAndExpand;
                ZoomImage = "zoom_in";
            }
        });


        #endregion
    }
}
