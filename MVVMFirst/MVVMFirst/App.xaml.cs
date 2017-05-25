using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVMFirst.VM;
using MVVMFirst.V;

namespace MVVMFirst
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View view = new View();
            ViewModel viewmodel = new ViewModel();
            view.DataContext = viewmodel;
            view.Show();
        }
    }
}
