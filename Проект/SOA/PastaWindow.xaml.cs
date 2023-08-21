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
    /// Interaction logic for PastaWindow.xaml
    /// </summary>
    public partial class PastaWindow : Window
    {
        Service1 server = new Service1();
        public PastaWindow()
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

            countCapellini.Content = amount;
            countFetuchini.Content = amount;
            countLinguine.Content = amount;
            countSpageti.Content = amount;
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

        //Capellini
        private void Capellini_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusCapellini.Visibility = Visibility.Visible;
                minusCapellini.Visibility = Visibility.Visible;
                countCapellini.Visibility = Visibility.Visible;
                addMenuCapellini.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusCapellini_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusCapellini_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuCapellini_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 10;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusCapellini.Visibility = Visibility.Hidden;
            minusCapellini.Visibility = Visibility.Hidden;
            countCapellini.Visibility = Visibility.Hidden;
            addMenuCapellini.Visibility = Visibility.Hidden;
            Make_InVisible();
        }


        //Fetuchini
        private void Fetuchini_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusFetuchini.Visibility = Visibility.Visible;
                minusFetuchini.Visibility = Visibility.Visible;
                countFetuchini.Visibility = Visibility.Visible;
                addMenuFetuchini.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusFetuchini_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusFetuchini_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuFetuchini_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 13;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusFetuchini.Visibility = Visibility.Hidden;
            minusFetuchini.Visibility = Visibility.Hidden;
            countFetuchini.Visibility = Visibility.Hidden;
            addMenuFetuchini.Visibility = Visibility.Hidden;
            Make_InVisible();
        }



        //Linguine
        private void Linguine_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusLinguine.Visibility = Visibility.Visible;
                minusLinguine.Visibility = Visibility.Visible;
                countLinguine.Visibility = Visibility.Visible;
                addMenuLinguine.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusLinguine_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusLinguine_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuLinguine_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 12;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusLinguine.Visibility = Visibility.Hidden;
            minusLinguine.Visibility = Visibility.Hidden;
            countLinguine.Visibility = Visibility.Hidden;
            addMenuLinguine.Visibility = Visibility.Hidden;
            Make_InVisible();
        }



        //Spageti
        private void Spageti_Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_smth_visible == false)
            {
                plusSpageti.Visibility = Visibility.Visible;
                minusSpageti.Visibility = Visibility.Visible;
                countSpageti.Visibility = Visibility.Visible;
                addMenuSpageti.Visibility = Visibility.Visible;
                Make_Visible();
                Change_Amount(0);
            }
        }
        private void PlusSpageti_Button_Click(object sender, RoutedEventArgs e)
        {
            amount++;
            Change_Amount(amount);
        }

        private void MinusSpageti_Button_Click(object sender, RoutedEventArgs e)
        {
            amount--;
            Change_Amount(amount);
        }

        private void AddMenuSpageti_Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 11;
            if (amount > 0)
            {
                server.CreateCartRecord(id, amount);
            }


            plusSpageti.Visibility = Visibility.Hidden;
            minusSpageti.Visibility = Visibility.Hidden;
            countSpageti.Visibility = Visibility.Hidden;
            addMenuSpageti.Visibility = Visibility.Hidden;
            Make_InVisible();
        }
    }
}
