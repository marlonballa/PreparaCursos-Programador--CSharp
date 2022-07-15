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

                btnShowImage.Enabled = false;
                btnCleanImage.Enabled = true;
                //Desabilita o botão "Mostrar Imagem" para que o usuário não possa colocar imagem sobre imagem. 

            }
        }

        private void btnCleanImage_Click(object sender, EventArgs e)
        {
            //Define como nula a propriedade Imagem da pictureBox
            picboxImagem.Image = null;
            btnShowImage.Enabled = true;
            btnCleanImage.Enabled = false;

        }

        private void frmVisualizadorImagens_Load(object sender, EventArgs e)
        {
            /*
             Como não existe nenhuma imagem carregada quando a aplicação começa, o botão "limpar Imagem" deve ficar desabilitado.
             */
            btnCleanImage.Enabled=false;
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            /**
                Identifica se o radioButton que indica o Stretch está marcado, se estiver aplica este formato de imagem para 
            a imagem que está aparecendo.
             */
            if (rbStretch.Checked == true)
            {
                picboxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            /**
                Identifica se o radioButton que indica o Normal está marcado, se estiver aplica este formato de imagem para 
            a imagem que está aparecendo.
            */
            if (rbNormal.Checked == true)
            {
                picboxImagem.SizeMode = PictureBoxSizeMode.Normal; 
            }
        }
    }
}
