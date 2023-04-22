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

namespace ProjektP4
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            TextBlock1.Inlines.Add(new Run("Stacja\nStacja\nStacja\nStacja\nStacja\nStacja\nStacja\nStacja"));
            TextBlock2.Inlines.Add(new Run("Stacja\nStacja\nStacja\nStacja\nStacja\nStacja\nStacja\nStacja"));
            TextBlock3.Inlines.Add(new Run("Godzina\nGodzina\nGodzina\nGodzina\nGodzina\nGodzina\nGodzina\nGodzina\n"));
            TextBlock4.Inlines.Add(new Run("Data\nData\nData\nData\nData\nData\nData\nData\nData\nData\n"));


        }

        private void Wroc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
