using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ModuleOne_Alpha
{
    public partial class _6_1AddDeal : Form
    {
        public _6_1AddDeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void _6_1AddDeal_Load(object sender, EventArgs e)
        {
            DB_1Clients dBCon = new DB_1Clients();

            dataGridView1.DataSource = dBCon.Select();
            dataGridView1.Columns[0].HeaderText = "Имя клиента";

        }
    }
}
