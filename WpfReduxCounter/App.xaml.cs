using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Redux;

namespace WpfReduxCounter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IStore<int> CounterStore { get; private set; }
        public App()
        {
            CounterStore = new Store<int>(CounterReducer.Execute, 0);
        }
    }
}
