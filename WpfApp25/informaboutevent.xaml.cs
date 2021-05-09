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
    /// Логика взаимодействия для informaboutevent.xaml
    /// </summary>
    public partial class informaboutevent : Window
    {
        public informaboutevent()
        {
            InitializeComponent();
        }
        string email, pass;
        int lan;
        public informaboutevent(string Email, string Pass, int Lan)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            lan = Lan;
            if (Lan == 1)
            {
                Text.Text = "The route passes in the very center of Minsk. The participants of the race can enjoy the charm of the wide avenues of the city combined with the historical sights. At the distance, you will find picturesque places of the Belarusian capital. Traffic will be completely blocked.";
                Church.Text = "Church of Saints Simeon and Elena";
                Theatre.Text = "Opera and Ballet Theater";
                Library.Text = "National Library";
                Island_Tears.Text = "Island of Tears";
                Photo1.Text = "Photo";
                Video.Content = "Distance";
            }
            else
            {
                Text.Text = "Маршрут проходит в самом центре Минска. Участники забега могут насладиться очарованием широких проспектов города в сочетании с историческими достопримечательностями. На дистанции Вас ожидают живописные места белорусской столицы. Движение автотранспорта будет полностью перекрыто.";
                Church.Text = "Костел Святых Симеона и Елены";
                Theatre.Text = "Театр оперы и балета";
                Library.Text = "Национальная Библиотека";
                Island_Tears.Text = "Остров слёз";
                Photo1.Text = "Фотографии";
                Video.Content = "Дистанция";
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass, lan);
            runnerMenu.Show();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/2.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/3.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/4.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/7.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);

        }

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/8.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_5(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/9.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_6(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/10.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }
    }
}
