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

    public partial class RabotnikVhod : Window
    {
        public RabotnikVhod()
        {
            InitializeComponent();
        }
       
            private void LoginButton_Click(object sender, RoutedEventArgs e)
            {
                string username = txtLogin.Text;
                string password = txtPassword.Password;


                if (username == "user" && password == "password")
                {
                    StartShift();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }

            private void StartShift()
            {
                string selectedBox = txtBox.Text;

                if (!string.IsNullOrEmpty(selectedBox))
                {
                    
                }
                else
                {
                    MessageBox.Show("Пожалуйста, укажите бокс для работы");
                }
            }

            private void CompleteShift()
            {
               
            }
        }
    }