using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lnc
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id, string nome,string telefone)
        {
            IdCliente = id;
            Nome = nome;
            Telefone = telefone;
        }
        public bool SalvarDados(List<Cliente> cliente, string path)
        {
            var strJson = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            return SalvarArquivos(strJson, path);
        }
        public bool SalvarArquivos(string strJson, string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
                return false;
            }
        }
    }
}
