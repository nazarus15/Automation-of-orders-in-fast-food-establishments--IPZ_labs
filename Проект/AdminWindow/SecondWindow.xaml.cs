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

namespace AdminWindow
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private Service1 server = new Service1();
        public SecondWindow()
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
            textBlock.Dispatcher.Invoke(() =>
            {
                textBlock.Text = server.Show_Done_Orders();
            });
        }

        private void Change_Orders()
        {

            textBlock.Text += server.Show_Done_Orders();

        }
        private void EnterOrderButtonClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(textBoxPassword.Text);
            server.Delete_Done_Order(id);
            InitializeComponent();
            SecondWindow menu = new SecondWindow();
            menu.Show();
            Close();
        }
    }
}
