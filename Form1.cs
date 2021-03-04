using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfaUtils;

namespace TesteBD
{
    public partial class Form1 : Form
    {

        private string SC =
                    "data source = DOMINGOS\\SQLEXPRESS;" +
                    "Initial Catalog = testes;" +
                    "User Id=sa;" +
                    "Password=123.Abc.@;";

        private string SSQL = "select * from TNomes;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Conecta c = new Conecta();
            dt = c.BuscarDados(SC, SSQL);
            dataGridView1.DataSource = dt;
        }
    }
}
