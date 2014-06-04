using PghTechFestApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(SpeakerRepository))]
[assembly: Dependency(typeof(SessionRepository))] 
namespace PghTechFestApp1.Service
{
  
    interface IRepository<T> : IDisposable where T :class, new()
    {
        Task<IEnumerable<T>> All();
    }
}
