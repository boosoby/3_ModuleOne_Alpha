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
            dBinsert.Insert(textBox1.Text, maskedTextBox1.Text, textBox3.Text);
            MessageBox.Show("Контактное лицо успешно добавлено!");
        }

        private void _1_2Contact_faces_Reg_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "+7/000/000/0000";

            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", maskedTextBox1, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", maskedTextBox1, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", maskedTextBox1, 0, -20, 5000);
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(maskedTextBox1);
        }
    }
}
