namespace PrimeiroAplicativo04
{
    partial class frmConversorTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversorTemperatura));
            this.lblValor = new System.Windows.Forms.Label();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gpEntrada = new System.Windows.Forms.GroupBox();
            this.rbFarenheit = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.gpSaida = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbCelsiusSaida = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpEntrada.SuspendLayout();
            this.gpSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 21);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 15);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Location = new System.Drawing.Point(20, 32);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(62, 19);
            this.rbCelsius.TabIndex = 1;
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius";
            this.rbCelsius.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(76, 244);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(144, 55);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(76, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderText = "Insira o valor que será convertido";
            this.txtValor.Size = new System.Drawing.Size(330, 23);
            this.txtValor.TabIndex = 3;
            // 
            // gpEntrada
            // 
            this.gpEntrada.Controls.Add(this.rbKelvin);
            this.gpEntrada.Controls.Add(this.rbFarenheit);
            this.gpEntrada.Controls.Add(this.rbCelsius);
            this.gpEntrada.Location = new System.Drawing.Point(79, 75);
            this.gpEntrada.Name = "gpEntrada";
            this.gpEntrada.Size = new System.Drawing.Size(141, 115);
            this.gpEntrada.TabIndex = 4;
            this.gpEntrada.TabStop = false;
            this.gpEntrada.Text = "Entrada";
            // 
            // rbFarenheit
            // 
            this.rbFarenheit.AutoSize = true;
            this.rbFarenheit.Location = new System.Drawing.Point(20, 57);
            this.rbFarenheit.Name = "rbFarenheit";
            this.rbFarenheit.Size = new System.Drawing.Size(74, 19);
            this.rbFarenheit.TabIndex = 2;
            this.rbFarenheit.TabStop = true;
            this.rbFarenheit.Text = "Farenheit";
            this.rbFarenheit.UseVisualStyleBackColor = true;
            this.rbFarenheit.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(20, 82);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(57, 19);
            this.rbKelvin.TabIndex = 3;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // gpSaida
            // 
            this.gpSaida.Controls.Add(this.radioButton1);
            this.gpSaida.Controls.Add(this.radioButton2);
            this.gpSaida.Controls.Add(this.rbCelsiusSaida);
            this.gpSaida.Location = new System.Drawing.Point(236, 75);
            this.gpSaida.Name = "gpSaida";
            this.gpSaida.Size = new System.Drawing.Size(141, 115);
            this.gpSaida.TabIndex = 4;
            this.gpSaida.TabStop = false;
            this.gpSaida.Text = "Entrada";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kelvin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Farenheit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCelsiusSaida
            // 
            this.rbCelsiusSaida.AutoSize = true;
            this.rbCelsiusSaida.Location = new System.Drawing.Point(20, 32);
            this.rbCelsiusSaida.Name = "rbCelsiusSaida";
            this.rbCelsiusSaida.Size = new System.Drawing.Size(62, 19);
            this.rbCelsiusSaida.TabIndex = 1;
            this.rbCelsiusSaida.TabStop = true;
            this.rbCelsiusSaida.Text = "Celsius";
            this.rbCelsiusSaida.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 219);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(76, 215);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.PlaceholderText = "Resultado da Conversão";
            this.txtResultado.Size = new System.Drawing.Size(330, 23);
            this.txtResultado.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(236, 244);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 55);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmConversorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 310);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpSaida);
            this.Controls.Add(this.gpEntrada);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConversorTemperatura";
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.frmConversorTemperatura_Load);
            this.gpEntrada.ResumeLayout(false);
            this.gpEntrada.PerformLayout();
            this.gpSaida.ResumeLayout(false);
            this.gpSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValor;
        private RadioButton rbCelsius;
        private Button btnConverter;
        private TextBox txtValor;
        private GroupBox gpEntrada;
        private RadioButton rbFarenheit;
        private RadioButton rbKelvin;
        private GroupBox gpSaida;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton rbCelsiusSaida;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnLimpar;
    }
}