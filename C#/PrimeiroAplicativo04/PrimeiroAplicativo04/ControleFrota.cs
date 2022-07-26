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
    public partial class frmControleFrota : Form
    {
        public frmControleFrota()
        {
            InitializeComponent();
        }

        public class Veiculo
        {
            private string modelo, placa, Km;

            public void gravarModelo(string modelo)
            {
                this.modelo = modelo;
            }

            public string mostrarModelo()
            {
                return modelo;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Veiculo newCar = new Veiculo();

            //Pega as informações que o usuário insere. 
            newCar.gravarModelo(txtModelo.Text);
            newCar.placa = txtPlaca.Text;
            newCar.Km = txtKM.Text;

            //Apresenta as informações na tela.
            txtVeiculos.Text += newCar.modelo + "\t";
            txtVeiculos.Text += newCar.placa + "\t";
            txtVeiculos.Text += newCar.Km + "\r\n";

        }

        private void frmControleFrota_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewTruck_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Changed");
        }

        private void txtModelo__TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
}
