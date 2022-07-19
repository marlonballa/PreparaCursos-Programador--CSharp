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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrimeiroAplicativo04.Properties.Resources.logoPrepara;
            this.pictureBox2.Location = new System.Drawing.Point(175, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(151, 140);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(0);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PlaceholderText = "Primeira Nota";
            this.txtNota1.Size = new System.Drawing.Size(112, 23);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(269, 140);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(0);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PlaceholderText = "Segunda Nota";
            this.txtNota2.Size = new System.Drawing.Size(112, 23);
            this.txtNota2.TabIndex = 1;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(387, 140);
            this.txtTrabalho.Margin = new System.Windows.Forms.Padding(0);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.PlaceholderText = "Nota do Trabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(112, 23);
            this.txtTrabalho.TabIndex = 1;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTrabalho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboPesoNota1
            // 
            this.cboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota1.FormattingEnabled = true;
            this.cboPesoNota1.Items.AddRange(new object[] {
            "20%;",
            "30%",
            "50%"});
            this.cboPesoNota1.Location = new System.Drawing.Point(151, 166);
            this.cboPesoNota1.Name = "cboPesoNota1";
            this.cboPesoNota1.Size = new System.Drawing.Size(112, 23);
            this.cboPesoNota1.TabIndex = 2;
            // 
            // cboPesoNota2
            // 
            this.cboPesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota2.FormattingEnabled = true;
            this.cboPesoNota2.Items.AddRange(new object[] {
            "20%;",
            "30%",
            "50%"});
            this.cboPesoNota2.Location = new System.Drawing.Point(269, 166);
            this.cboPesoNota2.Name = "cboPesoNota2";
            this.cboPesoNota2.Size = new System.Drawing.Size(112, 23);
            this.cboPesoNota2.TabIndex = 2;
            // 
            // cboPesoTrabalho
            // 
            this.cboPesoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoTrabalho.FormattingEnabled = true;
            this.cboPesoTrabalho.Items.AddRange(new object[] {
            "20%;",
            "30%",
            "50%"});
            this.cboPesoTrabalho.Location = new System.Drawing.Point(387, 166);
            this.cboPesoTrabalho.Name = "cboPesoTrabalho";
            this.cboPesoTrabalho.Size = new System.Drawing.Size(112, 23);
            this.cboPesoTrabalho.TabIndex = 2;
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(151, 195);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.PlaceholderText = "Quantidade de Aulas";
            this.txtQtdAulas.Size = new System.Drawing.Size(230, 23);
            this.txtQtdAulas.TabIndex = 5;
            this.txtQtdAulas.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtQtdFaltas
            // 
            this.txtQtdFaltas.Location = new System.Drawing.Point(151, 224);
            this.txtQtdFaltas.Name = "txtQtdFaltas";
            this.txtQtdFaltas.PlaceholderText = "Quantidade de Faltas";
            this.txtQtdFaltas.Size = new System.Drawing.Size(230, 23);
            this.txtQtdFaltas.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numNotaCorte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(387, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 52);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota de Corte";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::PrimeiroAplicativo04.Properties.Resources.calculadora;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(151, 331);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnCalcular.Size = new System.Drawing.Size(171, 76);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(328, 334);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnLimpar.Size = new System.Drawing.Size(171, 73);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(151, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 71);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota de Corte";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(328, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 71);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aproveitamento";
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
            this.numNotaCorte.TabIndex = 1;
            this.numNotaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // frmMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.Name = "frmMediaAluno";
            this.Text = "Média Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
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
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private NumericUpDown numNotaCorte;
    }
}