using PghTechFestApp1.Model;
using PghTechFestApp1.Service;
using PghTechFestApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace PghTechFestApp1
{
    public class App
    {

        internal static IDictionary<Type, Type> TypeMap;

        static App()
        {
            TypeMap = new Dictionary<Type, Type> 
            {
                {typeof(Session), typeof(SessionRepository)},
                {typeof(Speaker), typeof(SpeakerRepository)},
            };
        }

        public static Page GetMainPage()
        {
            return new NavigationPage(new MenuPage());
        }
    }
}
