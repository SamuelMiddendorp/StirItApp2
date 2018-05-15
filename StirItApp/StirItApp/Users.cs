using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace StirItApp
{
    class Users
    {
        // Field
        public string name { get; set; }
        public int id { get; set; }
        // Constructor that takes one argument.
        public Users(string nm, int idd)
        {
            name = nm;
            id = idd;
        }
        public Users()
        {

        }

    }
}