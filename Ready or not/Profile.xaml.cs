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
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public User currentUser;
        public Profile(User user)
        {
            InitializeComponent();
            currentUser = user;
            Login.Text = currentUser.Login;
            EmailBox.Text = currentUser.Email;
            Number.Text = currentUser.Number;
            firstName.Text = currentUser.Name;
            secondName.Text = currentUser.Surname;

        }

        private void userChallengeList_Loaded(object sender, RoutedEventArgs e)
        {
            User user = UsersDB.FindUserByLogin(currentUser.Login);
            userChallengeList.ItemsSource = user.Challenges;   
        }

        private void userChallengeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AcceptWindow acceptWindow = new AcceptWindow();
            if (acceptWindow.ShowDialog() == true)
            {
                Challenge challenge = userChallengeList.SelectedItem as Challenge;
                string name = (userChallengeList.SelectedItem as Challenge).Name;
                Challenge ch = ChallengeDB.FindChallengeByName(name);
                currentUser.CompletedChallenges.Add(challenge);
                currentUser.Challenges.Remove(ch);
                UsersDB.ReplaceUser(currentUser.Login, currentUser);
                
            }
        }


    }
}
