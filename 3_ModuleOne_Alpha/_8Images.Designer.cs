namespace _3_ModuleOne_Alpha
{
    partial class _8Images
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(151, 57);
            button2.Name = "button2";
            button2.Size = new Size(143, 52);
            button2.TabIndex = 17;
            button2.Text = "Загрузка подписи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 57);
            button1.Name = "button1";
            button1.Size = new Size(124, 52);
            button1.TabIndex = 16;
            button1.Text = "Загрузка логотипа";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(357, 45);
            label1.TabIndex = 14;
            label1.Text = "Загрузка изображений";
            // 
            // _8Images
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "_8Images";
            Text = "_8Images";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
    }
}