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

namespace Practica_Gataullov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vxod registration = new Vxod();
            registration.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var mail = Login.Text;
            var login = login.Text;
            Password.Text = Passwordvx.Password.ToString();
            var password = Password.Text;
            var context = new AppDbContext();
            var LogEnter = context.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
            var MailEnter = context.Users.SingleOrDefault(x => x.Email == mail && x.Password == password);
            if (login != "Введите логин или почту" && password != "")
            {

            }
        }
    }
}
