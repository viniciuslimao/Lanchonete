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
        }
        public void CarregarDados()
        {
            c.IdCliente = int.Parse(textBoxId.Text);
            c.Nome = textBoxNome.Text;
            c.Telefone = textBoxTel.Text;
            listarCliente.Add(c);

            dataGridView1.DataSource = "";
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
    }
}
