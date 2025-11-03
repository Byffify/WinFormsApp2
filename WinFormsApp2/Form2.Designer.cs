namespace WinFormsApp2
{
    partial class Form2
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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(598, 454);
            button2.Name = "button2";
            button2.Size = new Size(131, 50);
            button2.TabIndex = 10;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;   // << ผูกอีเวนต์ NEXT
            // 
            // button1
            // 
            button1.Location = new Point(93, 454);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 11;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;   // << ผูกอีเวนต์ BACK
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
    }
}