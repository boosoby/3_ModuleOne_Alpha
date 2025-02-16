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

namespace _3_ModuleOne_Alpha
{
    public partial class _1_2Contact_faces_Reg : Form
    {
        public _1_2Contact_faces_Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_1_1Contact_faces dBinsert = new DB_1_1Contact_faces();
            dBinsert.Insert(textBox1.Text, textBox2.Text, textBox3.Text);
           
        }
    }
}
