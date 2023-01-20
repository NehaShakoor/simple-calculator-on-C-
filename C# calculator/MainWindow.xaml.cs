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

namespace Simple_calculator
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

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "" || textbox2.Text == "")
            {
                MessageBox.Show("Both boxs are mandatory.");

            }
            else
            {
                int num1 = Int32.Parse(textbox1.Text);
                int num2 = Int32.Parse(textbox2.Text);
                int sum = num1 + num2;
                //MessageBox.Show(sum.ToString());
                labelx.Text = sum.ToString();
                labelx.Visibility = true;

            }


        }

        private void sum_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "" || textbox2.Text == "")
            {
                MessageBox.Show("Both boxs are mandatory.");

            }
            else
            {
                int num1 = Int32.Parse(textbox1.Text);
                int num2 = Int32.Parse(textbox2.Text);
                int sub = num1 - num2;
                //MessageBox.Show(sub.ToString());
                 labelx.Text = sub.ToString();
                labelx.Visibility = true;
            }
        }

        private void sum_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "" || textbox2.Text == "")
            {
                MessageBox.Show("Both boxs are mandatory.");

            }
            else
            {
                int num1 = Int32.Parse(textbox1.Text);
                int num2 = Int32.Parse(textbox2.Text);
                int multiply = num1 * num2;
                //MessageBox.Show(multiply.ToString());
                 labelx.Text = multiply.ToString();
                labelx.Visibility = true;
            }
        }

        private void sum_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "" || textbox2.Text == "")
            {
                MessageBox.Show("Both boxs are mandatory.");

            }
            else
            {
                int num1 = Int32.Parse(textbox1.Text);
                int num2 = Int32.Parse(textbox2.Text);
                int divide = num1 / num2;
               // MessageBox.Show(divide.ToString());
                 labelx.Text = divide.ToString();
                 label.Visibility = true;
            }
        }
    }
}