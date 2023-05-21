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
            Database1Entities db = new Database1Entities();
            var polaczenia = from s in db.schedules 
                             join o in db.stations on s.origin_station_id equals o.id 
                             join d in db.stations on s.destination_station_id equals d.id
                             join t in db.trains on s.train_id equals t.id

                             where o.name.Equals("opole glowne")

                             select new
                             {
                                 StacjaPoczatkowa = o.name,
                                 StacjaKoncowa =  d.name,
                                 CzasOdjazdu = s.departure_time,
                                 CzasPrzyjazdu = s.arrival_time,
                                 NazwaPociagu = t.name
                             };
            foreach (var item in polaczenia)
            {
                Console.WriteLine(item.StacjaKoncowa);
                Console.WriteLine(item.StacjaPoczatkowa);
                Console.WriteLine(item.CzasOdjazdu);
                Console.WriteLine(item.CzasPrzyjazdu);
                Console.WriteLine(item.NazwaPociagu);

            }
            this.polaczenia.ItemsSource = polaczenia.ToList();
        }

        private void Wroc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
