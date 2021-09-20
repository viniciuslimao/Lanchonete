using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lnc
{
    public partial class Form1 : Form
    {
        Cliente c = new Cliente();
        List<Cliente> listarCliente = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }
        private void CarregarDados()
        {
            var MaxId = listarCliente.Max(x => x.IdCliente);
            c.IdCliente = MaxId + 1;
            c.Nome = textBoxNome.Text;
            c.Telefone = textBoxTel.Text;
            listarCliente.Add(c);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listarCliente;
        }
        //public void CarregarDados()
        //{
        //    c.IdCliente = int.Parse(textBoxId.Text);
        //    c.Nome = textBoxNome.Text;
        //    c.Telefone = textBoxTel.Text;
        //    listarCliente.Add(c);

        //    dataGridView1.DataSource = "";
        //    dataGridView1.DataSource = listarCliente;
        //}

        private void ExibirDados()
        {
           listarCliente = Cliente.carregarCliente(@"C:/Bd/BdCliente.json");
           dataGridView1.DataSource = listarCliente;
        }
        private void buttonCad_Click(object sender, EventArgs e)
        {
            CarregarDados();
            

            if (c.SalvarDados(listarCliente, @"C:/Bd/BdCliente.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textBoxId.Text = "";
            textBoxNome.Text = "";
            textBoxTel.Text = "";
        }

        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxId.Text = gridViewRow.Cells[0].Value.ToString();
                textBoxNome.Text = gridViewRow.Cells[1].Value.ToString();
                textBoxTel.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var elem = listarCliente.Where<Cliente>(x => x.IdCliente == id).FirstOrDefault();
            int index = listarCliente.IndexOf(elem);

            listarCliente[index].Nome = textBoxNome.Text;
            listarCliente[index].Telefone = textBoxTel.Text;
            if (c.SalvarDados(listarCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados Salvos");
            }
            ExibirDados();
            textBoxNome.Text = "";
            textBoxTel.Text = "";
        }

        private void buttonExc_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            var elem = listarCliente.Where<Cliente>(x => x.IdCliente == id).FirstOrDefault();
            listarCliente.Remove(elem);

            if (c.SalvarDados(listarCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados Excluidos");
            }
            ExibirDados();
        }
    }
}
