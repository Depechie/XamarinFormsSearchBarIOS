using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsSearchBarIOS.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(SearchBar), typeof(CustomSearchBarRendererNotWorking))]
namespace XamarinFormsSearchBarIOS.iOS.CustomRenderers
{
    public class CustomSearchBarRendererNotWorking : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.SearchBar> e)
        {
            base.OnElementChanged(e);

            Control.ShowsCancelButton = false;
        }
    }
}