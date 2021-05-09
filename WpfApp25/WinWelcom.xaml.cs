using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для WinWelcom.xaml
    /// </summary>
    public partial class WinWelcom : Window, INotifyPropertyChanged
    {
        public string Time
        {
            get
            {
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse("2021-09-09 9:00");

                TimeSpan timeSpan = dt2 - dt1;
                return string.Format("{0} дн {1} ч {2} минут {3} сек до старта марафона", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
        }
        public WinWelcom()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public WinWelcom(int Lan)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PropertyChange("Time");
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            Language Language = new Language();
            Language.Show();
        }
    }
}
