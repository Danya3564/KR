using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    public partial class LichStrRabot2 : Window
    {
        private string connectionString = "Your SQL Connection String"; // Замените на свою строку подключения

        public LichStrRabot2()
        {
            InitializeComponent();
            LogoutButton.Click += LogoutButton_Click;

            // Загрузка данных из базы данных при открытии страницы
            LoadDataFromDatabase();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика для обработки нажатия кнопки "Выйти"
            // Например, выход из учетной записи и переход на страницу входа
        }

        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT YourColumn FROM YourTable"; // Замените на свой запрос SQL

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    txtBox.Text = dataTable.Rows[0]["YourColumn"].ToString(); // Замените YourTextBox на имя вашего TextBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
                }
            }
        }
    }
}
    
