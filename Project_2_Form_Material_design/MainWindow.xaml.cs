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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace Project_2_Form_Material_design
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            DoubleAnimation btnAnimation = new DoubleAnimation();

            btnAnimation.From = 0;
            btnAnimation.To = 450;
            btnAnimation.Duration = TimeSpan.FromSeconds(10);
            regButton.BeginAnimation(Button.WidthProperty, btnAnimation);

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textboxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string passRepeat = passBoxRepeat.Password.Trim();
            string email = textboxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textboxLogin.ToolTip = "This Login incorrect";
                textboxLogin.Background = Brushes.LightCoral;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Pass must contain more then 5 symbols";
                passBox.Background = Brushes.LightCoral;
            }
            else if (pass != passRepeat)
            {
                passBox.ToolTip = "Pass must contain the same password";
                passBox.Background = Brushes.LightCoral;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textboxEmail.ToolTip = "Incorrect email";
                textboxEmail.Background = Brushes.LightCoral;
            }
            else
            {
                textboxLogin.ToolTip = "";
                textboxLogin.Background = Brushes.LightCyan;
                passBox.ToolTip = "";
                passBox.Background = Brushes.LightCyan;
                passBoxRepeat.ToolTip = "";
                passBoxRepeat.Background = Brushes.LightCyan;
                textboxEmail.ToolTip = "";
                textboxEmail.Background = Brushes.LightCyan;

                MessageBox.Show("Login Successful");

                User user = new User(login, email, pass);

                db.Users.Add(user);

                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();
            }
        }

        private void Button_Windw_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
