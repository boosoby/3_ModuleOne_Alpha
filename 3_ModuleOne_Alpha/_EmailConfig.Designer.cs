namespace _3_ModuleOne_Alpha
{
    partial class _EmailConfig
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
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 58);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Электронная почта:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 87);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(218, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(345, 134);
            dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 185);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 10;
            label2.Text = "Текущие настройки:";
            // 
            // _EmailConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "_EmailConfig";
            Text = "_EmailConfig";
            Load += _EmailConfig_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}