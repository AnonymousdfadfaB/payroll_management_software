namespace payroll_management_software
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            label4 = new Label();
            button7 = new Button();
            panel3 = new Panel();
            uC_Employee1 = new UC_Employee();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 1367);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(51, 842);
            button4.Name = "button4";
            button4.Size = new Size(218, 119);
            button4.TabIndex = 4;
            button4.Text = "Attendance";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(51, 665);
            button3.Name = "button3";
            button3.Size = new Size(218, 119);
            button3.TabIndex = 3;
            button3.Text = "Salary";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(51, 490);
            button2.Name = "button2";
            button2.Size = new Size(218, 119);
            button2.TabIndex = 2;
            button2.Text = "Employee";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(51, 302);
            button1.Name = "button1";
            button1.Size = new Size(218, 127);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(321, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(1907, 168);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(1160, 28);
            button6.Name = "button6";
            button6.Size = new Size(218, 118);
            button6.TabIndex = 3;
            button6.Text = "Reports";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(1441, 28);
            button5.Name = "button5";
            button5.Size = new Size(218, 118);
            button5.TabIndex = 2;
            button5.Text = "Setting";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(982, 29);
            label4.Name = "label4";
            label4.Size = new Size(603, 47);
            label4.TabIndex = 2;
            label4.Text = "Payroll Management Software";
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(2042, 27);
            button7.Name = "button7";
            button7.Size = new Size(65, 64);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(1907, 1037);
            panel3.TabIndex = 4;
            // 
            // uC_Employee1
            // 
            uC_Employee1.BackColor = Color.White;
            uC_Employee1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_Employee1.Location = new Point(328, 408);
            uC_Employee1.Margin = new Padding(4, 3, 4, 3);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(2500, 1468);
            uC_Employee1.TabIndex = 4;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2233, 1367);
            Controls.Add(uC_Employee1);
            Controls.Add(button7);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashBoard";
            Text = "DashBoard";
            WindowState = FormWindowState.Maximized;
            Load += DashBoard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label4;
        private Button button7;
        private Panel panel3;
        private UC_Employee uC_Employee1;
    }
}