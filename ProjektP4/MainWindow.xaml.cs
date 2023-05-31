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
            Combo1.ItemsSource = new string[] { "Opole Główne", "Brzeg", "Wrocław" };
            Combo2.ItemsSource = new string[] { "Opole Główne", "Brzeg", "Wrocław" };
        }
        private int _numValue = 0;
        
        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        public void NumberUpDown()
        {
            
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();

            if (NumValue <= 0)
            {
                txtNum.Text = "0";
            }
            if (NumValue > 23)
            {
                txtNum.Text = "23";
            }
        }

        private int _numValue1 = 0;

        public int NumValue1
        {
            get { return _numValue1; }
            set
            {
                _numValue1 = value;
                txtNum1.Text = value.ToString();
            }
        }

        public void NumberUpDown1()
        {

            InitializeComponent();
            txtNum1.Text = _numValue1.ToString();
        }

        private void cmdUp_Click1(object sender, RoutedEventArgs e)
        {
            NumValue1++;
        }

        private void cmdDown_Click1(object sender, RoutedEventArgs e)
        {
            NumValue1--;
        }

        private void txtNum_TextChanged1(object sender, TextChangedEventArgs e)
        {
            if (txtNum1 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum1.Text, out _numValue1))
                txtNum1.Text = _numValue1.ToString();

            if(NumValue1 <= 0)
            {
                txtNum1.Text = "00";
            }
            if (NumValue1 > 59)
            {
                txtNum1.Text = "59";
            }
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            int skad = Combo1.SelectedIndex;
            int dokad = Combo2.SelectedIndex;
            Window1 Noweokno = new Window1(skad+1, dokad+1);
            Noweokno.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 Noweokno = new Window2();
            Noweokno.ShowDialog();
        }
    }
}
