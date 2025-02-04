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
            button1 = new Button();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(12, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 63);
            panel1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(164, 3);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 4;
            button3.Text = "Печать счёта на оплату";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(2, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(164, 32);
            button5.Name = "button5";
            button5.Size = new Size(183, 23);
            button5.TabIndex = 6;
            button5.Text = "Форма оплаты";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(83, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(2, 32);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 5;
            button4.Text = "Экспорт файла";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(377, 255);
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
            // _6Deals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_6Deals";
            Text = " ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
    }
}