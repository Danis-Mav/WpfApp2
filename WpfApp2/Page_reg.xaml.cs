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
    /// Логика взаимодействия для Page_reg.xaml
    /// </summary>
    public partial class Page_reg : Page
    {
        public static ObservableCollection<Position> Posit { get; set; }
        int i { get; set; }
        public Page_reg()
        {
            InitializeComponent();
            Posit = new ObservableCollection<Position>(bd_connection.connection.Position.ToList());
            this.DataContext = this;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Botton_Click(object sender, RoutedEventArgs e)
        {
            var a = new Employee();
            a.Name = name_txt.Text;
            a.login = login_txt.Text;
            a.password = password_txt.Text;
            a.id_position = i;
            bd_connection.connection.Employee.Add(a);
            bd_connection.connection.SaveChanges();
            MessageBox.Show("all ok");
            NavigationService.GoBack();
        }
        private void cmb_position(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Position;
            i = a.id_position;
        }
    }
}
