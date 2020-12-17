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
        public string dato = File.ReadAllText(@"dato.txt");
        public MainWindow()
        {
            InitializeComponent();
            
            lakrids_antal.Text = File.ReadAllText(@"is_antal\lakrids.txt");
            karamel_antal.Text = File.ReadAllText(@"is_antal\karamel.txt");
            chokolade_antal.Text = File.ReadAllText(@"is_antal\chokolade.txt");
            pistacie_antal.Text = File.ReadAllText(@"is_antal\pistacie.txt");
            jordbær_antal.Text = File.ReadAllText(@"is_antal\jordbær.txt");
            solbær_antal.Text = File.ReadAllText(@"is_antal\solbær.txt");
            hindbær_antal.Text = File.ReadAllText(@"is_antal\hindbær.txt");
            vanilje_antal.Text = File.ReadAllText(@"is_antal\vanilje.txt");

            lakrids_solgt.Text = File.ReadAllText(@"solgt\lakrids.txt");
            karamel_solgt.Text = File.ReadAllText(@"solgt\karamel.txt");
            chokolade_solgt.Text = File.ReadAllText(@"solgt\chokolade.txt");
            pistacie_solgt.Text = File.ReadAllText(@"solgt\pistacie.txt");
            jordbær_solgt.Text = File.ReadAllText(@"solgt\jordbær.txt");
            solbær_solgt.Text = File.ReadAllText(@"solgt\solbær.txt");
            hindbær_solgt.Text = File.ReadAllText(@"solgt\hindbær.txt");
            vanilje_solgt.Text = File.ReadAllText(@"solgt\vanilje.txt");

            i_alt_tjent.Text = File.ReadAllText(@"indtjening\i_alt.txt");
            tjent_dag.Text = File.ReadAllText(@"indtjening\dag.txt");

            lakrids_tjent.Text = File.ReadAllText(@"indtjening\lakrids_tjent.txt");
            karamel_tjent.Text = File.ReadAllText(@"indtjening\karamel_tjent.txt");
            chokolade_tjent.Text = File.ReadAllText(@"indtjening\chokolade_tjent.txt");
            pistacie_tjent.Text = File.ReadAllText(@"indtjening\pistacie_tjent.txt");
            jordbær_tjent.Text = File.ReadAllText(@"indtjening\jordbær_tjent.txt");
            solbær_tjent.Text = File.ReadAllText(@"indtjening\solbær_tjent.txt");
            hindbær_tjent.Text = File.ReadAllText(@"indtjening\hindbær_tjent.txt");
            vanilje_tjent.Text = File.ReadAllText(@"indtjening\vanilje_tjent.txt");
            
            DateTime now = DateTime.Now;
            if (dato != now.Date.ToString())
            {
                File.WriteAllText(@"dato.txt", now.Date.ToString());

                File.WriteAllText(@"indtjening\dag.txt", tjent_dag.Text);

                File.WriteAllText(@"indtjening\lakrids_tjent.txt", "0");
                File.WriteAllText(@"indtjening\karamel_tjent.txt", "0");
                File.WriteAllText(@"indtjening\chokolade_tjent.txt", "0");
                File.WriteAllText(@"indtjening\pistacie_tjent.txt", "0");
                File.WriteAllText(@"indtjening\jordbær_tjent.txt", "0");
                File.WriteAllText(@"indtjening\solbær_tjent.txt", "0");
                File.WriteAllText(@"indtjening\hindbær_tjent.txt", "0");
                File.WriteAllText(@"indtjening\vanilje_tjent.txt", "0");

                File.WriteAllText(@"solgt\lakrids.txt", "0");
                File.WriteAllText(@"solgt\karamel.txt", "0");
                File.WriteAllText(@"solgt\chokolade.txt", "0");
                File.WriteAllText(@"solgt\pistacie.txt", "0");
                File.WriteAllText(@"solgt\jordbær.txt", "0");
                File.WriteAllText(@"solgt\solbær.txt", "0");
                File.WriteAllText(@"solgt\hindbær.txt", "0");
                File.WriteAllText(@"solgt\vanilje.txt", "0");

                tjent_dag.Text = File.ReadAllText(@"indtjening\dag.txt");

                lakrids_tjent.Text = File.ReadAllText(@"indtjening\lakrids_tjent.txt");
                karamel_tjent.Text = File.ReadAllText(@"indtjening\karamel_tjent.txt");
                chokolade_tjent.Text = File.ReadAllText(@"indtjening\chokolade_tjent.txt");
                pistacie_tjent.Text = File.ReadAllText(@"indtjening\pistacie_tjent.txt");
                jordbær_tjent.Text = File.ReadAllText(@"indtjening\jordbær_tjent.txt");
                solbær_tjent.Text = File.ReadAllText(@"indtjening\solbær_tjent.txt");
                hindbær_tjent.Text = File.ReadAllText(@"indtjening\hindbær_tjent.txt");
                vanilje_tjent.Text = File.ReadAllText(@"indtjening\vanilje_tjent.txt");
            }
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(@"is_antal\lakrids.txt", lakrids_antal.Text);
            File.WriteAllText(@"is_antal\karamel.txt", karamel_antal.Text);
            File.WriteAllText(@"is_antal\chokolade.txt", chokolade_antal.Text);
            File.WriteAllText(@"is_antal\pistacie.txt", pistacie_antal.Text);
            File.WriteAllText(@"is_antal\jordbær.txt", jordbær_antal.Text);
            File.WriteAllText(@"is_antal\solbær.txt", solbær_antal.Text);
            File.WriteAllText(@"is_antal\hindbær.txt", hindbær_antal.Text);
            File.WriteAllText(@"is_antal\vanilje.txt", vanilje_antal.Text);
            
            File.WriteAllText(@"solgt\lakrids.txt", lakrids_solgt.Text);
            File.WriteAllText(@"solgt\karamel.txt", karamel_solgt.Text);
            File.WriteAllText(@"solgt\chokolade.txt", chokolade_solgt.Text);
            File.WriteAllText(@"solgt\pistacie.txt", pistacie_solgt.Text);
            File.WriteAllText(@"solgt\jordbær.txt", jordbær_solgt.Text);
            File.WriteAllText(@"solgt\solbær.txt", solbær_solgt.Text);
            File.WriteAllText(@"solgt\hindbær.txt", hindbær_solgt.Text);
            File.WriteAllText(@"solgt\vanilje.txt", vanilje_solgt.Text);

            File.WriteAllText(@"indtjening\i_alt.txt", i_alt_tjent.Text);
            File.WriteAllText(@"indtjening\dag.txt", tjent_dag.Text);

            File.WriteAllText(@"indtjening\lakrids_tjent.txt", lakrids_tjent.Text);
            File.WriteAllText(@"indtjening\karamel_tjent.txt", karamel_tjent.Text);
            File.WriteAllText(@"indtjening\chokolade_tjent.txt", chokolade_tjent.Text);
            File.WriteAllText(@"indtjening\pistacie_tjent.txt", pistacie_tjent.Text);
            File.WriteAllText(@"indtjening\jordbær_tjent.txt", jordbær_tjent.Text);
            File.WriteAllText(@"indtjening\solbær_tjent.txt", solbær_tjent.Text);
            File.WriteAllText(@"indtjening\hindbær_tjent.txt", hindbær_tjent.Text);
            File.WriteAllText(@"indtjening\vanilje_tjent.txt", vanilje_tjent.Text);
            
        }

        private void lakrids_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\lakrids.txt");
        }
        private void lakrids_minus_click(object sender, RoutedEventArgs e)
        {
            lakrids_tjent.Text = (short.Parse(lakrids_tjent.Text) + byte.Parse(lakrids_kost.Text)).ToString();

            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) + byte.Parse(lakrids_kost.Text)).ToString();
            
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(lakrids_kost.Text)).ToString();
            
            lakrids_antal.Text = (byte.Parse(lakrids_antal.Text)-1).ToString();

            lakrids_solgt.Text = (byte.Parse(lakrids_solgt.Text)+1).ToString();

        }
        private void lakrids_plus_click(object sender, RoutedEventArgs e)
        {
            lakrids_tjent.Text = (short.Parse(lakrids_tjent.Text) - byte.Parse(lakrids_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) - byte.Parse(lakrids_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(lakrids_afgift.Text)).ToString();
            
            lakrids_antal.Text = (byte.Parse(lakrids_antal.Text)+1).ToString();
        }
        
        private void karamel_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\karamel.txt");
        }
        private void karamel_minus_click(object sender, RoutedEventArgs e)
        {
            karamel_tjent.Text = (short.Parse(karamel_tjent.Text) + byte.Parse(karamel_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) + byte.Parse(karamel_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(karamel_kost.Text)).ToString();
            
            karamel_antal.Text = (byte.Parse(karamel_antal.Text)-1).ToString();
            karamel_solgt.Text = (byte.Parse(karamel_solgt.Text)+1).ToString();

        }
        private void karamel_plus_click(object sender, RoutedEventArgs e)
        {
            karamel_tjent.Text = (short.Parse(karamel_tjent.Text) - byte.Parse(karamel_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) - byte.Parse(karamel_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(karamel_afgift.Text)).ToString();
            karamel_antal.Text = (byte.Parse(karamel_antal.Text)+1).ToString();
        }
        
        private void chokolade_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\chokolade.txt");
        }
        private void chokolade_minus_click(object sender, RoutedEventArgs e)
        {
            chokolade_tjent.Text = (short.Parse(chokolade_tjent.Text) + byte.Parse(chokolade_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) + byte.Parse(chokolade_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(chokolade_kost.Text)).ToString();
            chokolade_antal.Text = (byte.Parse(chokolade_antal.Text)-1).ToString();
            chokolade_solgt.Text = (byte.Parse(chokolade_solgt.Text)+1).ToString();

        }
        private void chokolade_plus_click(object sender, RoutedEventArgs e)
        {
            chokolade_tjent.Text = (short.Parse(chokolade_tjent.Text) - byte.Parse(chokolade_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) - byte.Parse(chokolade_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(chokolade_afgift.Text)).ToString();
            chokolade_antal.Text = (byte.Parse(chokolade_antal.Text)+1).ToString();
        }

        private void pistacie_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\pistacie.txt");
        }
        private void pistacie_minus_click(object sender, RoutedEventArgs e)
        {
            pistacie_tjent.Text = (short.Parse(pistacie_tjent.Text) + byte.Parse(pistacie_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) + byte.Parse(pistacie_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(pistacie_kost.Text)).ToString();
            pistacie_antal.Text = (byte.Parse(pistacie_antal.Text)-1).ToString();
            pistacie_solgt.Text = (byte.Parse(pistacie_solgt.Text)+1).ToString();

        }
        private void pistacie_plus_click(object sender, RoutedEventArgs e)
        {
            pistacie_tjent.Text = (short.Parse(pistacie_tjent.Text) - byte.Parse(pistacie_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) - byte.Parse(pistacie_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(pistacie_afgift.Text)).ToString();
            pistacie_antal.Text = (byte.Parse(pistacie_antal.Text)+1).ToString();
        }

        private void jordbær_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\jordbær.txt");
        }
        private void jordbær_minus_click(object sender, RoutedEventArgs e)
        {
            jordbær_tjent.Text = (short.Parse(jordbær_tjent.Text) + byte.Parse(jordbær_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) + byte.Parse(jordbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(jordbær_kost.Text)).ToString();
            jordbær_antal.Text = (byte.Parse(jordbær_antal.Text)-1).ToString();
            jordbær_solgt.Text = (byte.Parse(jordbær_solgt.Text)+1).ToString();

        }
        private void jordbær_plus_click(object sender, RoutedEventArgs e)
        {
            jordbær_tjent.Text = (short.Parse(jordbær_tjent.Text) - byte.Parse(jordbær_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) - byte.Parse(jordbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(jordbær_afgift.Text)).ToString();
            jordbær_antal.Text = (byte.Parse(jordbær_antal.Text)+1).ToString();
        }

        private void solbær_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\solbær.txt");
        }
        private void solbær_minus_click(object sender, RoutedEventArgs e)
        {
            solbær_tjent.Text = (short.Parse(solbær_tjent.Text) + byte.Parse(solbær_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) + byte.Parse(solbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(solbær_kost.Text)).ToString();
            solbær_antal.Text = (byte.Parse(solbær_antal.Text)-1).ToString();
            solbær_solgt.Text = (byte.Parse(solbær_solgt.Text)+1).ToString();

        }
        private void solbær_plus_click(object sender, RoutedEventArgs e)
        {
            solbær_tjent.Text = (short.Parse(solbær_tjent.Text) - byte.Parse(solbær_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(lakrids_tjent.Text) - byte.Parse(solbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(solbær_afgift.Text)).ToString();
            solbær_antal.Text = (byte.Parse(solbær_antal.Text)+1).ToString();
        }

        private void hindbær_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\hindbær.txt");
        }
        private void hindbær_minus_click(object sender, RoutedEventArgs e)
        {
            hindbær_tjent.Text = (short.Parse(hindbær_tjent.Text) + byte.Parse(hindbær_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) + byte.Parse(hindbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(hindbær_kost.Text)).ToString();
            hindbær_antal.Text = (byte.Parse(hindbær_antal.Text)-1).ToString();
            hindbær_solgt.Text = (byte.Parse(hindbær_solgt.Text)+1).ToString();

        }
        private void hindbær_plus_click(object sender, RoutedEventArgs e)
        {
            hindbær_tjent.Text = (short.Parse(hindbær_tjent.Text) - byte.Parse(hindbær_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) - byte.Parse(hindbær_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(hindbær_afgift.Text)).ToString();
            hindbær_antal.Text = (byte.Parse(hindbær_antal.Text)+1).ToString();
        }

        private void vanilje_info_click(object sender, RoutedEventArgs e)
        {
            info.Text = File.ReadAllText(@"is_info\vanilje.txt");
        }
        private void vanilje_minus_click(object sender, RoutedEventArgs e)
        {
            vanilje_tjent.Text = (short.Parse(vanilje_tjent.Text) + byte.Parse(vanilje_kost.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) + byte.Parse(vanilje_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) + byte.Parse(vanilje_kost.Text)).ToString();
            vanilje_antal.Text = (byte.Parse(vanilje_antal.Text)-1).ToString();
            vanilje_solgt.Text = (byte.Parse(vanilje_solgt.Text)+1).ToString();

        }
        private void vanilje_plus_click(object sender, RoutedEventArgs e)
        {
            vanilje_tjent.Text = (short.Parse(vanilje_tjent.Text) - byte.Parse(vanilje_afgift.Text)).ToString();
            tjent_dag.Text = (Int32.Parse(tjent_dag.Text) - byte.Parse(vanilje_kost.Text)).ToString();
            i_alt_tjent.Text = (long.Parse(i_alt_tjent.Text) - byte.Parse(vanilje_afgift.Text)).ToString();
            vanilje_antal.Text = (byte.Parse(vanilje_antal.Text)+1).ToString();
        }
    }
}
