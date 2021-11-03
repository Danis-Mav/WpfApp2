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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для BillWindow.xaml
    /// </summary>
    public partial class BillWindow : Window
    {
        public static ObservableCollection<zakaz> zakazz { get; set; }
      

        public BillWindow(ObservableCollection<zakaz> zak)
        {
            InitializeComponent();
            zakazz = zak;
            this.DataContext = this;

            foreach(zakaz z in zakazz)
            {
                Global.total += Convert.ToInt32(z.Price );
            }
            total_txt.Text = Global.total.ToString();
        }
    }
}
