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
    /// Логика взаимодействия для SendCH.xaml
    /// </summary>
    public partial class SendCH : Window
    {
        public SendCH()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != string.Empty && desc.Text != string.Empty && dif.Text != string.Empty && reward.Text != string.Empty)
            {
                try
                {
                    Challenge challenge = new Challenge(Name.Text, desc.Text, int.Parse(dif.Text), int.Parse(reward.Text));
                    ChallengeDB.AddChallengeToDataBase(challenge);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("В полях: сложность и награда - могут быть только числа");
                }
            }
            else
            {
                MessageBox.Show("Все поля должы быть заполнены!");
            }
        }


    }
}
