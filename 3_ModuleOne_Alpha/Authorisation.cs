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
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_17Authorisation dB = new DB_17Authorisation();
            string login = textBox1.Text;
            string pass = textBox2.Text;
            string role = dB.Select_role(login, pass);

            int irole = Convert.ToInt32(role);

            if (irole == 1)
            {
                MainMenu formLogIn = new MainMenu(); //FormLogIn — имя формы, которую хотим открыть
                formLogIn.ShowDialog();
            }
            else if (irole == 2)
            {
                _3Tasks formLogIn = new _3Tasks(); //FormLogIn — имя формы, которую хотим открыть
                formLogIn.ShowDialog();
            }

            label3.Text = role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox3.Text;
            string pass = textBox4.Text;
            int role = 0;
            if (radioButton1.Checked)
            {
                role = 1;
            }
            else if (radioButton2.Checked) {
                role = 2; 
            }

            DB_17Authorisation dB_17 = new DB_17Authorisation();
            dB_17.Insert(login, pass, role);
            MessageBox.Show("Регистрация прошла успешно!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
