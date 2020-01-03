using BlankApp1.Interfaces;
using BlankApp1.Views.TitleViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingView : ContentPage, IDanamicTitle
    {
        public TrainingView()
        {
            InitializeComponent();
        }
        View title_;
        public View GetTitle()
        {
            if (title_ == null)
            {
                title_= new TraningTilteView();
            }
            return title_;
        }
    }
}