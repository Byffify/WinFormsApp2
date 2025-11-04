using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        // ฟอร์มนี้ = ข้อที่ 2 → index 1
        private const int QuestionIndex = 1;

        public Form4()
        {
            InitializeComponent();

            // ผูกอีเวนต์
            this.Load += Form4_Load;

            this.button1.Click += button1_Click;   // BACK
            this.button2.Click += button2_Click;   // NEXT

            this.radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            this.radioButton2.CheckedChanged += radioButton2_CheckedChanged;

            this.AcceptButton = button2;

            textBox2.ReadOnly = true;
            textBox2.TabStop = false;
            textBox2.Cursor = Cursors.Arrow;
            textBox2.Enter += (s, e) => button2.Focus();
            textBox2.MouseDown += (s, e) => button2.Focus();
        }

        private void Form4_Load(object? sender, EventArgs e)
        {
            var q = QuizData.Questions[QuestionIndex];
            textBox2.Text = q.Question;
            radioButton1.Text = q.A;
            radioButton2.Text = q.B;

            var ans = AppState.State.Answers[QuestionIndex];
            radioButton1.Checked = ans == 'A';
            radioButton2.Checked = ans == 'B';

            UpdateNextEnabled();
        }

        private void radioButton1_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'A');
                UpdateNextEnabled();
            }
        }

        private void radioButton2_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'B');
                UpdateNextEnabled();
            }
        }

        // ✅ BACK → กลับไป Form3
        private void button1_Click(object? sender, EventArgs e)
        {
            var f3 = new Form3 { Owner = this.Owner }; // owner ควรเป็นตัวเดียวกับก่อนหน้า (เช่น Form2)
            this.Hide();
            f3.Show();
            f3.FormClosed += (s, args) => this.Close();
        }

        // ▶ NEXT → ไป Form5 (ข้อที่ 3 → index 2)
        private void button2_Click(object? sender, EventArgs e)
        {
            if (AppState.State.Answers[QuestionIndex] == null)
            {
                MessageBox.Show("โปรดเลือกคำตอบ (A หรือ B) ก่อนกด NEXT",
                    "ยังไม่ได้เลือก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ถ้ามี Form5 แล้วใช้โค้ดนี้
            var f5 = new Form5 { Owner = this.Owner };
            this.Hide();
            f5.Show();
            f5.FormClosed += (s, args) => this.Close();

            // ชั่วคราว ถ้ายังไม่มี Form5:
            //MessageBox.Show("NEXT: ไปข้อถัดไป (สร้าง Form5 แล้วเปิดจากตรงนี้)", "ถัดไป");
        }

        private void UpdateNextEnabled()
        {
            button2.Enabled = AppState.State.Answers[QuestionIndex] != null;
        }

        private void textBox2_TextChanged(object? sender, EventArgs e) { }
        private void pictureBox1_Click(object? sender, EventArgs e) { }
    }
}
