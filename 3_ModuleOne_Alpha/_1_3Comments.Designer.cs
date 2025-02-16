namespace _3_ModuleOne_Alpha
{
    partial class _1_3Comments
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
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 119);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 22;
            label5.Text = "Выберите клиента";
            // 
            // button3
            // 
            button3.Location = new Point(103, 493);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(22, 493);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Готово";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(684, 152);
            dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(22, 59);
            label1.Name = "label1";
            label1.Size = new Size(330, 45);
            label1.TabIndex = 18;
            label1.Text = "Новый комментарий";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 369);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(684, 118);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 326);
            label2.Name = "label2";
            label2.Size = new Size(210, 21);
            label2.TabIndex = 24;
            label2.Text = "Введите текст комментария";
            // 
            // _1_3Comments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 608);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_1_3Comments";
            Text = "_1_3Comments";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}