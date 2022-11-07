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

namespace WpfAppCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int intA = 0;
        int intB = 0;
        bool operator_pressed = false;
        string pressed = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Content)
            {
                case "+":
                case "-":
                case "/":
                case "X":
                    pressed = (sender as Button).Content.ToString();
                    if (!operator_pressed)
                    {
                        intA = int.Parse(txtblk.Text);
                        operator_pressed = true;
                    }
                    break;
                case "=":
                    Eqauls();
                    break;

                default:
                    //numbers:
                    if (operator_pressed)
                        txtblk.Text = "";
                    operator_pressed = false;
                    txtblk.Text += (sender as Button).Content;
                    break;
            }
        }

        private void Eqauls()
        {
            intB = int.Parse(txtblk.Text);
            switch (pressed)
            {
                case "+":
                    txtblk.Text = (intA + intB).ToString();
                    break;
                case "-":
                    txtblk.Text = (intA - intB).ToString();
                    break;
                case "/":
                    txtblk.Text = (intA / intB).ToString();
                    break;
                case "X":
                    txtblk.Text = (intA * intB).ToString();
                    break;
            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            txtblk.Text = "";
            intA = 0;
            intB = 0;
        }
    }
}
