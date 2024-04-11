// Rafael Rivera Harrison
// 4.9.2024
// Programming 122
// Assignment 1 - Basic Calculator
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_1_Calculator_for_programing_2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Even tho this private void is black i have noticed if i attempt to remove it the program stops working.
       
        private void addNumberButton_Click_1(object sender, RoutedEventArgs e)
        {
            //create your variable for addition and parse them using the x name of the textboxes

            int a = int.Parse(TextBox_1.Text);

            int b = int.Parse(TextBox_2.Text);

            //make a new variable to add them together

            int sum = a + b;

            //in order to get the message box to display a formatted string i simply treated it like a console.Write line and performed string concatanation to display everything together.

            MessageBox.Show($"{a.ToString()} + {b.ToString()} = {sum.ToString()}");
        }

        private void subtractNumberButton_Click_2(object sender, RoutedEventArgs e)
        {
            //create your variable for subtraction and parse them using the x name of the textboxes

            int a = int.Parse(TextBox_1.Text);

            int b = int.Parse(TextBox_2.Text);

            //make a new variable to subtract them

            int sum = a - b;

            //in order to get the message box to display a formatted string i simply treated it like a console.Write line and performed string concatanation to display everything together.

            MessageBox.Show($"{a.ToString()} - {b.ToString()} = {sum.ToString()}");
        }

        private void multiplyNumberButton_Click_3(object sender, RoutedEventArgs e)
        {
            //create your variable for multiplication and parse them using the x name of the textboxes

            int a = int.Parse(TextBox_1.Text);

            int b = int.Parse(TextBox_2.Text);

            //make a new variable to multiply them together

            int sum = a * b;

            //in order to get the message box to display a formatted string i simply treated it like a console.Write line and performed string concatanation to display everything together.

            MessageBox.Show($"{a.ToString()} * {b.ToString()} = {sum.ToString()}");
        }

        private void divideNumberButton_Click_4(object sender, RoutedEventArgs e)
        {

            try
            {

                //create your variable for division and parse them using the x name of the textboxes

                //the data type cannot be int else it will perform integer division,use double instead

                int a = int.Parse(TextBox_1.Text);

                int b = int.Parse(TextBox_2.Text);

                //make a new variable to divide them together

                int sum = a / b;

                
                
                
                
                
             MessageBox.Show($"{a.ToString()} / {b.ToString()} = {sum.ToString()}");
                

          
            }
            catch(DivideByZeroException) 
            { 
                MessageBox.Show("Division by 0 is not possible");
            } 
           
            //in order to get the message box to display a formatted string i simply treated it like a console.Write line and performed string concatanation to display everything together.

        }
    }
}