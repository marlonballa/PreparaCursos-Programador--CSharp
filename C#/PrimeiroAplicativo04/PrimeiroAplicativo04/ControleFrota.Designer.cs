namespace PrimeiroAplicativo04
{
    partial class frmControleFrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleFrota));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewTruck = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnAddNewCar = new System.Windows.Forms.PictureBox();
            this.lblCarros = new System.Windows.Forms.Label();
            this.lblTrucks = new System.Windows.Forms.Label();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtVeiculos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewTruck
            // 
            this.btnAddNewTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTruck.Image")));
            this.btnAddNewTruck.Location = new System.Drawing.Point(117, 127);
            this.btnAddNewTruck.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewTruck.Name = "btnAddNewTruck";
            this.btnAddNewTruck.Size = new System.Drawing.Size(64, 64);
            this.btnAddNewTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNewTruck.TabIndex = 2;
            this.btnAddNewTruck.TabStop = false;
            this.btnAddNewTruck.Click += new System.EventHandler(this.btnAddNewTruck_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(208, 127);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 64);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 3;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCar.Image")));
            this.btnAddNewCar.Location = new System.Drawing.Point(26, 127);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(64, 64);
            this.btnAddNewCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNewCar.TabIndex = 3;
            this.btnAddNewCar.TabStop = false;
            // 
            // lblCarros
            // 
            this.lblCarros.AutoSize = true;
            this.lblCarros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCarros.Location = new System.Drawing.Point(37, 191);
            this.lblCarros.Name = "lblCarros";
            this.lblCarros.Size = new System.Drawing.Size(47, 17);
            this.lblCarros.TabIndex = 4;
            this.lblCarros.Text = "Carros";
            // 
            // lblTrucks
            // 
            this.lblTrucks.AutoSize = true;
            this.lblTrucks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrucks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrucks.Location = new System.Drawing.Point(113, 191);
            this.lblTrucks.Name = "lblTrucks";
            this.lblTrucks.Size = new System.Drawing.Size(72, 17);
            this.lblTrucks.TabIndex = 5;
            this.lblTrucks.Text = "Caminhões";
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSalvar.Location = new System.Drawing.Point(219, 191);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(43, 17);
            this.lblSalvar.TabIndex = 5;
            this.lblSalvar.Text = "Salvar";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(26, 236);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PlaceholderText = "Modelo";
            this.txtModelo.Size = new System.Drawing.Size(246, 23);
            this.txtModelo.TabIndex = 6;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(26, 265);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PlaceholderText = "Placa";
            this.txtPlaca.Size = new System.Drawing.Size(246, 23);
            this.txtPlaca.TabIndex = 7;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(26, 294);
            this.txtKM.Name = "txtKM";
            this.txtKM.PlaceholderText = "KM";
            this.txtKM.Size = new System.Drawing.Size(122, 23);
            this.txtKM.TabIndex = 7;
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(150, 294);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.PlaceholderText = "Eixos";
            this.txtEixos.Size = new System.Drawing.Size(122, 23);
            this.txtEixos.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 334);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 334);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // txtVeiculos
            // 
            this.txtVeiculos.Location = new System.Drawing.Point(26, 413);
            this.txtVeiculos.Multiline = true;
            this.txtVeiculos.Name = "txtVeiculos";
            this.txtVeiculos.Size = new System.Drawing.Size(246, 246);
            this.txtVeiculos.TabIndex = 11;
            this.txtVeiculos.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // frmControleFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(304, 681);
            this.Controls.Add(this.txtVeiculos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtEixos);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblTrucks);
            this.Controls.Add(this.lblCarros);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNewTruck);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControleFrota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleFrota";
            this.Load += new System.EventHandler(this.frmControleFrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnAddNewTruck;
        private PictureBox btnSave;
        private PictureBox btnAddNewCar;
        private Label lblCarros;
        private Label lblTrucks;
        private Label lblSalvar;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private TextBox txtKM;
        private TextBox txtEixos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtVeiculos;
    }
}