using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class MenuPage : ContentPage
    {


        public MenuPage()
        {
			Title = "Pgh Tech Fest 2014";
			ListView list = new ListView ();
			list.ItemsSource = new string[] { "Speakers", "Sessions" };

			ContentPage page = null;
			list.ItemSelected += (sender, e) => {
				var item = (String)e.SelectedItem;
				switch (item) {
				case "Speakers":
					page = new SpeakerListPage ();
					break;
				case "Sessions":
					page = new SessionListPage ();
					break;
				default:
					break;
				}
				Navigation.PushAsync (page);
				list.SelectedItem = null;
			};
            Content = new StackLayout
            {
                Children = { list }
            };
        }

    }
}
