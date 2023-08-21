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
using System.Windows.Shapes;

namespace SOA
{
    /// <summary>
    /// Interaction logic for BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        Service1 server = new Service1();

        public BuyWindow()
        {
            InitializeComponent();
            SummaryToPayText.Text = (server.ReturnPriceFromOrder(server.GetStartID())).ToString();
        }

        private void Button_DishesWindow_Click(object sender, RoutedEventArgs e)
        {
            Dishes dishes_menu = new Dishes();
            dishes_menu.Show();
            this.Close();
        }
        private void Button_Exit_CLick(object sender, RoutedEventArgs e)
        {
            server.Exit();
            StartWindow main_menu = new StartWindow();
            main_menu.Show();
            this.Close();
        }

        private void Button_Buy_Click (object sender, RoutedEventArgs e)
        {
            server.ToCook(0);
            server.ToDoneWindow();
            server.DeleteFromPoP(0);
            server.DeleteFromCart(0);
            StartWindow start_menu = new StartWindow();
            DateTime now = DateTime.Now;
            while (DateTime.Now.Subtract(now).Seconds < 3)
            {
                // wait for 3 seconds
            }
            MessageBox.Show("Оплата успішна");
            this.Close();
            start_menu.Show();
        }
    }
}
