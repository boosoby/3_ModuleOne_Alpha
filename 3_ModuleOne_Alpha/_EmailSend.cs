using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ModuleOne_Alpha
{
    public partial class _EmailSend : Form
    {
        public _EmailSend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("bo.osoby@gmail.com", "Name and stuff");
            string address = textBox2.Text;
            MailAddress to = new MailAddress("bo.osoby@gmail.com", "Name and stuff");

            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("bo.osoby@gmail.com", "Name and stuff"));
            string message_send = textBox1.Text;
            SendEmail(textBox1.Text, from, to, cc);
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("smtp.google.com");
            MailMessage msgMail;
            Text = "Stuff";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string email = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    email = Convert.ToString(row.Cells[1].Value);
                    textBox2.Text = email;
                }
            }
        }

        private void _EmailSend_Load(object sender, EventArgs e)
        {
            DB_15Email dBCon = new DB_15Email();

            dataGridView1.DataSource = dBCon.Select_fill();
        }
    }
}
