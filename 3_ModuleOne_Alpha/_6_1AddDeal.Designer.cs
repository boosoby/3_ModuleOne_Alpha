namespace _3_ModuleOne_Alpha
{
    partial class _6_1AddDeal
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
            dataGridView2 = new DataGridView();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 470);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(684, 152);
            dataGridView2.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 27;
            label5.Text = "Выберите клиента";
            // 
            // button3
            // 
            button3.Location = new Point(91, 665);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(10, 665);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 25;
            button4.Text = "Готово";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 446);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 24;
            label2.Text = "Выберите товар/услугу";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 308);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 23;
            label4.Text = "Сумма сделки";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(684, 152);
            dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(219, 45);
            label1.TabIndex = 19;
            label1.Text = "Новая сделка";
            // 
            // button2
            // 
            button2.Location = new Point(489, 628);
            button2.Name = "button2";
            button2.Size = new Size(205, 23);
            button2.TabIndex = 29;
            button2.Text = "Добавить новый товар/услугу";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 348);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 31;
            label3.Text = "Срок оплаты";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 397);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(259, 19);
            radioButton2.TabIndex = 33;
            radioButton2.TabStop = true;
            radioButton2.Text = "Оплачено не полностью или не оплачено";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 372);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(146, 19);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Оплачено полностью";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // _6_1AddDeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 722);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_6_1AddDeal";
            Text = "_6_1AddDeal";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}