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
    public partial class _5_1NewProject : Form
    {
        public _5_1NewProject()
        {
            InitializeComponent();
            DB_9Managers dbSelect = new DB_9Managers();
            dbSelect.Select();
            dataGridView1.DataSource = dbSelect.Select();
        }
        int select_ID;
        string text;
        string IDmanagers;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    text = Rows.Cells[0].Value.ToString();
                    DB_9Managers dBSelect = new DB_9Managers();
                    select_ID = Convert.ToInt32(text);
                    textBox2.Text = dBSelect.Select_fn(select_ID);




                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string project_name = textBox1.Text;
            DB_5Projects dB_5Projects = new DB_5Projects();
            dB_5Projects.Insert(select_ID, project_name);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void _5_1NewProject_Load(object sender, EventArgs e)
        {

        }
    }
}
