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
using System.Windows.Shapes;

namespace KR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button userButton = FindName("UserButton") as Button;
            Button employeeButton = FindName("EmployeeButton") as Button;
            Button adminButton = FindName("AdminButton") as Button;

            userButton.Click += UserButton_Click;
            employeeButton.Click += EmployeeButton_Click;
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу пользователя
            UserPage userPage = new UserPage();
            this.NavigationService.Navigate(userPage);
        }

        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу работника
            RabotnikVhod employeePage = new RabotnikVhod();
            this.NavigationService.Navigate(employeePage);
        }
    }
}
