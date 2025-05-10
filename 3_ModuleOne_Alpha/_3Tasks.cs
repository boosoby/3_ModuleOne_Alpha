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
    public partial class _3Tasks : Form
    {
        public _3Tasks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void _3Tasks_Load(object sender, EventArgs e)
        {
            DB_3Tasks dBCon = new DB_3Tasks();

            dataGridView1.DataSource = dBCon.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3_1Add_Tasks newProject = new _3_1Add_Tasks();
            newProject.ShowDialog();
        }
    }
}
