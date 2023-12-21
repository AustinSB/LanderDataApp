using LanderDataApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanderDataApp.ViewModel
{
    public class ShellViewModel : INotifyPropertyChanged
    {
        public string? HelloString
        {
            get;
            set;
        }

        private ShellModel? _shellModel;
        public ShellModel? ShellModel
        {
            get => _shellModel;
            set
            {
                _shellModel = value;

            }
        }

        public ShellViewModel()
        {
            HelloString = "Hello";
            ShellModel = new ShellModel();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
