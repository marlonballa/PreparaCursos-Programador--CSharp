namespace PrimeiroAplicativo04
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
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntMostrarMensagem = new System.Windows.Forms.Button();
            this.lblMsgSurprise = new System.Windows.Forms.Label();
            this.pnlCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.pnlCabecalho.Controls.Add(this.btnMinimizar);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Controls.Add(this.label1);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(334, 44);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(272, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(300, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(201, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário: Mostrar Mensagem";
            // 
            // bntMostrarMensagem
            // 
            this.bntMostrarMensagem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bntMostrarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMostrarMensagem.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntMostrarMensagem.ForeColor = System.Drawing.SystemColors.Window;
            this.bntMostrarMensagem.Location = new System.Drawing.Point(103, 145);
            this.bntMostrarMensagem.Name = "bntMostrarMensagem";
            this.bntMostrarMensagem.Size = new System.Drawing.Size(125, 40);
            this.bntMostrarMensagem.TabIndex = 1;
            this.bntMostrarMensagem.Text = "Mostrar Mensagem";
            this.bntMostrarMensagem.UseVisualStyleBackColor = true;
            this.bntMostrarMensagem.Click += new System.EventHandler(this.bntMostrarMensagem_Click);
            // 
            // lblMsgSurprise
            // 
            this.lblMsgSurprise.AutoSize = true;
            this.lblMsgSurprise.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsgSurprise.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMsgSurprise.Location = new System.Drawing.Point(75, 93);
            this.lblMsgSurprise.Name = "lblMsgSurprise";
            this.lblMsgSurprise.Size = new System.Drawing.Size(0, 21);
            this.lblMsgSurprise.TabIndex = 2;
            // 
            // frmMostrarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.lblMsgSurprise);
            this.Controls.Add(this.bntMostrarMensagem);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMostrarMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarMensagem";
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlCabecalho;
        private Label label1;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button bntMostrarMensagem;
        private Label lblMsgSurprise;
    }
}