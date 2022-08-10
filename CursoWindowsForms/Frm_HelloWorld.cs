namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbl_ModificaTexto_Click(object sender, EventArgs e)
        {
            this.Lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }
    }
}