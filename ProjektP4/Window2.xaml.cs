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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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

            if (NumValue1 <= 0)
            {
                txtNum1.Text = "00";
            }
            if (NumValue1 > 59)
            {
                txtNum1.Text = "59";
            }
        }

        private int _numValue2 = 0;
        public int NumValue2
        {
            get { return _numValue2; }
            set
            {
                _numValue2 = value;
                txtNum2.Text = value.ToString();
            }
        }

        public void NumberUpDown2()
        {

            InitializeComponent();
            txtNum2.Text = _numValue2.ToString();
        }

        private void cmdUp_Click2(object sender, RoutedEventArgs e)
        {
            NumValue2++;
        }

        private void cmdDown_Click2(object sender, RoutedEventArgs e)
        {
            NumValue2--;
        }

        private void txtNum_TextChanged2(object sender, TextChangedEventArgs e)
        {
            if (txtNum2 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum2.Text, out _numValue2))
                txtNum2.Text = _numValue2.ToString();

            if (NumValue2 <= 0)
            {
                txtNum2.Text = "0";
            }
            if (NumValue2 > 23)
            {
                txtNum2.Text = "23";
            }
        }

        private int _numValue3 = 0;

        public int NumValue3
        {
            get { return _numValue3; }
            set
            {
                _numValue3 = value;
                txtNum3.Text = value.ToString();
            }
        }

        public void NumberUpDown3()
        {

            InitializeComponent();
            txtNum3.Text = _numValue3.ToString();
        }

        private void cmdUp_Click3(object sender, RoutedEventArgs e)
        {
            NumValue3++;
        }

        private void cmdDown_Click3(object sender, RoutedEventArgs e)
        {
            NumValue3--;
        }

        private void txtNum_TextChanged3(object sender, TextChangedEventArgs e)
        {
            if (txtNum3 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum3.Text, out _numValue3))
                txtNum3.Text = _numValue3.ToString();

            if (NumValue3 <= 0)
            {
                txtNum3.Text = "00";
            }
            if (NumValue3 > 59)
            {
                txtNum3.Text = "59";
            }
        }
        

        private void Wroc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(Combo1.SelectedIndex == -1) && (!(Combo2.SelectedIndex == -1)))
            
                Dodaj.IsEnabled = true;
            
            else Dodaj.IsEnabled = false;
        }

        private void Combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(Combo1.SelectedIndex == -1) && (!(Combo2.SelectedIndex == -1)))
    
                Dodaj.IsEnabled = true;
            
            else Dodaj.IsEnabled = false;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Database1Entities db = new Database1Entities();

            schedule scheduleobj = new schedule()
            {
                train_id = 1,
                origin_station_id = Combo1.SelectedIndex++,
                destination_station_id = Combo2.SelectedIndex++,
               

            };

        }
    }
}
