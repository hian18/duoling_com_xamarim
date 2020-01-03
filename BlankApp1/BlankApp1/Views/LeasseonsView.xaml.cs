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
    public partial class LeasseonsView : ContentPage, IDanamicTitle, ISelectIcon
    {
        public LeasseonsView()
        {
            InitializeComponent();
        }

        private View title_; 
        public View GetTitle()
        {
            if (title_ == null)
            {
                    title_= new LessonsTitleView();
            }
            return title_;
        }

        public string GetIcon()
        {
            return "tab_lessons";
        }

        public string GetSelectedIcon()
        {
            return "tab_lessons_selected";
        }

        //public string GetIcon => "tab_lessons";


        //public string GetSelectedIcon => "tab_lessons_selected";

    }
}