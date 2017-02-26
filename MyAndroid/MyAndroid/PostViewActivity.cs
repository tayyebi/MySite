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
using System.Data.SqlClient;

namespace MyAndroid
{
    [Activity(Label = "PostViewActivity")]
    public class PostViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.PostView);

            TextView title, group, admin, date, abst, body;
            title = FindViewById<TextView>(Resource.Id.textView1);
            group = FindViewById<TextView>(Resource.Id.textView2);
            admin = FindViewById<TextView>(Resource.Id.textView3);
            date = FindViewById<TextView>(Resource.Id.textView4);
            abst = FindViewById<TextView>(Resource.Id.textView5);
            body = FindViewById<TextView>(Resource.Id.textView6);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = About.ConnectionString;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT TOP 1 * FROM [Post] WHERE [Id]=@Id";
            com.Parameters.AddWithValue("Id", About.ThisPostId);
            com.Connection = con;
            SqlDataReader data = com.ExecuteReader();
            if (data.Read())
            {
                title.SetText(data["Title"].ToString(), TextView.BufferType.Normal);
                group.SetText(data["GroupId"].ToString(), TextView.BufferType.Normal);
                admin.SetText(data["AdminUsername"].ToString(), TextView.BufferType.Normal);
                date.SetText(data["Date"].ToString(), TextView.BufferType.Normal);
                abst.SetText(data["Abstract"].ToString(), TextView.BufferType.Normal);
                body.SetText(data["Body"].ToString(), TextView.BufferType.Normal);
            }
        }
    }
}