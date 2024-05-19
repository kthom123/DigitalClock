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
            lblTime = new Label();
            lblSecond = new Label();
            lblDate = new Label();
            lblDay = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(70, 41);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(353, 159);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecond.ForeColor = Color.White;
            lblSecond.Location = new Point(493, 119);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(77, 62);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "22";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(70, 302);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(379, 81);
            lblDate.TabIndex = 2;
            lblDate.Text = "June 25 2016";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(493, 302);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(268, 81);
            lblDay.TabIndex = 3;
            lblDay.Text = "Saturday";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSecond;
        private Label lblDate;
        private Label lblDay;
    }
}
