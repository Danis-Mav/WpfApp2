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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page_zakaz.xaml
    /// </summary>
    public partial class Page_zakaz : Page
    {
        public Page_zakaz()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from ALKO in bd_connection.connection.ALKO
            select new { ALKO.Name, ALKO.Price };

            AlcoGrid.ItemsSource = query.ToList();

            var query_2 =
            from NoAlk in bd_connection.connection.NoAlk
            select new { NoAlk.Name, NoAlk.Price };
            AlcoGrid1.ItemsSource = query_2.ToList();

            var query_3 =
            from Dish in bd_connection.connection.Dish
            select new { Dish.Name, Dish.Price };
            AlcoGrid2.ItemsSource = query_3.ToList();
        }

        private void back_(object sender, RoutedEventArgs e)
        {

        }

        private void ready_(object sender, RoutedEventArgs e)
        {

        }
    }
}
