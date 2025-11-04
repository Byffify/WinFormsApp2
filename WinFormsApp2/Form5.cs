using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        // ฟอร์มนี้ = ข้อที่ 3 → index 2
        private const int QuestionIndex = 2;

        public Form5()
        {
            InitializeComponent();

            // ผูกอีเวนต์
            this.Load += Form5_Load;

            this.button1.Click += button1_Click;   // BACK
            this.button2.Click += button2_Click;   // NEXT

            this.radioButton1.CheckedChanged += radioButton1_CheckedChanged; // A = E
            this.radioButton2.CheckedChanged += radioButton2_CheckedChanged; // B = I

            // Enter = NEXT
            this.AcceptButton = button2;

            // กล่องคำถามให้อ่านอย่างเดียวและไม่โฟกัส
            textBox2.ReadOnly = true;
            textBox2.TabStop = false;
            textBox2.Cursor = Cursors.Arrow;
            textBox2.Enter += (s, e) => button2.Focus();
            textBox2.MouseDown += (s, e) => button2.Focus();
        }

        private void Form5_Load(object? sender, EventArgs e)
        {
            var q = QuizData.Questions[QuestionIndex];
            textBox2.Text = q.Question;
            radioButton1.Text = q.A;
            radioButton2.Text = q.B;

            // คืนค่าเลือกเดิม (ถ้ามี)
            var ans = AppState.State.Answers[QuestionIndex];
            radioButton1.Checked = ans == 'A';
            radioButton2.Checked = ans == 'B';

            UpdateNextEnabled();
        }

        private void radioButton1_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'A'); // A = E
                UpdateNextEnabled();
            }
        }

        private void radioButton2_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                AppState.State.SetAnswer(QuestionIndex, 'B'); // B = I
                UpdateNextEnabled();
            }
        }

        // BACK → กลับไป Form4
        private void button1_Click(object? sender, EventArgs e)
        {
            var f4 = new Form4 { Owner = this.Owner };
            this.Hide();
            f4.Show();
            f4.FormClosed += (s, args) => this.Close();
        }

        // NEXT → ไป Form6 (ข้อที่ 4 → index 3)
        private void button2_Click(object? sender, EventArgs e)
        {
            if (AppState.State.Answers[QuestionIndex] == null)
            {
                MessageBox.Show("โปรดเลือกคำตอบ (A หรือ B) ก่อนกด NEXT",
                    "ยังไม่ได้เลือก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ถ้ามี Form6 แล้วปลดคอมเมนต์โค้ดด้านล่าง
            var f6 = new Form6 { Owner = this.Owner };
            this.Hide();
            f6.Show();
            f6.FormClosed += (s, args) => this.Close();

            // ชั่วคราวถ้ายังไม่มี Form6
            //MessageBox.Show("NEXT: ไปข้อถัดไป (สร้าง Form6 แล้วเปิดจากตรงนี้)", "ถัดไป");
        }

        private void UpdateNextEnabled()
        {
            button2.Enabled = AppState.State.Answers[QuestionIndex] != null;
        }

        // ถ้า Designer ผูก TextChanged ไว้
        private void textBox2_TextChanged(object? sender, EventArgs e) { }
        private void pictureBox1_Click(object? sender, EventArgs e) { }
    }
}
