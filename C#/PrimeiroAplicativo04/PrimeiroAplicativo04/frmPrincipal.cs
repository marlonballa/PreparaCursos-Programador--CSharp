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

        private void btnVisualizadorImagens_Click(object sender, EventArgs e)
        {
            frmVisualizadorImagens frmVisualizadorImagens = new frmVisualizadorImagens();
            frmVisualizadorImagens.ShowDialog();   
        }

        private void btnTaduada_Click(object sender, EventArgs e)
        {
            frmTabuada frmTabuada = new frmTabuada();
            frmTabuada.ShowDialog();
        }

        private void btnMediaAluno_Click(object sender, EventArgs e)
        {
            frmMediaAluno frmMediaAluno = new frmMediaAluno();
            frmMediaAluno.ShowDialog();
        }
    }
}