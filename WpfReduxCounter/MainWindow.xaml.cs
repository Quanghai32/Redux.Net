using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfReduxCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.CounterStore.Subscribe(counter => CounterRun.Text = counter.ToString());
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            App.CounterStore.Dispatch(new IncrementAction());
        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {
            App.CounterStore.Dispatch(new DecrementAction());
        }

        private void IncrementIfOddButton_Click(object sender, RoutedEventArgs e)
        {
            //var counter = await App.CounterStore.FirstAsync();
            //if (counter % 2 == 1)
            //{
            //    App.CounterStore.Dispatch(new IncrementAction());
            //}
        }

        private void IncrementAsyncButton_Click(object sender, RoutedEventArgs e)
        {
            //await Task.Delay(1000);
            //App.CounterStore.Dispatch(new IncrementAction());
        }
    }
}
