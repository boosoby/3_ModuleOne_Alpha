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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox3.Text;
            int role = 0;
            string pass = "";
            if (radioButton1.Checked)
            {
                role = 1;
            }
            else if (radioButton2.Checked)
            {
                role = 2;
            }

            if (textBox4.Text == textBox5.Text)
            {
                pass = textBox4.Text;
            }
            else MessageBox.Show("Пароли не совпадают");

            string full_name = textBox6.Text;
            string years_of_work = textBox7.Text;

            DB_17Authorisation dB_17 = new DB_17Authorisation();
            dB_17.Insert(login, pass, role, full_name, years_of_work);
            MessageBox.Show("Регистрация прошла успешно!");
        }
    }
}
