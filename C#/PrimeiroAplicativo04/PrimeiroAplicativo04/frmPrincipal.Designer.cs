﻿namespace PrimeiroAplicativo04
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
            this.btnFisJur = new System.Windows.Forms.Button();
            this.btnVisualizadorImagens = new System.Windows.Forms.Button();
            this.btnTaduada = new System.Windows.Forms.Button();
            this.btnMediaAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Image = global::PrimeiroAplicativo04.Properties.Resources.chatting;
            this.btnMostrarMensagem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarMensagem.Location = new System.Drawing.Point(13, 27);
            this.btnMostrarMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnMostrarMensagem.Size = new System.Drawing.Size(200, 76);
            this.btnMostrarMensagem.TabIndex = 0;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // btnFisJur
            // 
            this.btnFisJur.Image = global::PrimeiroAplicativo04.Properties.Resources.caixa_de_selecao;
            this.btnFisJur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFisJur.Location = new System.Drawing.Point(13, 111);
            this.btnFisJur.Margin = new System.Windows.Forms.Padding(4);
            this.btnFisJur.Name = "btnFisJur";
            this.btnFisJur.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnFisJur.Size = new System.Drawing.Size(200, 76);
            this.btnFisJur.TabIndex = 1;
            this.btnFisJur.Text = "Física x Jurídica";
            this.btnFisJur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFisJur.UseVisualStyleBackColor = true;
            this.btnFisJur.Click += new System.EventHandler(this.btnFisJur_Click);
            // 
            // btnVisualizadorImagens
            // 
            this.btnVisualizadorImagens.Image = global::PrimeiroAplicativo04.Properties.Resources.galeria_de_imagens;
            this.btnVisualizadorImagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizadorImagens.Location = new System.Drawing.Point(13, 195);
            this.btnVisualizadorImagens.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizadorImagens.Name = "btnVisualizadorImagens";
            this.btnVisualizadorImagens.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnVisualizadorImagens.Size = new System.Drawing.Size(200, 76);
            this.btnVisualizadorImagens.TabIndex = 2;
            this.btnVisualizadorImagens.Text = "Visualizador de Imagens";
            this.btnVisualizadorImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizadorImagens.UseVisualStyleBackColor = true;
            this.btnVisualizadorImagens.Click += new System.EventHandler(this.btnVisualizadorImagens_Click);
            // 
            // btnTaduada
            // 
            this.btnTaduada.Image = global::PrimeiroAplicativo04.Properties.Resources.calculadora;
            this.btnTaduada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaduada.Location = new System.Drawing.Point(221, 111);
            this.btnTaduada.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaduada.Name = "btnTaduada";
            this.btnTaduada.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnTaduada.Size = new System.Drawing.Size(200, 76);
            this.btnTaduada.TabIndex = 3;
            this.btnTaduada.Text = "Tabuada";
            this.btnTaduada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaduada.UseVisualStyleBackColor = true;
            this.btnTaduada.Click += new System.EventHandler(this.btnTaduada_Click);
            // 
            // btnMediaAluno
            // 
            this.btnMediaAluno.Image = global::PrimeiroAplicativo04.Properties.Resources.calculadora;
            this.btnMediaAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMediaAluno.Location = new System.Drawing.Point(221, 195);
            this.btnMediaAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btnMediaAluno.Name = "btnMediaAluno";
            this.btnMediaAluno.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.btnMediaAluno.Size = new System.Drawing.Size(200, 76);
            this.btnMediaAluno.TabIndex = 4;
            this.btnMediaAluno.Text = "Média do Aluno";
            this.btnMediaAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMediaAluno.UseVisualStyleBackColor = true;
            this.btnMediaAluno.Click += new System.EventHandler(this.btnMediaAluno_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnMediaAluno);
            this.Controls.Add(this.btnTaduada);
            this.Controls.Add(this.btnVisualizadorImagens);
            this.Controls.Add(this.btnFisJur);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMostrarMensagem;
        private Button btnFisJur;
        private Button btnVisualizadorImagens;
        private Button btnTaduada;
        private Button btnMediaAluno;
    }
}