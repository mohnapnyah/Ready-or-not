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
    /// Логика взаимодействия для CompletedChallenges.xaml
    /// </summary>
    public partial class CompletedChallenges : Window
    {
        User currentUser;
        public CompletedChallenges(User user)
        {
            InitializeComponent();
            currentUser = user;
            CompletedList.ItemsSource = currentUser.CompletedChallenges;
        }

        private void Points_Loaded(object sender, RoutedEventArgs e)
        {
            Points.Text = currentUser.Points.ToString();
            if(currentUser.Points < 500)
            {
                Rank.Text = "Новичок";
            }
            else if(currentUser.Points > 500 && currentUser.Points < 1000)
            {
                Rank.Text = "Бывалый";
            }
            else
            {
                Rank.Text = "Крейзи-чел";
            }
        }
    }
}
