namespace PrimeiroAplicativo04
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
           frmMostrarMensagem frmMostrarMensagem = new frmMostrarMensagem();
           frmMostrarMensagem.ShowDialog();
        }

        private void btnFisJur_Click(object sender, EventArgs e)
        {
            frmFisicaJuridica frmFisicaJuridica = new frmFisicaJuridica();
            frmFisicaJuridica.ShowDialog();
        }
    }
}