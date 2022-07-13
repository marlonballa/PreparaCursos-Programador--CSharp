namespace PrimeiroAplicativo02
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnChamarFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Location = new System.Drawing.Point(79, 81);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(143, 43);
            this.btnMostrarMensagem.TabIndex = 0;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(85, 63);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(130, 15);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "Descubra a Mensagem!";
            // 
            // btnChamarFormulario
            // 
            this.btnChamarFormulario.Location = new System.Drawing.Point(79, 130);
            this.btnChamarFormulario.Name = "btnChamarFormulario";
            this.btnChamarFormulario.Size = new System.Drawing.Size(143, 43);
            this.btnChamarFormulario.TabIndex = 2;
            this.btnChamarFormulario.Text = "Chamar Formulário";
            this.btnChamarFormulario.UseVisualStyleBackColor = true;
            this.btnChamarFormulario.Click += new System.EventHandler(this.btnChamarFormulario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.btnChamarFormulario);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnMostrarMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostrarMensagem;
        private Label lblMensagem;
        private Button btnChamarFormulario;
    }
}