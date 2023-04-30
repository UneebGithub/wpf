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

namespace loginfull
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {

            InitializeComponent();
        }

        private void btn_new(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.a = password_new.Password;
            m.b = m.pass;
            m.pass = m.a;
            MessageBox.Show("Password Changed!");
            MessageBox.Show("Your New Password Is:  " + m.a);
            m.Show();
            this.Close();

           
        }
    }
}
