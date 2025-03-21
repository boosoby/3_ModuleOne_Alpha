namespace _3_ModuleOne_Alpha
{
    partial class _1_2Contact_faces_Reg
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 3;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 4;
            label2.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 5;
            label3.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(372, 45);
            label4.TabIndex = 6;
            label4.Text = "Новое контактное лицо";
            // 
            // button1
            // 
            button1.Location = new Point(108, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 171);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 110);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(261, 23);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.KeyDown += maskedTextBox1_KeyDown;
            // 
            // _1_2Contact_faces_Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "_1_2Contact_faces_Reg";
            Text = "_1_1Contact_faces_Reg";
            Load += _1_2Contact_faces_Reg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private ToolTip toolTip1;
    }
}