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
using static System.Net.Mime.MediaTypeNames;
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
            
            DB_1Clients dBCon2 = new DB_1Clients();

            dataGridView2.DataSource = dBCon2.Select_email();
          
            
            DB_1Clients dBCon3 = new DB_1Clients();

            dataGridView3.DataSource = dBCon3.Select_name();
           

            DB_1Clients dBCon4 = new DB_1Clients();

            dataGridView4.DataSource = dBCon4.Select_phone();
           
            //

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _1_3Comments formLogIn = new _1_3Comments(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        string client_id;
        int idclient;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    client_id = Rows.Cells[0].Value.ToString();
                    DB_1Clients dBinsert = new DB_1Clients();
                    idclient = Convert.ToInt32(client_id);
                    //idclient = Convert.ToInt32(dBinsert.Select_3(select_client));



                }

            }
            _1_4More formLogIn = new _1_4More(idclient); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _1_3_View_Com formLogIn = new _1_3_View_Com(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }
    }
}
