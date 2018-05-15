using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.IO;
using SQLite;

namespace StirItApp
{
    [Activity(Label = "StirItApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            string dBPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button LoginBTN = FindViewById<Button>(Resource.Id.LoginBTN);
            LoginBTN.Click += delegate
            {
                var dB = new SQLiteConnection(dBPath);
                dB.CreateTable<Users>();
                Users User1 = new Users("Peter", 1);
                dB.Insert(User1);
            };
            Button ShowBTN = FindViewById<Button>(Resource.Id.ShowBTN);
            ShowBTN.Click += delegate
            {
                var dB = new SQLiteConnection(dBPath);
                var table = dB.Table<Users>();
                foreach (var Users in table)
                {
                    ShowBTN.Text = Users.name;
                }
            };
            }
    }
}

