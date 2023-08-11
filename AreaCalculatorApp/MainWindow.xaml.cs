using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// <summary>s
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
                aStackPanel.Visibility = Visibility.Collapsed;
                bStackPanel.Visibility = Visibility.Collapsed;
                cStackPanel.Visibility = Visibility.Collapsed;
                rStackPanel.Visibility = Visibility.Visible;
                vStackPanel.Visibility = Visibility.Collapsed;


            }
            else if (shape == "rectangle")
            {
                Uri resourceUri = new Uri("/static/rectangle.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //     a, b
                aStackPanel.Visibility = Visibility.Visible;
                bStackPanel.Visibility = Visibility.Visible;
                cStackPanel.Visibility = Visibility.Collapsed;
                rStackPanel.Visibility = Visibility.Collapsed;
                vStackPanel.Visibility = Visibility.Collapsed;
            }
            else if (shape == "square")
            {
                Uri resourceUri = new Uri("/static/square.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //  a
                aStackPanel.Visibility = Visibility.Visible;
                bStackPanel.Visibility = Visibility.Collapsed;
                cStackPanel.Visibility = Visibility.Collapsed;
                rStackPanel.Visibility = Visibility.Collapsed;
                vStackPanel.Visibility = Visibility.Collapsed;
            }
            else if (shape == "trapezoid")
            {
                Uri resourceUri = new Uri("/static/trapezoid.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //    a, c, v
                aStackPanel.Visibility = Visibility.Visible;
                bStackPanel.Visibility = Visibility.Collapsed;
                cStackPanel.Visibility = Visibility.Visible;
                rStackPanel.Visibility = Visibility.Collapsed;
                vStackPanel.Visibility = Visibility.Visible;
            }
            else if (shape == "triangle")
            {
                Uri resourceUri = new Uri("/static/triangle.png", UriKind.Relative);
                imageOfShape.Source = new BitmapImage(resourceUri);

                //   a, v
                aStackPanel.Visibility = Visibility.Visible;
                bStackPanel.Visibility = Visibility.Collapsed;
                cStackPanel.Visibility = Visibility.Collapsed;
                rStackPanel.Visibility = Visibility.Collapsed;
                vStackPanel.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("sorry, there's an error");

            vysledekTextBlock.Text = "0";
            aTextBox.Text = "";
            bTextBox.Text = "";
            cTextBox.Text = "";
            vTextBox.Text = "";
            rTextBox.Text = "";   
        }

        private void vypocitatButton_Click(object sender, RoutedEventArgs e)
        {

            // get name of the selected shape:
            ComboBoxItem ComboItem = (ComboBoxItem)shapeComboBox.SelectedItem;
            string shape = ComboItem.Name;

            //setting type of 'result'
            double vysledek = 0;

            switch (shape)
            {
                case "circle":
                    double rCircle = (Regex.IsMatch(rTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? double.Parse(rTextBox.Text.Replace(',', '.')) : 0;
                    //float rCircle = float.Parse(rTextBox.Text);
                    Circle myCircle = new Circle(rCircle);
                    vysledek = myCircle.GetResult();
                    break;
                case "rectangle":
                    float aRectangle = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(aTextBox.Text) : 0;
                    float bRectangle = (Regex.IsMatch(bTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(bTextBox.Text) : 0;
                    Rectangle myRectangle = new Rectangle(aRectangle, bRectangle);
                    vysledek = myRectangle.GetResult();
                    break;
                case "square":
                    float aSquare = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(aTextBox.Text) : 0;
                    Square mySquare = new Square(aSquare);
                    vysledek = mySquare.GetResult();
                    break;
                case "trapezoid":
                    float aTrapezoid = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(aTextBox.Text) : 0;
                    float cTrapezoid = (Regex.IsMatch(cTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(cTextBox.Text) : 0;
                    float vTrapezoid = (Regex.IsMatch(vTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(vTextBox.Text) : 0;
                    Trapezoid myTrapezoid = new Trapezoid(aTrapezoid, cTrapezoid, vTrapezoid);
                    vysledek = myTrapezoid.GetResult();
                    break;
                case "triangle":
                    float aTriangle = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(aTextBox.Text) : 0;
                    float vTriangle = (Regex.IsMatch(vTextBox.Text, @"^-?[0-9]*\.?[0-9]+$")) ? float.Parse(vTextBox.Text) : 0;
                    Triangle myTriangle = new Triangle(aTriangle, vTriangle);
                    vysledek = myTriangle.GetResult();
                    break;
                default:
                    MessageBox.Show("sorry, there's an error");
                    break;
            }
           

            // put the result into the TextBlock:
            vysledekTextBlock.Text = vysledek.ToString("");


        }
    }
}
