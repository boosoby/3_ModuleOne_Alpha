namespace _3_ModuleOne_Alpha
{
    partial class _4Worktime
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(108, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Задача";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(108, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Проект";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 10;
            label2.Text = "Тип:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(958, 171);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 45);
            label1.TabIndex = 8;
            label1.Text = "Рабочее время сотрудников";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(40, 294);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1115, 312);
            dataGridView2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(40, 220);
            button1.Name = "button1";
            button1.Size = new Size(133, 47);
            button1.TabIndex = 14;
            button1.Text = "Учёт рабочего времени";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _4Worktime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 618);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_4Worktime";
            Text = "_4Worktime";
            Load += _4Worktime_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button1;
    }
}