namespace LAB1
{
    partial class LAB1_bai08
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            timmonan = new Button();
            xoa = new Button();
            thoat = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 77);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Them mon an";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 79);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 242);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(299, 128);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Them";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timmonan
            // 
            timmonan.Location = new Point(44, 330);
            timmonan.Name = "timmonan";
            timmonan.Size = new Size(102, 37);
            timmonan.TabIndex = 4;
            timmonan.Text = "Tim mon an";
            timmonan.UseVisualStyleBackColor = true;
            timmonan.Click += timmonan_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(299, 334);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 5;
            xoa.Text = "Xoa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(543, 338);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 6;
            thoat.Text = "Thoat";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 27);
            textBox3.TabIndex = 7;
            // 
            // LAB1_bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(timmonan);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LAB1_bai08";
            Text = "LAB1_bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button timmonan;
        private Button xoa;
        private Button thoat;
        private TextBox textBox3;
    }
}