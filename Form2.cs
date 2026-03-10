using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBusinessCard
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.BackColor = Color.FromArgb(255, 192, 192);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.BackColor = Color.FromArgb(255, 255, 192);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.BackColor = Color.FromArgb(192, 255, 192);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.BackColor = Color.FromArgb(192, 255, 255);
            this.Close();
        }
    }
}
