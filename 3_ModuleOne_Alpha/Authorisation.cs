using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

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

            //  int irole = Convert.ToInt32(role);
            int parse_result = 0;
            int.TryParse(role, out parse_result);

            if (parse_result == 1)
            {
                MainMenu formLogIn = new MainMenu(); //FormLogIn — имя формы, которую хотим открыть
                formLogIn.ShowDialog();
            }
            else if (parse_result == 2)
            {
                _3Tasks formLogIn = new _3Tasks(); //FormLogIn — имя формы, которую хотим открыть
                formLogIn.ShowDialog();
            }
            else if (parse_result == 0)
            {
                MessageBox.Show("Такого пользователя не существует");
            }

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
