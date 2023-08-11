using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    double rCircle = (Regex.IsMatch(rTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(rTextBox.Text.Replace(',', '.')) : 0;
                    //float rCircle = float.Parse(rTextBox.Text);
                    //consoleTextBlock.Text = rCircle.ToString("F");
                    //consoleTextBlock.Text = Convert.ToDouble(rTextBox.Text.Replace(',', '.')).ToString();
                    Circle myCircle = new Circle(rCircle);
                    vysledek = myCircle.GetResult();
                    break;
                case "rectangle":
                    double aRectangle = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(aTextBox.Text.Replace(',', '.')) : 0;
                    double bRectangle = (Regex.IsMatch(bTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(bTextBox.Text.Replace(',', '.')) : 0;
                    Rectangle myRectangle = new Rectangle(aRectangle, bRectangle);
                    vysledek = myRectangle.GetResult();
                    break;
                case "square":
                    double aSquare = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(aTextBox.Text.Replace(',', '.')) : 0; ;
                    Square mySquare = new Square(aSquare);
                    vysledek = mySquare.GetResult();
                    break;
                case "trapezoid":
                    double aTrapezoid = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(aTextBox.Text.Replace(',', '.')) : 0;
                    double cTrapezoid = (Regex.IsMatch(cTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(cTextBox.Text.Replace(',', '.')) : 0;
                    double vTrapezoid = (Regex.IsMatch(vTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(vTextBox.Text.Replace(',', '.')) : 0;
                    Trapezoid myTrapezoid = new Trapezoid(aTrapezoid, cTrapezoid, vTrapezoid);
                    vysledek = myTrapezoid.GetResult();
                    break;
                case "triangle":
                    double aTriangle = (Regex.IsMatch(aTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(aTextBox.Text.Replace(',', '.')) : 0;
                    double vTriangle = (Regex.IsMatch(vTextBox.Text, @"^-?[0-9]*\.?[0-9]*\,?[0-9]+$")) ? Convert.ToDouble(vTextBox.Text.Replace(',', '.')) : 0;
                    Triangle myTriangle = new Triangle(aTriangle, vTriangle);
                    vysledek = myTriangle.GetResult();
                    break;
                default:
                    MessageBox.Show("sorry, there's an error");
                    break;
            }
           

            // put the result into the TextBlock:
            vysledekTextBlock.Text = vysledek.ToString("F");


        }
    }
}
