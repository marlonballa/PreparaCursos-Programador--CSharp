namespace PrimeiroAplicativo02
{
    partial class frmMostrarMensagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntMostrarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao curso: Programador C#!";
            // 
            // bntMostrarMensagem
            // 
            this.bntMostrarMensagem.Location = new System.Drawing.Point(102, 116);
            this.bntMostrarMensagem.Name = "bntMostrarMensagem";
            this.bntMostrarMensagem.Size = new System.Drawing.Size(132, 39);
            this.bntMostrarMensagem.TabIndex = 1;
            this.bntMostrarMensagem.Text = "Mostrar Mensagem";
            this.bntMostrarMensagem.UseVisualStyleBackColor = true;
            // 
            // frmMostrarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.bntMostrarMensagem);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrarMensagem";
            this.Text = "frmMostrarMensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bntMostrarMensagem;
    }
}