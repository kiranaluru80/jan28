using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConEd.PAP.Views
{
    public partial class HelpPage : ContentPage
	{
		public string iscomefrom;
		public HelpPage()
        {
            InitializeComponent();
            Title = "HELP";
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#43AEE7");
            NavigationPage.SetBackButtonTitle(this, "Back");
            navigationPage.BarTextColor = Color.White;
            closeref.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new DocumentTypes(iscomefrom));
            };

		}
    }
}
