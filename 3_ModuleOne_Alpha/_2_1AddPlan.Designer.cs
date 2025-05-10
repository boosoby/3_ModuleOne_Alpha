namespace _3_ModuleOne_Alpha
{
    partial class _2_1AddPlan
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
            radioButton1 = new RadioButton();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(39, 249);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 25);
            radioButton1.TabIndex = 55;
            radioButton1.TabStop = true;
            radioButton1.Text = "Сумма:";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(58, 299);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 54;
            label3.Text = "Месяц:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 23);
            dateTimePicker1.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 52;
            label5.Text = "Выберите менеджера";
            // 
            // button3
            // 
            button3.Location = new Point(133, 367);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 51;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(870, 152);
            dataGridView1.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 45);
            label1.TabIndex = 48;
            label1.Text = "Добавить план продаж";
            // 
            // button4
            // 
            button4.Location = new Point(58, 367);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 57;
            button4.Text = "Готово";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // _2_1AddPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 495);
            Controls.Add(button4);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_2_1AddPlan";
            Text = "_2_1AddPlan";
            Load += _2_1AddPlan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button4;
    }
}