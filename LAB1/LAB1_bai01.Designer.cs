namespace LAB1
{
    partial class LAB1_bai01
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(142, 167);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(155, 293);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(178, 56);
            label3.Name = "label3";
            label3.Size = new Size(302, 37);
            label3.TabIndex = 2;
            label3.Text = "Tính tống 2 số nguyên";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 167);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 293);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(293, 367);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 48);
            button1.TabIndex = 5;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(203, 460);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 6;
            label4.Text = "Tổng:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(333, 460);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 27);
            textBox3.TabIndex = 7;
            // 
            // LAB1_bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 600);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LAB1_bai01";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
    }
}