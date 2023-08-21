﻿using Server_part;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1 server = new Service1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            SecondWindow menu = new SecondWindow();
            string email = textBoxLoign.Text;
            string password = textBoxPassword.Text;
            string pos = "admin";
            if (server.Authorization(email, password, pos) == 0)
            {
                menu.Show();
                this.Close();
            }
            if (server.Authorization(email, password, pos) == 1)
            {
                ErrorBlock.Text = "Такого email не існує";
            }
            if (server.Authorization(email, password, pos) >= 2 && server.Authorization(email, password, pos) < 4)
            {
                ErrorBlock.Text = "Пароль невірний";
            }
            if (server.Authorization(email, password, pos) >= 5)
            {
                ErrorBlock.Text = "Ви не адмін";
            }
        }
    }
}
