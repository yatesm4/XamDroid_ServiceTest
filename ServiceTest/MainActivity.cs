using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Content.PM;
using Android.Hardware;
using Android.Runtime;

namespace ServiceTest
{
    [Activity(Label = "ServiceTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btn_Start;
        Button btn_Stop;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            LoadComponents();
            LoadDelegates();
        }

        void LoadComponents()
        {
            btn_Start = FindViewById<Button>(Resource.Id.btn_start);
            btn_Stop = FindViewById<Button>(Resource.Id.btn_stop);
        }

        void LoadDelegates()
        {
            btn_Start.Click += delegate
            {
                StartService(new Intent(this, typeof(SimpleService)));
            };

            btn_Stop.Click += delegate
            {
                StopService(new Intent(this, typeof(SimpleService)));
            };
        }
    }
}

