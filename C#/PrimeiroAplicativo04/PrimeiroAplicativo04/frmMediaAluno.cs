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
    public partial class frmMediaAluno : Form
    {
        public frmMediaAluno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalcular_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*
             * O botão Calcular é o responsável por realizar os cáculos que determinarão
             * se o aluno foi ou não aprovado. 
             * 
             * Vale lembrar que: TextBox e ComboBox possuem valores do tipo String e por isso devem
             * ser convertidos para o tipo int ou double, para que possamos realizar as contas necessárias. 
             */

            //++++++++++ INÍCIO: CÁLCULO DA MÉDIA ++++++++++
                double Nota1, Nota2, Trabalho;
                Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
                Nota2 = double.Parse(txtNota2.Text) * double.Parse(cboPesoNota2.Text);
                Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboPesoTrabalho.Text);
                //Os métodos Convert e Parse realizam exatamente a mesma função

                double Media = Nota1 + Nota2 + Trabalho;

                //Insere o valor da média numa label dentro do panelMediaAluno
                txtMediaFinal.Text = Media.ToString();
            //++++++++++ FIM: CÁLCULO DA MÉDIA ++++++++++

            //++++++++++ INÍCIO: CÁLCULO DO APROVEITAMENTO ++++++++++
                //Pegando a quantidade de aulas e faltas
                double PorcentagemPresenca, Aproveitamento, QtdAulas, QtdFaltas;
                QtdAulas = double.Parse(txtQtdAulas.Text);
                QtdFaltas = double.Parse(txtQtdFaltas.Text);

                //Calcula a porcetagem de aproveitamento do aluno
                PorcentagemPresenca = ((QtdAulas - QtdFaltas) / QtdAulas) * 100;
                //Calcula o aproveitamento do aluno
                Aproveitamento = (Media * 10 + PorcentagemPresenca)/2;

                //Apresentando o percentual de aproveitamento
                txtAproveitamento.Text = Convert.ToString(Aproveitamento) + "%";
            //++++++++++ FIM: CÁLCULO DO APROVEITAMENTO ++++++++++


                //Mostra a média e o aproveitamento do aluno. 
                panelMediaFinal.Visible = true;
                pnlAproveitamento.Visible = true;



        }
    }
}
