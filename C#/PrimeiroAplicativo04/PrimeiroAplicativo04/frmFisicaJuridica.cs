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
    public partial class frmFisicaJuridica : Form
    {
        public frmFisicaJuridica()
        {
            InitializeComponent();
        }

        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true)
            {
                pnlPessoaFisica.Visible = true;
                chkPessoaJuridica.Checked = false;
                pnlPessoaJuridica.Visible = false;

            }
        }

        private void chkPessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
                chkPessoaFisica.Checked = false;
                pnlPessoaFisica.Visible = false;
            }
        }
        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFisicaJuridica_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
