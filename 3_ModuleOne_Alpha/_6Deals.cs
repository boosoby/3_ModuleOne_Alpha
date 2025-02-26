﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ModuleOne_Alpha
{
    public partial class _6Deals : Form
    {
        public _6Deals()
        {
            InitializeComponent();
        }
         public int iddeals = 0;

        private void _6Deals_Load(object sender, EventArgs e)
        {
            DB_6Deals dBCon = new DB_6Deals();
            DB_6Deals dBCon2 = new DB_6Deals();
           

            dataGridView1.DataSource = dBCon.Select();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                iddeals = Convert.ToInt32(row.Cells[0].Value);
                string pay_date = dBCon.Select_pay_date(iddeals);
                int pay_status =Convert.ToInt32(dBCon2.Select_pay_status(iddeals));
                try
                {
                    DateTime time;
                    string mySqlTimestamp = pay_date;
                    time = DateTime.Parse(mySqlTimestamp);
                    //DateTime datetime_date = DateTime.ParseExact(pay_date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    if ((DateTime.Now > time)&& pay_status==2)

                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _6_1AddDeal formLogIn = new _6_1AddDeal(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _6_2Payment formLogIn = new _6_2Payment(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

       


        private void button3_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {

                    iddeals = Convert.ToInt32(row.Cells[0].Value);
                    
                }
               
                
             
            }


         
            _6_3Print formLogIn = new _6_3Print(iddeals); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }
    }
}
