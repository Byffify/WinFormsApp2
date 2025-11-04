namespace WinFormsApp2
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// // ฟิลด์ประกาศบนสุดของคลาส
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mali", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 51);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Mali", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(94, 167);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(410, 295);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(232, 540);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 8;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 761);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}