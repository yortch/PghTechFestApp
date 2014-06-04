using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    public class SpeakerCell : ViewCell
    {
        public SpeakerCell ()
        {
            var label = new Label{
                YAlign = TextAlignment.Center
            };
            label.SetBinding (Label.TextProperty, "Name");

            var layout = new StackLayout {
                Padding = new Thickness(20, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                Children = { label }
            };
            View = layout;
        }

    }
}
