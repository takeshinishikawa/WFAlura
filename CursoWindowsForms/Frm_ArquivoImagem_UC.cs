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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivo)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivo;//inclui o nome do arquivo na label
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivo);//insere dentro do PictureBox a imagem contida no arquivo apontado
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDB = new ColorDialog();
            if (CDB.ShowDialog() == DialogResult.OK)//caso o usuário tenha selecionado uma cor e dado ok
                Lbl_ArquivoImagem.ForeColor = CDB.Color;//a cor do label será alterada pela cor selecionada
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDB = new FontDialog();
            if (FDB.ShowDialog() == DialogResult.OK)
                Lbl_ArquivoImagem.Font = FDB.Font;
        }
    }
}
