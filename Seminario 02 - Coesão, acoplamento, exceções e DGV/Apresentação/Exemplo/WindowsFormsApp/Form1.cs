using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pessoa.Dados;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
       private int i= 0;
       private Dados[] cadastro = new Dados[1]; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var novo = new Dados()
            {
                Nome = tbNome.Text,
                Idade = Convert.ToInt16(tbIdade.Text)
            };
            cadastro[i] = novo;
            dgvDados.DataSource = cadastro;
            i++;

            Array.Resize(ref cadastro, i + 1);

            tbNome.Text = null;
            tbIdade.Text = null;


        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // centralizar os dados das colunas
            dgvDados.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDados.Columns["Idade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // mudar o tamanho da coluna
            dgvDados.Columns["Idade"].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtMostra1.Visible = true;
            txtMostrar2.Visible = true;
            txtMostra1.Text= dgvDados.CurrentRow.Cells[0].Value.ToString();
            txtMostrar2.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();

        }

        private void txtAlteracao_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
