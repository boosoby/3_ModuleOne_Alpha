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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _3_1Add_Tasks : Form
    {
        string task_name;
        public _3_1Add_Tasks()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        task_name = textBox1.Text;
            int idclientmanagers = 0;
            int idprojects = 0;
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    idclientmanagers = Convert.ToInt32(Rows.Cells[4].Value);
                    idprojects = Convert.ToInt32(Rows.Cells[0].Value);
                    DB_9Managers dBSelect = new DB_9Managers();
                   
                   label3.Text = dBSelect.Select_fn(idclientmanagers);




                }

            }
            DB_3Tasks dB_3Tasks = new DB_3Tasks();
            dB_3Tasks.Insert(task_name,idprojects, idclientmanagers);
            MessageBox.Show("Задача успешно добавлена");
        }

        private void _3_1Add_Tasks_Load(object sender, EventArgs e)
        {
            DB_5Projects dBCon = new DB_5Projects();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
