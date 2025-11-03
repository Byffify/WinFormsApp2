using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f3 = new Form3 { Owner = this.Owner }; // Owner เดิมคือ Form1
            this.Hide();
            f3.Show();
            f3.FormClosed += (s, args) => this.Show();
        }

    }
}
