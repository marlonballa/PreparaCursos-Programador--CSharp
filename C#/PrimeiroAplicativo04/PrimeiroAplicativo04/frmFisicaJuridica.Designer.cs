namespace PrimeiroAplicativo04
{
    partial class frmFisicaJuridica
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
            this.lblTextPeople = new System.Windows.Forms.Label();
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomePessoaFisica = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNomePesFisica = new System.Windows.Forms.Label();
            this.pnlPessoaJuridica = new System.Windows.Forms.Panel();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.pnlPessoaFisica.SuspendLayout();
            this.pnlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextPeople
            // 
            this.lblTextPeople.AutoSize = true;
            this.lblTextPeople.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPeople.Location = new System.Drawing.Point(16, 35);
            this.lblTextPeople.Margin = new System.Windows.Forms.Padding(0);
            this.lblTextPeople.Name = "lblTextPeople";
            this.lblTextPeople.Size = new System.Drawing.Size(134, 25);
            this.lblTextPeople.TabIndex = 0;
            this.lblTextPeople.Text = "Quem é você?";
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Location = new System.Drawing.Point(22, 71);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(94, 19);
            this.chkPessoaFisica.TabIndex = 1;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            this.chkPessoaFisica.CheckedChanged += new System.EventHandler(this.chkPessoaFisica_CheckedChanged);
            this.chkPessoaFisica.CheckStateChanged += new System.EventHandler(this.chkPessoaFisica_CheckStateChanged);
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Location = new System.Drawing.Point(234, 71);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(105, 19);
            this.chkPessoaJuridica.TabIndex = 2;
            this.chkPessoaJuridica.Text = "Pessoa Jurídica";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkPessoaJuridica.CheckedChanged += new System.EventHandler(this.chkPessoaJuridica_CheckedChanged);
            this.chkPessoaJuridica.CheckStateChanged += new System.EventHandler(this.chkPessoaJuridica_CheckStateChanged);
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.Controls.Add(this.txtCPF);
            this.pnlPessoaFisica.Controls.Add(this.txtNomePessoaFisica);
            this.pnlPessoaFisica.Controls.Add(this.lblCPF);
            this.pnlPessoaFisica.Controls.Add(this.lblNomePesFisica);
            this.pnlPessoaFisica.Location = new System.Drawing.Point(22, 96);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(200, 100);
            this.pnlPessoaFisica.TabIndex = 3;
            this.pnlPessoaFisica.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(59, 46);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 3;
            // 
            // txtNomePessoaFisica
            // 
            this.txtNomePessoaFisica.Location = new System.Drawing.Point(59, 20);
            this.txtNomePessoaFisica.Name = "txtNomePessoaFisica";
            this.txtNomePessoaFisica.Size = new System.Drawing.Size(100, 23);
            this.txtNomePessoaFisica.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 54);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNomePesFisica
            // 
            this.lblNomePesFisica.AutoSize = true;
            this.lblNomePesFisica.Location = new System.Drawing.Point(10, 28);
            this.lblNomePesFisica.Name = "lblNomePesFisica";
            this.lblNomePesFisica.Size = new System.Drawing.Size(43, 15);
            this.lblNomePesFisica.TabIndex = 0;
            this.lblNomePesFisica.Text = "Nome:";
            // 
            // pnlPessoaJuridica
            // 
            this.pnlPessoaJuridica.Controls.Add(this.txtCNPJ);
            this.pnlPessoaJuridica.Controls.Add(this.txtNomeEmpresa);
            this.pnlPessoaJuridica.Controls.Add(this.lblCNPJ);
            this.pnlPessoaJuridica.Controls.Add(this.lblNomeEmpresa);
            this.pnlPessoaJuridica.Location = new System.Drawing.Point(234, 96);
            this.pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            this.pnlPessoaJuridica.Size = new System.Drawing.Size(200, 100);
            this.pnlPessoaJuridica.TabIndex = 4;
            this.pnlPessoaJuridica.Visible = false;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(65, 51);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 23);
            this.txtCNPJ.TabIndex = 5;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(65, 24);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(100, 23);
            this.txtNomeEmpresa.TabIndex = 4;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(16, 54);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 15);
            this.lblCNPJ.TabIndex = 3;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(16, 28);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(43, 15);
            this.lblNomeEmpresa.TabIndex = 2;
            this.lblNomeEmpresa.Text = "Nome:";
            // 
            // frmFisicaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.Controls.Add(this.pnlPessoaJuridica);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.chkPessoaJuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.Controls.Add(this.lblTextPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFisicaJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Física x Pessoa Jurídica";
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.pnlPessoaJuridica.ResumeLayout(false);
            this.pnlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTextPeople;
        private CheckBox chkPessoaFisica;
        private CheckBox chkPessoaJuridica;
        private Panel pnlPessoaFisica;
        private TextBox txtCPF;
        private TextBox txtNomePessoaFisica;
        private Label lblCPF;
        private Label lblNomePesFisica;
        private Panel pnlPessoaJuridica;
        private TextBox txtCNPJ;
        private TextBox txtNomeEmpresa;
        private Label lblCNPJ;
        private Label lblNomeEmpresa;
    }
}