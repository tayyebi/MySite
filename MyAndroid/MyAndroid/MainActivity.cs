using Android.App;
using Android.Widget;
using Android.OS;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MyAndroid
{
    public class PostOnFirstPage
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string DateTime { get; set; }
    }
    [Activity(Label = "MyAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = About.ConnectionString;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT TOP 20 Id, Title, [Date] FROM [Post] ORDER BY [Date] DESC";
            SqlDataReader data = com.ExecuteReader();

            List<PostOnFirstPage> myPosts = new List<PostOnFirstPage>();

            while (data.Read())
            {
                myPosts.Add(new PostOnFirstPage
                {
                    Title = data["Title"].ToString(),
                    DateTime = data["Date"].ToString()
                });
            }

            if (myPosts.Count == 0)
            {
                Toast.MakeText(this, "هیچ پستی دریافت نشد", ToastLength.Long).Show();
            }
            else
            {
                ListView l1 = FindViewById<ListView>(Resource.Id.listView1);
                l1.Adapter = new RexaAdapter1(this, myPosts);
                l1.ItemClick += L1_ItemClick;
            }

        }

        private void L1_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            // throw new System.NotImplementedException();
        }
    }
}

