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
    public partial class _6_2Payment : Form
    {
        public _6_2Payment()
        {
            InitializeComponent();
        }

        private void _6_2Payment_Load(object sender, EventArgs e)
        {

            DB_6Deals dBCon = new DB_6Deals();

            dataGridView1.DataSource = dBCon.Select();

            dataGridView1.Hide();
            label5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label5.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Show();
            dataGridView1.Show();
        }
    }
}
