using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _6_1AddDeal : Form
    {
        public _6_1AddDeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idclient_managers = 0 ;
            int idgoods = 0 ;
            string date = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            int amount = Convert.ToInt32(textBox1.Text);
            int iddeal_status = 0;
            int pay_status = 0;
            if (radioButton1.Checked)
            {
                iddeal_status = 1;
                pay_status = 2;
            }
            else if (radioButton2.Checked)
            {
                iddeal_status = 2;
                pay_status = 1;
            }

            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {

                    idclient_managers = Convert.ToInt32(Rows.Cells[0].Value);
                 
                }

            }
            foreach (DataGridViewRow Rows in this.dataGridView2.Rows)

            {
                if (Rows.Selected)
                {
                    idgoods = Convert.ToInt32(Rows.Cells[0].Value);
                   
                }

            }
            string deals_name = textBox2.Text;
            string pay_date = dateTimePicker2.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            DB_6Deals dB_6Deals = new DB_6Deals();
            dB_6Deals.Insert(date, amount, iddeal_status, idclient_managers, deals_name, pay_date);
            DB_12Goods_in_deals dB_12Goods_In_Deals = new DB_12Goods_in_deals();
            int quantity = Convert.ToInt32(textBox3.Text);
            dB_12Goods_In_Deals.Insert(quantity, idgoods);

            DB_6Deals payment = new DB_6Deals();
           // payment.Insert_payment_deal(pay_date,pay_status);
            //(string date, int amount, int iddeal_status, int idclient_managers)
        }

        private void _6_1AddDeal_Load(object sender, EventArgs e)
        {
            DB_1Clients dBCon = new DB_1Clients();

            dataGridView1.DataSource = dBCon.Select();
            dataGridView1.Columns[0].HeaderText = "Имя клиента";
             DB_12Goods_in_deals dbSelect = new DB_12Goods_in_deals();

            dataGridView2.DataSource = dbSelect.Select_goods();
          



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
