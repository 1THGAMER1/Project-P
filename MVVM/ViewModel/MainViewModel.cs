using Project_P.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_P.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand View2Command { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public View2ViewModel View2VM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            View2VM = new View2ViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            }) ;

            View2Command = new RelayCommand(o =>
            {
                CurrentView = View2VM;
            });
        }       
    }
}