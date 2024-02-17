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

namespace Practica_Gataullov
{
    /// <summary>
    /// Логика взаимодействия для Lichnizkab.xaml
    /// </summary>
    public partial class Lichnizkab : Window
    {
        public Lichnizkab()
        {
            InitializeComponent();
        }

        private void vixod_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Lichnizkab Vixod = new Lichnizkab();
            Vixod.Show();
        }
    }
}
