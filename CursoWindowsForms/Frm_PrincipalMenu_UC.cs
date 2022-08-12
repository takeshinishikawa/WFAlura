using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_PrincipalMenu_UC : Form
    {
        int ControlDK = 0;
        int ControlHelloWorld = 0;
        int ControlMascara = 0;
        int ControlValidaCPF = 0;
        int ControlValidaCPF2 = 0;
        int ControlValidaSenha = 0;
        int ControlArquivoImagem = 0;

        public Frm_PrincipalMenu_UC()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlDK++;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demonstração Key " + ControlDK;
            TB.Text = "Demonstração Key " + ControlDK;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlHelloWorld++;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC(); //instanciar o objeto UC
            U.Dock = DockStyle.Fill;//ajusta o Form para o espaço disponível dentro do TabControl
            TabPage TB = new TabPage(); //instanciar uma nova TabPage
            TB.Name = "Hello World " + ControlHelloWorld;// Definir o nome da TabPage
            TB.Text = "Hello World " + ControlHelloWorld;//Definir o nome que irá aparecer na aba
            TB.ImageIndex = 1;//Incluir agora 'no TB o índice da imageList que deverá ser incluída na Tab
            TB.Controls.Add(U);//Controls define quais os componentes que estarão contidos dentro da TabPage criada
            Tbc_Aplicacoes.TabPages.Add(TB);//Inserir dentro do TabControl a TabPage criada que contém o formulário UC
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlMascara++;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Mascara " + ControlMascara;
            TB.Text = "Mascara " + ControlMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaCPF++;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControlValidaCPF;
            TB.Text = "Valida CPF " + ControlValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaCPF2++;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF 2 " + ControlValidaCPF2;
            TB.Text = "Valida CPF 2 " + ControlValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaSenha++;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControlValidaSenha;
            TB.Text = "Valida Senha " + ControlValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);//Remove da TabControl a Tab que estiver selecionada
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();//instancia um obj do tipo OpenFileDialog
            Db.InitialDirectory = "C:\\Users\\takes\\source\\repos\\Windows-Forms\\CursoWindowsForms\\Icones_Imagens\\";//Busca à partir da pasta indicada
            Db.Filter = "PNG|*.PNG";//Filtra para que sejam apresentados somente itens no formato PNG
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;
                
                ControlArquivoImagem++;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControlArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControlArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();
        }
    }
}