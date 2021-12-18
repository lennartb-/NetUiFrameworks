using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace NetMaui
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Current.CurrentItem = DesktopTabBar;
        }
    }
}
