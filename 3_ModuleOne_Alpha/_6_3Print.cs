using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace _3_ModuleOne_Alpha
{
    public partial class _6_3Print : Form
    {
        public _6_3Print()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        Bitmap bmp;
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void _6_3Print_Load(object sender, EventArgs e)
        {
            DB_6Deals dB_6Deals = new DB_6Deals();

            dataGridView1.DataSource = dB_6Deals.Select_goods_in_d();

            pictureBox1.ImageLocation = Path.Combine(@"~\imagelogo.jpg");
            pictureBox2.ImageLocation = Path.Combine(@"~\imagesignature.jpg");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
