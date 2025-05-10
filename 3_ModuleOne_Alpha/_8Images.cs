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
    public partial class _8Images : Form
    {
        public _8Images()
        {
            InitializeComponent();
        }
        public string logo_path;
        public string signature;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //    pictureBox1_logo.ImageLocation = dialog.FileName.ToString();
                    signature = dialog.FileName.ToString();
                    string path = Path.Combine(@"~\image");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var fileName = "signature.jpg";
                    path = path + fileName;
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    File.Copy(dialog.FileName, path);

                    MessageBox.Show("Загрузка подписи выполнена успешно!");
                }
            }
            catch (Exception ex) { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opnfd = new OpenFileDialog();
            //opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            //if (opnfd.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = new Bitmap(opnfd.FileName);
            //}
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //    pictureBox1_logo.ImageLocation = dialog.FileName.ToString();
                    logo_path = dialog.FileName.ToString();
                    string path = Path.Combine(@"~\image");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var fileName = "logo.jpg";
                    path = path + fileName;
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    File.Copy(dialog.FileName, path);
                    MessageBox.Show("Загрузка логотипа выполнена успешно!");
                }
            }
            catch (Exception ex) { }


        }
    }
}
