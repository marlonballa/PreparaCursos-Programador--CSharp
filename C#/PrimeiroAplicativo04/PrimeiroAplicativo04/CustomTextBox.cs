using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAplicativo04
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        //Propriedades:

        //Cor da Borda
        private Color borderColor = Color.MediumSlateBlue;
        //Tamanho da borda
        private int borderSize = 2;
        //Estilo da caixa de texto
        private bool underlinedStyle = false;
        //Cor da borda selecionada
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false; 


        //Métodos Get e Set das propriedades
        [Category("Custom")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); }}
        [Category("Custom")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); }}
        [Category("Custom")] 
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); }}
        [Category("Custom")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }


        //Permitindo que a TextBox seja usada para receber senhas
        [Category("Custom")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar;  }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Custom")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        //Altera a cor de fundo do forms criado e da textbox que está dentro dele
        [Category("Custom")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; }}

        //Altera a cor do texto que aparecerá na textobox
        [Category("Custom")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; }}

        //Altera a fonte do texto e também a altura da textbox
        [Category("Custom")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value; textBox1.Font = value;
                if (this.DesignMode) { UpdateControlHeigth(); }
            }
        }

        [Category("Custom")]
        public string Texts
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        //Substituindo os métodos dos eventos padrões pelos novos. 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Desenhando a borda
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underlinedStyle) //Estilo de linha
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Estilo Normal
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                } 
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Estilo de linha
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Estilo Normal
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
  
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeigth(); 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeigth();
        }

        //Define uma altura adequada para a caixa de texto e impede sua alteração, desde que a caixa de texto não seja multilinha.
        //Caso seja, irá se adequar a quantidade de linhas que a caixa possui. 
        private void UpdateControlHeigth()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeigth = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeigth);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //Método Construtor
        public CustomTextBox()
        {
            InitializeComponent();
        }

        //Evento ao dar dois cliques na TextBox
        public event EventHandler _TextChanged; 


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }


        private void CustomTextBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void CustomTextBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void CustomTextBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void CustomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void CustomTextBox_Load(object sender, EventArgs e)
        {

        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

    }
}
