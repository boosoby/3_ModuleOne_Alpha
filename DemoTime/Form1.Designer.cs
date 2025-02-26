namespace DemoTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelStart = new Label();
            labelEnd = new Label();
            labelQH = new Label();
            label4 = new Label();
            labelQM = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 105);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 2;
            label1.Text = "Начало выполнения работы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 120);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Время окончания:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 135);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество часов:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(415, 105);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(13, 15);
            labelStart.TabIndex = 5;
            labelStart.Text = "0";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(415, 120);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(13, 15);
            labelEnd.TabIndex = 6;
            labelEnd.Text = "0";
            // 
            // labelQH
            // 
            labelQH.AutoSize = true;
            labelQH.Location = new Point(415, 135);
            labelQH.Name = "labelQH";
            labelQH.Size = new Size(13, 15);
            labelQH.TabIndex = 7;
            labelQH.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 150);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 8;
            label4.Text = "Количество минут:";
            // 
            // labelQM
            // 
            labelQM.AutoSize = true;
            labelQM.Location = new Point(415, 150);
            labelQM.Name = "labelQM";
            labelQM.Size = new Size(13, 15);
            labelQM.TabIndex = 9;
            labelQM.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelQM);
            Controls.Add(label4);
            Controls.Add(labelQH);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelStart;
        private Label labelEnd;
        private Label labelQH;
        private Label label4;
        private Label labelQM;
    }
}
