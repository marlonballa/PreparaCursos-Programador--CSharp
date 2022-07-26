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
    public partial class frmConversorTemperatura : Form
    {
        public frmConversorTemperatura()
        {
            InitializeComponent();
        }

        private void frmConversorTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            //++++++++++ INÍCIO: CONVERSÃO DE CELSIUS ++++++++++
            if (rbCelsius.Checked == true)
            {
                if (rbKelvinSaida.Checked == true) { txtResultado.Text = (valor + 273.15).ToString("F") + "K"; }
                else if (rbFarenheitSaida.Checked == true) { txtResultado.Text = (valor * 1.8 + 32).ToString("F") + "F"; }
                else { MessageBox.Show("Não é possível converter um valor para ele mesmo. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            //++++++++++ FIM: CONVERSÃO DE CELSIUS ++++++++++
            //++++++++++ INÍCIO: CONVERSÃO DE FARENHEIT ++++++++++
            if (rbFarenheit.Checked == true)
            {
                if (rbKelvinSaida.Checked == true) { txtResultado.Text = (((valor -32)*5/9) + 273.15).ToString("F") + "K"; }
                else if (rbCelsiusSaida.Checked == true) { txtResultado.Text = ((valor - 32)*5/9).ToString("F") + "°C"; }
                else { MessageBox.Show("Não é possível converter um valor para ele mesmo. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            //++++++++++ FIM: CONVERSÃO DE FARENHEIT ++++++++++
            //++++++++++ INÍCIO: CONVERSÃO DE KELVIN ++++++++++
            if (rbKelvin.Checked == true)
            {
                if (rbCelsiusSaida.Checked == true) { txtResultado.Text = (valor - 273.15).ToString("F") + "ºC"; }
                else if (rbFarenheitSaida.Checked == true) { txtResultado.Text = (valor * 1.8 - 459.67).ToString("F") + "°F"; }
                else { MessageBox.Show("Não é possível converter um valor para ele mesmo. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            //++++++++++ FIM: CONVERSÃO DE KELVIN ++++++++++
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Text = "";
            foreach (Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
        }

        private void frmConversorTemperatura_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
