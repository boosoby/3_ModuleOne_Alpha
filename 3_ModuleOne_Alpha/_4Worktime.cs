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
    public partial class _4Worktime : Form
    {
        public _4Worktime()
        {
            InitializeComponent();
        }

        private void _4Worktime_Load(object sender, EventArgs e)
        {
            DB_4Worktime dBCon = new DB_4Worktime();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
