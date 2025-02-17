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
    public partial class _1_4_1AddCommunication : Form
    {
        public _1_4_1AddCommunication(int idclient)
        {
            InitializeComponent();
            button1.Click += (sender, EventArgs) => { button1_Click(sender, EventArgs, idclient); };

        }

        private void button1_Click(object sender, EventArgs e, int idclient)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd HH':'mm':'ss";
            // string demoddate = dateTimePicker1.CustomFormat.ToString();
            int idcommunication_type = 0;
            string datestring = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            string idtext = textBox1.Text;
            
            DB_10Communications dB_10Communications = new DB_10Communications();
            if (radioButton1.Checked == true) {
                idcommunication_type = 1;
            }
            else if (radioButton2.Checked == true) {
                idcommunication_type = 2;
            }
            dB_10Communications.Insert(datestring, idclient, idcommunication_type, idtext);
                //    public void Insert(string date, int idclients, int idcommunication_type, string idtext)
        }
    }
}
