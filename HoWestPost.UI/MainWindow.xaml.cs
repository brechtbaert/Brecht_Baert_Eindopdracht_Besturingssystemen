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
using HoWestPost.Domain;

namespace HoWestPost.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Delivery delivery = new Delivery();
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        void UpdateGui() 
        {
            lstInProcess.ItemsSource = delivery.Packages;
            lstInProcess.Items.Refresh();

        }

        void ShowDetails(Package package) 
        {
            txtTotaleReistijd.Text = package.reistijd.ToString();

            if (package.type == 0) {
                BitmapImage image = new BitmapImage(new Uri("/Images/Mini.jpg", UriKind.RelativeOrAbsolute));
                imgPakket.Source = image;

                txtType.Text = "Mini";


            } else if (package.type == 1) {
                BitmapImage image = new BitmapImage(new Uri("/Images/Standaard.jpg", UriKind.RelativeOrAbsolute));
                imgPakket.Source = image;

                txtType.Text = "Standaard";

            } else if (package.type == 2){
                BitmapImage image = new BitmapImage(new Uri("/Images/Maxi.jpg", UriKind.RelativeOrAbsolute));
                imgPakket.Source = image;

                txtType.Text = "Maxi";
            }

            if (package.prior == 0)
            {
                txtPrior.Text = "Neen";

            }
            else if (package.prior == 1)
            {
                txtPrior.Text = "Ja";
            }

        }

        private void lstInProcess_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int itemId = lstInProcess.SelectedIndex;
            Package package = delivery.Packages[itemId];

            ShowDetails(package);
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtReistijd.Text)) 
            {
                string warning = "Gelieve een reistijd in te vullen !";
                lblWarning.Content = warning;
            }
            else {
                int reistijd = Convert.ToInt32(txtReistijd.Text);
                int packageType = 0;
                int prior = 0;

                if (chkPrior.IsChecked == true)
                {
                    prior = 1;
                }
                else if (chkPrior.IsChecked == false)
                {
                    prior = 0;
                }

                delivery.AddPackage(packageType, reistijd, prior);
                UpdateGui();
            }

        }
       

        private void btnStandaard_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtReistijd.Text))
            {
                string warning = "Gelieve een reistijd in te vullen !";
                lblWarning.Content = warning;
            }
            else {
                int reistijd = Convert.ToInt32(txtReistijd.Text);
                int packageType = 1;
                int prior = 0;

                if (chkPrior.IsChecked == true)
                {
                    prior = 1;
                }
                else if (chkPrior.IsChecked == false)
                {
                    prior = 0;
                }
                delivery.AddPackage(packageType, reistijd, prior);
                UpdateGui();
            }
        
        }

        private void btnMaxi_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtReistijd.Text))
            {
                string warning = "Gelieve een reistijd in te vullen !";
                lblWarning.Content = warning;
            }
            else {
                int reistijd = Convert.ToInt32(txtReistijd.Text);
                int packageType = 2;
                int prior = 0;

                if (chkPrior.IsChecked == true)
                {
                    prior = 1;
                }
                else if (chkPrior.IsChecked == false)
                {
                    prior = 0;
                }

                delivery.AddPackage(packageType, reistijd, prior);
                UpdateGui();
            }
            
        }
    }
}
