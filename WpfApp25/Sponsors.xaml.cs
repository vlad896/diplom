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

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для Sponsors.xaml
    /// </summary>
    public partial class Sponsors : Window
    {
        public Sponsors()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public Sponsors(string Email, string Pass, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            lan = Lan;
            if (Lan == 1)
            {
                TextIndex.Text = "Sponsors of Minsk Half Marathon";
                BelarusCal.Text = "Open Joint Stock Company Belaruskali is one of the largest producers and exporters of potash fertilizers in the world.";
                Bank.Text = "Bank Dabrabyt is the new name of the Bank Moscow-Minsk. The rebranding should modernize the perception of Dabrabyt Bank and bring it in line with the current situation.";
                BMW.Text = "AVTOIDEYA-official BMW dealer in Belarus";
                A100.Text = "A-100 Development Group is one of the leading developers in the Minsk region. Having started our history with the construction of a gas station, for more than 15 years we have remained true to our principles — we get the required quality, meeting the deadlines and budget.";
                Epam.Text = "EPAM Since 1993, we have been helping world leaders design, develop, and implement software that changes the world.";
                BackButton.Content = "Back";
            }
            else
            {
                TextIndex.Text = "Спонсоры Minsk Half Marathon";
                BelarusCal.Text = "Открытое акционерное общество «Беларуськалий» является одним из крупнейших производителей и экспортеров калийных удобрений в мире.";
                Bank.Text = "Банк Дабрабыт - это новое имя Банка Москва-Минск. Ребрендинг должен осовременить восприятие Банка Дабрабыт, привести его в соответствии с текущей ситуацией.";
                BMW.Text = "АВТОИДЕЯ — официальный дилер BMW в Беларуси";
                A100.Text = "Группа компаний А-100 Девелопмент – один из ведущих застройщиков Минского региона. Начав свою историю со строительства АЗС, более 15 лет мы остаемся верны своим принципам — получаем требуемое качество, укладываясь в сроки и бюджет.";
                Epam.Text = "EPAM c 1993 года мы помогаем мировым лидерам проектировать, разрабатывать и внедрять программное обеспечение, которое меняет мир.";
                BackButton.Content = "Назад";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
