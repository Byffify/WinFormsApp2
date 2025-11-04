using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        // ฟอร์มนี้คือ "ข้อที่ 1" → index 0 ใน QuizData/QuizState
        private const int QuestionIndex = 0;

        public Form3()
        {
            InitializeComponent();

            // ผูกอีเวนต์เพิ่มเติม (ใน Designer ผูกไว้แล้วบางส่วน)
            this.Load += Form3_Load;

            // ปุ่มย้อน/ถัดไป
            this.button1.Click += button1_Click;   // BACK
            this.button2.Click += button2_Click;   // NEXT

            // Radio B ยังไม่ได้ผูกใน Designer → ผูกเพิ่ม
            this.radioButton2.CheckedChanged += radioButton2_CheckedChanged;

            // สะดวกกด Enter = NEXT
            this.AcceptButton = button2;

            // ตั้ง TextBox คำถามเป็นแสดงผลอย่างเดียว (ไม่ให้โฟกัส/ไม่เห็น caret)
            textBox2.ReadOnly = true;
            textBox2.TabStop = false;
            textBox2.Cursor = Cursors.Arrow;
            textBox2.Enter += (s, e) => button2.Focus();
            textBox2.MouseDown += (s, e) => button2.Focus();
        }

        // เติมข้อความโจทย์/ตัวเลือก และ restore คำตอบเดิม
        private void Form3_Load(object sender, EventArgs e)
        {
            var q = QuizData.Questions[QuestionIndex];
            textBox2.Text = q.Question;
            radioButton1.Text = q.A;
            radioButton2.Text = q.B;

            // คืนค่าคำตอบเดิมถ้ามี
            var ans = AppState.State.Answers[QuestionIndex];
            radioButton1.Checked = ans == 'A';
            radioButton2.Checked = ans == 'B';

            UpdateNextEnabled();
        }

        // A = ฝั่ง E
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'A');
                UpdateNextEnabled();
            }
        }

        // B = ฝั่ง I
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'B');
                UpdateNextEnabled();
            }
        }

        // BACK → กลับหน้า Owner (เช่น Form2)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }

        // NEXT → ไปหน้าถัดไป (ถ้ายังไม่สร้าง Form4 จะแจ้งเตือนเฉย ๆ)
        private void button2_Click(object sender, EventArgs e)
        {
            if (AppState.State.Answers[QuestionIndex] == null)
            {
                MessageBox.Show("โปรดเลือกคำตอบ (A หรือ B) ก่อนกด NEXT",
                    "ยังไม่ได้เลือก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ ถ้ามี Form4 แล้ว ให้เอาคอมเมนต์ 4 บรรทัดล่างนี้ออก
            var f4 = new Form4 { Owner = this.Owner };
            this.Hide();
            f4.Show();
            f4.FormClosed += (s, args) => this.Close();
        }

        // เปิด/ปิดปุ่ม NEXT ตามสถานะการเลือก
        private void UpdateNextEnabled()
        {
            button2.Enabled = AppState.State.Answers[QuestionIndex] != null;
        }

        // ใน Designer มี textBox2_TextChanged ถูกอ้างไว้ → ทำเมธอดว่างกัน error
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // ไม่ต้องทำอะไร (เราเซ็ตข้อความเอง)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
