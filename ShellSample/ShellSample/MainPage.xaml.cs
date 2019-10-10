using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonBottomTabs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BottomTabs());
        }

        private void ButtonTopTabs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TopTabs());
        }

        private void ButtonFlyout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ShellSimpleFlyout());
        }

        private void ButtonSearchBar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ShellSearchBar());
        }
    }
}