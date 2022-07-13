namespace PrimeiroAplicativo02
{
    partial class frmPropriedadeCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropriedadeCheckBox));
            this.lblMensagemApresentação = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagemApresentação
            // 
            this.lblMensagemApresentação.AutoSize = true;
            this.lblMensagemApresentação.Location = new System.Drawing.Point(26, 24);
            this.lblMensagemApresentação.Name = "lblMensagemApresentação";
            this.lblMensagemApresentação.Size = new System.Drawing.Size(288, 15);
            this.lblMensagemApresentação.TabIndex = 0;
            this.lblMensagemApresentação.Text = "Formulário de chamada e apresentação do CheckBox";
            // 
            // frmPropriedadeCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblMensagemApresentação);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPropriedadeCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades do CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMensagemApresentação;
    }
}