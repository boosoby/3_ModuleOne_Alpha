namespace _3_ModuleOne_Alpha
{
    partial class _11DealAnalysis
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
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 353);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 22;
            label3.Text = "По";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(37, 347);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 324);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 20;
            label2.Text = "С";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(37, 318);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(12, 383);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 18;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 255);
            dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 16;
            label1.Text = "Анализ сделок и клиентов";
            // 
            // _11DealAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_11DealAnalysis";
            Text = "_11DealAnalysis";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}