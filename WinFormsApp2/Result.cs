using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Result : Form
    {
        private const string INTROVERT_DESC =
@"Introverts prefer calm and quiet environments where they can recharge their energy by spending time alone. They tend to think deeply before speaking and value meaningful one-on-one connections. Being alone helps them reflect, regain focus, and feel balanced in daily life.";

        private const string EXTROVERT_DESC =
@"Extroverts feel energized by being around people and enjoy socializing, talking, and sharing ideas with others. They thrive in lively environments and are often outgoing, confident, and expressive. Interaction with others inspires them and keeps them feeling motivated and positive.";

        public Result()
        {
            InitializeComponent();

            // โหลดผล & เซ็ตคอนเทนต์
            this.Load += Result_Load;

            // ปุ่มกลับหน้า Home
            button1.Click += button1_Click;

            // กล่องข้อความ: อ่านอย่างเดียว + ไม่รับโฟกัส
            textBox1.ReadOnly = true;
            textBox1.TabStop = false;
            textBox1.Cursor = Cursors.Arrow;
            textBox1.Enter += (s, e) => button1.Focus();
            textBox1.MouseDown += (s, e) => button1.Focus();

            // รูป
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;
        }

        private void Result_Load(object? sender, EventArgs e)
        {
            var st = AppState.State;

            if (st.CountI > st.CountE)
            {
                this.Text = "Introvert";                 // ใช้ Title ฟอร์มแทน label
                textBox1.Text = INTROVERT_DESC;
                pictureBox1.Image = Properties.Resources.introvert; // เปลี่ยนชื่อให้ตรงกับ resource คุณ
            }
            else if (st.CountE > st.CountI)
            {
                this.Text = "Extrovert";
                textBox1.Text = EXTROVERT_DESC;
                pictureBox1.Image = Properties.Resources.extrovert;
            }
            else
            {
                this.Text = "Balanced (E = I)";
                textBox1.Text =
@"คุณค่อนข้างสมดุลระหว่างการเติมพลังจากผู้คนและการอยู่กับตัวเอง 
ปรับใช้โหมด Introvert/Extrovert ได้ตามสถานการณ์ที่เหมาะสม.";
                pictureBox1.Image = null; // หรือใส่รูป balanced ถ้ามี
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // รีเซ็ตทั้งแบบทดสอบ แล้วกลับ Home
            AppState.Reset();

            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.Activate();
                this.Close();
            }
            else
            {
                var home = new Form1(); // ถ้า Home คุณคือ Form2 ให้เปลี่ยนเป็น new Form2();
                home.Show();
                this.Close();
            }
        }

        // เผื่อ Designer ผูกไว้
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
