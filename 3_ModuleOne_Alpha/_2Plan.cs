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
    public partial class _2Plan : Form
    {
        public _2Plan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_1AddPlan formLogIn = new _2_1AddPlan(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void _2Plan_Load(object sender, EventArgs e)
        {
            DB_11Sales_Plan dBCon = new DB_11Sales_Plan();

            dataGridView1.DataSource = dBCon.Select();
        }
    }
}
