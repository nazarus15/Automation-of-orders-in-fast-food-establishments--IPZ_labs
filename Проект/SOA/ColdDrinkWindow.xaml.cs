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
    /// Interaction logic for ColdDrinkWindow.xaml
    /// </summary>
    public partial class ColdDrinkWindow : Window
    {
        Service1 server = new Service1();
        public ColdDrinkWindow()
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


            countCola.Content = amount;
            countSprite.Content = amount;
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

        //Cola
        private void Cola_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusCola.Visibility = Visibility.Visible;
                minusCola.Visibility = Visibility.Visible;
                countCola.Visibility = Visibility.Visible;
                addMenuCola.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusCola_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusCola_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuCola_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 19;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusCola.Visibility = Visibility.Hidden;
            minusCola.Visibility = Visibility.Hidden;
            countCola.Visibility = Visibility.Hidden;
            addMenuCola.Visibility = Visibility.Hidden;
            Make_InVisible();
        }

        //Sprite
        private void Sprite_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusSprite.Visibility = Visibility.Visible;
                minusSprite.Visibility = Visibility.Visible;
                countSprite.Visibility = Visibility.Visible;
                addMenuSprite.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusSprite_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusSprite_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuSprite_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 20;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusSprite.Visibility = Visibility.Hidden;
            minusSprite.Visibility = Visibility.Hidden;
            countSprite.Visibility = Visibility.Hidden;
            addMenuSprite.Visibility = Visibility.Hidden;
            Make_InVisible();
        }
    }
}
