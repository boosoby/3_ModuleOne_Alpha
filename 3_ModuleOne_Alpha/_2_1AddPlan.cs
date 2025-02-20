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
    public partial class _2_1AddPlan : Form
    {
        public _2_1AddPlan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _2_1AddPlan_Load(object sender, EventArgs e)
        {
           DB_9Managers dBCon = new DB_9Managers();

            dataGridView1.DataSource = dBCon.Select();
           // dataGridView1.Columns[0].HeaderText = "Имя клиента";
        }
    }
}
