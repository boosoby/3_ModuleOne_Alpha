namespace _3_ModuleOne_Alpha
{
    partial class _6Deals
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
            panel1 = new Panel();
            button3 = new Button();
            button5 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 63);
            panel1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(84, 3);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 4;
            button3.Text = "Печать счёта на оплату";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 32);
            button5.Name = "button5";
            button5.Size = new Size(183, 23);
            button5.TabIndex = 6;
            button5.Text = "Форма оплаты";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1130, 255);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 9;
            label1.Text = "Сделки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 318);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 12;
            label2.Text = "Рискованные клиенты:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 318);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 13;
            label3.Text = "- ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 333);
            label4.Name = "label4";
            label4.Size = new Size(245, 15);
            label4.TabIndex = 14;
            label4.Text = "(Сортировка проводится по сумме сделки)";
            // 
            // _6Deals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 589);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_6Deals";
            Text = " ";
            Load += _6Deals_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button5;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}