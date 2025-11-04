using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        // --- เสริม: ซ่อน caret (เคอร์เซอร์กระพริบ) เมื่อ TextBox ได้โฟกัส ---
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public Form2()
        {
            InitializeComponent();

            // ผูกอีเวนต์ (ถ้าไม่ได้ผูกจาก Designer)
            this.Load += Form2_Load;
            this.button2.Click += button2_Click;

            // ตั้งค่า TextBox ให้อ่านอย่างเดียว แต่ "ไม่รับโฟกัส"
            textBox1.ReadOnly = true;        // พิมพ์ไม่ได้
            textBox1.TabStop = false;       // กด Tab จะไม่วิ่งมาหากล่องนี้
            textBox1.Cursor = Cursors.Arrow; // เมาส์เป็นลูกศรธรรมดา

            // ถ้าเผลอคลิก/ได้โฟกัส ให้เด้งโฟกัสไปที่ปุ่ม NEXT และซ่อน caret
            textBox1.Enter += (s, e) => { button2.Focus(); HideCaret(textBox1.Handle); };
            textBox1.MouseDown += (s, e) => { button2.Focus(); HideCaret(textBox1.Handle); };
            textBox1.GotFocus += (s, e) => HideCaret(textBox1.Handle);
            textBox1.MouseUp += (s, e) => HideCaret(textBox1.Handle);
        }

        private void Form2_Load(object? sender, EventArgs e)
        {
            // ตอนเปิดฟอร์ม ให้โฟกัสอยู่ที่ปุ่ม NEXT ทันที (เคอร์เซอร์จะไม่ไปกระพริบใน TextBox)
            this.ActiveControl = button2;   // หรือ button2.Select();
        }

        // Update the button2_Click method signature to explicitly allow nullable sender parameter
        private void button2_Click(object? sender, EventArgs e)
        {
            // เปิด Form3 แบบมี Owner เพื่อย้อนกลับมาหน้านี้ได้
            var f3 = new Form3 { Owner = this };
            this.Hide();
            f3.Show();

            // เมื่อปิด Form3 ให้แสดง Form2 กลับมาและโฟกัสที่ปุ่ม NEXT
            f3.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
                button2.Focus();
            };
        }
    }
}
