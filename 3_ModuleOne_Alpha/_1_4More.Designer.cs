namespace _3_ModuleOne_Alpha
{
    partial class _1_4More
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
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 255);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 2;
            label1.Text = "Подробнее";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 64);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 18;
            label5.Text = "ФИО клиента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(138, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 19;
            label2.Text = "null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(193, 21);
            label3.TabIndex = 20;
            label3.Text = "История взаимодействий";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 22;
            label4.Text = "Контактное лицо";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 433);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(684, 255);
            dataGridView2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 691);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 24;
            label6.Text = "Комментарии";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 715);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(684, 255);
            dataGridView3.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(500, 401);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 25;
            button1.Text = "Добавить взаимодействие";
            button1.UseVisualStyleBackColor = true;
           
            // 
            // _1_4More
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 962);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dataGridView3);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "_1_4More";
            Text = "_1_4More";
            Load += _1_4More_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label6;
        private DataGridView dataGridView3;
        private Button button1;
    }
}