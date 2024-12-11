using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
            });
        }

        public ICommand ClickCommand { get;  }

        //public ICommand ClickCommand =>
        //    new Command(() => App.Current.MainPage.DisplayAlert("Title", "message", "Ok"));
        //public ICommand ClickCommand =>
        //    new Command(Alert);

        //private void Alert()
        //{
        //    App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
        //}
    }
}
