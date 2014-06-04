using PghTechFestApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class SpeakerListPage : BaseListPage<Speaker>
    {
        public SpeakerListPage()
        {
            Title = "Speakers";
            var listView = new ListView();
            listView.ItemTemplate = new DataTemplate(typeof(SpeakerCell));
            listView.ItemsSource = Model;
            listView.ItemSelected += (sender, e) =>
            {
                var item = (Speaker)e.SelectedItem;
                var page = new SpeakerDetailPage();
                page.BindingContext = item;
                Navigation.PushAsync(page);
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Model.Count == 0)
            {
                LoadModelsCommand.Execute(null);
            }
        }
    }
}
