namespace PrimeiroAplicativo04
{
    partial class frmMediaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaAluno));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.cboPesoNota1 = new System.Windows.Forms.ComboBox();
            this.cboPesoNota2 = new System.Windows.Forms.ComboBox();
            this.cboPesoTrabalho = new System.Windows.Forms.ComboBox();
            this.txtQtdAulas = new System.Windows.Forms.TextBox();
            this.txtQtdFaltas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelMediaFinal = new System.Windows.Forms.Panel();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAproveitamento = new System.Windows.Forms.Panel();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.gbRecuperacao = new System.Windows.Forms.GroupBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.panelMediaFinal.SuspendLayout();
            this.pnlAproveitamento.SuspendLayout();
            this.gbSituacao.SuspendLayout();
            this.gbRecuperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(175, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(151, 128);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(0);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PlaceholderText = "Primeira Nota";
            this.txtNota1.Size = new System.Drawing.Size(112, 23);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(269, 128);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(0);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PlaceholderText = "Segunda Nota";
            this.txtNota2.Size = new System.Drawing.Size(112, 23);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(387, 128);
            this.txtTrabalho.Margin = new System.Windows.Forms.Padding(0);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.PlaceholderText = "Nota do Trabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(112, 23);
            this.txtTrabalho.TabIndex = 4;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTrabalho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboPesoNota1
            // 
            this.cboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota1.FormattingEnabled = true;
            this.cboPesoNota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota1.Location = new System.Drawing.Point(151, 154);
            this.cboPesoNota1.Name = "cboPesoNota1";
            this.cboPesoNota1.Size = new System.Drawing.Size(112, 23);
            this.cboPesoNota1.TabIndex = 1;
            // 
            // cboPesoNota2
            // 
            this.cboPesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota2.FormattingEnabled = true;
            this.cboPesoNota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota2.Location = new System.Drawing.Point(269, 154);
            this.cboPesoNota2.Name = "cboPesoNota2";
            this.cboPesoNota2.Size = new System.Drawing.Size(112, 23);
            this.cboPesoNota2.TabIndex = 3;
            // 
            // cboPesoTrabalho
            // 
            this.cboPesoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoTrabalho.FormattingEnabled = true;
            this.cboPesoTrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoTrabalho.Location = new System.Drawing.Point(387, 154);
            this.cboPesoTrabalho.Name = "cboPesoTrabalho";
            this.cboPesoTrabalho.Size = new System.Drawing.Size(112, 23);
            this.cboPesoTrabalho.TabIndex = 5;
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(151, 183);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.PlaceholderText = "Quantidade de Aulas";
            this.txtQtdAulas.Size = new System.Drawing.Size(230, 23);
            this.txtQtdAulas.TabIndex = 6;
            this.txtQtdAulas.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtQtdFaltas
            // 
            this.txtQtdFaltas.Location = new System.Drawing.Point(151, 212);
            this.txtQtdFaltas.Name = "txtQtdFaltas";
            this.txtQtdFaltas.PlaceholderText = "Quantidade de Faltas";
            this.txtQtdFaltas.Size = new System.Drawing.Size(230, 23);
            this.txtQtdFaltas.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numNotaCorte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(387, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 52);
            this.panel1.TabIndex = 7;
            // 
            // numNotaCorte
            // 
            this.numNotaCorte.Location = new System.Drawing.Point(17, 21);
            this.numNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotaCorte.Name = "numNotaCorte";
            this.numNotaCorte.Size = new System.Drawing.Size(81, 23);
            this.numNotaCorte.TabIndex = 0;
            this.numNotaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota de Corte";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalcular.Image = global::PrimeiroAplicativo04.Properties.Resources.calculadora;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(151, 320);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnCalcular.Size = new System.Drawing.Size(171, 76);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.MouseHover += new System.EventHandler(this.btnCalcular_MouseHover);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(328, 320);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnLimpar.Size = new System.Drawing.Size(171, 76);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelMediaFinal
            // 
            this.panelMediaFinal.BackColor = System.Drawing.Color.Black;
            this.panelMediaFinal.Controls.Add(this.txtMediaFinal);
            this.panelMediaFinal.Controls.Add(this.label3);
            this.panelMediaFinal.Location = new System.Drawing.Point(151, 241);
            this.panelMediaFinal.Name = "panelMediaFinal";
            this.panelMediaFinal.Size = new System.Drawing.Size(171, 71);
            this.panelMediaFinal.TabIndex = 8;
            this.panelMediaFinal.Visible = false;
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.BackColor = System.Drawing.Color.Black;
            this.txtMediaFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaFinal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMediaFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMediaFinal.Location = new System.Drawing.Point(34, 24);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(100, 36);
            this.txtMediaFinal.TabIndex = 1;
            this.txtMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(50, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Média Final";
            // 
            // pnlAproveitamento
            // 
            this.pnlAproveitamento.BackColor = System.Drawing.Color.Black;
            this.pnlAproveitamento.Controls.Add(this.txtAproveitamento);
            this.pnlAproveitamento.Controls.Add(this.label5);
            this.pnlAproveitamento.Location = new System.Drawing.Point(328, 241);
            this.pnlAproveitamento.Name = "pnlAproveitamento";
            this.pnlAproveitamento.Size = new System.Drawing.Size(171, 71);
            this.pnlAproveitamento.TabIndex = 9;
            this.pnlAproveitamento.Visible = false;
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.BackColor = System.Drawing.Color.Black;
            this.txtAproveitamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAproveitamento.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAproveitamento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAproveitamento.Location = new System.Drawing.Point(33, 24);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(100, 36);
            this.txtAproveitamento.TabIndex = 2;
            this.txtAproveitamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(37, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aproveitamento";
            // 
            // gbSituacao
            // 
            this.gbSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(187)))), ((int)(((byte)(107)))));
            this.gbSituacao.Controls.Add(this.lblSituacao);
            this.gbSituacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSituacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbSituacao.Location = new System.Drawing.Point(151, 410);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(348, 70);
            this.gbSituacao.TabIndex = 16;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            this.gbSituacao.Visible = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(12, 21);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(148, 37);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Aprovado";
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRecuperacao
            // 
            this.gbRecuperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(134)))), ((int)(((byte)(4)))));
            this.gbRecuperacao.Controls.Add(this.txtRecuperacao);
            this.gbRecuperacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRecuperacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbRecuperacao.Location = new System.Drawing.Point(328, 410);
            this.gbRecuperacao.Name = "gbRecuperacao";
            this.gbRecuperacao.Size = new System.Drawing.Size(171, 70);
            this.gbRecuperacao.TabIndex = 17;
            this.gbRecuperacao.TabStop = false;
            this.gbRecuperacao.Text = "Recuperação";
            this.gbRecuperacao.Visible = false;
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(6, 28);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(159, 23);
            this.txtRecuperacao.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimizar.Location = new System.Drawing.Point(572, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizar.TabIndex = 19;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFechar.Location = new System.Drawing.Point(600, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(634, 501);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAproveitamento);
            this.Controls.Add(this.panelMediaFinal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQtdFaltas);
            this.Controls.Add(this.txtQtdAulas);
            this.Controls.Add(this.cboPesoTrabalho);
            this.Controls.Add(this.cboPesoNota2);
            this.Controls.Add(this.cboPesoNota1);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbRecuperacao);
            this.Controls.Add(this.gbSituacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMediaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
            this.panelMediaFinal.ResumeLayout(false);
            this.panelMediaFinal.PerformLayout();
            this.pnlAproveitamento.ResumeLayout(false);
            this.pnlAproveitamento.PerformLayout();
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.gbRecuperacao.ResumeLayout(false);
            this.gbRecuperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtTrabalho;
        private ComboBox cboPesoNota1;
        private ComboBox cboPesoNota2;
        private ComboBox cboPesoTrabalho;
        private TextBox txtQtdAulas;
        private TextBox txtQtdFaltas;
        private Panel panel1;
        private Label label1;
        private Button btnCalcular;
        private Button btnLimpar;
        private Panel panelMediaFinal;
        private Label label3;
        private Panel pnlAproveitamento;
        private Label label5;
        private NumericUpDown numNotaCorte;
        private GroupBox gbSituacao;
        private GroupBox gbRecuperacao;
        private Button btnMinimizar;
        private Button btnFechar;
        private TextBox txtMediaFinal;
        private TextBox txtAproveitamento;
        private TextBox txtRecuperacao;
        private Label lblSituacao;
    }
}