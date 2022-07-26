namespace PrimeiroAplicativo04
{
    partial class frmVisualizadorImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizadorImagens));
            this.picboxMoldura = new System.Windows.Forms.PictureBox();
            this.picboxImagem = new System.Windows.Forms.PictureBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.btnCleanImage = new System.Windows.Forms.Button();
            this.ofdImagens = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMoldura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxMoldura
            // 
            this.picboxMoldura.Image = global::PrimeiroAplicativo04.Properties.Resources.Aesthetic_Frame_PNG_Picture;
            this.picboxMoldura.Location = new System.Drawing.Point(5, -22);
            this.picboxMoldura.Name = "picboxMoldura";
            this.picboxMoldura.Size = new System.Drawing.Size(720, 715);
            this.picboxMoldura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMoldura.TabIndex = 0;
            this.picboxMoldura.TabStop = false;
            // 
            // picboxImagem
            // 
            this.picboxImagem.Location = new System.Drawing.Point(109, 78);
            this.picboxImagem.Name = "picboxImagem";
            this.picboxImagem.Size = new System.Drawing.Size(509, 499);
            this.picboxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImagem.TabIndex = 1;
            this.picboxImagem.TabStop = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(748, 25);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(65, 19);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Location = new System.Drawing.Point(748, 50);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(62, 19);
            this.rbStretch.TabIndex = 3;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.rbStretch_CheckedChanged);
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(748, 107);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(116, 23);
            this.btnShowImage.TabIndex = 4;
            this.btnShowImage.Text = "Mostrar Imagem";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnCleanImage
            // 
            this.btnCleanImage.Location = new System.Drawing.Point(748, 78);
            this.btnCleanImage.Name = "btnCleanImage";
            this.btnCleanImage.Size = new System.Drawing.Size(116, 23);
            this.btnCleanImage.TabIndex = 5;
            this.btnCleanImage.Text = "Limpar Imagem";
            this.btnCleanImage.UseVisualStyleBackColor = true;
            this.btnCleanImage.Click += new System.EventHandler(this.btnCleanImage_Click);
            // 
            // ofdImagens
            // 
            this.ofdImagens.FileName = "openFileDialog1";
            // 
            // frmVisualizadorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 681);
            this.Controls.Add(this.btnCleanImage);
            this.Controls.Add(this.btnShowImage);
            this.Controls.Add(this.rbStretch);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.picboxImagem);
            this.Controls.Add(this.picboxMoldura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVisualizadorImagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Imagens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVisualizadorImagens_FormClosing);
            this.Load += new System.EventHandler(this.frmVisualizadorImagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMoldura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picboxMoldura;
        private PictureBox picboxImagem;
        private RadioButton rbNormal;
        private RadioButton rbStretch;
        private Button btnShowImage;
        private Button btnCleanImage;
        private OpenFileDialog ofdImagens;
    }
}