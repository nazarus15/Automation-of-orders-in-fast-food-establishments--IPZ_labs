using Server_part;
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

namespace SOA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1 server = new Service1();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_To_Main_Inside_Click(object sender, RoutedEventArgs e)
        {
            server.SetLocation(true);

            Dishes dishes_menu = new Dishes();
            dishes_menu.Show();
            this.Close();
        }

        private void Button_To_Main_Outside_Click(object sender, RoutedEventArgs e)
        {
            server.SetLocation(false);

            Dishes dishes_menu = new Dishes();
            dishes_menu.Show();
            this.Close();
        }
    }
}
