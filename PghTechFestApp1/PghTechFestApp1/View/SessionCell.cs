using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class SessionCell  : ViewCell
    {
        public SessionCell ()
        {
            var label = new Label{
                YAlign = TextAlignment.Center
            };
            label.SetBinding (Label.TextProperty, "Title");

            var layout = new StackLayout {
                Padding = new Thickness(20, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                Children = { label }
            };
            View = layout;
        }
    
    }
}
