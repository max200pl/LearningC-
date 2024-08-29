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

namespace Project_2_Form_Material_design
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textboxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
     

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
            else
            {
                textboxLogin.ToolTip = "";
                textboxLogin.Background = Brushes.LightCyan;
                passBox.ToolTip = "";
                passBox.Background = Brushes.LightCyan;

                User authUser = null;


                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Login Successful");
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else MessageBox.Show("Login Incorrect");
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
