using System;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Page_author.xaml
    /// </summary>
    public partial class Page_author : Page
    {
        public static ObservableCollection<Employee> userss { get; set; }
        public Page_author()
        {
            InitializeComponent();
        }

        private void author_event_click(object sender, RoutedEventArgs e)
        {
            userss = new ObservableCollection<Employee>(bd_connection.connection.Employee.ToList());
            var z = userss.Where(a => a.login == txt_Login.Text && a.password == txt_Password.Password).FirstOrDefault();
            if (z != null)
            {
                MessageBox.Show(z.Name);
                NavigationService.Navigate(new Page_zakaz());

            }
            else
            {
                MessageBox.Show("логин или  пароль не верные", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Botton_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_reg());
        }
    }
}
