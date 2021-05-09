using Microsoft.Win32;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System;
namespace WpfApp25
{
    public partial class Print : Window
    {
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;

        public Print()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public Print(string Email, string Pass, string Dist, string Pocket, string Sum, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            EmailTextbox.Text = email;
            DistaTextBox.Text = Dist;
            PoketTextBox.Text = Pocket;
            CountTextBox.Text = Sum;
            lan = Lan;
            if (Lan == 1)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Email");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(NameTextBox, "Name");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(SurTextBox, "Surname");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(BDTextBox, "Date");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountryTextBox, "Country");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(DistaTextBox, "Distance");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(PoketTextBox, "Kit option");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountTextBox, "Total number");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualification, "Qualification");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Personal_Record, "Record");
                BackButton.Content = "Back";
                Text.Text = "Thank you for registering as a runner in Half Marathon 2020";
                File.Content = "Save to File";
                EmailButton.Content = "Send to email";
                PrintButton.Content = "Print";
                NextButton.Content = "Continue";

            }
            else
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHint(EmailTextbox, "Почта");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(NameTextBox, "Имя");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(SurTextBox, "Фамилия");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(BDTextBox, "Дата рождения");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountryTextBox, "Страна");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(DistaTextBox, "Дистанция");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(PoketTextBox, "Вариант комплекта");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CountTextBox, "Итоговое окно");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualification, "Квалификация");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Personal_Record, "Рекорд");
                BackButton.Content = "Назад";
                Text.Text = "Спасибо за вашу регистрацию в качастве бегуна в Half Marathon 2020";
                File.Content = "Сохранить в файл";
                EmailButton.Content = "Отправить на почту";
                PrintButton.Content = "Распечатать";
                NextButton.Content = "Продолжить";
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM [Tablues] WHERE Email='{email}' AND Password= '{pass}'";
            command = new SQLiteCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmailTextbox.Text = reader[1].ToString();
                    NameTextBox.Text = reader[3].ToString();
                    SurTextBox.Text = reader[4].ToString();
                    BDTextBox.Text = reader[5].ToString();
                    CountryTextBox.Text = reader[6].ToString();
                    Qualification.Text = reader[8].ToString();
                    Personal_Record.Text = reader[9].ToString();
                }
                reader.Close();
            }
            reader.Close();
        }
        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            MailAddress From = new MailAddress("marathon.f01@gmail.com", "Fedorvich Vlad 35ТП");
            MailAddress To = new MailAddress($"{EmailTextbox.Text}");
            MailMessage message = new MailMessage(From, To);
            message.Subject = "Half Marathon 2020";
            message.Body = $"Информация о регистрации\n" +
                        $"Email = {EmailTextbox.Text}\n" +
                        $"Имя = {NameTextBox.Text}\n" +
                        $"Фамилия = {SurTextBox.Text}\n" +
                        $"Дата рождения = {BDTextBox.Text}\n" +
                        $"Страна = {CountryTextBox.Text}\n" +
                        $"Дистанция = {DistaTextBox.Text}\n" +
                        $"Вариат комплекта = {PoketTextBox.Text}\n" +
                        $"Итог = {CountTextBox.Text}\n" +
                        $"Классификая = {Qualification.Text}\n" +
                        $"Личный рекорд = {Personal_Record.Text}\n";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("marathon.f01@gmail.com", "vlad_6675041");
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);
            MessageBox.Show("OK");
        }
        string pring = "";
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(pring)));
            doc.Name = "Information_about_Half_Marathon_2020";
            IDocumentPaginatorSource idpSource = doc;
            pring = $"Информация о регистрации\n" +
                       $" Email = {EmailTextbox.Text}\n" +
                       $" Имя = {NameTextBox.Text}\n" +
                       $" Фамилия = {SurTextBox.Text}\n" +
                       $" Дата рождения = {BDTextBox.Text}\n" +
                       $" Страна = {CountryTextBox.Text}\n" +
                       $" Дистанция = {DistaTextBox.Text}\n" +
                       $" Вариат комплекта = {PoketTextBox.Text}\n" +
                       $" Итог= {CountTextBox.Text}\n " +
                       $" Классификая= {Qualification.Text}\n " +
                       $" Личный рекорд= {Personal_Record.Text}\n ";
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello");
        }
        private void File_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            pring = $"Информация о регистрации\n" +
                       $" Email = {EmailTextbox.Text}\n" +
                       $" Имя = {NameTextBox.Text}\n" +
                       $" Фамилия = {SurTextBox.Text}\n" +
                       $" Дата рождения = {BDTextBox.Text}\n" +
                       $" Страна = {CountryTextBox.Text}\n" +
                       $" Дистанция = {DistaTextBox.Text}\n" +
                       $" Вариат комплекта = {PoketTextBox.Text}\n" +
                       $" Итог= {CountTextBox.Text}\n " +
                       $" Классификая= {Qualification.Text}\n " +
                       $" Личный рекорд= {Personal_Record.Text}\n ";
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile(), System.Text.Encoding.Default))
                {
                    sw.Write(pring);
                    sw.Close();
                }
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT Id FROM [Tablues] WHERE Email='{email}' AND Password= '{pass}'";
            string connctString = "DataSource=Table.db; Version=3";
            SQLiteCommand command;
            SQLiteConnection connection = new SQLiteConnection(connctString);
            command = new SQLiteCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Id.Text = reader[0].ToString();
                }
                reader.Close();
            }
            reader.Close();

            string query1 = $"INSERT INTO [Event] (Id,Dist,Var, Sum) VALUES( '{Convert.ToInt32(Id.Text)}','{DistaTextBox.Text}', '{PoketTextBox.Text}'," +
             $" '{CountTextBox.Text}')";
            command = new SQLiteCommand(query1, connection);
            command.ExecuteNonQuery();
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegForMar regForMar = new RegForMar(email, pass, lan);
            regForMar.Show();
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
