namespace _12345
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(114, 162);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 1;
            label1.Text = "Введите длину комнаты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(114, 191);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 3;
            label2.Text = "Введите ширину комнаты";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(117, 222);
            label3.Name = "label3";
            label3.Size = new Size(189, 21);
            label3.TabIndex = 5;
            label3.Text = "Введите высоту комнаты";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(304, 274);
            button1.Name = "button1";
            button1.Size = new Size(164, 66);
            button1.TabIndex = 6;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(35, 9);
            label4.Name = "label4";
            label4.Size = new Size(725, 30);
            label4.TabIndex = 7;
            label4.Text = "Рассчитайте объём кислорода в своей комнате в считанные секунды!";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(271, 377);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(155, 370);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 9;
            label5.Text = "Результат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(474, 162);
            label6.Name = "label6";
            label6.Size = new Size(32, 25);
            label6.TabIndex = 10;
            label6.Text = "м³";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(474, 191);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 11;
            label7.Text = "м³";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(474, 218);
            label8.Name = "label8";
            label8.Size = new Size(32, 25);
            label8.TabIndex = 12;
            label8.Text = "м³";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(498, 374);
            label9.Name = "label9";
            label9.Size = new Size(32, 25);
            label9.TabIndex = 13;
            label9.Text = "м³";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1674276304_flomaster_club_p_risunok_kislorod_krasivo_70;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
