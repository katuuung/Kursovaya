using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Training.ViewModel
{
   public class CreateNewTrainingViewModel : ViewModelBase
    {
        private string _trainname;

        public string TrainName
        {
            get { return _trainname; }
            set { _trainname = value; RaisePropertyChanged("TrainName"); }
        }

       
            
   }
}
