using Android.App;
using Android.Widget;
using DoctorVirtus.Android.Interface;
using DoctorVirtus.Aplicativo.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(ServiceToast))]
namespace DoctorVirtus.Android.Interface {

    public class ServiceToast : IToast {

        public void LongAlert(string message) {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message) {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}