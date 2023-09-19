using System;
using System.Collections.Generic;
using System.IO;
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

namespace Dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Fuvar> fuvarok = new List<Fuvar>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ReadData()
        {
            fuvarok.Clear();
            List<string> list = File.ReadAllLines("fuvar.csv").Skip(1).ToList();
            foreach(string item in list)
            {
                string[] data = item.Split(";");
                fuvarok.Add(new Fuvar(data[0], data[1], data[2], data[3], data[4], data[5], data[6]));
            }
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ReadData();
            MessageBox.Show(Convert.ToString(fuvarok.Count()));
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ReadData();
            int income = 0;
            foreach(Fuvar item in fuvarok)
            {
                if (item.TaxiId == "6185")
                {
                    income += Convert.ToInt32(item.Price) + Convert.ToInt32(item.Tip);
                }
            }
            MessageBox.Show(Convert.ToString(income));
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {

        }
    }
}
