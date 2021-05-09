using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf.Transitions;
using System.Windows.Controls;

namespace WpfApp25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int lan;
        public MainWindow(int Lan)
        {
            lan = Lan;
            InitializeComponent();
            if (Lan == 1)
            {
                ButtonLogin.Content = "Login";
                RegButton.Content = "Registr";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(pass, "Password");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Email");
                TextBlockReg.Text = "Do you have an account?";
            }
            else
            {

                ButtonLogin.Content = "Войти";
                RegButton.Content = "Зарегистрироваться";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Почта");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(pass, "Пароль");
                TextBlockReg.Text = "У Вас есть аккаунт?";
            }

        }

        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            text.Text = pass.Password;
            text.Visibility = Visibility.Visible ^ pass.Visibility;
            pass.Visibility = Visibility.Hidden ^ text.Visibility;
        }
        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            this.Hide();
            Register redister = new Register(lan);
            redister.Show();
        }
        private void TextBlock_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Register register = new Register(lan);
            register.Show();
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register(lan);
            register.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WinWelcom winWelcom = new WinWelcom(lan);
            winWelcom.Show();
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string Email = EmailTextbox.Text;
            string Pass = pass.Password;
            if (Email == "Admin" && Pass == "Admin")
            {
                this.Hide();
                Run_Admin run = new Run_Admin(lan);
                run.Show();
            }
            else
            {

                string query = $"SELECT * FROM [Tablues] WHERE Email='{Email}' AND Password='{Pass}' ";
                command = new SQLiteCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Операция завершина успешно");
                    reader.Close();
                    this.Hide();
                    RunnerMenu runnerMenu = new RunnerMenu(Email, Pass, lan);
                    runnerMenu.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                    connection.Close();
                    return;
                }
                connection.Close();
            }
        }

        private void pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // pass.Password = (sender as PasswordBox).Password;
        }
    }
}
