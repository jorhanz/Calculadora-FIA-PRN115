using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculadoraGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para validar las entradas
        private bool ValidarEntrada(out double Numero1, out double Numero2)
        {
            // Asignar valores predeterminados a Numero1 y Numero2
            Numero1 = 0;
            Numero2 = 0;

            // Reemplazar comas por puntos para la conversión
            string entradaNumero1 = txtbNumero1.Text.Replace(',', '.');
            string entradaNumero2 = txtbNumero2.Text.Replace(',', '.');

            // Intentar convertir las entradas a números
            if (double.TryParse(entradaNumero1, NumberStyles.Any, CultureInfo.InvariantCulture, out Numero1) &&
                double.TryParse(entradaNumero2, NumberStyles.Any, CultureInfo.InvariantCulture, out Numero2))
            {
                return true;
            }

            // Mostrar un mensaje de error si la conversión falla
            MessageBox.Show("Ha ingresado un dato inválido, por favor ingrese valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Método para realizar las operaciones aritméticas
        private void RealizarOperacion(string operacion)
        {
            if (ValidarEntrada(out double Numero1, out double Numero2))
            {
                double Resultado = 0;
                switch (operacion)
                {
                    case "+":
                        Resultado = Numero1 + Numero2;
                        break;
                    case "-":
                        Resultado = Numero1 - Numero2;
                        break;
                    case "*":
                        Resultado = Numero1 * Numero2;
                        break;
                    case "/":
                        if (Numero2 != 0)
                        {
                            Resultado = Numero1 / Numero2;
                        }
                        else
                        {
                            MessageBox.Show("Error: División por cero no permitida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                // Mostrar el resultado con 2 decimales
                lblResultado.Text = Resultado.ToString("F2");
            }
        }

        // Eventos para los botones de las operaciones
        private void btnSuma_Click(object sender, EventArgs e) => RealizarOperacion("+");
        private void btnResta_Click(object sender, EventArgs e) => RealizarOperacion("-");
        private void btnMultiplicacion_Click(object sender, EventArgs e) => RealizarOperacion("*");
        private void btnDivision_Click(object sender, EventArgs e) => RealizarOperacion("/");

        // Botón para limpiar las entradas y el resultado
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNumero1.Text = "";
            txtbNumero2.Text = "";
            lblResultado.Text = "0.00"; // Reinicia el resultado a cero
        }

        // Método para el botón de salir (cerrar la aplicación)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la aplicación
        }
    }
}
