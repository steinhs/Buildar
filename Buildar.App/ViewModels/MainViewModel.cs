using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.Model;

namespace Buildar.App.ViewModels
{
    public class MainViewModel : Observable
    {
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ObservableCollection<Build> Builds { get; set; } = new ObservableCollection<Build>();
        private readonly Builds buildsDataAccess = new Builds();


        public MainViewModel()
        {

            
        }

        internal async Task LoadBuildsAsync()
        {
            var builds = await buildsDataAccess.GetBuildsAsync();
            foreach (Build build in builds)
                Builds.Add(build);
        }
    }
}
