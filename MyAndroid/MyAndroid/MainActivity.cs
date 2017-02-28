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

        public List<PostOnFirstPage> myPosts;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            myPosts = new List<PostOnFirstPage>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = About.ConnectionString;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT TOP 20 Id, Title, [Date] FROM [Post] ORDER BY [Date] DESC";
            SqlDataReader data = com.ExecuteReader();


            while (data.Read())
            {
                myPosts.Add(new PostOnFirstPage
                {
                    Id = data["Id"].ToString(),
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
            About.ThisPostId = myPosts[e.Position].Id;
            StartActivity(typeof(PostViewActivity));
        }
    }
}

