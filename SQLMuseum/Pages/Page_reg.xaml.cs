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
    /// Interaction logic for Page_reg.xaml
    /// </summary>
    public partial class Page_reg : Page
    {
        public static ObservableCollection<Position> Pos { get; set; }
        public static ObservableCollection<Employee> Employees { get; set; }
        int i { get; set; }
        public Page_reg()
        {
            InitializeComponent();
            Pos = new ObservableCollection<Position>(Bd_connection.connection.Position.ToList());
            Employees = new ObservableCollection<Employee>(Bd_connection.connection.Employee.ToList());
            this.DataContext = this;
        }

        private void TextBox_MouseDown(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void reverse_event(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void registation_event(object sender, RoutedEventArgs e)
        {
            var id_last = (from t in Employees select t.ID_Employee).Last().ToString();
            
            var a = new Employee
            {
                ID_Employee = int.Parse(id_last) + 1,
                Name = name_txt.Text,
                Second_Name = secondN_txt.Text,
                Patronymic = password_txt.Text,
                Password = password_txt.Text,
            };
            Bd_connection.connection.Employee.Add(a);
            Bd_connection.connection.SaveChanges();
            MessageBox.Show("OK");
            NavigationService.GoBack();
        }

        private void position_txt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as dbo.Position;
            i = a.ID_Position;
        }
    }
}
