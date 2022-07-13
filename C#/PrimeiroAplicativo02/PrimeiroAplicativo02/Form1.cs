namespace PrimeiroAplicativo02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Primeiro Aplicativo com C#";
            lblMensagem.ForeColor = Color.RoyalBlue;
        }

        private void btnChamarFormulario_Click(object sender, EventArgs e)
        {
            //Instanciando o formul�rio que dever� aparecer ao clicar nesse bot�o
            frmPropriedadeCheckBox propriedadeCheckBox = new frmPropriedadeCheckBox();
            //Em orienta��o a Objetos existem as atributos e os m�todos
            //Os m�todos s�o funcionalidades que podem ser executadas pelo objeto
            //Enquanto os atributos s�o as caracteristicas natas daquele objeto. 
            propriedadeCheckBox.ShowDialog();
            //O m�todo ShowDialog() chama e mostra o formul�rio, mantendo o foco nele. 
            //Sem encerrar o formul�rio que j� estava aberto.


        }
    }
}