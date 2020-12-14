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
using System.IO;

namespace Is_på_lager
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
        
        private void load_click(object sender, RoutedEventArgs e)
        {
            lakrids_antal.Text = File.ReadAllText(@"is\lakrids.txt");
            karamel_antal.Text = File.ReadAllText(@"is\karamel.txt");
            chokolade_antal.Text = File.ReadAllText(@"is\chokolade.txt");
            pistacie_antal.Text = File.ReadAllText(@"is\pistacie.txt");
            jordbær_antal.Text = File.ReadAllText(@"is\jordbær.txt");
            solbær_antal.Text = File.ReadAllText(@"is\solbær.txt");
            hindbær_antal.Text = File.ReadAllText(@"is\hindbær.txt");
            vanilje_antal.Text = File.ReadAllText(@"is\vanilje.txt");
        }
        private void save_click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(@"is\lakrids.txt", lakrids_antal.Text);
            File.WriteAllText(@"is\karamel.txt", karamel_antal.Text);
            File.WriteAllText(@"is\chokolade.txt", chokolade_antal.Text);
            File.WriteAllText(@"is\pistacie.txt", pistacie_antal.Text);
            File.WriteAllText(@"is\jordbær.txt", jordbær_antal.Text);
            File.WriteAllText(@"is\solbær.txt", solbær_antal.Text);
            File.WriteAllText(@"is\hindbær.txt", hindbær_antal.Text);
            File.WriteAllText(@"is\vanilje.txt", vanilje_antal.Text);
        }
        private void lakrids_minus_click(object sender, RoutedEventArgs e)
        {
            byte lakrids = byte.Parse(lakrids_antal.Text);
            lakrids--;
            lakrids_antal.Text = lakrids.ToString();

        }
        private void lakrids_plus_click(object sender, RoutedEventArgs e)
        {
            byte lakrids = byte.Parse(lakrids_antal.Text);
            lakrids++;
            lakrids_antal.Text = lakrids.ToString();
        }
        
        private void karamel_minus_click(object sender, RoutedEventArgs e)
        {
            byte karamel = byte.Parse(karamel_antal.Text);
            karamel--;
            karamel_antal.Text = karamel.ToString();

        }
        private void karamel_plus_click(object sender, RoutedEventArgs e)
        {
            byte karamel = byte.Parse(karamel_antal.Text);
            karamel++;
            karamel_antal.Text = karamel.ToString();
        }
        
        private void chokolade_minus_click(object sender, RoutedEventArgs e)
        {
            byte chokolade = byte.Parse(chokolade_antal.Text);
            chokolade--;
            chokolade_antal.Text = chokolade.ToString();

        }
        private void chokolade_plus_click(object sender, RoutedEventArgs e)
        {
            byte chokolade = byte.Parse(chokolade_antal.Text);
            chokolade++;
            chokolade_antal.Text = chokolade.ToString();
        }

        private void pistacie_minus_click(object sender, RoutedEventArgs e)
        {
            byte pistacie = byte.Parse(pistacie_antal.Text);
            pistacie--;
            pistacie_antal.Text = pistacie.ToString();

        }
        private void pistacie_plus_click(object sender, RoutedEventArgs e)
        {
            byte pistacie = byte.Parse(pistacie_antal.Text);
            pistacie++;
            pistacie_antal.Text = pistacie.ToString();
        }

        private void jordbær_minus_click(object sender, RoutedEventArgs e)
        {
            byte jordbær = byte.Parse(jordbær_antal.Text);
            jordbær--;
            jordbær_antal.Text = jordbær.ToString();

        }
        private void jordbær_plus_click(object sender, RoutedEventArgs e)
        {
            byte jordbær = byte.Parse(jordbær_antal.Text);
            jordbær++;
            jordbær_antal.Text = jordbær.ToString();
        }

        private void solbær_minus_click(object sender, RoutedEventArgs e)
        {
            byte solbær = byte.Parse(solbær_antal.Text);
            solbær--;
            solbær_antal.Text = solbær.ToString();

        }
        private void solbær_plus_click(object sender, RoutedEventArgs e)
        {
            byte solbær = byte.Parse(solbær_antal.Text);
            solbær++;
            solbær_antal.Text = solbær.ToString();
        }

        private void hindbær_minus_click(object sender, RoutedEventArgs e)
        {
            byte hindbær = byte.Parse(hindbær_antal.Text);
            hindbær--;
            hindbær_antal.Text = hindbær.ToString();

        }
        private void hindbær_plus_click(object sender, RoutedEventArgs e)
        {
            byte hindbær = byte.Parse(hindbær_antal.Text);
            hindbær++;
            hindbær_antal.Text = hindbær.ToString();
        }

        private void vanilje_minus_click(object sender, RoutedEventArgs e)
        {
            byte vanilje = byte.Parse(vanilje_antal.Text);
            vanilje--;
            vanilje_antal.Text = vanilje.ToString();

        }
        private void vanilje_plus_click(object sender, RoutedEventArgs e)
        {
            byte vanilje = byte.Parse(vanilje_antal.Text);
            vanilje++;
            vanilje_antal.Text = vanilje.ToString();
        }
    }
}
