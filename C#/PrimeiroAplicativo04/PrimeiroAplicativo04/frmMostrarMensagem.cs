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
    public partial class frmMostrarMensagem : Form
    {
        public frmMostrarMensagem()
        {
            InitializeComponent();
        }

        private void bntMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "BEM-VINDO AO CURSO DE C#";
            lblMensagem.ForeColor = Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
