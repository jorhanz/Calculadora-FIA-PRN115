using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Opcion_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculador_Click(object sender, EventArgs e)
        {
            //  Variables de entrada
            String LetraNumero1 = txtNum1.Text, LetraNumero2 = txtNum2.Text;
            double valor1, valor2;

            try
            {
                //Validacion solo para que acepte numeros
                if (double.TryParse(LetraNumero1, out valor1) && double.TryParse(LetraNumero2, out valor2))
                {
                    //Validacion para que solo se utilice un número (no se me ha ocurrido una forma mas optima de hacer esto xd
                    if (chckMas.Checked && chckMenos.Checked && chckPor.Checked && chckEntre.Checked ||
                        chckMas.Checked && chckMenos.Checked && chckPor.Checked || chckMenos.Checked && chckPor.Checked
                        && chckEntre.Checked || chckMas.Checked && chckEntre.Checked && chckPor.Checked ||
                        chckMas.Checked && chckMenos.Checked || chckMas.Checked&&chckPor.Checked|| chckMas.Checked && chckEntre.Checked
                        || chckMenos.Checked&&chckPor.Checked || chckMenos.Checked && chckEntre.Checked
                        || chckPor.Checked&&chckEntre.Checked)
                    {
                        MessageBox.Show
                 ("Solo seleccione una casilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Aqui van los procesos matematicos
                    else
                    {
                        if (chckMas.Checked)
                        {
                            double sumaN = valor1 + valor2;
                            lblResultado.Text = sumaN.ToString();
                        }
                        if (chckMenos.Checked)
                        {
                            double restaN = valor1 - valor2;
                            lblResultado.Text = restaN.ToString();
                        }
                        if (chckPor.Checked)
                        {
                            double multiplicarN = valor1 * valor2;
                            lblResultado.Text = multiplicarN.ToString();
                        }
                        if (chckEntre.Checked)
                        {
                            double DivN = valor1 / valor2;
                            lblResultado.Text = DivN.ToString();
                            if (valor2 == 0)
                            {
                                MessageBox.Show
                          ("Un número no puede dividirse entre 0, Ingrese otro valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                  
                }
                else
                {
                    MessageBox.Show
                  ("Ha ingresado un dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show
                  ("Ha ingresado un dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
