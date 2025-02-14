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
    public partial class _5Projects : Form
    {
        public _5Projects()
        {
            InitializeComponent();
        }

        private void _5Projects_Load(object sender, EventArgs e)
        {
            DB_5Projects dBCon = new DB_5Projects();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
