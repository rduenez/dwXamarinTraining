using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloWorld.Droid
{
    [Activity(Label = "HelloWorld.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            this.LoadApplication(new HelloWorldApp());

        }
    }
}

