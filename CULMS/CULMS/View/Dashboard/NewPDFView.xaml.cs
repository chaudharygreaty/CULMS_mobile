using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace CULMS.View.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPDFView : ContentPage
	{
       // string url = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
        string url = "https://www.orimi.com/pdf-test.pdf";
        public NewPDFView ()
		{
			InitializeComponent ();
            if (Device.RuntimePlatform == Device.Android)
            {
                pdfView.Uri = url;
                pdfView.On<Android>().EnableZoomControls(true);
                pdfView.On<Android>().DisplayZoomControls(false);
            }

            else
                pdfView.Source = url;
        }
    }
}