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
    public partial class FormLogin : Form
    {
        public bool userAutenticado {  get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        void Limpar()
        {
            //função para limpar conteudo das textBox
            textBox1.Clear();
            textBox2.Clear();
            textBoxNome.Clear();
        }
        
        void Autenticacao()
        {
            //função de autenticação
            string nome = "Paulo Barreira";
            string user = "AdminTOP";
            string pass = "Secret@";
            

            //verifica se as textBox não estão vazias
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                //compara os dados de login
                if (textBox1.Text.Equals(user) && textBox2.Text.Equals(pass) && textBoxNome.Text.Equals(nome))
                {
                    MessageBox.Show("Login realizado com sucesso!", "Login status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userAutenticado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha na autenticação! Dados de login errados.", "Login status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERRO! Campos de introdução vazios.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Falha na autenticação! Dados de login errados.", "Login status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void lblLOGIN_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            Limpar();
            /*textBox1.Clear();
            textBox2.Clear();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void btnVALIDAR_Click(object sender, EventArgs e)
        {
            Autenticacao();
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
