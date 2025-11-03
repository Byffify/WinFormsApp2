using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // เผื่อความชัวร์ให้รูปพอดีกรอบ
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            // ถ้าต้องการให้กล่องข้อความแก้ไม่ได้ ให้ใช้ ReadOnly
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        // EXIT
        private void button1_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show("Exit Program?", "Confirm",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                Application.Exit();
        }

        // NEXT -> เปิด Form2 แล้วซ่อน Form1
        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Owner = this;   // เก็บ reference ไว้กลับมาได้
            this.Hide();
            f2.Show();

            // กันผู้ใช้กด X ปิด Form2 แล้วแอพหายไป
            f2.FormClosed += (s, args) => this.Show();
        }

        // อีเวนต์ TextChanged ของ textBox (ไม่มีอะไรทำก็ปล่อยว่างได้)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
    }
}
