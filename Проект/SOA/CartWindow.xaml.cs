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
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        Service1 server = new Service1();
        public CartWindow()
        {
            InitializeComponent();
            Change_Text();
        }
        private void Button_DishesWindow_Click(object sender, RoutedEventArgs e)
        {
            Dishes dishes_menu = new Dishes();
            dishes_menu.Show();
            this.Close();
        }
        private void Button_BuyWindow_Click(object sender, RoutedEventArgs e)
        {
            int c;
            c = server.Show_Cart().Length;
            if (c > 70)
            {
                server.ToProccessOfPatment(1);
                BuyWindow buy_menu = new BuyWindow();
                buy_menu.Show();
                this.Close();
            }
            else { MessageBox.Show("В кошику пусто"); }

        }
        private void Button_Exit_CLick(object sender, RoutedEventArgs e)
        {
            server.Exit();
            StartWindow main_menu = new StartWindow();
            main_menu.Show();
            this.Close();
        }

        private void Change_Text()
        {
            CartTextBlock.Text = server.Show_Cart();
        }
    }
}
