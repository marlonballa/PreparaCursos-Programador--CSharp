using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAplicativo02
{
    public partial class frmPropriedadeCheckBox : Form
    {
        public frmPropriedadeCheckBox()
        {
            InitializeComponent();
        }

        //Evento CheckStateChange -> Verifica se o CheckBox está marcado e realiza uma ação.
        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            //Vamos verificar se o CheckBox - Pessoa Física, está marcado.
            if(chkPessoaFisica.Checked == true)
            {
                //Alteramos o valor da Propriedade Visible para True, o que permitirá que ela apareceça na tela.
                pnlPessoaFisica.Visible = true;
                chkPessoaJuridica.Checked = false;
            } else
            {
                //Alteramos o valor da Propriedade Visible para Falso, o que fará que ela apareceça na tela quando o chkPessoaFisica for desmarcado.
                pnlPessoaFisica.Visible = false;
            }
        }

        private void chkPessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if(chkPessoaJuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
                chkPessoaFisica.Checked = false;
            } else
            {
                pnlPessoaJuridica.Visible = false; 
            }
        }
    }
}
