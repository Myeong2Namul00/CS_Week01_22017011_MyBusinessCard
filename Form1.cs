using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer colorTimer = new System.Windows.Forms.Timer();
        Random rand = new Random();
        int count = 0;
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
                MessageBox.Show("왜 아무의미없다는데 누르는거지", "뭐지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();

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
    }
}
