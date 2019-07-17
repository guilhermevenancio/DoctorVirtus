using DoctorVirtus.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonEntryRenderer))]
namespace DoctorVirtus.Android
{
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
    public class ButtonEntryRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(e.NewElement.BackgroundColor.ToAndroid());
            }
        }
    }
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
}