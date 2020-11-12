using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cafe_management.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand StaffCommand { get; set; }
        public ICommand MenuCommand { get; set; }
        public MainViewModel()
        {
            StaffCommand = new RelayCommand<object>((p) => { return true; }, (p) => { StaffWindow wd = new StaffWindow(); wd.ShowDialog(); });
            MenuCommand = new RelayCommand<object>((p) => { return true; }, (p) => { MenuWindow wd = new MenuWindow(); wd.ShowDialog(); });
        }
    }
}
