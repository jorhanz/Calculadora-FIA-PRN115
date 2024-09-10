using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora2._0._1
{
    public partial class Form1 : Form
    {
        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true; // Habilita la captura de teclas para el formulario
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress); // Asocia el manejador de eventos para la tecla presionada
        }

        // Manejador del clic del botón "="
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Validar que ambos campos de entrada no estén vacíos
            if (string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                lblResultado.Text = "Por favor, ingresa ambos números.";
                return;
            }

            double numero1, numero2, resultado = 0;

            // Intentar convertir las entradas a números de acuerdo a la configuración regional del sistema
            try
            {
                numero1 = double.Parse(txtNumero1.Text, CultureInfo.CurrentCulture);
                numero2 = double.Parse(txtNumero2.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
                return;
            }

            // Validar que se haya seleccionado una operación
            if (cbOperacion.SelectedItem == null)
            {
                lblResultado.Text = "Selecciona una operación.";
                return;
            }

            // Realizar el cálculo basado en la operación seleccionada
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
                        lblResultado.Text = "No se puede dividir por 0.";
                        return;
                    }
                    break;
                default:
                    lblResultado.Text = "Operación no válida.";
                    return;
            }

            // Mostrar el resultado en el label con el formato adecuado
            lblResultado.Text = "Resultado: " + resultado.ToString("G", CultureInfo.CurrentCulture);

            // Guardar la operación en el historial
            GuardarHistorial(numero1, numero2, cbOperacion.SelectedItem.ToString(), resultado);

            // Preparar los campos para la siguiente operación
            PrepararSiguienteOperacion(resultado);
        }

        // Método para limpiar los campos de entrada y el resultado
        private void LimpiarCampos()
        {
            txtNumero1.Clear(); // Limpia el campo de texto del primer número
            txtNumero2.Clear(); // Limpia el campo de texto del segundo número
            lblResultado.Text = string.Empty; // Limpia el label del resultado
            cbOperacion.SelectedIndex = -1; // Deselecciona la operación
        }

        // Método para preparar los campos para la siguiente operación
        private void PrepararSiguienteOperacion(double resultado)
        {
            txtNumero1.Text = resultado.ToString(CultureInfo.CurrentCulture); // Usa el resultado como primer número para la siguiente operación
            txtNumero2.Clear(); // Limpia el campo del segundo número
            cbOperacion.SelectedIndex = -1; // Deselecciona la operación
        }

        // Método para guardar la operación en el historial
        private void GuardarHistorial(double numero1, double numero2, string operacion, double resultado)
        {
            // Agrega la operación al ListBox del historial
            listBoxHistorial.Items.Add($"{numero1.ToString(CultureInfo.CurrentCulture)} {operacion} {numero2.ToString(CultureInfo.CurrentCulture)} = {resultado.ToString(CultureInfo.CurrentCulture)}");
        }

        // Manejador del clic del botón "Limpiar"
        private void btnCleaner_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Llama al método para limpiar los campos
        }

        // Manejador del clic del botón "Salir"
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Manejador del evento de presionar teclas
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIgual.PerformClick(); // Ejecuta la operación cuando se presiona Enter
            }
        }
    }
}
