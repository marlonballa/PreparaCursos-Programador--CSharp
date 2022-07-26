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

        //Responsável por especificar os objetos que farão parte que representarão a frota de carros. 
        public class Veiculo
        {
            private string modelo, placa, Km;

            //+++++ INICIO - Informações de Modelo
                public void gravarModelo(string modelo) { this.modelo = modelo;}
                public string mostrarModelo() { return modelo; }
            //+++++ FIM - Informações de Modelo

            //+++++ INICIO - Informações de Placa
                public void gravarPlaca(string placa) { this.placa = placa; }
                public string mostrarPlaca() { return placa; }
            //+++++ FIM - Informações de Placa

            //+++++ INICIO - Informações de KM
                public void gravarKm(string Km) { this.Km = Km; }
                public string mostrarKm() { return Km; }
            //+++++ FIM - Informações de KM



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Instanciando a classe Veiculos
            Veiculo newCar = new Veiculo();

            //Pega as informações que o usuário insere. 
            newCar.gravarModelo(txtModelo.Text);
            newCar.gravarPlaca(txtPlaca.Text);
            newCar.gravarKm(txtKM.Text);

            //Apresenta as informações na tela.
            txtVeiculos.Text += newCar.mostrarModelo() + "\t";
            txtVeiculos.Text += newCar.mostrarPlaca() + "\t";
            txtVeiculos.Text += newCar.mostrarKm() + "\r\n";

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
