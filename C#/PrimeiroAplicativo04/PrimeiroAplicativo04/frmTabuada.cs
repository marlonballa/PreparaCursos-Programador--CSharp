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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
        }

        private void frmTabuada_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                MessageBox.Show("Clique no botão 'Limpar' para inserir novos valores.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNumero.Text == "" || txtNumero.Text == "Tabuada do:")
            {
                MessageBox.Show("Por favor, digite um número para calcularmos sua tabuada.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                double numero, resultado, limite;
                numero = double.Parse(txtNumero.Text);
                limite =  double.Parse(txtLimite.Text);

                for (int i = 0; i <= limite; i++)
                {
                    resultado = numero * i;
                    txtResultado.Text += numero + " X " + i + " = " + resultado.ToString() + "\r\n";
                }

                btnLimpar.Enabled = true;
                txtResultado.Enabled = true;
            }
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLimite_Click(object sender, EventArgs e)
        {
            txtLimite.Text = "";
        }

        //Responsável por limpar o conteúdo presente nos TextBox.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "Tabuada do:";
            txtLimite.Text = "Quero até:";
            txtResultado.Text = "";
            txtResultado.Enabled = false;
        }

        private void frmTabuada_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
        }
    }
}
