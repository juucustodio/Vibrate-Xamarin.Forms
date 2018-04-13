using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Vibrate;
using Xamarin.Forms;

namespace DemoVibrate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            CrossVibrate.Current.Vibration(TimeSpan.FromSeconds(1));
        }
    }
}
