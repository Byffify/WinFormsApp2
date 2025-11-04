using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Result : Form
    {
        private const string INTROVERT_TITLE = "Introvert";
        private const string INTROVERT_DESC =
@"Introverts prefer calm and quiet environments where they can recharge their energy by spending time alone. They tend to think deeply before speaking and value meaningful one-on-one connections. Being alone helps them reflect, regain focus, and feel balanced in daily life.";

        private const string EXTROVERT_TITLE = "Extrovert";
        private const string EXTROVERT_DESC =
@"Extroverts feel energized by being around people and enjoy socializing, talking, and sharing ideas with others. They thrive in lively environments and are often outgoing, confident, and expressive. Interaction with others inspires them and keeps them feeling motivated and positive.";

        public Result()
        {
            InitializeComponent();

            // ผูกอีเวนต์โหลด (ถ้า Designer ยังไม่ได้ผูก)
            this.Load += Result_Load;

            button1.Click += button1_Click;

            // กันเคอร์เซอร์มาที่กล่องข้อความ
            textBox1.Enter += (s, e) => this.ActiveControl = label1;
            textBox1.MouseDown += (s, e) => this.ActiveControl = label1;
        }

        private void Result_Load(object? sender, EventArgs e)
        {
            var st = AppState.State;

            if (st.CountI > st.CountE)
            {
                label1.Text = INTROVERT_TITLE;
                textBox1.Text = INTROVERT_DESC;
            }
            else if (st.CountE > st.CountI)
            {
                label1.Text = EXTROVERT_TITLE;
                textBox1.Text = EXTROVERT_DESC;
            }
            else
            {
                label1.Text = "Balanced (E = I)";
                textBox1.Text =
@"คุณค่อนข้างสมดุลระหว่างการเติมพลังจากผู้คนและการอยู่กับตัวเอง 
ปรับใช้โหมด Introvert/Extrovert ได้ตามสถานการณ์ที่เหมาะสม.";
            }
        }
        private void button1_Click(object? sender, EventArgs e)
        {
            // ล้างทั้งแบบทดสอบ
            AppState.Reset();         // หรือ AppState.State.ClearAll();

            // กลับหน้า Home
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.Activate();
                this.Close();
            }
            else
            {
                var home = new Form1();
                home.Show();
                this.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
