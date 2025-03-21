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
        int idmanagers = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _2_1AddPlan_Load(object sender, EventArgs e)
        {
            DB_9Managers dBCon = new DB_9Managers();

            dataGridView1.DataSource = dBCon.Select();
            // dataGridView1.Columns[0].HeaderText = "Имя клиента";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {

                    idmanagers = Convert.ToInt32(row.Cells[0].Value);
                int amount = Convert.ToInt32(textBox1.Text);
                string date = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
                DB_11Sales_Plan dB_11Sales_Plan = new DB_11Sales_Plan();
                dB_11Sales_Plan.Insert_plan(date, amount, idmanagers);

                }



            }
            MessageBox.Show("План успешно добавлен");
        }
    }
}
