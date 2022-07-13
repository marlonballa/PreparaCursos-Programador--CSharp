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
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomePessoaFisica = new System.Windows.Forms.TextBox();
            this.lblNomePessoaFisica = new System.Windows.Forms.Label();
            this.pnlPessoaJuridica = new System.Windows.Forms.Panel();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtPessoaJuridica = new System.Windows.Forms.TextBox();
            this.lblNomePessoaJuridica = new System.Windows.Forms.Label();
            this.pnlPessoaFisica.SuspendLayout();
            this.pnlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagemApresentação
            // 
            this.lblMensagemApresentação.AutoSize = true;
            this.lblMensagemApresentação.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensagemApresentação.Location = new System.Drawing.Point(73, 18);
            this.lblMensagemApresentação.Name = "lblMensagemApresentação";
            this.lblMensagemApresentação.Size = new System.Drawing.Size(359, 17);
            this.lblMensagemApresentação.TabIndex = 0;
            this.lblMensagemApresentação.Text = "Formulário de chamada e apresentação do CheckBox";
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPessoaFisica.Location = new System.Drawing.Point(49, 49);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(120, 21);
            this.chkPessoaFisica.TabIndex = 1;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            this.chkPessoaFisica.CheckStateChanged += new System.EventHandler(this.chkPessoaFisica_CheckStateChanged);
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPessoaJuridica.Location = new System.Drawing.Point(264, 49);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(131, 21);
            this.chkPessoaJuridica.TabIndex = 2;
            this.chkPessoaJuridica.Text = "Pessoa Juridíca";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkPessoaJuridica.CheckStateChanged += new System.EventHandler(this.chkPessoaJuridica_CheckStateChanged);
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.Controls.Add(this.txtCpf);
            this.pnlPessoaFisica.Controls.Add(this.lblCPF);
            this.pnlPessoaFisica.Controls.Add(this.txtNomePessoaFisica);
            this.pnlPessoaFisica.Controls.Add(this.lblNomePessoaFisica);
            this.pnlPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlPessoaFisica.Location = new System.Drawing.Point(49, 74);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(200, 89);
            this.pnlPessoaFisica.TabIndex = 3;
            this.pnlPessoaFisica.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(59, 45);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 25);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(10, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 17);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNomePessoaFisica
            // 
            this.txtNomePessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomePessoaFisica.Location = new System.Drawing.Point(59, 16);
            this.txtNomePessoaFisica.Name = "txtNomePessoaFisica";
            this.txtNomePessoaFisica.Size = new System.Drawing.Size(100, 25);
            this.txtNomePessoaFisica.TabIndex = 1;
            // 
            // lblNomePessoaFisica
            // 
            this.lblNomePessoaFisica.AutoSize = true;
            this.lblNomePessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePessoaFisica.Location = new System.Drawing.Point(10, 19);
            this.lblNomePessoaFisica.Name = "lblNomePessoaFisica";
            this.lblNomePessoaFisica.Size = new System.Drawing.Size(51, 17);
            this.lblNomePessoaFisica.TabIndex = 0;
            this.lblNomePessoaFisica.Text = "Nome:";
            // 
            // pnlPessoaJuridica
            // 
            this.pnlPessoaJuridica.Controls.Add(this.txtCnpj);
            this.pnlPessoaJuridica.Controls.Add(this.lblCnpj);
            this.pnlPessoaJuridica.Controls.Add(this.txtPessoaJuridica);
            this.pnlPessoaJuridica.Controls.Add(this.lblNomePessoaJuridica);
            this.pnlPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlPessoaJuridica.Location = new System.Drawing.Point(268, 74);
            this.pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            this.pnlPessoaJuridica.Size = new System.Drawing.Size(200, 89);
            this.pnlPessoaJuridica.TabIndex = 4;
            this.pnlPessoaJuridica.Visible = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.Location = new System.Drawing.Point(59, 45);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 25);
            this.txtCnpj.TabIndex = 3;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.Location = new System.Drawing.Point(10, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(50, 17);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtPessoaJuridica
            // 
            this.txtPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPessoaJuridica.Location = new System.Drawing.Point(59, 16);
            this.txtPessoaJuridica.Name = "txtPessoaJuridica";
            this.txtPessoaJuridica.Size = new System.Drawing.Size(100, 25);
            this.txtPessoaJuridica.TabIndex = 1;
            // 
            // lblNomePessoaJuridica
            // 
            this.lblNomePessoaJuridica.AutoSize = true;
            this.lblNomePessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePessoaJuridica.Location = new System.Drawing.Point(10, 19);
            this.lblNomePessoaJuridica.Name = "lblNomePessoaJuridica";
            this.lblNomePessoaJuridica.Size = new System.Drawing.Size(51, 17);
            this.lblNomePessoaJuridica.TabIndex = 0;
            this.lblNomePessoaJuridica.Text = "Nome:";
            // 
            // frmPropriedadeCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 184);
            this.Controls.Add(this.pnlPessoaJuridica);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.chkPessoaJuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.Controls.Add(this.lblMensagemApresentação);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPropriedadeCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades do CheckBox";
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.pnlPessoaJuridica.ResumeLayout(false);
            this.pnlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMensagemApresentação;
        private CheckBox chkPessoaFisica;
        private CheckBox chkPessoaJuridica;
        private Panel pnlPessoaFisica;
        private TextBox txtCpf;
        private Label lblCPF;
        private TextBox txtNomePessoaFisica;
        private Label lblNomePessoaFisica;
        private Panel pnlPessoaJuridica;
        private TextBox txtCnpj;
        private Label lblCnpj;
        private TextBox txtPessoaJuridica;
        private Label lblNomePessoaJuridica;
    }
}