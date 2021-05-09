using System.Windows;
using System.Windows.Input;
namespace WpfApp25
{
    public partial class Contacts : Window
    {
        public Contacts()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public Contacts(string Email, string Pass, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            lan = Lan;
            if (Lan == 1)
            {
                Author.Text = "Completed the work: Fedorovich Vladislav Alexandrovich";
                Entitlement.Content = "Copyright: @MGKE 2020";
                Version.Content = "Version: V 1.0.0.0";
                Discipline.Text = "Discipline: Program design and programming languages";
                Email1.Content = "Email: vlados6675041@gmail.com";
                Phone.Text = "Phone: +375 (33) 667-50-41";
                BackButton.Content = "Back";
            }
            else
            {
                Author.Text = " Выполнил работу: Федорович Владислав Александрович";
                Entitlement.Content = "Авторские права: @МГКЭ 2020";
                Version.Content = "Версия: V 1.0.0.0";
                Discipline.Text = "Дисциплина: Конструирование программ и языки программирования";
                Email1.Content = "Email: vlados6675041@gmail.com";
                Phone.Text = "Телефон: +375 (33) 667-50-41";
                BackButton.Content = "Back";
                BackButton.Content = "Назад";
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }
    }
}
