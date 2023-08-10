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

namespace AreaCalculatorApp
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

        private void vybratButton_Click(object sender, RoutedEventArgs e)
        {
            // get name of the selected shape:
            ComboBoxItem ComboItem = (ComboBoxItem)shapeComboBox.SelectedItem;
            string shape = ComboItem.Name;

            //adjust the form according to the selected shape:
            if (shape == "circle")
            {
                Uri resourceUri = new Uri("/static/circle.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

            //    r

            }
            else if (shape == "rectangle")
            {
                Uri resourceUri = new Uri("/static/rectangle.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //     a, b
            }
            else if (shape == "square")
            {
                Uri resourceUri = new Uri("/static/square.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //  a
            }
            else if (shape == "trapezoid")
            {
                Uri resourceUri = new Uri("/static/trapezoid.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);


                //    a, c, v
            }
            else if (shape == "triangle")
            {
                Uri resourceUri = new Uri("/static/triangle.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);


                //   a, v
            }
            else
                MessageBox.Show("sorry, there's an error");




        }

        private void vypocitatButton_Click(object sender, RoutedEventArgs e)
        {

            //get the information from form and set other variables:
            //
            //Binding aBinding = new Binding("Text");
            //aBinding.Source = aTextBox;
            //vysledekTextBlock.SetBinding(TextBlock.TextProperty, aBinding);


            double vysledek = 5;


            //put the information into the right class method, which will return the result:


            // put the result into the TextBlock:
            vysledekTextBlock.Text = vysledek.ToString();


        }
    }
}
