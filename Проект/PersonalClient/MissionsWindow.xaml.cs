using Server_part;
using System.Timers;
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


namespace PersonalClient
{
    /// <summary>
    /// Interaction logic for MissionsWindow.xaml
    /// </summary>
    public partial class MissionsWindow : Window
    {
        private Service1 server = new Service1();
        public MissionsWindow()
        {
            InitializeComponent();
            Change_Orders();
            var timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimerElapsed;
            timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            OrdersBlock1.Dispatcher.Invoke(() =>
            {
                for (int i = 0; i < server.CountOrders(); i++)
                {
                    if (i % 2 == 0)
                    {
                        OrdersBlock1.Text = server.Show_Orders(i) + "\n\n";
                    }
                    else
                    {
                        OrdersBlock2.Text = server.Show_Orders(i) + "\n\n";
                    }
                }
            });
        }

        private void Change_Orders()
        {

            for (int i = 0; i < server.CountOrders(); i++)
            {  
                if (i % 2 == 0)
                {
                    OrdersBlock1.Text += server.Show_Orders(i) +  "\n\n";
                }
                else
                {
                    OrdersBlock2.Text += server.Show_Orders(i) + "\n\n";
                }
            }
        }


        private static int CountLines(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");
            if (str == string.Empty)
                return 0;
            int index = -1;
            int count = 0;
            while (-1 != (index = str.IndexOf(Environment.NewLine, index + 1)))
                count++;

            return count + 1;
        }

        int id;
        private void EnterOrderButtonClick(object sender, RoutedEventArgs e)
        {
            string str = textBoxPassword.Text;
            if((string.IsNullOrEmpty(str)) != true)
            {
                id = int.Parse(textBoxPassword.Text);
            }

            if ((string.IsNullOrEmpty(str)) == true)
            {
                MessageBox.Show("Спершу введіть id");
            }
            else if (server.CheckIfExists(id) == true)
            {
                server.DoCooking(id);
                Title.Text = "Замовлення";
                textBlock.Text = server.Show_Orders_By_Number(id);
                textBoxPassword.Visibility = Visibility.Hidden;
                ButtonAcceptID.Visibility = Visibility.Hidden;
                OrdersBlock1.Visibility = Visibility.Hidden;
                OrdersBlock2.Visibility = Visibility.Hidden;
                ButtonAcceptOrder.Visibility = Visibility.Visible;
                ButtonRejectOrder.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Такого замовлення немає");
            }
        }

        private void RejectOrderButtonClick(object sender, RoutedEventArgs e)
        {
            server.RejectCooking(id);
            InitializeComponent();
            Change_Orders();
            MissionsWindow menu = new MissionsWindow();
            menu.Show();
            Close();
        }

        private void AcceptOrderButtonClick(object sender, RoutedEventArgs e)
        {
            server.DeleteFromCooking(id);
            server.SetStatusDoneWindow(id, true);
            InitializeComponent();
            MissionsWindow menu = new MissionsWindow();
            menu.Show();
            Close();
        }
    }
}
