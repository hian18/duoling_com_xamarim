using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using BlankApp1.Droid.Renderers;
using BlankApp1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using BlankApp1.Interfaces;
[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabPageRender))]
namespace BlankApp1.Droid.Renderers
{
    class CustomTabPageRender : TabbedPageRenderer

    {

        private TabbedPage _formTabs;
        BottomNavigationView _bottom;
        public CustomTabPageRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formTabs = Element;
                _formTabs.CurrentPageChanged += OnCurrurrentPageChanged;
                var relative = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottom = relative.GetChildAt(1) as BottomNavigationView;
                _bottom.SetMinimumHeight(300);
                _bottom.ItemIconTintList = null;
                _bottom.ItemIconSize = 150;
                _bottom.SetShiftMode(false, false);
                _bottom.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
                ChangeIcons();

            }
            if (e.OldElement != null)
                _formTabs.CurrentPageChanged -= OnCurrurrentPageChanged;

        }

        private void ChangeIcons()
        {
            int c = 0;
            int iconId=0;
            foreach (var item in _formTabs.Children)
            {
                var androidTab = _bottom.Menu.GetItem(c);
                if (_formTabs.Children[c] is ISelectIcon tabpage)
                {
                    if (_formTabs.Children[c] == _formTabs.CurrentPage)
                    {
                        iconId = Resources.GetIdentifier(tabpage.GetSelectedIcon(), "drawable",Context.PackageName);
                        androidTab.SetIcon(iconId);
                    }
                    else
                    {
                        iconId = Resources.GetIdentifier(tabpage.GetIcon(), "drawable", Context.PackageName);
                        androidTab.SetIcon(iconId);
                    }

                }
                c++;
            }
        }

        private void OnCurrurrentPageChanged(object sender, EventArgs e)
        {
            ChangeIcons();
        }
    }
}