using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            String LetraNumero1 = txtbNumero1.Text, LetraNumero2 = txtbNumero2.Text;
            double Numero1, Numero2,Resultado;
            if (double.TryParse(LetraNumero1, out Numero1))
            {
                if (double.TryParse(LetraNumero2, out Numero1))
                {
                    Numero1 = double.Parse(LetraNumero1);
                    Numero2 = double.Parse(LetraNumero2);
                    Resultado = Numero1 - Numero2;
                    lblResultado.Text = Resultado.ToString();
                }
                else
                {
                    lblResultado.Text = "Por favor digite solamente numeros";
                }
                    
            }
            else
            {
                lblResultado.Text = "Por favor digite solamente numeros";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNumero1.Text = "";
            txtbNumero2.Text = "";
            lblResultado.Text = "0.00";
        }
    }
}
