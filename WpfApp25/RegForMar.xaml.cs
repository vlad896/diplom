using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace WpfApp25
{
    public partial class RegForMar : Window
    {
        public int Sum { get; set; }
        const int FullAmount = 100;
        const int HalfAmount = 50;
        const int ShortAmount = 0;
        const int OptionBAmount = 25;
        const int OptionCAmount = 40;
        public RegForMar()
        {
            InitializeComponent();
            SmallMar.IsChecked = true;
            VersionA.IsChecked = true;
        }
        public string email, pass;
        int lan;
        public RegForMar(string Email, string Pass, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            lan = Lan;
            if (Lan == 1)
            {
                Text.Text = "Please fill in all the information to register for the marathon held in Minsk. Republic of Belarus";
                RegButton.Content = "Resistr";
                CancelButton.Content = "Cancel";
                BackButton.Content = "Back";
                Type.Text = "Type of marathon";
                Kit.Text = "Kit Options";
                FullMar.Content = "42 km Full Marathon (100BYN)";
                HalfMar.Content = "21 km Half Marathon (50BYN)";
                SmallMar.Content = "5 km Small Marathon (0BYN)";
                RegNum.Text = "Registration fee";
                A.Header = "Option A (0BYN)";
                B.Header = "Option B (25BYN)";
                C.Header = "Option C (40BYN)";
                V1.Text = "Runner number RFID Wristband";
                V2.Text = "Option A + baseball cap + water bottle";
                V3.Text = "Option B + T-shirt + souvenir booklet";
            }
            else
            {
                Text.Text = "Пожалуйста заполните всё информацию, чтобы зарегистрироваться на марафон проводимом в Минске. Республика Беларусь";
                RegButton.Content = "Зарегистрироваться";
                CancelButton.Content = "Закрыть";
                BackButton.Content = "Назад";
                Type.Text = "Вид марафона";
                Kit.Text = "Варианты комплектов";
                FullMar.Content = "42 km Полный марафон (100BYN)";
                HalfMar.Content = "21 km Полумарафон (50BYN)";
                SmallMar.Content = "5 km Малая марафон (0BYN)";
                RegNum.Text = " Регистрационный взнос";
                A.Header = "Вариант А (0BYN)";
                B.Header = "Вариант Б (25BYN)";
                C.Header = "Вариант С (40BYN)";
                V1.Text = "Номер бегуна RFID браслет";
                V2.Text = "Вариант А + бейсболка + бутылка воды";
                V3.Text = "Вариант Б + футболка + сувенирный буклет";
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
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }
        private void VersionB_Checked(object sender, RoutedEventArgs e)
        {
            if (VersionB.IsChecked == true)
            {
                Sum += OptionBAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void VersionB_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VersionB.IsChecked == false)
            {
                Sum -= OptionBAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void VersionC_Checked(object sender, RoutedEventArgs e)
        {
            if (VersionC.IsChecked == true)
            {
                Sum += OptionCAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void VersionC_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VersionC.IsChecked == false)
            {
                Sum -= OptionCAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void FullMar_Checked(object sender, RoutedEventArgs e)
        {
            if (FullMar.IsChecked == true)
            {
                Sum += FullAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void FullMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (FullMar.IsChecked == false)
            {
                Sum -= FullAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void HalfMar_Checked(object sender, RoutedEventArgs e)
        {
            if (HalfMar.IsChecked == true)
            {
                Sum += HalfAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void HalfMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (HalfMar.IsChecked == false)
            {
                Sum -= HalfAmount;
                PriceBYN.Content = Sum.ToString() + "BYN";
                Curs(Sum);
            }
        }
        private void SmallMar_Checked(object sender, RoutedEventArgs e)
        {
            if (SmallMar.IsChecked == true)
            {
                Sum += ShortAmount;
                Curs(Sum);
                PriceBYN.Content = Sum.ToString() + "BYN";
            }
        }
        private void SmallMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (SmallMar.IsChecked == false)
            {
                Sum -= ShortAmount;
                Curs(Sum);
                PriceBYN.Content = Sum.ToString() + "BYN";
            }
        }

        public void Curs(int Price)
        {

            double p = Price;
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.nbrb.by/services/xmlexrates.aspx?");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("DailyExRates").Elements("Currency");
            string dollar = el.Where(x => x.Attribute("Id").Value == "145").Select(x => x.Element("Rate").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("Id").Value == "292").Select(x => x.Element("Rate").Value).FirstOrDefault();

            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double d = double.Parse(dollar);
            double e = double.Parse(eur);
            Thread.CurrentThread.CurrentCulture = temp_culture;

            double D = p / d;
            double E = p / e;
            string s = System.String.Format("{0:F2}", D);
            string s1 = System.String.Format("{0:F2}", E);
            PriceD.Content = s + "$";
            PriceE.Content = s1 + "€";
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            string dist = "";
            string ver = "";
            string count = "";
            if (SmallMar.IsChecked == true)
            {
                dist = SmallMar.Content.ToString();
            }
            if (HalfMar.IsChecked == true)
            {
                dist = HalfMar.Content.ToString();
            }
            if (FullMar.IsChecked == true)
            {
                dist = FullMar.Content.ToString();
            }
            if (VersionA.IsChecked == true)
            {
                ver = V1.Text;
            }
            if (VersionB.IsChecked == true)
            {
                ver = V2.Text;
            }
            if (VersionC.IsChecked == true)
            {
                ver = V3.Text;
            }
            if (PriceBYN.IsChecked == true)
            {
                count = (PriceBYN.Content).ToString();
            }
            if (PriceD.IsChecked == true)
            {
                count = (PriceD.Content).ToString();
            }
            if (PriceE.IsChecked == true)
            {
                count = (PriceE.Content).ToString();
            }
            this.Hide();
            Print print = new Print(email, pass, dist, ver, count, lan);
            print.Show();
        }
    }
}
