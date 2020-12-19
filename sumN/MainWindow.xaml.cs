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

namespace sumN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {              
                    double cymma = 0;
                    int n = int.Parse(countBox1.Text);
                    double x = double.Parse(countBox2.Text);
                    for (int i = 0; i < n; i++)
                    {
                    cymma += Math.Sin(i *2 + 1 * x) / (i * 2 + 1);
                    }
                    resultBox.Text = $"Сумма {n} рядов = {cymma}";               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}