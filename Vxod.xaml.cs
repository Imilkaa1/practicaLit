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

namespace Practica_Gataullov
{
    /// <summary>
    /// Логика взаимодействия для Vxod.xaml
    /// </summary>
    public partial class Vxod : Window
    {
        public Vxod()
        {
            InitializeComponent();
        }

        private void Regvx_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow registration = new MainWindow();
            registration.Show();

        }

        private void Vx_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
