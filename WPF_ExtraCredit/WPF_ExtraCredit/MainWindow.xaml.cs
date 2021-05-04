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

namespace WPF_ExtraCredit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbo_service.Items.Add("All");
            cbo_service.SelectedIndex = 0;
            cbo_service.Items.Add("Netflix");
            cbo_service.Items.Add("Hulu");
            cbo_service.Items.Add("Amazon Prime Video");
        }

        string website;

        private void btn_getWeb_Click(object sender, RoutedEventArgs e)
        {
            if (cbo_service.SelectedIndex == 0)
            {
                website = "https://gracefain.github.io/ExtraCredit/index.html";
            }
            else if (cbo_service.SelectedIndex == 1)
            {
                website = "https://gracefain.github.io/ExtraCredit/NetflixHTML.html";
            }
            else if (cbo_service.SelectedIndex == 2)
            {
                website = "https://gracefain.github.io/ExtraCredit/HuluHTML.html";
            }
            else
            {
                website = "https://gracefain.github.io/ExtraCredit/Amazon.html";
            }

            WB_service.Source = new Uri(website);
        }
    }
}
