using Server_part;
using System.Threading;
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
    /// Interaction logic for DoneWindow.xaml
    /// </summary>
    public partial class DoneWindow : Window
    {
        Service1 server = new Service1();
        public DoneWindow()
        {
            InitializeComponent();
            //DateTime now = DateTime.Now;
            //while (DateTime.Now.Subtract(now).Seconds < 5)
            //{
            //    // wait for 60 seconds
            //}
            End();
        }

        void End()
        {
            server.Exit();
            StartWindow main_menu = new StartWindow();
            this.Close();
            main_menu.Show();
        }
    }
}
