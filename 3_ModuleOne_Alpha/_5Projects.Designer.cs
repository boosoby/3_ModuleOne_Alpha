namespace _3_ModuleOne_Alpha
{
    partial class _5Projects
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(142, 383);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Окончен";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 383);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 12;
            button1.Text = "Добавить проект";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1073, 255);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 45);
            label1.TabIndex = 10;
            label1.Text = "Проекты";
            // 
            // button3
            // 
            button3.Location = new Point(223, 383);
            button3.Name = "button3";
            button3.Size = new Size(141, 23);
            button3.TabIndex = 14;
            button3.Text = "В процессе";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(370, 383);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 15;
            button4.Text = "Окончен";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(517, 383);
            button5.Name = "button5";
            button5.Size = new Size(141, 23);
            button5.TabIndex = 16;
            button5.Text = "Отменен";
            button5.UseVisualStyleBackColor = true;
            // 
            // _5Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_5Projects";
            Text = "_5Projects";
            Load += _5Projects_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}