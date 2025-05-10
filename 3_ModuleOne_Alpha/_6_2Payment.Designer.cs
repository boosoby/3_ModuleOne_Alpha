namespace _3_ModuleOne_Alpha
{
    partial class _6_2Payment
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(111, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(144, 19);
            radioButton2.TabIndex = 48;
            radioButton2.TabStop = true;
            radioButton2.Text = "На основании сделки";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 62);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 47;
            radioButton1.TabStop = true;
            radioButton1.Text = "Независимо";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 42;
            label5.Text = "Выберите сделку";
            // 
            // button3
            // 
            button3.Location = new Point(88, 457);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 41;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(7, 457);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 40;
            button4.Text = "Готово";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 299);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 38;
            label4.Text = "Сумма оплаты:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(684, 152);
            dataGridView1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 34;
            label1.Text = "Оплата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 334);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 50;
            label2.Text = "Название оплаты:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 49;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 530);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(684, 152);
            dataGridView2.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 506);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 52;
            label3.Text = "История всех оплат";
            // 
            // _6_2Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 694);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_6_2Payment";
            Text = "_6_2Payment";
            Load += _6_2Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Label label3;
    }
}