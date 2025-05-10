namespace _3_ModuleOne_Alpha
{
    partial class _5_1NewProject
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(341, 150);
            dataGridView1.TabIndex = 10;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 9;
            label2.Text = "Ответственный:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 92);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "Клиент:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 23);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(107, 309);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 6;
            button1.Text = "Добавить проект";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(232, 45);
            label3.TabIndex = 11;
            label3.Text = "Новый проект";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(588, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(588, 279);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 256);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Начальная дата:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 287);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 16;
            label5.Text = "Конечная дата:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 95);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 18;
            label6.Text = "Название проекта:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(575, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 17;
            // 
            // _5_1NewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "_5_1NewProject";
            Text = "_5_1NewProject";
            Load += _5_1NewProject_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
    }
}