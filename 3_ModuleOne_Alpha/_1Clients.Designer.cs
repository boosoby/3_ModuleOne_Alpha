﻿namespace _3_ModuleOne_Alpha
{
    partial class _1Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 45);
            label1.TabIndex = 0;
            label1.Text = "Клиенты";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(684, 255);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(2, 3);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить проект";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(164, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 3;
            button2.Text = "Добавить задачу";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(299, 3);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 4;
            button3.Text = "Подробнее";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(2, 32);
            button4.Name = "button4";
            button4.Size = new Size(173, 23);
            button4.TabIndex = 5;
            button4.Text = "Добавить комментарий";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(181, 32);
            button5.Name = "button5";
            button5.Size = new Size(218, 23);
            button5.TabIndex = 6;
            button5.Text = "Экспорт файла";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 61);
            button6.Name = "button6";
            button6.Size = new Size(172, 23);
            button6.TabIndex = 7;
            button6.Text = "Добавить клиента";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(12, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 97);
            panel1.TabIndex = 8;
            // 
            // button7
            // 
            button7.Location = new Point(181, 61);
            button7.Name = "button7";
            button7.Size = new Size(173, 23);
            button7.TabIndex = 8;
            button7.Text = "Посмотреть комментарии";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // _1Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_1Clients";
            Text = "_1Clients";
            Load += _1Clients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Button button7;
    }
}