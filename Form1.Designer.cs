namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.면상;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("궁서", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(297, 167);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 1;
            button1.Text = "색상을 변경하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("궁서", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(9, 129);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 2;
            label1.Text = "김동환";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("궁서", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(9, 174);
            label2.Name = "label2";
            label2.Size = new Size(279, 32);
            label2.TabIndex = 3;
            label2.Text = "☎ 01064676663";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("궁서", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(135, 49);
            label3.Name = "label3";
            label3.Size = new Size(204, 21);
            label3.TabIndex = 4;
            label3.Text = "수원대 22학번 사내";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("궁서", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(135, 12);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 5;
            label4.Text = "프로필";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("궁서", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(135, 80);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 6;
            label5.Text = "삶을 잘 사는중";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("궁서", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(297, 139);
            button2.Name = "button2";
            button2.Size = new Size(145, 24);
            button2.TabIndex = 7;
            button2.Text = "아무의미없는버튼";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("궁서", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(297, 109);
            button3.Name = "button3";
            button3.Size = new Size(145, 24);
            button3.TabIndex = 8;
            button3.Text = "깃허브";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(454, 231);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("돋움", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "김 동환의 프로필";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}
