using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoctorVirtus.Aplicativo.Plugins {
    public static class Display {

        public static Task<bool> Alert(Page page, string title, string message, string cancel, string accept = null) {

            var tcs = new TaskCompletionSource<bool>();

            Device.BeginInvokeOnMainThread(async () => {
                try {

                    if (accept == null)
                        await page.DisplayAlert(title, message, cancel);
                    else
                        await page.DisplayAlert(title, message, accept, cancel);

                    tcs.SetResult(true);

                } catch (Exception ex) {
                    tcs.SetException(ex);
                }
            });

            return tcs.Task;
        }
    }
}
