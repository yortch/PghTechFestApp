using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class SpeakerDetailPage : ContentPage
    {
        public SpeakerDetailPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label { Text = "Name: " };
            var nameValueLabel = new Label();

            nameValueLabel.SetBinding(Label.TextProperty, "Name");

            var descriptionLabel = new Label { Text = "Twitter: " };
            var descriptionValueLabel = new Label();
            descriptionValueLabel.SetBinding(Label.TextProperty, "Twitter");

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(20),
                Children = {
                    nameLabel, nameValueLabel,
                    descriptionLabel, descriptionValueLabel
                }
            };
        }

    }
}
