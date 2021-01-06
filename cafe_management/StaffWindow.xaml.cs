﻿using System;
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

namespace cafe_management
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        public StaffWindow()
        {
            InitializeComponent();
        }

        private void Spending_Click(object sender, RoutedEventArgs e)
        {
            SpendingWindow spendingWindow = new SpendingWindow();
            spendingWindow.Show();
            this.Close();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            StatisticWindow statisticWindow = new StatisticWindow();
            statisticWindow.Show();
            this.Close();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow accountWindow = new AccountWindow();
            accountWindow.Show();
            this.Close();
        }
    }
}
