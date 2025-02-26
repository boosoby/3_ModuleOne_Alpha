using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _1_3_View_Com : Form
    {
        public _1_3_View_Com()
        {
            InitializeComponent();
        }
        int id_clients = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    id_clients = Convert.ToInt32(Rows.Cells[0].Value);
                    DB_8Comments dBSelect = new DB_8Comments();

                   

            dataGridView2.DataSource = dBSelect.Select(id_clients);


                }

            }
        }

        private void _1_3_View_Com_Load(object sender, EventArgs e)
        {
            DB_1Clients dBCon = new DB_1Clients();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
