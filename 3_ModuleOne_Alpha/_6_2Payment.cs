using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;

namespace _3_ModuleOne_Alpha
{
    public partial class _6_2Payment : Form
    {
        public _6_2Payment()
        {
            InitializeComponent();
        }
        int iddeals = 0;

        private void _6_2Payment_Load(object sender, EventArgs e)
        {

            DB_13Payment dBCon = new DB_13Payment();

            dataGridView1.DataSource = dBCon.Select();
            
            DB_13Payment dBCon2 = new DB_13Payment();

            dataGridView2.DataSource = dBCon.Select_2();


            
            dataGridView1.Hide();
            label5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label5.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Show();
            dataGridView1.Show();
        }

        public int Percent(int pay_total, int pay_f_p)
        {
            int temp = pay_total / pay_f_p;
            if (temp == 0)
            {
                return 100;
            }
            return 100 / temp;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int pay_total = 0;
            string pay_date = DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            int pay_amount = Convert.ToInt32(textBox1.Text);
            int pay_status = 0;

            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {

                    iddeals = Convert.ToInt32(Rows.Cells[0].Value);
                    pay_total = Convert.ToInt32(Rows.Cells[4].Value);
                }

            }

            int pay_percent = Percent(pay_total, pay_amount);
            if (pay_percent >= 100)
            {
                pay_status = 1;
            }
            else if (pay_percent < 100)
            { pay_status = 2; } 
            string payment_name = textBox2.Text;
            DB_13Payment dB_13Payment = new DB_13Payment();
            dB_13Payment.Insert(pay_date, pay_amount, pay_percent, pay_status, iddeals, payment_name);
            DB_13Payment dB_13Payment1 = new DB_13Payment();
            dB_13Payment1.Update_percent(pay_percent, iddeals);
            DB_13Payment dB_13Payment2 = new DB_13Payment();
            dB_13Payment2.Update_status();
            MessageBox.Show("Оплата успешно добавлена");
        }
    }
}
