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
    public partial class _6Deals : Form
    {
        public _6Deals()
        {
            InitializeComponent();
        }

        private void _6Deals_Load(object sender, EventArgs e)
        {
            DB_6Deals dBCon = new DB_6Deals();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
