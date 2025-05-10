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
    public partial class _14Avg : Form
    {
        public _14Avg()
        {
            InitializeComponent();
        }

        private void _14Avg_Load(object sender, EventArgs e)
        {
            DB_14Avg dB_14Avg = new DB_14Avg();
           
            dataGridView1.DataSource = dB_14Avg.Select();


            DB_14Avg dB_14Avg2 = new DB_14Avg();
           
            dataGridView2.DataSource = dB_14Avg.Select_c();

        }
    }
}
