﻿namespace _3_ModuleOne_Alpha
{
    partial class MainMenu
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
            button1Clients = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button11DealAnalysis = new Button();
            button10PlanAnalysis = new Button();
            button9Settings = new Button();
            button8Images = new Button();
            button7Efficiency = new Button();
            button6Deals = new Button();
            button5Projects = new Button();
            button4WorkTime = new Button();
            button3Tasks = new Button();
            button2Plan = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1Clients
            // 
            button1Clients.Location = new Point(0, 3);
            button1Clients.Name = "button1Clients";
            button1Clients.Size = new Size(75, 23);
            button1Clients.TabIndex = 0;
            button1Clients.Text = "Клиенты";
            button1Clients.UseVisualStyleBackColor = true;
            button1Clients.Click += button1Clients_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button11DealAnalysis);
            panel1.Controls.Add(button10PlanAnalysis);
            panel1.Controls.Add(button9Settings);
            panel1.Controls.Add(button8Images);
            panel1.Controls.Add(button7Efficiency);
            panel1.Controls.Add(button6Deals);
            panel1.Controls.Add(button5Projects);
            panel1.Controls.Add(button4WorkTime);
            panel1.Controls.Add(button3Tasks);
            panel1.Controls.Add(button2Plan);
            panel1.Controls.Add(button1Clients);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 233);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(3, 177);
            button3.Name = "button3";
            button3.Size = new Size(182, 23);
            button3.TabIndex = 13;
            button3.Text = "Отправка почты";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 148);
            button2.Name = "button2";
            button2.Size = new Size(182, 23);
            button2.TabIndex = 12;
            button2.Text = "Настройка почты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 148);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 11;
            button1.Text = "Средний чек";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button11DealAnalysis
            // 
            button11DealAnalysis.ForeColor = Color.Red;
            button11DealAnalysis.Location = new Point(151, 119);
            button11DealAnalysis.Name = "button11DealAnalysis";
            button11DealAnalysis.Size = new Size(246, 23);
            button11DealAnalysis.TabIndex = 10;
            button11DealAnalysis.Text = "Анализ сделок и клиентов";
            button11DealAnalysis.UseVisualStyleBackColor = true;
            button11DealAnalysis.Click += button11DealAnalysis_Click;
            // 
            // button10PlanAnalysis
            // 
            button10PlanAnalysis.ForeColor = Color.Red;
            button10PlanAnalysis.Location = new Point(3, 119);
            button10PlanAnalysis.Name = "button10PlanAnalysis";
            button10PlanAnalysis.Size = new Size(142, 23);
            button10PlanAnalysis.TabIndex = 9;
            button10PlanAnalysis.Text = "План-фактный анализ";
            button10PlanAnalysis.UseVisualStyleBackColor = true;
            button10PlanAnalysis.Click += button10PlanAnalysis_Click;
            // 
            // button9Settings
            // 
            button9Settings.ForeColor = Color.Red;
            button9Settings.Location = new Point(165, 90);
            button9Settings.Name = "button9Settings";
            button9Settings.Size = new Size(232, 23);
            button9Settings.TabIndex = 8;
            button9Settings.Text = "Настройки";
            button9Settings.UseVisualStyleBackColor = true;
            button9Settings.Click += button9Settings_Click;
            // 
            // button8Images
            // 
            button8Images.Location = new Point(3, 90);
            button8Images.Name = "button8Images";
            button8Images.Size = new Size(156, 23);
            button8Images.TabIndex = 7;
            button8Images.Text = "Загрузка изображений";
            button8Images.UseVisualStyleBackColor = true;
            button8Images.Click += button8Images_Click;
            // 
            // button7Efficiency
            // 
            button7Efficiency.ForeColor = Color.Red;
            button7Efficiency.Location = new Point(84, 61);
            button7Efficiency.Name = "button7Efficiency";
            button7Efficiency.Size = new Size(313, 23);
            button7Efficiency.TabIndex = 6;
            button7Efficiency.Text = "Отчёт по эффективности";
            button7Efficiency.UseVisualStyleBackColor = true;
            button7Efficiency.Click += button7Efficiency_Click;
            // 
            // button6Deals
            // 
            button6Deals.Location = new Point(3, 61);
            button6Deals.Name = "button6Deals";
            button6Deals.Size = new Size(75, 23);
            button6Deals.TabIndex = 5;
            button6Deals.Text = "Сделки";
            button6Deals.UseVisualStyleBackColor = true;
            button6Deals.Click += button6Deals_Click;
            // 
            // button5Projects
            // 
            button5Projects.Location = new Point(215, 32);
            button5Projects.Name = "button5Projects";
            button5Projects.Size = new Size(182, 23);
            button5Projects.TabIndex = 4;
            button5Projects.Text = "Проекты";
            button5Projects.UseVisualStyleBackColor = true;
            button5Projects.Click += button5Projects_Click;
            // 
            // button4WorkTime
            // 
            button4WorkTime.Location = new Point(3, 32);
            button4WorkTime.Name = "button4WorkTime";
            button4WorkTime.Size = new Size(206, 23);
            button4WorkTime.TabIndex = 3;
            button4WorkTime.Text = "Рабочее время сотрудников";
            button4WorkTime.UseVisualStyleBackColor = true;
            button4WorkTime.Click += button4WorkTime_Click;
            // 
            // button3Tasks
            // 
            button3Tasks.Location = new Point(162, 3);
            button3Tasks.Name = "button3Tasks";
            button3Tasks.Size = new Size(235, 23);
            button3Tasks.TabIndex = 2;
            button3Tasks.Text = "Задачи";
            button3Tasks.UseVisualStyleBackColor = true;
            button3Tasks.Click += button3Tasks_Click;
            // 
            // button2Plan
            // 
            button2Plan.Location = new Point(81, 3);
            button2Plan.Name = "button2Plan";
            button2Plan.Size = new Size(75, 23);
            button2Plan.TabIndex = 1;
            button2Plan.Text = "План продаж";
            button2Plan.UseVisualStyleBackColor = true;
            button2Plan.Click += button2Plan_Click;
            // 
            // button4
            // 
            button4.Location = new Point(191, 177);
            button4.Name = "button4";
            button4.Size = new Size(182, 23);
            button4.TabIndex = 14;
            button4.Text = "Настройка календаря";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 257);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "Главное меню";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1Clients;
        private Panel panel1;
        private Button button11DealAnalysis;
        private Button button10PlanAnalysis;
        private Button button9Settings;
        private Button button8Images;
        private Button button7Efficiency;
        private Button button6Deals;
        private Button button5Projects;
        private Button button4WorkTime;
        private Button button3Tasks;
        private Button button2Plan;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
