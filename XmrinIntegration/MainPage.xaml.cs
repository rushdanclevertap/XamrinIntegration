using Com.Clevertap.Android.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmrinIntegration
{
    public partial class MainPage : ContentPage

    {
        CleverTapAPI cleverTapAPI;
        public MainPage()
        {
            InitializeComponent();
            cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
        }

        private void Push_Clicked(Object sender, EventArgs e)
        {


            cleverTapAPI.PushEvent("Rushdan");


        }

        private void App_Inbox_Clicked(Object sender, EventArgs e)
        {


            cleverTapAPI.PushEvent("Inboxxxx");
            cleverTapAPI.ShowAppInbox();
           

        }

        private void Inapp_Clicked(Object sender, EventArgs e)
        {
            cleverTapAPI.PushEvent("Rushdanflutterinapp");
        }

        private void Nativedisplay_Clicked(Object sender, EventArgs e)
        {
            cleverTapAPI.PushEvent("NativeDsiplayRushdan");
        }
    }
}
