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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ready_or_not
{
    public partial class MainWindow : Window
    {
        public User currentUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if(Login.Text != string.Empty && PasswordBox.Password != string.Empty)
            {
                User user = UsersDB.FindUserByLogin(Login.Text);
                if (user.Password == PasswordBox.Password)
                {
                    currentUser = user;
                    MessageBox.Show("Успешная авторизация");
                    var challengeList = new ChallengeList(currentUser);
                    challengeList.Show();
                    Login.Text = string.Empty;
                    PasswordBox.Password = string.Empty;
                    this.Close();
                }
                else { MessageBox.Show("Неверный пароль");}
            }
            else
            {
                MessageBox.Show("Не введены логин или пароль");
            }
        }
    }
}
