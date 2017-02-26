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

namespace MyAndroid
{
    class About
    {
        // Shake well before use
        static public string ConnectionString
        {
            get
            {
                return @"Data Source=192.168.93.1, 1433;Initial Catalog=MySite;Persist Security Info=True;User ID=rexa;Password=1";
            }
        }
        static public string ThisPostId { get; set; }
    }
}