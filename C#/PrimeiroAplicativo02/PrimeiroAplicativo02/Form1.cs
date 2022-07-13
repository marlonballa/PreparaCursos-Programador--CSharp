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
            //Instanciando o formulário que deverá aparecer ao clicar nesse botão
            frmPropriedadeCheckBox propriedadeCheckBox = new frmPropriedadeCheckBox();
            //Em orientação a Objetos existem as atributos e os métodos
            //Os métodos são funcionalidades que podem ser executadas pelo objeto
            //Enquanto os atributos são as caracteristicas natas daquele objeto. 
            propriedadeCheckBox.ShowDialog();
            //O método ShowDialog() chama e mostra o formulário, mantendo o foco nele. 
            //Sem encerrar o formulário que já estava aberto.


        }
    }
}