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
    public partial class _4_1AddWorkTime : Form
    {
        public DateTime dateStart;
        public DateTime dateEnd;
        public _4_1AddWorkTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelStart.Text = DateTime.Now.ToString();
            dateStart = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelEnd.Text = DateTime.Now.ToString();
            dateEnd = DateTime.Now;
            var hours = (dateEnd - dateStart).Hours;
            var minutes = (dateEnd - dateStart).Minutes;

            labelQH.Text = hours.ToString();
            labelQM.Text = minutes.ToString();
        }
    }
}
