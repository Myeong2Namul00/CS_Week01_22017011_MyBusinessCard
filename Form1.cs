using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer colorTimer = new System.Windows.Forms.Timer();
        Random rand = new Random();
        int count = 0;
        private bool isSadImage = false;
        private BorderStyle pictureBoxOriginalBorderStyle;
        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(
                rand.Next(180, 256),
                rand.Next(180, 256),
                rand.Next(180, 256)
            );

            count++;

            if (count >= 40)
            {
                colorTimer.Stop();
                MessageBox.Show("한번만 바꾸면 재미없으니까 여려번 바꿨습니다", "좋다", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // 저장된 원래 BorderStyle을 보관
            pictureBoxOriginalBorderStyle = pictureBox1.BorderStyle;

            colorTimer.Interval = 50;
            colorTimer.Tick += ColorTimer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);

            form.StartPosition = FormStartPosition.Manual;

            form.Location = new Point(
                this.Location.X + this.Width,
                this.Location.Y
            );

            form.Show();

            // 과제용
            //Random rand = new Random();
            //this.BackColor = Color.FromArgb(rand.Next(180, 256), rand.Next(180, 256), rand.Next(180, 256));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isSadImage)
            {
                MessageBox.Show("얼굴네르지마세요", "으앙", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = pictureBoxOriginalBorderStyle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왜 여길 클릭하지?", "뭐지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "깃허브에 볼거 없어요 그래도 열거임?",
                "깃허브",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/Myeong2Namul00",
                    UseShellExecute = true
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            colorTimer.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isSadImage)
            {
                pictureBox1.BackgroundImage = Properties.Resources.슬픈면상;
                isSadImage = true;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.면상;
                isSadImage = false;
            }
        }
    }
}
