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

    public partial class LichStrRabotxaml : Window
    {
        public LichStrRabotxaml()
        {
            InitializeComponent();
        }

        private void FinishShiftButton_Click(object sender, RoutedEventArgs e)
        {
            string status = ((ComboBoxItem)statusComboBox.SelectedItem)?.Content.ToString();
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Пожалуйста, выберите статус заказа.");
                return;
            }


        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
