using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page_zakaz.xaml
    /// </summary>
    public partial class Page_zakaz : Page
    {
        public static ObservableCollection<zakaz> zakazz { get; set; }
        public static ObservableCollection<ALKO> alko { get; set; }
        public static ObservableCollection<NoAlk> noalk { get; set; }
        public static ObservableCollection<Dish> dish { get; set; }


        public Page_zakaz()
        {
            InitializeComponent();
            zakazz = new ObservableCollection<zakaz>(bd_connection.connection.zakaz.ToList());
            alko = new ObservableCollection<ALKO>(bd_connection.connection.ALKO.ToList());
            this.DataContext = this;
            noalk = new ObservableCollection<NoAlk>(bd_connection.connection.NoAlk.ToList());
            this.DataContext = this;
            dish = new ObservableCollection<Dish>(bd_connection.connection.Dish.ToList());
            this.DataContext = this;

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
 

        private void back_(object sender, RoutedEventArgs e)
        {
            zakazz = new ObservableCollection<zakaz>();
            Global.total = 0;
        }

        private void ready_(object sender, RoutedEventArgs e)
        {
            new BillWindow(zakazz).ShowDialog();
        }

 
        private void AlcoGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            zakaz zak = new zakaz();
            var send = (sender as DataGrid).SelectedItem as ALKO;
            zak.item = send.Name;
            zak.Price = send.Price;

            zakazz.Add(zak);
        }

        private void AlcoGrid2_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            zakaz zak = new zakaz();
            var send = (sender as DataGrid).SelectedItem as Dish;
            zak.item = send.Name;
            zak.Price = send.Price;

            zakazz.Add(zak);
        }

        private void AlcoGrid1_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            zakaz zak = new zakaz();
            var send = (sender as DataGrid).SelectedItem as NoAlk;
            zak.item = send.Name;
            zak.Price = send.Price;

            zakazz.Add(zak);
        }

        private void add(object sender, RoutedEventArgs e)
        {

        }
    }
}
