namespace Digital_Clock
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSecond = new Label();
            lblDate = new Label();
            lblDay = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BorderStyle = BorderStyle.FixedSingle;
            lblTime.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(174, 48);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(355, 161);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecond.ForeColor = Color.White;
            lblSecond.Location = new Point(574, 126);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(79, 64);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "22";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.FixedSingle;
            lblDate.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(50, 288);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(381, 83);
            lblDate.TabIndex = 2;
            lblDate.Text = "June 25 2016";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BorderStyle = BorderStyle.FixedSingle;
            lblDay.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(484, 288);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(270, 83);
            lblDay.TabIndex = 3;
            lblDay.Text = "Saturday";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDay);
            Controls.Add(lblDate);
            Controls.Add(lblSecond);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSecond;
        private Label lblDate;
        private Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}
