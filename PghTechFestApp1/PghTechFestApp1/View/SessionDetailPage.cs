using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class SessionDetailPage : ContentPage
    {
        public SessionDetailPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Title");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label { Text = "Title: " };
            var nameValueLabel = new Label();

            nameValueLabel.SetBinding(Label.TextProperty, "Title");

            var descriptionLabel = new Label { Text = "Description: " };
            var descriptionValueLabel = new Label();
            descriptionValueLabel.SetBinding(Label.TextProperty, "Description");

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
