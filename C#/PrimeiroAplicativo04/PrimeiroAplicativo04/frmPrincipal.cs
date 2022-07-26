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
           this.Hide();
           /*
            * Forma alternativa de instanciar um novo formulário e chamar um método de sua classe:
            * (new nomeForm()).Show(); 
            * Neste caso realizamos todo o processo em apenas uma linha. 
            */
           frmMostrarMensagem frmMostrarMensagem = new frmMostrarMensagem();
           frmMostrarMensagem.Show();
        }

        private void btnFisJur_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFisicaJuridica frmFisicaJuridica = new frmFisicaJuridica();
            frmFisicaJuridica.Show();
        }

        private void btnVisualizadorImagens_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVisualizadorImagens frmVisualizadorImagens = new frmVisualizadorImagens();
            frmVisualizadorImagens.Show();   
        }

        private void btnTaduada_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada frmTabuada = new frmTabuada();
            frmTabuada.Show();
        }

        private void btnMediaAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMediaAluno frmMediaAluno = new frmMediaAluno();
            frmMediaAluno.Show();
     
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pnlUserInformations_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConversorTemperatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConversorTemperatura frmConversorTemperatura = new frmConversorTemperatura();
            frmConversorTemperatura.Show();
        }

        private void btnControleFrota_Click(object sender, EventArgs e)
        {
            frmControleFrota frmControleFrota = new frmControleFrota();
            frmControleFrota.Show();
        }
    }
}