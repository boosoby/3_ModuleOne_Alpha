namespace _3_ModuleOne_Alpha
{
    partial class Register
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
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 234);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(226, 23);
            textBox7.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 237);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 30;
            label7.Text = "Стаж";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(226, 23);
            textBox6.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 204);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 28;
            label6.Text = "ФИО";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 23);
            textBox5.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 169);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 26;
            label3.Text = "Повторить пароль";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(200, 263);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 19);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "Менеджер";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(132, 263);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Админ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(136, 308);
            button2.Name = "button2";
            button2.Size = new Size(147, 23);
            button2.TabIndex = 23;
            button2.Text = "Зарегистрироваться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 134);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 22;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 100);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(41, 15);
            label5.TabIndex = 21;
            label5.Text = "Логин";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 23);
            textBox4.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 32;
            label1.Text = "Регистрация";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
    }
}