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
    public partial class frmVisualizadorImagens : Form
    {
        public frmVisualizadorImagens()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK) //Se o usuário clicar em OK -> Confirmando o envio de uma imgaem.
            {

                picboxImagem.Load(ofdImagens.FileName);
                //A Imagem será carregada o OFD indicado. 

            }
        }
    }
}
