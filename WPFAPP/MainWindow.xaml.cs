using LibreriaStringheTeam1;
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


namespace WPFAPP
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_visualizza_Click(object sender, RoutedEventArgs e)
        {
            if (scelta.SelectedIndex == 0)
            {
                int a = MetodiStringhe.LunghezzaStringa();
                risultato.Content = $"La lunghezza delle stringhe è {a}";
            }
            if (scelta.SelectedIndex == 1)
            {
                int a = MetodiStringhe.ConfrontoStringhe();
                risultato.Content = $"L'indice del carattere che varia è {a}";
            }
            if (scelta.SelectedIndex == 2)
            {
                using (StreamWriter sw=new StreamWriter("DNAidentico.txt", false, Encoding.UTF8))
                {
                    sw.Write(MetodiStringhe.DNAidentico());
                }
                string a = MetodiStringhe.DNAidentico();
                risultato.Content = $"La prima porzione di DNA identico è stata stampata su un file \r\n di testo chiamato DNAidentico.txt";
            }
            if (scelta.SelectedIndex == 3)
            {
                int a = MetodiStringhe.CaratteriDifferenti();
                risultato.Content = $"Il numero di caratteri che variano tra le due stringhe è {a}";
            }
            if (scelta.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un'operazione da svolgere", "Attenzione", MessageBoxButton.OK);
            }
        }
    }
}
