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

namespace калькулятор2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sign = 0, flag = 0;
        double str = 0, str1 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else
            {
                if ((text.Text == "0") || (text.Text == "-0"))
                {

                }
                else
                {
                    text.Text += '0';
                    if (sign == 0) str = double.Parse(text.Text);
                    else str1 = double.Parse(text.Text);
                }
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '1';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '1';
            }
            else
            {
                text.Text += '1';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '2';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '2';
            }
            else
            {
                text.Text += '2';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            ;
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '3';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '3';
            }
            else
            {
                text.Text += '3';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '4';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '4';
            }
            else
            {
                text.Text += '4';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '5';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '5';
            }
            else
            {
                text.Text += '5';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '6';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '6';
            }
            else
            {
                text.Text += '6';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '7';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '7';
            }
            else
            {
                text.Text += '7';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '8';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '8';
            }
            else
            {
                text.Text += '8';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if ((text.Text == "0") && (flag != 0) || (flag == 0))
            {
                text.Clear();
                text.Text += '9';
                flag++;
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
            else if (text.Text == "-0")
            {
                text.Clear();
                text.Text += '-';
                text.Text += '9';
            }
            else
            {
                text.Text += '9';
                if (sign == 0) str = double.Parse(text.Text);
                else str1 = double.Parse(text.Text);
            }
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text.IndexOf('*') != -1)
            {

            }
            else if (text1.Text.IndexOf('/') != -1)
            {

            }
            else if (text1.Text.IndexOf('+') != -1)
            {

            }
            else if (text1.Text.IndexOf('-') != -1)
            {

            }
            else
            {
                text1.Text += text.Text + '*';
                sign = 1;
                text.Clear();
                text.Text += '0';
                flag = 0;
                str1 = 0;
            }
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text.IndexOf('*') != -1)
            {

            }
            else if (text1.Text.IndexOf('/') != -1)
            {

            }
            else if (text1.Text.IndexOf('+') != -1)
            {

            }
            else if (text1.Text.IndexOf('-') != -1)
            {

            }
            else
            {
                text1.Text += text.Text + '/';
                sign = 2;
                text.Clear();
                text.Text += '0';
                flag = 0;
                str1 = 0;
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (sign != 0)
            {
                if (flag == 0)
                {
                    text.Clear();
                    text.Text += '-';
                    flag++;
                }
            }
            else if (text1.Text.IndexOf('*') != -1)
            {

            }
            else if (text1.Text.IndexOf('/') != -1)
            {

            }
            else if (text1.Text.IndexOf('+') != -1)
            {

            }
            else if ((text1.Text.IndexOf('-') != -1) && (sign == 0))
            {
                text.Clear();
                text.Text += '0';
                sign = 3;
                text1.Text += '-';
                flag = 0;
            }
            else if (flag == 0)
            {
                text.Clear();
                text.Text += '-';
                flag++;
            }
            else
            {
                text1.Text += text.Text + '-';
                sign = 3;
                text.Clear();
                flag = 0;
                text.Text += '0';
                str1 = 0;
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text.IndexOf('*') != -1)
            {

            }
            else if (text1.Text.IndexOf('/') != -1)
            {

            }
            else if (text1.Text.IndexOf('+') != -1)
            {

            }
            else if (text1.Text.IndexOf('-') != -1)
            {

            }
            else
            {
                text1.Text += text.Text + '+';
                sign = 4;
                text.Clear();
                text.Text += '0';
                flag = 0;
                str1 = 0;
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            text1.Clear();
            text.Text += '0';
            flag = 0;
            sign = 0;
            str = 0;
            str1 = 0;
        }
        /*
        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }
        */
        private void comma_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text.IndexOf(',') != -1)
            {

            }
            else if (text.Text != "-")
            {
                text.Text += ',';
                flag++;
            }
        }

        private void equally_Click(object sender, RoutedEventArgs e)
        {
            if ((sign == 2) && (str1 == 0))
            {
                MessageBox.Show("На ноль делить нельзя, дурак");
                text.Clear();
                text1.Clear();
                sign = 0;
                flag = 0;
            }

            else
            {
                double result = 0;
                switch (sign)
                {
                    case 0:
                        result = str;
                        break;
                    case 1:
                        result = str * str1;
                        break;
                    case 2:
                        result = str / str1;
                        break;
                    case 3:
                        result = str - str1;
                        break;
                    case 4:
                        result = str + str1;
                        break;
                }
                text.Clear();
                text1.Clear();
                text.Text += result;
                str = double.Parse(text.Text);
                //sign = 0;
                //str1 = 0;
            }
        }

        private void Click_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void spr(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.ShowDialog();
        }
    }
}
