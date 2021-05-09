using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для BMI.xaml
    /// </summary>
    public partial class BMI : Window
    {
        public bool StartAnimation { get; set; } = false;
        public BMI()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public BMI(string Email, string Pass, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            lan = Lan;
            if (Lan == 1)
            {
                TextIndex.Text = "Find out your body mass index with BMI calculator";
                TextMale.Text = "Male";
                TextFMale.Text = "Female";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxHeight, "Height");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxWeight, "Weight");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxAge, "Age");
                Ex.Header = "Additional information about body weight";
                First.Text = "Less than 18.5 - Underweight";
                Second.Text = "18.5-24.9-Healthy weight";
                Third.Text = "25-29.9-Overweight";
                foth.Text = "Over 30 - Obese";
                CalButton.Content = "Measure";
                Clear.Content = "Сlear";
                BackButton.Content = "Back";
            }
            else
            {
                TextIndex.Text = "Узнай свой индекс массы тела с помощью BMI калькулятора";
                TextMale.Text = "Мужской";
                TextFMale.Text = "Женский";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxHeight, "Рост");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxWeight, "Вес");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxAge, "Возраст");
                Ex.Header = "Дополнительная информация о массе тела";
                First.Text = "Меньше 18,5 - Недостаточный вес";
                Second.Text = "18.5 - 24.9 - Здоровый вес";
                Third.Text = " 25 - 29,9 - Избыточный вес";
                foth.Text = "Больше 30 - Ожирение";
                CalButton.Content = "Расчитать";
                Clear.Content = "Очистить";
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
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxAge.Text = "";
            TextBoxHeight.Text = "";
            TextBoxWeight.Text = "";
            MaleRadio.IsChecked = false;
            FemaleRadio.IsChecked = false;

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
        private void Ex_Expanded(object sender, RoutedEventArgs e)
        {

            if (Ex.IsExpanded == true)
            {
                Number.Visibility = Visibility.Hidden;
            }
        }
        private void Ex_Collapsed(object sender, RoutedEventArgs e)
        {
            if (Ex.IsExpanded == false)
            {
                Number.Visibility = Visibility.Visible;
            }
        }
        private void CalButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxWeight.Text == "" || TextBoxHeight.Text == "" || TextBoxAge.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми");
                return;
            }
            if (FemaleRadio.IsChecked == false && MaleRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите свой гендер");
                return;
            }
            if (!int.TryParse(TextBoxWeight.Text, out int weight))
            {
                MessageBox.Show("Введите число корректно", "Attantion", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (!int.TryParse(TextBoxHeight.Text, out int height))
            {
                MessageBox.Show("Введите число корректно", "Attantion", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (!int.TryParse(TextBoxAge.Text, out int age))
            {
                MessageBox.Show("Введите число корректно", "Attantion", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            string _weight, _height, _age;
            double sum = 0, a;
            _weight = (TextBoxWeight.Text);
            _height = TextBoxHeight.Text;
            _age = TextBoxAge.Text;
            a = 0.01 * Convert.ToDouble(_height);
            sum = Convert.ToDouble(_weight) / (a * a);
            Number.Text = $"{Math.Round(sum, 2)}";
            if (sum <= 18.5)
            {
                Number.Foreground = new SolidColorBrush(Color.FromArgb(255, 243, 255, 0));
            }
            else if ((sum > 18.5) && (sum < 24.9))
            {
                Number.Foreground = new SolidColorBrush(Color.FromArgb(255, 51, 226, 11));
            }
            else if ((sum > 25) && (sum < 29.9))
            {
                Number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 175, 0));
            }
            else
            {
                Number.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
        }
    }
}
