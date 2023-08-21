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
    /// Interaction logic for Dishes.xaml
    /// </summary>
    public partial class Dishes : Window
    {
        Service1 server = new Service1();
        public Dishes()
        {
            InitializeComponent();
        }
        private void Button_Exit_CLick(object sender, RoutedEventArgs e)
        {
            server.Exit();
            StartWindow main_menu = new StartWindow();
            main_menu.Show();
            this.Close();
        }
        private void Button_CartWindow_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cart_menu = new CartWindow();
            cart_menu.Show();
            this.Close();
        }

        private void Button_FirstDishesWindow_Click(object sender, RoutedEventArgs e)
        {
            First_dishesWindow first_dishes_menu = new First_dishesWindow();
            first_dishes_menu.Show();
            this.Close();
        }

        private void Button_BurgersWindow_Click (object sender, RoutedEventArgs e)
        {
            BurgersWindow menu = new BurgersWindow();
            menu.Show();
            this.Close();
        }

        private void Button_PizzaWindow_Click (object sender, RoutedEventArgs e)
        {
            PizzaWindow menu = new PizzaWindow();
            menu.Show();
            this.Close();
        }
        
        private void Button_PastaWindow_Click (object sender, RoutedEventArgs e)
        {
            PastaWindow menu = new PastaWindow();
            menu.Show();
            this.Close();
        }
        
        private void Button_HotDrinkWindow_Click(object sender, RoutedEventArgs e)
        {
            HotDrinkWindow menu = new HotDrinkWindow();
            menu.Show();
            this.Close();
        }
                
        private void Button_ColdDrinkWindow_Click(object sender, RoutedEventArgs e)
        {
            ColdDrinkWindow menu = new ColdDrinkWindow();
            menu.Show();
            this.Close();
        }
    }
}
