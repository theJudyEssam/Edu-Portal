﻿namespace Edu_Portal
{
    partial class Teacher_Materials
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materials_link = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materials Page";
            // 
            // materials_link
            // 
            this.materials_link.Location = new System.Drawing.Point(72, 120);
            this.materials_link.Name = "materials_link";
            this.materials_link.Size = new System.Drawing.Size(296, 26);
            this.materials_link.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(72, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert your link here:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(160, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(8, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "<--";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Teacher_Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 247);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materials_link);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher_Materials";
            this.Text = "Teacher_Materials";
            this.Load += new System.EventHandler(this.Teacher_Materials_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materials_link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}