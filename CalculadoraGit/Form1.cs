using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ComboBoxColorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cbOperacion.DrawMode = DrawMode.OwnerDrawFixed;
            cbOperacion.DrawItem += new DrawItemEventHandler(cbOperacion_DrawItem);
        }

        private void cbOperacion_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox comboBox = (ComboBox)sender;
            string itemText = comboBox.Items[e.Index].ToString();

            e.DrawBackground();
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (var brush = new SolidBrush(Color.DarkBlue))
            {
                e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado:";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double result = 0;

            var culture = CultureInfo.CurrentCulture;
            var numberFormat = culture.NumberFormat;
            string decimalSeparator = numberFormat.CurrencyDecimalSeparator;

            string textNum1 = txtNumero1.Text.Replace(',', decimalSeparator[0]).Replace('.', decimalSeparator[0]);
            string textNum2 = txtNumero2.Text.Replace(',', decimalSeparator[0]).Replace('.', decimalSeparator[0]);

            if (double.TryParse(textNum1, NumberStyles.Float, culture, out num1) && double.TryParse(textNum2, NumberStyles.Float, culture, out num2))
            {
                // Verificar si se ha seleccionado una operación
                if (cbOperacion.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una operación.");
                    return;
                }

                // Realizar la operación según la selección
                switch (cbOperacion.SelectedItem.ToString())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.");
                            return;
                        }
                        break;
                }

                lblResultado.Text = $"Resultado: {result.ToString(culture)}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }
    }
}
