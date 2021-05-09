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
    /// Логика взаимодействия для Language.xaml
    /// </summary>
    public partial class Language : Window
    {
        public Language()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int Lang = 0;
            if (LanEng.IsChecked == true)
            {
                Lang = 1;
            }
            if (LanRus.IsChecked == true)
            {
                Lang = 2;
            }
            this.Hide();
            MainWindow mainWindow = new MainWindow(Lang);
            mainWindow.Show();
        }
    }
}
