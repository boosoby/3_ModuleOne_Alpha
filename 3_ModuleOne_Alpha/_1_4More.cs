﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace _3_ModuleOne_Alpha
{
    public partial class _1_4More : Form
    {
        public _1_4More(int idclient)
        {
            InitializeComponent();
            DB_1Clients dB_1Clients = new DB_1Clients();
            var testList = new List<string>();
            testList = dB_1Clients.Select_3(idclient);
            //label2.Text = Convert.ToString(idclient);

            int i = 0;
            foreach (var name in testList)
            {
                label2.Text = name;
                i++;
            }

            //dataGridView1.Columns[0].HeaderText = "бу";


            DB_10Communications dBCon = new DB_10Communications();
            dataGridView1.DataSource = dBCon.Select(idclient);
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Текст";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Тип";

            DB_1_1Contact_faces dbSelect = new DB_1_1Contact_faces();
            dbSelect.Select_2(idclient);
            dataGridView2.DataSource = dbSelect.Select_2(idclient);
            
            dataGridView2.Columns[0].HeaderText = "ФИО контактного лица";
            dataGridView2.Columns[1].HeaderText = "Телефон";
            dataGridView2.Columns[2].HeaderText = "Должность";
           
            DB_8Comments dbSelectCom = new DB_8Comments();
            dbSelectCom.Select(idclient);
            dataGridView3.DataSource = dbSelectCom.Select(idclient);
            dataGridView3.Columns[0].HeaderText = "Текст";

            button1.Click += (sender, EventArgs) => { button1_Click(sender, EventArgs, idclient); };

           
        }

       

        private void _1_4More_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, int idclient)
        {
           
            _1_4_1AddCommunication formLogIn = new _1_4_1AddCommunication(idclient); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }
    }
}
