namespace PrimeiroAplicativo04
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.btnFisJur = new System.Windows.Forms.Button();
            this.btnVisualizadorImagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Location = new System.Drawing.Point(114, 49);
            this.btnMostrarMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(200, 59);
            this.btnMostrarMensagem.TabIndex = 0;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // btnFisJur
            // 
            this.btnFisJur.Location = new System.Drawing.Point(114, 116);
            this.btnFisJur.Margin = new System.Windows.Forms.Padding(4);
            this.btnFisJur.Name = "btnFisJur";
            this.btnFisJur.Size = new System.Drawing.Size(200, 59);
            this.btnFisJur.TabIndex = 1;
            this.btnFisJur.Text = "Física x Jurídica";
            this.btnFisJur.UseVisualStyleBackColor = true;
            this.btnFisJur.Click += new System.EventHandler(this.btnFisJur_Click);
            // 
            // btnVisualizadorImagens
            // 
            this.btnVisualizadorImagens.Location = new System.Drawing.Point(114, 183);
            this.btnVisualizadorImagens.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizadorImagens.Name = "btnVisualizadorImagens";
            this.btnVisualizadorImagens.Size = new System.Drawing.Size(200, 59);
            this.btnVisualizadorImagens.TabIndex = 2;
            this.btnVisualizadorImagens.Text = "Visualizador de Imagens";
            this.btnVisualizadorImagens.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnVisualizadorImagens);
            this.Controls.Add(this.btnFisJur);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMostrarMensagem;
        private Button btnFisJur;
        private Button btnVisualizadorImagens;
    }
}