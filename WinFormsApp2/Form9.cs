using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class Form9 : Form
    {
        private const int QuestionIndex = 6; // ข้อ 7 (สุดท้าย)

        public Form9()
        {
            InitializeComponent();

            this.Load += Form9_Load;

            button1.Click += button1_Click;   // BACK
            button2.Click += button2_Click;   // NEXT → RESULT

            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;

            this.AcceptButton = button2;

            textBox2.ReadOnly = true;
            textBox2.TabStop = false;
            textBox2.Cursor = Cursors.Arrow;
            textBox2.Enter += (s, e) => button2.Focus();
            textBox2.MouseDown += (s, e) => button2.Focus();
        }

        private void Form9_Load(object? sender, EventArgs e)
        {
            var q = QuizData.Questions[QuestionIndex];
            textBox2.Text = q.Question;
            radioButton1.Text = q.A;
            radioButton2.Text = q.B;

            var ans = AppState.State.Answers[QuestionIndex];
            radioButton1.Checked = ans == 'A';
            radioButton2.Checked = ans == 'B';

            button2.Text = "RESULT";
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

        private void button1_Click(object? sender, EventArgs e)
        {
            var prev = new Form8 { Owner = this.Owner };
            this.Hide();
            prev.Show();
            prev.FormClosed += (s, args) => this.Close();
        }

        // ▶ ไปหน้าสรุปผล
        private void button2_Click(object? sender, EventArgs e)
        {
            if (AppState.State.Answers[QuestionIndex] == null)
            {
                MessageBox.Show("โปรดเลือกคำตอบก่อน", "ยังไม่ได้เลือก");
                return;
            }

            var result = new Result { Owner = this.Owner };
            this.Hide();
            result.Show();
            result.FormClosed += (s, args) => this.Close();
        }

        private void UpdateNextEnabled()
            => button2.Enabled = AppState.State.Answers[QuestionIndex] != null;

        private void textBox2_TextChanged(object? sender, EventArgs e) { }
        private void pictureBox1_Click(object? sender, EventArgs e) { }
    }
}
