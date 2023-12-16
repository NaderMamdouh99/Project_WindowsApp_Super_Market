using Super_Market.Models;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context context = new Context();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region select box

            string UserRole = comboValue.Text;
            if (UserRole != "Select Role")
            {

                if (UserRole == "Admin")
                {

                    var AdminQuery = context.users.Where(usr => usr.Pos == (position)1 && usr.IsDelete == false && usr.UserName == txtUsrName.Text && usr.Password == txtPass.Password).FirstOrDefault();

                    if (AdminQuery != null)
                    {
                        Login.Content = new Admin(txtUsrName.Text);
                    }
                    else
                    {
                        MessageBox.Show($"ooops!! you entered wrong email or password please enter a valid data for Admin", "Wrong Data Input", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }

                else if (UserRole == "Casher")
                {
                    var casherQuery = context.users.Where(usr => usr.Pos == 0 && usr.UserName == txtUsrName.Text && usr.Password == txtPass.Password).FirstOrDefault();
                    if (casherQuery != null)
                    {
                        Login.Content = new Casher(txtUsrName.Text);
                    }
                    else
                    {
                        MessageBox.Show($"ooops!! you entered wrong email or password please enter a valid data for casher", "Wrong Data Input", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show($"ooops!! you entered wrong user role", "please choose user role", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            #endregion


        }


        private void Login_PreviewKeyDown(object sender, TextCompositionEventArgs e)
        {

        }

        private void Login_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string admin = comboValue.Text;

                if (admin == "Admin")
                {
                    var AdminQueryVaild = context.users.Where(usr => usr.Pos == (position)1 && usr.UserName == txtUsrName.Text && usr.Password == txtPass.Password).FirstOrDefault();
                    Login.Content = new Admin(txtUsrName.Text);
                }

                else if (admin == "Casher")
                {
                    var casherQuery = context.users.Where(usr => usr.Pos == 0 && usr.IsDelete == false && usr.UserName == txtUsrName.Text && usr.Password == txtPass.Password).FirstOrDefault();
                    Login.Content = new Casher(txtUsrName.Text);
                }
                else
                {
                    MessageBox.Show("wrong");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
