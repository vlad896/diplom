using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        int lan;
        public Register(int Lan)
        {
            lan = Lan;
            InitializeComponent();
            if (Lan == 1)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Email");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Password, "Password");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Cpass, "Confirm password");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(NameTextBox, "Name");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(SurTextBox, "Surname");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxTime, "Date");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountryCombo, "Country");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualific, "Qualification");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Record, "Record");
                TextMale.Text = "Male";
                TextFMale.Text = "Female";
                RegButton.Content = "Registr";
                CancelButton.Content = "Cancel";
                BackButton.Content = "Back";
            }
            else
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Почта");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Password, "Пароль");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Cpass, "Повторный пароль");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(NameTextBox, "Имя");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(SurTextBox, "Фамилия");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxTime, "Дата рождения");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountryCombo, "Страна");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualific, "Квалификация");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Record, "Рекорд");
                TextMale.Text = "Мужской";
                TextFMale.Text = "Женский";
                RegButton.Content = "Зарегистрироваться";
                CancelButton.Content = "Закрыть";
                BackButton.Content = "Назад";
            }
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

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            string Email = EmailTextbox.Text;
            string Pass = Password.Password;
            if (Email == "" || Pass == "" || Cpass.Password == "" || NameTextBox.Text == "" || SurTextBox.Text == "" || TextBoxTime.Text == "" || CountryCombo.Text == "" || Qualific.Text == "" || Record.Text == "")
            {
                MessageBox.Show("Поля для заполнения не должны быть пустыми");
                return;
            }
            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (!Regex.IsMatch(Email, cond))
            {
                MessageBox.Show("Введите корректно email");
                return;
            }
            if (Pass.Length < 8)
            {
                MessageBox.Show("Пароль должен быть не менее 8 символов");
                return;
            }
            if (Cpass.Password != Pass)
            {
                MessageBox.Show("Пароли должны совпадать", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (FemaleRadio.IsChecked == false && MaleRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите свой гендер");
                return;
            }
            DateTime dt;
            if (DateTime.TryParse(TextBoxTime.Text, out dt))
            {

            }
            else
            {
                MessageBox.Show("Дата введена неправиьно");
                return;
            }
            string connctString = "DataSource=Table.db; Version=3";
            SQLiteCommand command;
            SQLiteConnection connection = new SQLiteConnection(connctString);
            SQLiteDataReader reader;
            string gender = "";
            if (FemaleRadio.IsChecked == true)
            {
                gender = TextFMale.Text;
            }
            if (MaleRadio.IsChecked == true)
            {
                gender = TextMale.Text;
            }
            connection = new SQLiteConnection(connctString);
            connection.Open();
            string query = $"INSERT INTO [Tablues] (Email,Password, Name , Surname, BD, Country ,Sex,Qualification,Personal_Record) VALUES( '{EmailTextbox.Text}', '{Password.Password}'," +
                $" '{NameTextBox.Text}', '{SurTextBox.Text}', '{TextBoxTime.Text}', '{CountryCombo.Text}', '{gender}','{Qualific.Text}','{Record.Text}')";
            command = new SQLiteCommand(query, connection);

            command.ExecuteNonQuery();

            this.Hide();
            MainWindow MainWindow = new MainWindow(lan);
            MainWindow.Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(lan);
            mainWindow.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(lan);
            mainWindow.Show();
        }
    }
}
