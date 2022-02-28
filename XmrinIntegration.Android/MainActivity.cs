using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Com.Clevertap.Android.Sdk;
using System.Collections.Generic;
using Java.Util;
using Firebase.Iid;
using Android.Gms.Extensions;
using Android.Util;
using Com.Clevertap.Android.Sdk.Displayunits;
using Com.Clevertap.Android.Sdk.Displayunits.Model;

namespace XmrinIntegration.Droid
{
    [Activity(Label = "XmrinIntegration", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IDisplayUnitListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());


            CleverTapAPI cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
            IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

            cleverTapAPI.SetDisplayUnitListener(this);

            profileData.Add("Name", "Rushdan Bijapure");    // String
            //profileData.Add("Identity", 456);      // String or number
            profileData.Add("Email", "xamrinrushdandemo@google.com"); // Email address of the user
            profileData.Add("Phone", "7788994455");   // Phone (with the country code, starting with +)
            profileData.Add("Gender", "M");             // Can be either M or F
            profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util
            profileData.Add("MSG-push", true);
            profileData.Add("MSG-email", true);
            profileData.Add("MSG-sms", true);
            profileData.Add("MSG-whatsapp", true);
            cleverTapAPI.OnUserLogin(profileData);
            cleverTapAPI.PushEvent("Product View Via Xamarin");
            CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "1999", "Channel1999", "ChannelDescription", 5, true);
            PushTokenAsync();
           
           
          
        }

       

        private async System.Threading.Tasks.Task PushTokenAsync()
        {
            var instanceIdResult = await FirebaseInstanceId.Instance.GetInstanceId().AsAsync<IInstanceIdResult>();
            string token = instanceIdResult.Token;
            CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushFcmRegistrationId(token, true);
            Log.Debug("TOken", "token Sent" + token);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnDisplayUnitsLoaded(IList<CleverTapDisplayUnit> p0)
        {
            foreach (CleverTapDisplayUnit p in p0)
            {
                Log.Debug("Title", p.Contents[0].Title);
                Log.Debug("Finally", p.Contents[0].Message);
                CleverTapAPI cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
                cleverTapAPI.PushDisplayUnitClickedEventForID(p.UnitID);
                cleverTapAPI.PushDisplayUnitViewedEventForID(p.UnitID);
            }
        }
    }
}