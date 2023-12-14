using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_autenticacao
{
    public partial class FormMDI : Form
    {
        public bool userAutenticado = false;
        public FormMDI()
        {
            InitializeComponent();
        }

        void abrirAvarias()
        {
            if (userAutenticado)
            {
                FormAvarias formAvarias = new FormAvarias();
                formAvarias.MdiParent = this;
                formAvarias.Show();
            }
            else
            {
                MessageBox.Show("É necessário fazer Login para aceder a este menu.", "Autenticação necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void abrirProdutos()
        {
            if (userAutenticado)
            {
                FormProdutos formProdutos = new FormProdutos();
                formProdutos.MdiParent = this;
                formProdutos.Show();
            }
            else
            {
                MessageBox.Show("É necessário fazer Login para aceder a este menu.", "Autenticação necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.MdiParent = this;
            formLogin.Show();

            if (formLogin.userAutenticado)
            {
                userAutenticado = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //CAMPO INUTIL
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormProdutos formProdutos = new FormProdutos();
            formProdutos.MdiParent = this;
            formProdutos.Show();*/
            abrirProdutos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CAMPO INUTIL
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormProdutos formProdutos = new FormProdutos();
            formProdutos.MdiParent = this;
            formProdutos.Show();*/
            abrirProdutos();
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormAvarias formAvarias = new FormAvarias();
            formAvarias.MdiParent = this;
            formAvarias.Show();*/
            abrirAvarias();
        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormAvarias formAvarias = new FormAvarias();
            formAvarias.MdiParent = this;
            formAvarias.Show();*/
            abrirAvarias();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            /*FormAvarias formAvarias = new FormAvarias();
            formAvarias.MdiParent = this;
            formAvarias.Show();*/
            abrirAvarias();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void vendasMensaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }
    }
}
