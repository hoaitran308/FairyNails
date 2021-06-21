
namespace FairyNails
{
    partial class CheckinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinForm));
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.iconPowerOffCheckin = new System.Windows.Forms.Label();
            this.iconControlPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label999 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.process2CheckinControl1 = new FairyNails.Process2CheckinControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.SuspendLayout();
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Interval = 40;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 40;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // iconPowerOffCheckin
            // 
            this.iconPowerOffCheckin.BackColor = System.Drawing.Color.Transparent;
            this.iconPowerOffCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPowerOffCheckin.Image = ((System.Drawing.Image)(resources.GetObject("iconPowerOffCheckin.Image")));
            this.iconPowerOffCheckin.Location = new System.Drawing.Point(983, 9);
            this.iconPowerOffCheckin.Name = "iconPowerOffCheckin";
            this.iconPowerOffCheckin.Size = new System.Drawing.Size(38, 35);
            this.iconPowerOffCheckin.TabIndex = 0;
            this.iconPowerOffCheckin.Click += new System.EventHandler(this.powerOffCheckin_Click);
            // 
            // iconControlPanel
            // 
            this.iconControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.iconControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconControlPanel.Image = ((System.Drawing.Image)(resources.GetObject("iconControlPanel.Image")));
            this.iconControlPanel.Location = new System.Drawing.Point(939, 9);
            this.iconControlPanel.Name = "iconControlPanel";
            this.iconControlPanel.Size = new System.Drawing.Size(38, 35);
            this.iconControlPanel.TabIndex = 1;
            this.iconControlPanel.Click += new System.EventHandler(this.iconControlPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(674, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 53);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(733, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 53);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(792, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 53);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(792, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 53);
            this.label6.TabIndex = 8;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(733, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 53);
            this.label5.TabIndex = 7;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(674, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 53);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label999
            // 
            this.label999.BackColor = System.Drawing.Color.Transparent;
            this.label999.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label999.Image = ((System.Drawing.Image)(resources.GetObject("label999.Image")));
            this.label999.Location = new System.Drawing.Point(792, 424);
            this.label999.Name = "label999";
            this.label999.Size = new System.Drawing.Size(53, 53);
            this.label999.TabIndex = 14;
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label0.Image = ((System.Drawing.Image)(resources.GetObject("label0.Image")));
            this.label0.Location = new System.Drawing.Point(733, 424);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(53, 53);
            this.label0.TabIndex = 13;
            this.label0.Click += new System.EventHandler(this.label0_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(792, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 53);
            this.label9.TabIndex = 11;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(733, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 53);
            this.label8.TabIndex = 10;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(674, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 53);
            this.label7.TabIndex = 9;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.White;
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumber.Font = new System.Drawing.Font("Roboto Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.phoneNumber.Location = new System.Drawing.Point(656, 207);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(206, 43);
            this.phoneNumber.TabIndex = 15;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.label10.Location = new System.Drawing.Point(704, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 39);
            this.label10.TabIndex = 16;
            this.label10.Text = "FairyNails";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(667, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(639, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 40);
            this.label11.TabIndex = 18;
            this.label11.Text = "Please enter your cell phone number\r\nYour info will not be shared";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(788, 422);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 57);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 19;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(674, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 53);
            this.label12.TabIndex = 20;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // process2CheckinControl1
            // 
            this.process2CheckinControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("process2CheckinControl1.BackgroundImage")));
            this.process2CheckinControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.process2CheckinControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process2CheckinControl1.Location = new System.Drawing.Point(0, 0);
            this.process2CheckinControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.process2CheckinControl1.Name = "process2CheckinControl1";
            this.process2CheckinControl1.Size = new System.Drawing.Size(1033, 653);
            this.process2CheckinControl1.TabIndex = 21;
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 653);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label999);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconControlPanel);
            this.Controls.Add(this.iconPowerOffCheckin);
            this.Controls.Add(this.process2CheckinControl1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckinForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Label iconPowerOffCheckin;
        private System.Windows.Forms.Label iconControlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label999;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.Label label12;
        private Process2CheckinControl process2CheckinControl1;
    }
}