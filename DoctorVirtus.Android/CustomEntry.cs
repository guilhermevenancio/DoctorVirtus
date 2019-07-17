using DoctorVirtus.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace DoctorVirtus.Android
{
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var nativeEditText = Control;
                nativeEditText.SetBackgroundResource(Resource.Drawable.Entry);
            }
        }
    }
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
}