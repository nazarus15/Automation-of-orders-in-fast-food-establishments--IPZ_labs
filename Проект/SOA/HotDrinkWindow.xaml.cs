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
    /// Interaction logic for HotDrinkWindow.xaml
    /// </summary>
    public partial class HotDrinkWindow : Window
    {
        Service1 server = new Service1();
        public HotDrinkWindow()
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

            countGreenTea.Content = amount;
            countBlackTea.Content = amount;
            countEspresso.Content = amount;
            countLatte.Content = amount;
            countСappuccino.Content = amount;
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

        //GreenTea
        private void GreenTea_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusGreenTea.Visibility = Visibility.Visible;
                minusGreenTea.Visibility = Visibility.Visible;
                countGreenTea.Visibility = Visibility.Visible;
                addMenuGreenTea.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusGreenTea_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusGreenTea_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuGreenTea_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 14;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusGreenTea.Visibility = Visibility.Hidden;
            minusGreenTea.Visibility = Visibility.Hidden;
            countGreenTea.Visibility = Visibility.Hidden;
            addMenuGreenTea.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //BlackTea
        private void BlackTea_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusBlackTea.Visibility = Visibility.Visible;
                minusBlackTea.Visibility = Visibility.Visible;
                countBlackTea.Visibility = Visibility.Visible;
                addMenuBlackTea.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusBlackTea_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusBlackTea_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuBlackTea_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 15;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusBlackTea.Visibility = Visibility.Hidden;
            minusBlackTea.Visibility = Visibility.Hidden;
            countBlackTea.Visibility = Visibility.Hidden;
            addMenuBlackTea.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Espresso
        private void Espresso_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusEspresso.Visibility = Visibility.Visible;
                minusEspresso.Visibility = Visibility.Visible;
                countEspresso.Visibility = Visibility.Visible;
                addMenuEspresso.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusEspresso_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusEspresso_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuEspresso_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 16;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusEspresso.Visibility = Visibility.Hidden;
            minusEspresso.Visibility = Visibility.Hidden;
            countEspresso.Visibility = Visibility.Hidden;
            addMenuEspresso.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Latte
        private void Latte_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusLatte.Visibility = Visibility.Visible;
                minusLatte.Visibility = Visibility.Visible;
                countLatte.Visibility = Visibility.Visible;
                addMenuLatte.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusLatte_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusLatte_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuLatte_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 17;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusLatte.Visibility = Visibility.Hidden;
            minusLatte.Visibility = Visibility.Hidden;
            countLatte.Visibility = Visibility.Hidden;
            addMenuLatte.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Сappuccino
        private void Сappuccino_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusСappuccino.Visibility = Visibility.Visible;
                minusСappuccino.Visibility = Visibility.Visible;
                countСappuccino.Visibility = Visibility.Visible;
                addMenuСappuccino.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusСappuccino_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusСappuccino_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuСappuccino_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 18;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusСappuccino.Visibility = Visibility.Hidden;
            minusСappuccino.Visibility = Visibility.Hidden;
            countСappuccino.Visibility = Visibility.Hidden;
            addMenuСappuccino.Visibility = Visibility.Hidden;
            Make_InVisible();
        }
    }
}
