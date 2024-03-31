namespace LAB1
{
    partial class LAB1_bai04
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
            label1 = new Label();
            hoten = new TextBox();
            label2 = new Label();
            label3 = new Label();
            soghe = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(58, 61);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhap hovaten:";
            // 
            // hoten
            // 
            hoten.Location = new Point(169, 61);
            hoten.Margin = new Padding(3, 2, 3, 2);
            hoten.Name = "hoten";
            hoten.Size = new Size(110, 23);
            hoten.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Location = new Point(58, 120);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhap tenphim:";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Location = new Point(94, 218);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Loai ve:";
            // 
            // soghe
            // 
            soghe.Location = new Point(169, 257);
            soghe.Margin = new Padding(3, 2, 3, 2);
            soghe.Name = "soghe";
            soghe.Size = new Size(110, 23);
            soghe.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Location = new Point(98, 262);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Soghe:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 52);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 234);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(326, 354);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Lam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "vé vớt", "vé thường", "vé VIP" });
            comboBox1.Location = new Point(168, 210);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            comboBox2.Location = new Point(169, 120);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 23);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox3.Location = new Point(167, 170);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(111, 23);
            comboBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 170);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "So phong";
            // 
            // LAB1_bai04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(soghe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hoten);
            Controls.Add(label1);
            Name = "LAB1_bai04";
            Text = "bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox hoten;
        private Label label2;
        private Label label3;
        private TextBox soghe;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label5;
    }
}