using System;
using System.Collections;
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
    public partial class ChallengeList : Window
    {
        public User user;
        public ChallengeList(User currentUser)
        {
            user = currentUser;
            InitializeComponent();
        }

        private void challengeList_Loaded(object sender, RoutedEventArgs e)
        {
            challengeList.ItemsSource = ChallengeDB.FindAllChallenges();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            var profile = new Profile(user);
            profile.Show();
            this.Close();
        }

        private void challengeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ConfirmWindow confirmWindow = new ConfirmWindow();
            if(confirmWindow.ShowDialog() == true)
            {
                Challenge challenge = challengeList.SelectedItem as Challenge;
                user.Challenges.Add(challenge);
                UsersDB.ReplaceUser(user.Login, user);
               
            }
        }
    }
}
