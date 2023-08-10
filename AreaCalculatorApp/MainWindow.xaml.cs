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
    /// <summary>s
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //enum typeOfShape
    //{
    //    circle, rectangle, square, trapezoid, triangle
    //}
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

            //get the information from form and set other variables using switch - case
            //save numbers from user inputs using binding ? or just .Text
            //put the information into the right class method, which will return the result

            // get name of the selected shape:
            ComboBoxItem ComboItem = (ComboBoxItem)shapeComboBox.SelectedItem;
            string shape = ComboItem.Name;

            //setting type of 'result'
            double vysledek = 0;

            switch (shape)
            {
                case "circle":
                    //Binding rCircle = new Binding("Text");
                    //rCircle.Source = rTextBox;
                    double rCircle = int.Parse(rTextBox.Text);
                    Circle myCircle = new Circle(rCircle);
                    vysledek = myCircle.GetResult();
                    //
                    break;
                case "rectangle":
                    //Binding aRectangle = new Binding("Text");
                    //aRectangle.Source = aTextBox;
                    //Binding bRectangle = new Binding("Text");
                    //bRectangle.Source = bTextBox;
                    double aRectangle = int.Parse(aTextBox.Text);
                    double bRectangle = int.Parse(bTextBox.Text);
                    Rectangle myRectangle = new Rectangle(aRectangle, bRectangle);
                    vysledek = myRectangle.GetResult();

                    break;
                case "square":
                    //Binding aSquare = new Binding("Text");
                    //aSquare.Source = aTextBox;

                    double aSquare = int.Parse(aTextBox.Text);
                    Square mySquare = new Square(aSquare);
                    vysledek = mySquare.GetResult();

                    break;
                case "trapezoid":
                    //Binding aTrapezoid = new Binding("Text");
                    //aTrapezoid.Source = aTextBox;
                    //Binding cTrapezoid = new Binding("Text");
                    //cTrapezoid.Source = cTextBox;
                    //Binding vTrapezoid = new Binding("Text");
                    //vTrapezoid.Source = vTextBox;
                    double aTrapezoid = int.Parse(aTextBox.Text);
                    double cTrapezoid = int.Parse(cTextBox.Text);
                    double vTrapezoid = int.Parse(vTextBox.Text);
                    Trapezoid myTrapezoid = new Trapezoid(aTrapezoid, cTrapezoid, vTrapezoid);
                    vysledek = myTrapezoid.GetResult();


                    break;
                case "triangle":
                    //Binding aTriangle = new Binding("Text");
                    //aTriangle.Source = aTextBox;
                    //Binding vTriangle = new Binding("Text");
                    //vTriangle.Source = vTextBox;
                    double aTriangle = int.Parse(aTextBox.Text);
                    double vTriangle = int.Parse(vTextBox.Text);
                    Rectangle myTriangle = new Rectangle(aTriangle, vTriangle);
                    vysledek = myTriangle.GetResult();


                    break;
                default:
                    MessageBox.Show("sorry, there's an error");
                    break;
            }
           

            // put the result into the TextBlock:
            vysledekTextBlock.Text = vysledek.ToString();


        }
    }
}
