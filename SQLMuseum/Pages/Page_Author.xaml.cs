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
using SQLMuseum.dbo;

namespace SQLMuseum
{
    /// <summary>
    /// Interaction logic for Page_Author.xaml
    /// </summary>
    public partial class Page_Author : Page
    {
        public static ObservableCollection<Employee> Users { get; set; }
        public Page_Author()
        {
            InitializeComponent();
        }


        private void Autho_event(object sender, RoutedEventArgs e)
        {
            Users = new ObservableCollection<Employee>(Bd_connection.connection.Employee.ToList());
            var log = Users.Where(a => a.ID_Employee.ToString() == txt_login.Text && a.Salary.ToString() == txt_password.Password).FirstOrDefault();

            if (log != null)
            {
                MessageBox.Show(log.Name);
            }
            else
            {
                MessageBox.Show("Invalid user", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Reg_event(object sender, RoutedEventArgs e)
        {
            _ = NavigationService.Navigate(new Page_reg());
        }
    }
}
