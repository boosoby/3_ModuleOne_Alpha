using MySqlX.XDevAPI;
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
    public partial class _Calendar_Config : Form
    {
        public _Calendar_Config()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            string address = textBox3.Text;
            string name = textBox4.Text;

            DB_16Calendar dB_16Calendar = new DB_16Calendar();
            dB_16Calendar.Insert(login, pass, address, name);


        }

        private void _Calendar_Config_Load(object sender, EventArgs e)
        {
            DB_16Calendar dB_16Calendar1 = new DB_16Calendar();
           
            dataGridView1.DataSource = dB_16Calendar1.Select_fill_2();

        }
    }
}
