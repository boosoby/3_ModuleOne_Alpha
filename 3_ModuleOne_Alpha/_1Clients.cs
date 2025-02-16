using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _1Clients : Form
    {
        public _1Clients()
        {
            InitializeComponent();
        }
        List<_1Clients> _1Clientslist;
        private void button6_Click(object sender, EventArgs e)
        {
            _1_1Clients_Reg formLogIn = new _1_1Clients_Reg(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void _1Clients_Load(object sender, EventArgs e)
        {
            DB_1Clients dBCon = new DB_1Clients();

            dataGridView1.DataSource = dBCon.Select();
            dataGridView1.Columns[0].HeaderText = "Имя клиента";
            //

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _1_3Comments formLogIn = new _1_3Comments(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }
    }
}
