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
using Java.Lang;

namespace MyAndroid
{
    class RexaAdapter1 : BaseAdapter
    {
        List<PostOnFirstPage> items;
        Activity context;
        public RexaAdapter1(Activity context, IEnumerable<PostOnFirstPage> items) : base()
        {
            this.context = context;
            this.items = items.ToList();
        }

        public override int Count
        {
            get
            {
                return items.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return items[position].Title;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                 view = context.LayoutInflater.Inflate(Resource.Layout.RexaListItem1, null);
            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Title;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].DateTime;
            return view;

        }
    }
}