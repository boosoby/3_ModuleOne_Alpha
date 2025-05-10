namespace _3_ModuleOne_Alpha
{
    partial class _4_1AddWorkTime
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
            labelQM = new Label();
            label4 = new Label();
            labelQH = new Label();
            labelEnd = new Label();
            labelStart = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelQM
            // 
            labelQM.AutoSize = true;
            labelQM.Location = new Point(332, 140);
            labelQM.Name = "labelQM";
            labelQM.Size = new Size(13, 15);
            labelQM.TabIndex = 19;
            labelQM.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 140);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 18;
            label4.Text = "Количество минут:";
            // 
            // labelQH
            // 
            labelQH.AutoSize = true;
            labelQH.Location = new Point(332, 125);
            labelQH.Name = "labelQH";
            labelQH.Size = new Size(13, 15);
            labelQH.TabIndex = 17;
            labelQH.Text = "0";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(332, 110);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(13, 15);
            labelEnd.TabIndex = 16;
            labelEnd.Text = "0";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(332, 95);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(13, 15);
            labelStart.TabIndex = 15;
            labelStart.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 14;
            label3.Text = "Количество часов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 110);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 13;
            label2.Text = "Время окончания:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 95);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 12;
            label1.Text = "Начало выполнения работы:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(372, 45);
            label5.TabIndex = 20;
            label5.Text = "Учет рабочего времени";
            // 
            // _4_1AddWorkTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
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
            Name = "_4_1AddWorkTime";
            Text = "_4_1AddWorkTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQM;
        private Label label4;
        private Label labelQH;
        private Label labelEnd;
        private Label labelStart;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label5;
    }
}