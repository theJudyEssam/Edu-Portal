namespace Edu_Portal
{
    partial class Administration
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quote = new System.Windows.Forms.TextBox();
            this.study = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.title = new System.Windows.Forms.TextBox();
            this.edu_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(32, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(32, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Teacher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(32, 512);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Announcements";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(24, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 104);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 528);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.quote);
            this.panel3.Controls.Add(this.study);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.welcome);
            this.panel3.Location = new System.Drawing.Point(336, 128);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 159);
            this.panel3.TabIndex = 30;
            // 
            // quote
            // 
            this.quote.BackColor = System.Drawing.Color.CadetBlue;
            this.quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quote.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.ForeColor = System.Drawing.Color.Lavender;
            this.quote.Location = new System.Drawing.Point(40, 88);
            this.quote.Margin = new System.Windows.Forms.Padding(2);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(213, 27);
            this.quote.TabIndex = 3;
            this.quote.Text = "STAY UPDATED !";
            // 
            // study
            // 
            this.study.Image = global::Edu_Portal.Properties.Resources.educational_tool;
            this.study.Location = new System.Drawing.Point(456, 8);
            this.study.Margin = new System.Windows.Forms.Padding(2);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(160, 134);
            this.study.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.study.TabIndex = 2;
            this.study.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Elephant", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.Location = new System.Drawing.Point(199, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 42);
            this.name.TabIndex = 1;
            this.name.Text = "hello !";
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.CadetBlue;
            this.welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome.Font = new System.Drawing.Font("Elephant", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Blue;
            this.welcome.Location = new System.Drawing.Point(34, 34);
            this.welcome.Margin = new System.Windows.Forms.Padding(2);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(308, 42);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome, ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Azure;
            this.panel6.Controls.Add(this.generateButton);
            this.panel6.Controls.Add(this.quoteLabel);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(680, 328);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 256);
            this.panel6.TabIndex = 35;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(24, 304);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(239, 40);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLabel.Location = new System.Drawing.Point(32, 88);
            this.quoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(75, 30);
            this.quoteLabel.TabIndex = 1;
            this.quoteLabel.Text = "quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quote of the Day";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.CadetBlue;
            this.calendar.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.Color.Black;
            this.calendar.Location = new System.Drawing.Point(336, 328);
            this.calendar.Margin = new System.Windows.Forms.Padding(7);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 34;
            this.calendar.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.CadetBlue;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.AliceBlue;
            this.title.Location = new System.Drawing.Point(56, 213);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(184, 36);
            this.title.TabIndex = 37;
            this.title.Text = "Edu Portal";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edu_icon
            // 
            this.edu_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edu_icon.BackColor = System.Drawing.Color.CadetBlue;
            this.edu_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edu_icon.Image = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.InitialImage = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.Location = new System.Drawing.Point(88, 120);
            this.edu_icon.Margin = new System.Windows.Forms.Padding(2);
            this.edu_icon.Name = "edu_icon";
            this.edu_icon.Size = new System.Drawing.Size(120, 85);
            this.edu_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edu_icon.TabIndex = 36;
            this.edu_icon.TabStop = false;
            this.edu_icon.Visible = false;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1017, 610);
            this.Controls.Add(this.title);
            this.Controls.Add(this.edu_icon);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administration";
            this.Text = "Administrations";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox quote;
        private System.Windows.Forms.PictureBox study;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox welcome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.PictureBox edu_icon;
    }
}