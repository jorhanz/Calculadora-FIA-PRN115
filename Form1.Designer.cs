
namespace Calculadora2._0._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCleaner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.Color.Aqua;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(54, 12);
            this.txtNumero1.Name = "txtNumero1";
<<<<<<< HEAD
            this.txtNumero1.Size = new System.Drawing.Size(123, 35);
=======
            this.txtNumero1.Size = new System.Drawing.Size(100, 22);
>>>>>>> f3c88550e87f653efa30534db2f3cdca941c27ff
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.Aqua;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(54, 53);
            this.txtNumero2.Name = "txtNumero2";
<<<<<<< HEAD
            this.txtNumero2.Size = new System.Drawing.Size(123, 35);
=======
            this.txtNumero2.Size = new System.Drawing.Size(100, 22);
>>>>>>> f3c88550e87f653efa30534db2f3cdca941c27ff
            this.txtNumero2.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(33, 96);
            this.lblResultado.Name = "lblResultado";
<<<<<<< HEAD
            this.lblResultado.Size = new System.Drawing.Size(0, 29);
=======
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
>>>>>>> f3c88550e87f653efa30534db2f3cdca941c27ff
            this.lblResultado.TabIndex = 4;
            // 
            // cbOperacion
            // 
            this.cbOperacion.BackColor = System.Drawing.Color.Aqua;
            this.cbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperacion.Location = new System.Drawing.Point(184, 10);
            this.cbOperacion.Name = "cbOperacion";
<<<<<<< HEAD
            this.cbOperacion.Size = new System.Drawing.Size(46, 37);
=======
            this.cbOperacion.Size = new System.Drawing.Size(50, 24);
>>>>>>> f3c88550e87f653efa30534db2f3cdca941c27ff
            this.cbOperacion.TabIndex = 2;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Aqua;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(184, 53);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(46, 35);
            this.btnIgual.TabIndex = 3;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(142, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCleaner
            // 
            this.btnCleaner.BackColor = System.Drawing.Color.Aqua;
            this.btnCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaner.Location = new System.Drawing.Point(12, 133);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(120, 38);
            this.btnCleaner.TabIndex = 6;
            this.btnCleaner.Text = "Limpiar";
            this.btnCleaner.UseVisualStyleBackColor = false;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.btnCleaner);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.cbOperacion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCleaner;
    }

        #endregion
}


