﻿namespace _3_ModuleOne_Alpha
{
    partial class _2Plan
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 281);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 45;
            label3.Text = "Месяц:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 280);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 66);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 41;
            label5.Text = "Выберите менеджера";
            // 
            // button3
            // 
            button3.Location = new Point(91, 648);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 40;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(10, 648);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 39;
            button4.Text = "Готово";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(684, 152);
            dataGridView1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(217, 45);
            label1.TabIndex = 34;
            label1.Text = "План продаж";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(25, 319);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 47;
            label4.Text = "Сумма:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(117, 319);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 48;
            label6.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(25, 363);
            button1.Name = "button1";
            button1.Size = new Size(221, 23);
            button1.TabIndex = 49;
            button1.Text = "Добавить новый план";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _2Plan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_2Plan";
            Text = "_2Plan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private Label label6;
        private Button button1;
    }
}