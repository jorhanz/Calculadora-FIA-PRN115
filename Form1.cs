using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2._0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOperacion.SelectedIndex = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = 0;

            switch (cbOperacion.SelectedItem.ToString())
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        lblResultado.Text = "No se puede dividir por 0";
                        return;
                    }
                    break;
                default:
                    lblResultado.Text = "Selecciona una operación";
                    return;
            }

            lblResultado.Text = "Resultado: " + resultado.ToString();

        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
