using Newtonsoft.Json.Linq;
using PghTechFestApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PghTechFestApp1.Service
{
    class SpeakerRepository : IRepository<Speaker>
    {
        protected IList<Speaker> Items { get; private set; }

        public async Task<IEnumerable<Speaker>> All()
        {
            if (Items == null)
            {
                Items = new List<Speaker> ();
                string url = "http://pghtechfest.com/presenters.json";
                using (var client = new HttpClient ()) {   
                    Task<string> jsonTask = client.GetStringAsync (url);
                    string json = await jsonTask;
                    JObject speakers = JObject.Parse (json);
                    foreach (var p in speakers["presenters"]) {
                        var item = new Speaker ();
                        item.Name = (string)p ["name"];
                        item.Twitter = (string)p ["twitter"];
                        Items.Add (item);
                    }
                }

            }
            return Items;
        }

        public void Dispose()
        {
            
        }
    }
}
