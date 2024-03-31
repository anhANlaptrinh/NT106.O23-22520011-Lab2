namespace LAB2
{
    partial class LAB2_bai03
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
            textBox0 = new RichTextBox();
            buttom0 = new Button();
            SuspendLayout();
            // 
            // textBox0
            // 
            textBox0.Enabled = false;
            textBox0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox0.Location = new Point(288, 97);
            textBox0.Margin = new Padding(5, 4, 5, 4);
            textBox0.Name = "textBox0";
            textBox0.Size = new Size(467, 377);
            textBox0.TabIndex = 6;
            textBox0.Text = "";
            // 
            // buttom0
            // 
            buttom0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttom0.Location = new Point(87, 63);
            buttom0.Margin = new Padding(5, 4, 5, 4);
            buttom0.Name = "buttom0";
            buttom0.Size = new Size(138, 57);
            buttom0.TabIndex = 9;
            buttom0.Text = "Tính";
            buttom0.UseVisualStyleBackColor = true;
            buttom0.Click += buttom0_Click;
            // 
            // LAB2_bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 692);
            Controls.Add(buttom0);
            Controls.Add(textBox0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LAB2_bai03";
            Text = "Lab02_Bai03";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.RichTextBox textBox0;
        private System.Windows.Forms.Button buttom0;
    }
}