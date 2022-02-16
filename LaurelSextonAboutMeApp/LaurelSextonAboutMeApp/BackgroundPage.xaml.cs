using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaurelSextonAboutMeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackgroundPage : ContentPage
    {
        public BackgroundPage()
        {
            InitializeComponent();
        }
        //may be able to remove later
        /*private void InitializeComponent()
        {
            throw new NotImplementedException();
        }*/
 
       /* protected override void OnAppearing()
        {
            base.OnAppearing();
        }*/
    }
}
