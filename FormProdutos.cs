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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }
        void Inicial()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBoxCategorias.Items.Clear();
            comboBoxCategorias.Items.Add("Software");
            comboBoxCategorias.Items.Add("Hardware");
            comboBoxCategorias.Sorted = true;

            listBox1.Items.Clear();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            Inicial();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //CAMPO INUTIL
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
