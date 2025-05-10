using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3_ModuleOne_Alpha
{
    public partial class _EmailConfig : Form
    {
        public _EmailConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            DB_15Email dBCon = new DB_15Email();
            dBCon.Insert(email, password);
        }

        private void _EmailConfig_Load(object sender, EventArgs e)
        {
            DB_15Email dBCon = new DB_15Email();
            dBCon.Select_fill_2();
            dataGridView1.DataSource = dBCon.Select_fill_2();
        }
    }
}
