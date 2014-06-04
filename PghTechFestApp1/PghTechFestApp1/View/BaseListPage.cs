using PghTechFestApp1.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PghTechFestApp1.View
{
    class BaseListPage<T> : ContentPage where T:class, new()    
    {
        public ObservableCollection<T> Model { get; private set; }


        static readonly MethodInfo GetDependency;

        private Command loadModelsCommand;

        public Command LoadModelsCommand
        {
            get
            {
                return loadModelsCommand ?? (loadModelsCommand = new Command(LoadModel));
            }
        }

        static BaseListPage() 
        {
            var repoType = App.TypeMap[typeof(T)];
            var getMethod = typeof(DependencyService)
                .GetRuntimeMethods()
                .Single((method)=>
                    method.Name.Equals("Get"));
            GetDependency = getMethod.MakeGenericMethod(repoType);
        }

        public BaseListPage()
        {
            Model = new ObservableCollection<T> ();
        }

        protected virtual async void LoadModel()
        {
            using (var service = (IRepository<T>)GetDependency.Invoke(null, new object[] { DependencyFetchTarget.GlobalInstance }))
            {
                var items = await service.All();
                foreach (var item in items)
                {
                    Model.Add(item);
                }
            }
            OnPropertyChanged("Model");
        }

    }
}
