using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _1_1Clients_Reg : Form
    {
        public _1_1Clients_Reg()
        {
            InitializeComponent();
            DB_1_1Contact_faces dbSelect = new DB_1_1Contact_faces();
            dbSelect.Select();
            dataGridView1.DataSource = dbSelect.Select();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "ФИО контактного лица";
            dataGridView1.Columns[2].HeaderText = "Телефон";
            dataGridView1.Columns[3].HeaderText = "Должность";

            DB_9Managers dbManager = new DB_9Managers();
            dbManager.Select();
            dataGridView2.DataSource = dbManager.Select();

        }
        string text;
        string IDmanagers;
        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    text = Rows.Cells[0].Value.ToString();
                    DB_1Clients dBinsert = new DB_1Clients();
                    int insert_ID = Convert.ToInt32(text);
                    dBinsert.Insert(textBox1.Text, insert_ID);



                }

            }
            foreach (DataGridViewRow Rows in this.dataGridView2.Rows)

            {
                if (Rows.Selected)
                {


                    IDmanagers = Rows.Cells[0].Value.ToString();
                    DB_1Clients dBinsert = new DB_1Clients();
                    int managers_ID = Convert.ToInt32(IDmanagers);
                    int clients_ID = dBinsert.Select_last_client();
                    dBinsert.Insert_2(clients_ID, managers_ID);



                }

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            _1_2Contact_faces_Reg formLogIn = new _1_2Contact_faces_Reg(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();

        }

        private void _1_1Clients_Reg_Load(object sender, EventArgs e)
        {

        }
    }
}
