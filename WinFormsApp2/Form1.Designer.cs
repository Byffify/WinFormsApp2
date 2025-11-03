namespace WinFormsApp2
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
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(594, 450);
            button2.Name = "button2";
            button2.Size = new Size(131, 50);
            button2.TabIndex = 3;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(68, 450);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 4;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(97, 350);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 55);
            textBox1.TabIndex = 5;
            textBox1.Text = "อัญญิกา อรรถกุลกิจการ \r\n6842117026";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(429, 350);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 57);
            textBox2.TabIndex = 6;
            textBox2.Text = "ญาดา วรรณกูล \r\n6842021426";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_3855;
            pictureBox1.Location = new Point(148, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31EA8940_46AC_4B36_B713_FDF622981BFA;
            pictureBox2.Location = new Point(481, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MistyRose;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Angsana New", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.SaddleBrown;
            textBox3.Location = new Point(148, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(482, 67);
            textBox3.TabIndex = 9;
            textBox3.Text = "ก๋วยเตี๋ยวสูตรโบราณน้องอัญน้องหยก";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 561);
            Controls.Add(textBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox3;
    }
}
