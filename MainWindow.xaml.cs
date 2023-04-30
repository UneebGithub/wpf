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

namespace loginfull
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String? user, pass, a, b;


        public MainWindow()
        {
            if (a == null)
            {
                user = "uneeb";
                pass = "uneeb123";
            }
            else
            {
                pass = null;
                pass = a;
            }

            InitializeComponent();

        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            if(user_name.Text.Equals(user)&& password.Password.Equals(pass)){
                user_name.Clear();
                password.Clear();
                MessageBox.Show("Wellcome");
            }
            else
            {
                user_name.Clear();
                password.Clear();
                MessageBox.Show("Invalid ");
            }


        }
        private void btn_click1(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Hide();
        }
    }
}
