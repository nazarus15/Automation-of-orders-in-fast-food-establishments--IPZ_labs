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
using Server_part;

namespace SOA
{
    /// <summary>
    /// Interaction logic for PizzaWindow.xaml
    /// </summary>
    public partial class PizzaWindow : Window
    {

        Service1 server = new Service1();
        public PizzaWindow()
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

            countHawaiian.Content = amount;
            countChipolla.Content = amount;
            countMexican.Content = amount;
            countChampion.Content = amount;
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

        //Hawaiian
        private void Hawaiian_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusHawaiian.Visibility = Visibility.Visible;
                minusHawaiian.Visibility = Visibility.Visible;
                countHawaiian.Visibility = Visibility.Visible;
                addMenuHawaiian.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusHawaiian_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusHawaiian_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuHawaiian_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 6;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }

            
            plusHawaiian.Visibility = Visibility.Hidden;
            minusHawaiian.Visibility = Visibility.Hidden;
            countHawaiian.Visibility = Visibility.Hidden;
            addMenuHawaiian.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Chipolla
        private void Chipolla_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusChipolla.Visibility = Visibility.Visible;
                minusChipolla.Visibility = Visibility.Visible;
                countChipolla.Visibility = Visibility.Visible;
                addMenuChipolla.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusChipolla_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusChipolla_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuChipolla_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 7;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusChipolla.Visibility = Visibility.Hidden;
            minusChipolla.Visibility = Visibility.Hidden;
            countChipolla.Visibility = Visibility.Hidden;
            addMenuChipolla.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Mexican
        private void Mexican_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusMexican.Visibility = Visibility.Visible;
                minusMexican.Visibility = Visibility.Visible;
                countMexican.Visibility = Visibility.Visible;
                addMenuMexican.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusMexican_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusMexican_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuMexican_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 8;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusMexican.Visibility = Visibility.Hidden;
            minusMexican.Visibility = Visibility.Hidden;
            countMexican.Visibility = Visibility.Hidden;
            addMenuMexican.Visibility = Visibility.Hidden;
            Make_InVisible();
        }

        //Champion
        private void Champion_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusChampion.Visibility = Visibility.Visible;
                minusChampion.Visibility = Visibility.Visible;
                countChampion.Visibility = Visibility.Visible;
                addMenuChampion.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusChampion_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusChampion_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuChampion_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 9;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusChampion.Visibility = Visibility.Hidden;
            minusChampion.Visibility = Visibility.Hidden;
            countChampion.Visibility = Visibility.Hidden;
            addMenuChampion.Visibility = Visibility.Hidden;
            Make_InVisible();
        }
    }
}
