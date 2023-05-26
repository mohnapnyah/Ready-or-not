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

namespace Ready_or_not
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Login.Text = string.Empty;
            Password.Password = string.Empty;
            Number.Text = string.Empty;
            Email.Text = string.Empty;
            Name.Text = string.Empty;
            Surname.Text = string.Empty;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text != string.Empty && Password.Password != string.Empty &&
                Number.Text != string.Empty && Email.Text != string.Empty && Name.Text != string.Empty && Surname.Text != string.Empty)
            {
                User user = new User(Login.Text, Password.Password, Number.Text, Email.Text, Name.Text, Surname.Text);
                UsersDB.AddUserToDataBase(user);
                this.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
    }
}
