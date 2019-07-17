using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Gms.Common;
using Firebase.Iid;
using Plugin.Permissions;
using DoctorVirtus.Aplicativo;
using Plugin.CurrentActivity;
using Firebase;
using Plugin.Media;
using FFImageLoading.Forms.Platform;
using System.IO;
using Android.Content;

namespace DoctorVirtus.Android
{
    [Activity(Label = "Atlanta Sistemas", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            /*FirebaseApp.InitializeApp(this);

            if (IsPlayServicesAvailable()) {
                var refreshedToken = FirebaseInstanceId.Instance.Token;
                CreateNotificationChannel();
            }*/

            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            UserDialogs.Init(this);
            CrossMedia.Current.Initialize();
            CachedImageRenderer.Init(enableFastRenderer: true);


            var dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Database.db");
            LoadApplication(new App(dbPath));

            StartServices();

        }

        public void StartServices()
        {
            var intent = new Intent(this, typeof(AtualizacaoService));
            StartService(intent);
        }

        public bool IsPlayServicesAvailable()
        {
            if (GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this) != ConnectionResult.Success)
                return false;
            else
                return true;
        }

        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var channel = new NotificationChannel(CHANNEL_ID, "FCM Notifications", NotificationImportance.Max) {

                Description = "Firebase Cloud Messages appear in this channel"
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}