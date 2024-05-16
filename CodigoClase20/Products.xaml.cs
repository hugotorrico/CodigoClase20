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

namespace CodigoClase20
{
    /// <summary>
    /// Lógica de interacción para Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        public Products()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            var products = new List<Product>
            {
                new Product { Name = "Café Solo", Description = "Es un café de forma...", Price=50, imagePath="https://www.google.com/imgres?q=cafee&imgurl=https%3A%2F%2Fpbs.twimg.com%2Fprofile_images%2F1335415412893360135%2F1fnEe-wL_400x400.jpg&imgrefurl=https%3A%2F%2Ftwitter.com%2FCafeeChc&docid=rqDrDVY0pOG2eM&tbnid=hXRQo3LcQqHkqM&vet=12ahUKEwj4_92C6pCGAxXoFVkFHeOhDnoQM3oECBkQAA..i&w=399&h=399&hcb=2&ved=2ahUKEwj4_92C6pCGAxXoFVkFHeOhDnoQM3oECBkQAA"},
                new Product { Name = "Café con Leche", Description = "Es una combinación....",Price=20 },
                new Product { Name = "Manzanilla", Description = "Es relajante Natural...",Price=70 },
                new Product { Name = "Té Helado", Description = "Para el calor que está haci....",Price=100 }
            };

            productListView.ItemsSource = products;
        }

    }
}
