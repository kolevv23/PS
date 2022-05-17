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


namespace WPFHello1
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
        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length <= 1)
            {
                MessageBox.Show("Грешни данни, опитай отново");
            }
            else
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!\n Това е твоята първа програма! ");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("This is Windows Presentation Foundation!");
            textBlock1.Text = DateTime.Now.ToString();

        }
    }
}
