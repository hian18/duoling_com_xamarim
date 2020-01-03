using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using BlankApp1.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly:ExportRenderer(typeof(TabbedPage),typeof(CustomTabPageRender))]
namespace BlankApp1.Droid.Renderers
{
    class CustomTabPageRender:TabbedPageRenderer

    {
        public CustomTabPageRender(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                var relative = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                var bottom= relative.GetChildAt(1) as BottomNavigationView;
                bottom.SetMinimumHeight(300);
            }

        }
    }
}