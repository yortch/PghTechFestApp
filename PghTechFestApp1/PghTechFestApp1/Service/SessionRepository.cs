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
    class SessionRepository : IRepository<Session>
    {
        protected IList<Session> Items { get; private set; }

        public async Task<IEnumerable<Session>> All()
        {
            if (Items == null)
            {
                Items = new List<Session>();
                string url = "http://pghtechfest.com/session_list.json";
                using (var client = new HttpClient())
                {
                    Task<string> jsonTask = client.GetStringAsync(url);
                    string json = await jsonTask;
                    JObject jobj = JObject.Parse(json);
                    foreach (var p in jobj["sessions"])
                    {
                        var item = new Session();
                        item.Title = (string)p["title"];
                        item.Description = (string)p["description"];
                        Items.Add(item);
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
