using Super_Market.Models;
using System.Windows;
using System.Windows.Controls;

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        #region connect to database

        Context Context = new Context();
        public string UserName = "";
        public Admin(string name)
        {
            InitializeComponent();
            UserName = name;
            UserWelcome_Label.Content = "  Welcome " + name + "!";
        }
        #endregion

        #region props of admin
        //Store
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

            stores.Content = new Store();
        }
        //Category
        private void list_2_Selected(object sender, RoutedEventArgs e)
        {
            stores.Content = new Category();
        }
        //Product
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            stores.Content = new Product();
        }
        //Sales
        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            stores.Content = new Sales(UserName);
        }
        //Purchase
        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            stores.Content = new Purchase();
        }
        //Report
        //private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        //{
        //    stores.Content = new Report();
        //}
        //Retrieval
        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            stores.Content = new Retrieval();

        }
        //MainWindow
        private void ListViewItem_Selected_6(object sender, RoutedEventArgs e)
        {

            MainWindow window = new MainWindow();
            window.Show();
            Window.GetWindow(this).Close();
        }
        //Supplier
        private void ListViewItem_Selected_7(object sender, RoutedEventArgs e)
        {
            stores.Content = new Supplier();
        }
        //Minimized
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.WindowState = WindowState.Minimized;
        }
        //Maximized
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Window window = Window.GetWindow(this);
            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState = WindowState.Maximized;
            }
        }
        //Shutdown
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion

    }

}
