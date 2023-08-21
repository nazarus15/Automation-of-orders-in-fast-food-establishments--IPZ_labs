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
    /// Interaction logic for BurgersWindow.xaml
    /// </summary>
    public partial class BurgersWindow : Window
    {
        Service1 server = new Service1();
        public BurgersWindow()
        {
            InitializeComponent();
        }

        int amount = 0;
        private bool is_smth_visible = false;

        void Make_Visible()
        {
            is_smth_visible = true;
        }
        void Make_InVisible()
        {
            is_smth_visible = false;
        }
        void Change_Amount(int num)
        {
            if (num < 0)
            {
                amount = 0;
            }
            else { amount = num; }

            countBurger.Content = amount;
            countCheesseBurger.Content = amount;
            countDoubleBurger.Content = amount;
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
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
        private void Button_CartWindow_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cart_menu = new CartWindow();
            cart_menu.Show();
            this.Close();
        }

        //Burger
        private void Burger_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusBurger.Visibility = Visibility.Visible;
                minusBurger.Visibility = Visibility.Visible;
                countBurger.Visibility = Visibility.Visible;
                addMenuBurger.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 3;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusBurger.Visibility = Visibility.Hidden;
            minusBurger.Visibility = Visibility.Hidden;
            countBurger.Visibility = Visibility.Hidden;
            addMenuBurger.Visibility = Visibility.Hidden;
            Make_InVisible();
        }

        //CheesseBurger
        private void CheesseBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusCheesseBurger.Visibility = Visibility.Visible;
                minusCheesseBurger.Visibility = Visibility.Visible;
                countCheesseBurger.Visibility = Visibility.Visible;
                addMenuCheesseBurger.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusCheesseBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusCheesseBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuCheesseBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 4;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusCheesseBurger.Visibility = Visibility.Hidden;
            minusCheesseBurger.Visibility = Visibility.Hidden;
            countCheesseBurger.Visibility = Visibility.Hidden;
            addMenuCheesseBurger.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //DoubleBurger
        private void DoubleBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusDoubleBurger.Visibility = Visibility.Visible;
                minusDoubleBurger.Visibility = Visibility.Visible;
                countDoubleBurger.Visibility = Visibility.Visible;
                addMenuDoubleBurger.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusDoubleBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusDoubleBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuDoubleBurger_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 3;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusDoubleBurger.Visibility = Visibility.Hidden;
            minusDoubleBurger.Visibility = Visibility.Hidden;
            countDoubleBurger.Visibility = Visibility.Hidden;
            addMenuDoubleBurger.Visibility = Visibility.Hidden;
            Make_InVisible();
        }
    }
}
