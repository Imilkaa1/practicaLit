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
    /// Логика взаимодействия для resistr.xaml
    /// </summary>
    public partial class resistr : Window
    {
        public resistr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resistr form2 = new Vxod();
            form2.Show();
        }
    }
}
