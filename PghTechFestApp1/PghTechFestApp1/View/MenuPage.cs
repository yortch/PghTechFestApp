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
            this.SetValue(Page.TitleProperty, "Pgh Tech Fest 2014");
            var list = new ListView();
            list.ItemsSource = new string[] { "Speakers", "Sessions" };

            list.ItemSelected += list_ItemSelected;
            list.SelectedItem = null;
            Content = new StackLayout
            {
                Children = { list }
            };
        }

        void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (String)e.SelectedItem;
            ContentPage page = null;
            switch (item)
            {
                case "Speakers":
                    page = new SpeakerListPage();
                    break;
                case "Sessions":
                    page = new SessionListPage();
                    break;
                default:
                    break;
            }
            Navigation.PushAsync(page);
        }
    }
}
