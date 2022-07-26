namespace PrimeiroAplicativo04
{
    partial class frmTabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada));
            this.lblMsgTabuada = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMsgTabuada
            // 
            this.lblMsgTabuada.AutoSize = true;
            this.lblMsgTabuada.Location = new System.Drawing.Point(69, 19);
            this.lblMsgTabuada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgTabuada.Name = "lblMsgTabuada";
            this.lblMsgTabuada.Size = new System.Drawing.Size(297, 18);
            this.lblMsgTabuada.TabIndex = 0;
            this.lblMsgTabuada.Text = "Informe qual tabuada gostaria de calcular:";
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(69, 41);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(293, 26);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Text = "Tabuada do:";
            this.txtNumero.Click += new System.EventHandler(this.txtNumero_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(65, 104);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 28);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(266, 104);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 28);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(65, 142);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(297, 186);
            this.txtResultado.TabIndex = 4;
            // 
            // txtLimite
            // 
            this.txtLimite.ForeColor = System.Drawing.Color.Silver;
            this.txtLimite.Location = new System.Drawing.Point(69, 75);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(293, 26);
            this.txtLimite.TabIndex = 5;
            this.txtLimite.Text = "Quero até:";
            this.txtLimite.Click += new System.EventHandler(this.txtLimite_Click);
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged);
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 341);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblMsgTabuada);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmTabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vamos Calcular: Tabuada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTabuada_FormClosing);
            this.Load += new System.EventHandler(this.frmTabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMsgTabuada;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Button btnLimpar;
        private TextBox txtResultado;
        private TextBox txtLimite;
    }
}