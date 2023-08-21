
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
    /// Interaction logic for First_dishesWindow.xaml
    /// </summary>
    public partial class First_dishesWindow : Window
    {

        Service1 server = new Service1();
        public First_dishesWindow()
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
            else {amount = num;}

            countBorshch.Content = amount;
            countBulyon.Content = amount;
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


        //Borshch
        private void Borshch_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusBorshch.Visibility = Visibility.Visible;
                minusBorshch.Visibility = Visibility.Visible;
                countBorshch.Visibility = Visibility.Visible;
                addMenuBorshch.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusBorshch_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusBorshch_Button_Click(object sender, RoutedEventArgs e)
        {
            if (amount == 0)
            {
                MessageBox.Show("це ітак ніщо");
            }
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuBorshch_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 1;
            if(amount > 0) 
            { 
                server.CreateCartRecord(id, amount);
            }
            else
            {
                MessageBox.Show("Нічого не додано в кошик");
            }
            

            plusBorshch.Visibility = Visibility.Hidden;
            minusBorshch.Visibility = Visibility.Hidden;
            countBorshch.Visibility = Visibility.Hidden;
            addMenuBorshch.Visibility = Visibility.Hidden;
            Make_InVisible();
        }



        //Bulyon
        private void Bulyon_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusBulyon.Visibility = Visibility.Visible;
                minusBulyon.Visibility = Visibility.Visible;
                countBulyon.Visibility = Visibility.Visible;
                addMenuBulyon.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }          
        }
        private void PlusBulyon_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusBulyon_Button_Click(object sender, RoutedEventArgs e)
        {
           if(amount == 0)
            {
                MessageBox.Show("це ітак ніщо");
            }
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuBulyon_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 2;
            if (amount > 0) { 
                server.CreateCartRecord(id, amount);
            }
            else
            {
                MessageBox.Show("Нічого не додано в кошик");
            }


            plusBulyon.Visibility = Visibility.Hidden;
            minusBulyon.Visibility = Visibility.Hidden;
            countBulyon.Visibility = Visibility.Hidden;
            addMenuBulyon.Visibility = Visibility.Hidden;
            Make_InVisible();
        }

    }
}