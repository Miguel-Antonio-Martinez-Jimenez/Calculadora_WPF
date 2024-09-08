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

namespace Calculadora
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
        public string operacion = "";
        public double num1, num2, resultado;

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(txtPanel.Text);
            operacion = "-";
            txtPanel.Clear();
        }

        private void btnMultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(txtPanel.Text);
            operacion = "*";
            txtPanel.Clear();
        }

        private void btnDivicion_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(txtPanel.Text);
            operacion = "/";
            txtPanel.Clear();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtPanel.Clear();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(txtPanel.Text);
            operacion = "+";
            txtPanel.Clear();
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToInt32(txtPanel.Text);
            switch(operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    txtPanel.Text = Convert.ToString(resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    txtPanel.Text = Convert.ToString(resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    txtPanel.Text = Convert.ToString(resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    txtPanel.Text = Convert.ToString(resultado);
                    break;
            }
        }
    }
}
