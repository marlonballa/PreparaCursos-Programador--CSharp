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
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.btnChamarFormulario = new System.Windows.Forms.Button();
            this.btnVisualizadorImagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Location = new System.Drawing.Point(83, 49);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(143, 43);
            this.btnMostrarMensagem.TabIndex = 0;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            // 
            // btnChamarFormulario
            // 
            this.btnChamarFormulario.Location = new System.Drawing.Point(0, 0);
            this.btnChamarFormulario.Name = "btnChamarFormulario";
            this.btnChamarFormulario.Size = new System.Drawing.Size(75, 23);
            this.btnChamarFormulario.TabIndex = 0;
            // 
            // btnVisualizadorImagens
            // 
            this.btnVisualizadorImagens.Location = new System.Drawing.Point(0, 0);
            this.btnVisualizadorImagens.Name = "btnVisualizadorImagens";
            this.btnVisualizadorImagens.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizadorImagens.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMostrarMensagem;
        private Button btnChamarFormulario;
        private Button btnVisualizadorImagens;
    }
}