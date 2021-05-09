using System;
using System.Windows;
using System.Windows.Input;
namespace WpfApp25
{

    public partial class BMR : Window
    {
        public BMR()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public BMR(string Email, string Pass, int Lan)
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
                Sitting.Content = "Sitting";
                Lactivity.Content = "Little activity";
                Aactivity.Content = "Average activity";
                Sactivity.Content = "Strong activity";
                Mactivity.Content = "Max activity";
                BMR1.Content = "Your BMR";
                CalButton.Content = "Measure";
                Clear.Content = "Сlear";
                BackButton.Content = "Back";
            }
            else
            {
                TextIndex.Text = "Узнай минимальное количество энергии в день с помощью BMR калькулятора";
                TextMale.Text = "Мужской";
                TextFMale.Text = "Женский";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxHeight, "Рост");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxWeight, "Вес");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextBoxAge, "Возраст");
                Sitting.Content = "Сидячий";
                Lactivity.Content = "Маленькая активность";
                Aactivity.Content = "Средняя активность";
                Sactivity.Content = "Сильная активность";
                Mactivity.Content = "Максимальная активность";
                BMR1.Content = "Ваш BMR";
                CalButton.Content = "Рассчитать";
                Clear.Content = "Очистиь";
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
            Application.Current.Shutdown();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
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
            double sum = 0, a, b, c;
            _weight = (TextBoxWeight.Text);
            _height = TextBoxHeight.Text;
            _age = TextBoxAge.Text;

            if (MaleRadio.IsChecked == true)
            {
                a = 13.7 * Convert.ToDouble(_weight);
                b = 5 * Convert.ToDouble(_height);
                c = 6.8 * Convert.ToDouble(_age);
                sum = (66 + a + b - c);
                Number.Text = $"{Math.Round(sum, 2)}";
            }
            if (FemaleRadio.IsChecked == true)
            {
                a = 9.6 * Convert.ToDouble(_weight);
                b = 1.8 * Convert.ToDouble(_height);
                c = 4.7 * Convert.ToDouble(_age);
                sum = (655 + a + b - c);
                Number.Text = $"{Math.Round(sum, 2)}";
            }
            LabelSitting.Content = $"{Math.Round(sum * 1.2, 2)}";
            LabelLitActivity.Content = $"{Math.Round(sum * 1.375, 2)}";
            LabelAverActivity.Content = $"{Math.Round(sum * 1.55, 2)}";
            LabelStrongActivity.Content = $"{Math.Round(sum * 1.725, 2)}";
            LabelMaximumActivity.Content = $"{Math.Round(sum * 1.9, 2)}";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxAge.Text = "";
            TextBoxHeight.Text = "";
            TextBoxWeight.Text = "";
            MaleRadio.IsChecked = false;
            FemaleRadio.IsChecked = false;
        }
        DescriptionOfActivities descriptionOfActivities = new DescriptionOfActivities();
        private void PackIconMaterial_MouseEnter(object sender, MouseEventArgs e)
        {
            descriptionOfActivities.Show();
        }
        private void PackIconMaterial_MouseLeave(object sender, MouseEventArgs e)
        {
            descriptionOfActivities.Hide();
        }
    }
}
