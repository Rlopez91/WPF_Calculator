using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace MidTermRicardoLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    internal static class WindowExtensions
    {
        // from winuser.h
        private const int GWL_STYLE = -16,
                          WS_MAXIMIZEBOX = 0x10000,
                          WS_MINIMIZEBOX = 0x20000;

        [DllImport("user32.dll")]
        extern private static int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        extern private static int SetWindowLong(IntPtr hwnd, int index, int value);

        internal static void HideMinimizeAndMaximizeButtons(this Window window)
        {
            IntPtr hwnd = new System.Windows.Interop.WindowInteropHelper(window).Handle;
            var currentStyle = GetWindowLong(hwnd, GWL_STYLE);

            SetWindowLong(hwnd, GWL_STYLE, (currentStyle & ~WS_MAXIMIZEBOX & ~WS_MINIMIZEBOX));
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //to set a default icon
            Uri iconUri = new Uri("../../../calculator.ico", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);

            //remove the min and max buttons
            this.SourceInitialized += (x, y) =>
            {
                this.HideMinimizeAndMaximizeButtons();
            };


        }



        //variables to hold the numbers
        double num1=0, num2=0, total = 0;
        string oper = "";

        //number buttons 
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
            num1 = double.Parse(display.Text);
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "1";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "2";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "3";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "4";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "5";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "6";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "7";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "8";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + "9";
            if (num1 == 0)
            {
                num1 = double.Parse(display.Text);
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
        }

        //operation buttons

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(display.Text);
            if (num1 != 0)
            {
                num1 = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
            
            oper = "*";
            //display.Text += "*";
        }

        private void substract_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(display.Text);
            if (num1 != 0)
            {
                num1 = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
            //display.Text += "+";
            oper = "-";
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(display.Text);
            if (num1 != 0)
            {                
                num1 = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
            //display.Text += "+";
            oper = "+";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(display.Text);
            if (num1 != 0)
            {
                num1 = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
            oper = "/";
            //display.Text += "/";
        }

        //symbol functions
        private void sign_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(display.Text) > 0)
            {
                display.Text = (double.Parse(display.Text) * (-1)).ToString();
            }

            else if(double.Parse(display.Text) < 0)
            {
                display.Text = (double.Parse(display.Text) * (-1)).ToString();
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void scientific_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Scientific selected");
        }

        private void Standard_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Standard selected");
            scientific.IsChecked = false;
            Standard.IsChecked = true;
        }

        private void dmode_Click(object sender, RoutedEventArgs e)
        {
            if(dmode.IsChecked == true)
            {
                rickwindow.Background = Brushes.Black;
                Standard.Foreground = Brushes.White;
                scientific.Foreground = Brushes.White;
                dmode.Foreground = Brushes.White;
            }
            else
            {
                rickwindow.Background = Brushes.White;
                Standard.Foreground = Brushes.Black;
                scientific.Foreground = Brushes.Black;
                dmode.Foreground = Brushes.Black;
            }
            
        }

        private void divideTen_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(display.Text);
            if (num1 != 0)
            {
                num1 = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                num2 = double.Parse(display.Text);
            }
            //display.Text += "+";
            oper = "/2";
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + ".";
        }

        //display result
        private void result_Click(object sender, RoutedEventArgs e)
        {
            if(oper == "+")
            {
                total = num1 + num2;
                num1 = total;
                //MessageBox.Show(total.ToString() + " num1" + num1 + " num2"+num2);

            }
            else if(oper == "-")
            {
                total = num1 - num2;
                num1 = total;
                //MessageBox.Show(total.ToString() + " num1:" + num1 + " num2:" + num2);

            }
            else if(oper == "*")
            {
                total = num1 * num2;
                num1 = total;
            }
            else if (oper == "/")
            {
                if (num2 == 0)
                {

                    MessageBox.Show("Please do not divide by cero :(");
                }
                else
                {
                    //MessageBox.Show(total.ToString() + " num1:" + num1 + " num2:" + num2);
                    total = num1 / num2;
                    num1 = total;
                    
                }
                
            }else if(oper == "/2")
            {
                total = num1 / 10;
                num1 = total;
            }
            num1 = total;
            display.Text = total.ToString();
            MessageBox.Show("total" + total.ToString());
            MessageBox.Show("num1" + num1.ToString());
        }
    }
}
