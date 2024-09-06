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
            //Son variables de entrada
            String LetraNumero1 = txtbNumero1.Text, LetraNumero2 = txtbNumero2.Text;
            double Numero1, Numero2, Resultado;
            try
            {
                if (double.TryParse(LetraNumero1, out Numero1) && double.TryParse(LetraNumero2, out Numero2))
                {
                    if (double.TryParse(LetraNumero2, out Numero2))
                    {
                        Numero1 = double.Parse(LetraNumero1);
                        Numero2 = double.Parse(LetraNumero2);
                        Resultado = Numero1 + Numero2;
                        lblResultado.Text = Resultado.ToString();
                    }
                }
                else
                {
                    MessageBox.Show
                  ("Ha ingresado un dato invalido, por favor escriba un valor númerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show
                   ("Ha ingresado un dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Son variables de entrada
            String LetraNumero1 = txtbNumero1.Text, LetraNumero2 = txtbNumero2.Text;
            double Numero1, Numero2, Resultado;

            try
            {                           
                if (double.TryParse(LetraNumero1, out Numero1) && double.TryParse(LetraNumero2, out Numero2))
                {
                    if (double.TryParse(LetraNumero2, out Numero2))
                    {
                        Numero1 = double.Parse(LetraNumero1);
                        Numero2 = double.Parse(LetraNumero2);
                        Resultado = Numero1 - Numero2;
                        lblResultado.Text = Resultado.ToString();
                    }
                }
                else
                {
                    MessageBox.Show
                   ("Ha ingresado un dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show
                   ("Ha ingresado un dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
