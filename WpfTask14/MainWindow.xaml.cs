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

namespace WpfTask14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new List<Product>();

            products.Add(new Product()
            {
                ProductName = "Salat",
                Price = 150,
                ImageName = "Data/salat.jpg",
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                ProductName = "Steak",
                Price = 300,
                ImageName = "Data/steak.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Refrigeratore",
                Price = 50000,
                ImageName = "Data/refrigerator.jpg",
                ProductType = ProductTypes.Devices
            });
            products.Add(new Product()
            {
                ProductName = "Microwave",
                Price = 4000,
                ImageName = "Data/microwave.jpg",
                ProductType = ProductTypes.Devices
            });
            lstBox.ItemsSource = products;
        }
    }
}
