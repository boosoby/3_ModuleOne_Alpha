using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _3_ModuleOne_Alpha
{
    public partial class _1_3Comments : Form
    {
        public _1_3Comments()
        {
            InitializeComponent();
            DB_1_1Contact_faces dbSelect = new DB_1_1Contact_faces();
            dbSelect.Select();
            dataGridView1.DataSource = dbSelect.Select();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "ФИО контактного лица";
            dataGridView1.Columns[2].HeaderText = "Телефон";
            dataGridView1.Columns[3].HeaderText = "Должность";
        }
        string id_clients;
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    id_clients = Rows.Cells[0].Value.ToString();
                    DB_8Comments dBinsert = new DB_8Comments();
                    int insert_ID = Convert.ToInt32(id_clients);
                    dBinsert.Insert(textBox1.Text, insert_ID);



                }

            }
        }

        private void _1_3Comments_Load(object sender, EventArgs e)
        {

        }
    }
}
