using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel; 

namespace PrimeiroAplicativo04
{
    class CircularPictureBox : PictureBox
    {
        //Configurações de Estilo
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        //Método Construtor
        public CircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        //Métodos Geters e Setters de cada propriedade. 
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); }}
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color BorderColor2 { get => borderColor2; set { borderColor2 = value; this.Invalidate();}}
        public DashStyle BorderLineStyle { get => borderLineStyle; set { borderLineStyle = value; this.Invalidate();}}
        public DashCap BorderCapStyle { get => borderCapStyle; set { borderCapStyle = value; this.Invalidate();}}
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate();}}

        //Método Overridden
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectCountourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectCountourSmooth, -borderSize, borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath()) 
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize)) 
            using (var penBorder = new Pen(borderGColor, borderSize)) 
            {
                penBorder.DashStyle = BorderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectCountourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                //Desenhando
                graph.DrawEllipse(penSmooth, rectCountourSmooth); 
                if (borderSize > 0)
                {
                    graph.DrawEllipse(penBorder, rectBorder);
                }
            }


        }

    }
}
