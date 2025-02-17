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

        private void button2_Click(object sender, EventArgs e)
        {
            _6_1AddDeal formLogIn = new _6_1AddDeal(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _6_2Payment formLogIn = new _6_2Payment(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _6_3Print formLogIn = new _6_3Print(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }
    }
}
