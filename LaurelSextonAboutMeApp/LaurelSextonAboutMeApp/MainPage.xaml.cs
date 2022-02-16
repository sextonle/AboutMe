using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LaurelSextonAboutMeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            //var navigationpage = new NavigationPage(new ViewPage());
            //navigationpage.Title = "Background/ About Me";

            Children.Add(new BackgroundPage());
            //Children.Add(navigationpage);
        }
    }
}
