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
    /// Interaction logic for UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();

            ApplicationContext db = new ApplicationContext();

            List<User> users = db.Users.ToList();

            listOfUsers.ItemsSource = users;
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
