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

namespace EsercizioNataleList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string fileinvalido = @"fileinvalido.txt";
        private const string filevalido = @"filevalido.txt";

        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> nomi = new List<string>();
        List<int> voti = new List<int>();

        private void VediLista_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader rfile = new StreamReader(fileinvalido))
            {
                string sline; 
                while ((sline = rfile.ReadLine()) != null)
                {
                    int found = 0;
                    Console.WriteLine(sline);
                    {
                        found = sline.IndexOf(",");
                        nomi.Add(sline.Substring(0, found));
                        voti.Add(int.Parse(sline.Substring(found)));
                    }
                }
            }
        }
    }
}
