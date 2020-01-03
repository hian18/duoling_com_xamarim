using BlankApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new LeasseonsView());
            Children.Add(new ProfileView());
            if (Device.RuntimePlatform == Device.iOS)
                Children.Add(new TrainingView());
            Children.Add(new TrainingView());


        }
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (this.CurrentPage is IDanamicTitle page)
                NavigationPage.SetTitleView(this, page.GetTitle());
        }
    }
}