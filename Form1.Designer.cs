
namespace Calculadora_Opcion_B
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
            this.chckMas = new System.Windows.Forms.CheckBox();
            this.chckMenos = new System.Windows.Forms.CheckBox();
            this.chckPor = new System.Windows.Forms.CheckBox();
            this.chckEntre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calculador = new System.Windows.Forms.Button();
            this.btnCleaner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chckMas
            // 
            this.chckMas.AutoSize = true;
            this.chckMas.Location = new System.Drawing.Point(337, 112);
            this.chckMas.Name = "chckMas";
            this.chckMas.Size = new System.Drawing.Size(32, 17);
            this.chckMas.TabIndex = 0;
            this.chckMas.Text = "+";
            this.chckMas.UseVisualStyleBackColor = true;
            // 
            // chckMenos
            // 
            this.chckMenos.AutoSize = true;
            this.chckMenos.Location = new System.Drawing.Point(337, 135);
            this.chckMenos.Name = "chckMenos";
            this.chckMenos.Size = new System.Drawing.Size(29, 17);
            this.chckMenos.TabIndex = 1;
            this.chckMenos.Text = "-";
            this.chckMenos.UseVisualStyleBackColor = true;
            // 
            // chckPor
            // 
            this.chckPor.AutoSize = true;
            this.chckPor.Location = new System.Drawing.Point(337, 158);
            this.chckPor.Name = "chckPor";
            this.chckPor.Size = new System.Drawing.Size(31, 17);
            this.chckPor.TabIndex = 2;
            this.chckPor.Text = "x";
            this.chckPor.UseVisualStyleBackColor = true;
            // 
            // chckEntre
            // 
            this.chckEntre.AutoSize = true;
            this.chckEntre.Location = new System.Drawing.Point(337, 181);
            this.chckEntre.Name = "chckEntre";
            this.chckEntre.Size = new System.Drawing.Size(32, 17);
            this.chckEntre.TabIndex = 3;
            this.chckEntre.Text = "÷";
            this.chckEntre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signos matematicos";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(103, 109);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(103, 158);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor 2";
            // 
            // Calculador
            // 
            this.Calculador.Location = new System.Drawing.Point(65, 204);
            this.Calculador.Name = "Calculador";
            this.Calculador.Size = new System.Drawing.Size(75, 23);
            this.Calculador.TabIndex = 10;
            this.Calculador.Text = "Igual a";
            this.Calculador.UseVisualStyleBackColor = true;
            this.Calculador.Click += new System.EventHandler(this.Calculador_Click);
            // 
            // btnCleaner
            // 
            this.btnCleaner.Location = new System.Drawing.Point(65, 233);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(75, 23);
            this.btnCleaner.TabIndex = 11;
            this.btnCleaner.Text = "Limpiar";
            this.btnCleaner.UseVisualStyleBackColor = true;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(146, 209);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 13);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCleaner);
            this.Controls.Add(this.Calculador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckEntre);
            this.Controls.Add(this.chckPor);
            this.Controls.Add(this.chckMenos);
            this.Controls.Add(this.chckMas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckMas;
        private System.Windows.Forms.CheckBox chckMenos;
        private System.Windows.Forms.CheckBox chckPor;
        private System.Windows.Forms.CheckBox chckEntre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calculador;
        private System.Windows.Forms.Button btnCleaner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResultado;
    }
}

