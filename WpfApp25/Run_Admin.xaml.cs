using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    /// Логика взаимодействия для Run_Admin.xaml
    /// </summary>
    public partial class Run_Admin : Window
    {

        private ObservableCollection<ToDoModel> _todoData = new ObservableCollection<ToDoModel>();
        private ObservableCollection<ToDoModel1> _todoData1 = new ObservableCollection<ToDoModel1>();
        private ObservableCollection<ToDoModel2> _todoData2 = new ObservableCollection<ToDoModel2>();
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
        public Run_Admin()
        {
            InitializeComponent();

        }
        int lan;
        public Run_Admin(int Lan)
        {
            lan = Lan;
            InitializeComponent();
            if (Lan == 1)
            {
                HalfM.Text = "User Management";
                ADD.Content = "Add a new runner";
                Del.Content = "Delete the selected runner";
                Filtration.Content = "Search";
                Remove.Content = "Edit the selected row";
                TOP3.Content = "Top 3 Fastest Runners";
                Search.Content = "Search";
                ButtonReset.Content = "Reset";
                EmailCheck.Content = "Email";
                NameCheck.Content = "Name";
                SurnamelCheck.Content = "Surname";
                SexCheck.Content = "Sex";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextboxSeatch, "Search text");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualific, "Search criteria");
                Logout.Content = "Log out";
                TextBlockCounUsers.Text = "Total users";
            }
            else
            {
                HalfM.Text = "Управление пользователями";
                ADD.Content = "Добавить нового бегуна";
                Del.Content = "Удалить выбранного бегуна";
                Filtration.Content = "Найти";
                Remove.Content = "Изменить выбранную строку";
                TOP3.Content = "Топ 3 быстрых бегуна";
                Search.Content = "Найти";
                ButtonReset.Content = "Сбросить";
                EmailCheck.Content = "Почта";
                NameCheck.Content = "Имя";
                SurnamelCheck.Content = "Фамилия";
                SexCheck.Content = "Пол";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(TextboxSeatch, "Текст для поиска");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(Qualific, "Критерии поиска");
                Logout.Content = "Выход из системы";
                TextBlockCounUsers.Text = "Всего пользователей";

            }

        }
        public void ReadToBD()
        {
            dataGrid.ItemsSource = null;
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = "SELECT * FROM [Tablues]";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData.Add(new ToDoModel()
                {
                    ID = Convert.ToInt32(reader[0]),
                    Email = reader[1].ToString(),
                    Pass = reader[2].ToString(),
                    Name = reader[3].ToString(),
                    Surname = reader[4].ToString(),
                    BD = reader[5].ToString(),
                    Country = reader[6].ToString(),
                    Sex = reader[7].ToString(),
                    Qualific = reader[8].ToString(),
                    Personl_record = reader[9].ToString()
                });
            }
            dataGrid.ItemsSource = _todoData;
            _todoData.CollectionChanged += _todoData_CollectionChanged;
            reader.Close();
        }
        public void ReadToBD2()
        {
            dataGrid1.ItemsSource = null;
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = "SELECT * FROM [Event]";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData1.Add(new ToDoModel1()
                {
                    Id_event = Convert.ToInt32(reader[0]),
                    Id = Convert.ToInt32(reader[1]),
                    Dista = reader[2].ToString(),
                    Var = reader[3].ToString(),
                    Sum = reader[4].ToString()
                }); ;
            }
            dataGrid1.ItemsSource = _todoData1;
            _todoData1.CollectionChanged += _todoData1_CollectionChanged; ;
            reader.Close();
        }

        private void _todoData1_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

        }

        public void ReadToBD3()
        {
            dataGrid2.ItemsSource = null;
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = "SELECT * FROM [user_log]";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData2.Add(new ToDoModel2()
                {
                    Id_u = Convert.ToInt32(reader[0]),
                    U_date = reader[1].ToString(),
                    Operation = reader[2].ToString()
                });
            }
            dataGrid2.ItemsSource = _todoData2;
            _todoData2.CollectionChanged += _todoData2_CollectionChanged; ;
            reader.Close();
        }

        private void _todoData2_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

        }

        public void CountUsers()
        {
            string query = "select COUNT(Id) from Tablues";
            command = new SQLiteCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CountsUsers.Text = reader[0].ToString();
                }
                reader.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(lan);
            mainWindow.Show();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CountUsers();
            ReadToBD();
            ReadToBD2();
            ReadToBD3();
        }

        private void dataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAdmin register = new RegisterAdmin(lan);
            register.Show();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();


            try
            {
                DELLAdmin removeAdmin = new DELLAdmin(_todoData[dataGrid.SelectedIndex].ID, lan);
                removeAdmin.Show();
            }
            catch (Exception)
            {
                Run_Admin run_Admin = new Run_Admin(lan);
                run_Admin.Show();
                MessageBox.Show("error");
                return;
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();


            try
            {
                RemoveAdmin removeAdmin = new RemoveAdmin(_todoData[dataGrid.SelectedIndex].ID, lan);
                removeAdmin.Show();
            }
            catch (Exception)
            {
                Run_Admin run_Admin = new Run_Admin(lan);
                run_Admin.Show();
                MessageBox.Show("error");
                return;

            }
        }
        private void TOP3_Click_1(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _todoData;
            _todoData.Clear();
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = "select* from [tablues] order by Personal_Record desc limit 3";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                _todoData.Add(new ToDoModel()
                {
                    ID = Convert.ToInt32(reader[0]),
                    Email = reader[1].ToString(),
                    Pass = reader[2].ToString(),
                    Name = reader[3].ToString(),
                    Surname = reader[4].ToString(),
                    BD = reader[5].ToString(),
                    Country = reader[6].ToString(),
                    Sex = reader[7].ToString(),
                    Qualific = reader[8].ToString(),
                    Personl_record = reader[9].ToString()
                });
            }
            dataGrid.ItemsSource = _todoData;
            _todoData.CollectionChanged += _todoData_CollectionChanged; ;
            reader.Close();

        }

        private void _todoData_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _todoData;
            _todoData.Clear();
            if (Qualific.Text == "")
            {
                MessageBox.Show("error");
                return;

            }
            if (TextboxSeatch.Text == "")
            {
                MessageBox.Show("error");
                return;

            }
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = $"select  * from [tablues] where {Qualific.Text} like '%{TextboxSeatch.Text}%'";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData.Add(new ToDoModel()
                {
                    ID = Convert.ToInt32(reader[0]),
                    Email = reader[1].ToString(),
                    Pass = reader[2].ToString(),
                    Name = reader[3].ToString(),
                    Surname = reader[4].ToString(),
                    BD = reader[5].ToString(),
                    Country = reader[6].ToString(),
                    Sex = reader[7].ToString(),
                    Qualific = reader[8].ToString(),
                    Personl_record = reader[9].ToString()
                });
            }
            dataGrid.ItemsSource = _todoData;
            _todoData.CollectionChanged += _todoData_CollectionChanged;
            reader.Close();
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            TextboxSeatch.Text = "";
            Qualific.Text = "";
            dataGrid.ItemsSource = _todoData;
            _todoData.Clear();
            dataGrid1.ItemsSource = _todoData1;
            _todoData1.Clear();
            dataGrid2.ItemsSource = _todoData2;
            _todoData2.Clear();
            ReadToBD();
            ReadToBD2();
            ReadToBD3();
            EmailCheck.IsChecked = false;
            NameCheck.IsChecked = false;
            SurnamelCheck.IsChecked = false;
            SexCheck.IsChecked = false;

        }

        private void Filtration_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = _todoData;
            _todoData.Clear();
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = $"select * from [tablues]";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData.Add(new ToDoModel()
                {
                    ID = Convert.ToInt32(reader[0]),
                    Email = reader[1].ToString(),
                    Pass = reader[2].ToString(),
                    Name = reader[3].ToString(),
                    Surname = reader[4].ToString(),
                    BD = reader[5].ToString(),
                    Country = reader[6].ToString(),
                    Sex = reader[7].ToString(),
                    Qualific = reader[8].ToString(),
                    Personl_record = reader[9].ToString()
                });
            }
            dataGrid.ItemsSource = _todoData;
            _todoData.CollectionChanged += _todoData_CollectionChanged;
            reader.Close();

            if (EmailCheck.IsChecked == true)
            {
                dataGrid.Columns[1].Visibility = Visibility.Visible;
                dataGrid.Columns[2].Visibility = Visibility.Hidden;
                dataGrid.Columns[3].Visibility = Visibility.Hidden;
                dataGrid.Columns[4].Visibility = Visibility.Hidden;
                dataGrid.Columns[5].Visibility = Visibility.Hidden;
                dataGrid.Columns[6].Visibility = Visibility.Hidden;
                dataGrid.Columns[7].Visibility = Visibility.Hidden;
                dataGrid.Columns[8].Visibility = Visibility.Hidden;
                dataGrid.Columns[9].Visibility = Visibility.Hidden;
            }
            if (SurnamelCheck.IsChecked == true)
            {

                dataGrid.Columns[1].Visibility = Visibility.Hidden;
                dataGrid.Columns[2].Visibility = Visibility.Hidden;
                dataGrid.Columns[3].Visibility = Visibility.Hidden;
                dataGrid.Columns[4].Visibility = Visibility.Visible;
                dataGrid.Columns[5].Visibility = Visibility.Hidden;
                dataGrid.Columns[6].Visibility = Visibility.Hidden;
                dataGrid.Columns[7].Visibility = Visibility.Hidden;
                dataGrid.Columns[8].Visibility = Visibility.Hidden;
                dataGrid.Columns[9].Visibility = Visibility.Hidden;
            }

            if (SexCheck.IsChecked == true)
            {

                dataGrid.Columns[1].Visibility = Visibility.Hidden;
                dataGrid.Columns[2].Visibility = Visibility.Hidden;
                dataGrid.Columns[3].Visibility = Visibility.Hidden;
                dataGrid.Columns[4].Visibility = Visibility.Hidden;
                dataGrid.Columns[5].Visibility = Visibility.Hidden;
                dataGrid.Columns[6].Visibility = Visibility.Hidden;
                dataGrid.Columns[7].Visibility = Visibility.Visible;
                dataGrid.Columns[8].Visibility = Visibility.Hidden;
                dataGrid.Columns[9].Visibility = Visibility.Hidden;
            }
            if (NameCheck.IsChecked == true)
            {

                dataGrid.Columns[1].Visibility = Visibility.Hidden;
                dataGrid.Columns[2].Visibility = Visibility.Hidden;
                dataGrid.Columns[3].Visibility = Visibility.Visible;
                dataGrid.Columns[4].Visibility = Visibility.Hidden;
                dataGrid.Columns[5].Visibility = Visibility.Hidden;
                dataGrid.Columns[6].Visibility = Visibility.Hidden;
                dataGrid.Columns[7].Visibility = Visibility.Hidden;
                dataGrid.Columns[8].Visibility = Visibility.Hidden;
                dataGrid.Columns[9].Visibility = Visibility.Hidden;
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                CountsUsers.Visibility = Visibility.Visible;
                TextBlockCounUsers.Visibility = Visibility.Visible;
                Filtration.IsEnabled = true;
                Search.IsEnabled = true;
                TOP3.IsEnabled = true;
                ButtonReset.IsEnabled = true;
                ADD.IsEnabled = true;
                Del.IsEnabled = true;
                Remove.IsEnabled = true;

            }
            if (TabControl.SelectedIndex == 1)
            {
                CountsUsers.Visibility = Visibility.Hidden;
                TextBlockCounUsers.Visibility = Visibility.Hidden;
                Filtration.IsEnabled = false;
                Search.IsEnabled = false;
                TOP3.IsEnabled = false;
                ButtonReset.IsEnabled = false;
                ADD.IsEnabled = false;
                Del.IsEnabled = false;
                Remove.IsEnabled = false;
            }
            if (TabControl.SelectedIndex == 2)
            {
                CountsUsers.Visibility = Visibility.Hidden;
                TextBlockCounUsers.Visibility = Visibility.Hidden;
                Filtration.IsEnabled = false;
                Search.IsEnabled = false;
                TOP3.IsEnabled = false;
                ButtonReset.IsEnabled = false;
                ADD.IsEnabled = false;
                Del.IsEnabled = false;
                Remove.IsEnabled = false;
            }
        }
    }
}
