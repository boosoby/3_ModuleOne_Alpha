using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void _1Clients_Load(object sender, EventArgs e)
        {
            DB_1Clients dBCon = new DB_1Clients();


            var testList = new List<string>();
            testList = dBCon.Select();
            


            DataTable table = new DataTable();
            table.Columns.Add("ID", Type.GetType("System.Int32"));
           
            table.Columns.Add("Name", Type.GetType("System.String"));


            dataGridView1.DataSource = table;
            int i = 0;
            int j = 1;
            foreach (var name in testList)
            {
                
                table.Rows.Add(i);
                dataGridView1.Rows[i].Cells[j].Value = name;

                i++;
                
            }
        }
    }
}
