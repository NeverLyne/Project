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

namespace ProjektP4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Combo1.ItemsSource = new string[] {"Brzeg", "Opole", "Wrocław" };
            Combo2.ItemsSource = new string[] { "Brzeg", "Opole", "Wrocław" };
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            Window1 Noweokno = new Window1();
            Noweokno.ShowDialog();
        }

       
    }
}
