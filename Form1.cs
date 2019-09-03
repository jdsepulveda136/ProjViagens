using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjViagens
{
    public partial class Form1 : Form
    {
        MyGetData dados = new MyGetData();

        public Form1()
        {
            InitializeComponent();

            string query = "select * from veiculo";

            cmb_veiculo.DataSource = dados.BuscaDados(query);
            cmb_veiculo.DisplayMember = "matricula";
            cmb_veiculo.ValueMember = "id";

            dataGridView1.DataSource = dados.BuscaDados(query);

        }

        private void Bt_calcula_Click(object sender, EventArgs e)
        {
            string veiculo = Convert.ToString(cmb_veiculo.SelectedValue);

            string query = "select sum(kilometros) from viagem where cod_veiculo='" + veiculo + "'";

            DataTable result = dados.BuscaDados(query);

            txt_result.Text = Convert.ToString(result.Rows[0][0]);
        }

        private void Bt_copia_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_result.Text);
        }

        private void Bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
