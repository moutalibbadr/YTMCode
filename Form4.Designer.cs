namespace YTM
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Chrono = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.PB = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mainpicture = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1648, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1816, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sign Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1882, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Back";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LimeGreen;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(1144, 654);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 31);
            this.Start.TabIndex = 22;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Maroon;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(1245, 654);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(84, 31);
            this.Stop.TabIndex = 23;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Chrono
            // 
            this.Chrono.AutoSize = true;
            this.Chrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chrono.Location = new System.Drawing.Point(933, 267);
            this.Chrono.Name = "Chrono";
            this.Chrono.Size = new System.Drawing.Size(0, 24);
            this.Chrono.TabIndex = 29;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P1.Image = global::YTM.Properties.Resources.wrong_2_512;
            this.P1.Location = new System.Drawing.Point(708, 464);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(129, 90);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 30;
            this.P1.TabStop = false;
            // 
            // PB
            // 
            this.PB.Animation = 0;
            this.PB.AnimationStep = 10;
            this.PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB.BackgroundImage")));
            this.PB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.PB.BorderRadius = 5;
            this.PB.BorderThickness = 2;
            this.PB.Location = new System.Drawing.Point(640, 352);
            this.PB.MaximumValue = 100;
            this.PB.MinimumValue = 0;
            this.PB.Name = "PB";
            this.PB.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.PB.ProgressColorLeft = System.Drawing.Color.ForestGreen;
            this.PB.ProgressColorRight = System.Drawing.Color.Red;
            this.PB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PB.Size = new System.Drawing.Size(689, 21);
            this.PB.TabIndex = 25;
            this.PB.TabStop = false;
            this.PB.Value = 80;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C3.Image = global::YTM.Properties.Resources.Tick_Mark_Dark_512;
            this.C3.Location = new System.Drawing.Point(1129, 464);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(129, 90);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 20;
            this.C3.TabStop = false;
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C2.Image = global::YTM.Properties.Resources.Tick_Mark_Dark_512;
            this.C2.Location = new System.Drawing.Point(919, 464);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(129, 90);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 19;
            this.C2.TabStop = false;
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C1.Image = global::YTM.Properties.Resources.Tick_Mark_Dark_512;
            this.C1.Location = new System.Drawing.Point(708, 464);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(129, 90);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 18;
            this.C1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::YTM.Properties.Resources.Insertionplatformetest;
            this.pictureBox4.Location = new System.Drawing.Point(640, 396);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(689, 231);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::YTM.Properties.Resources.customer_512;
            this.pictureBox3.Location = new System.Drawing.Point(1612, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YTM.Properties.Resources.logout_512;
            this.pictureBox2.Location = new System.Drawing.Point(1823, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YTM.Properties.Resources.back_512;
            this.pictureBox1.Location = new System.Drawing.Point(1878, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Mainpicture
            // 
            this.Mainpicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mainpicture.BackColor = System.Drawing.Color.Transparent;
            this.Mainpicture.Image = global::YTM.Properties.Resources.Yazaki_company_logo_svg;
            this.Mainpicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mainpicture.Location = new System.Drawing.Point(24, 30);
            this.Mainpicture.Name = "Mainpicture";
            this.Mainpicture.Size = new System.Drawing.Size(404, 95);
            this.Mainpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mainpicture.TabIndex = 10;
            this.Mainpicture.TabStop = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P2.Image = global::YTM.Properties.Resources.wrong_2_512;
            this.P2.Location = new System.Drawing.Point(919, 464);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(129, 90);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2.TabIndex = 31;
            this.P2.TabStop = false;
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P3.Image = global::YTM.Properties.Resources.wrong_2_512;
            this.P3.Location = new System.Drawing.Point(1129, 464);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(129, 90);
            this.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P3.TabIndex = 32;
            this.P3.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Chrono);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mainpicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormInsertionB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Mainpicture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private Bunifu.UI.Winforms.BunifuProgressBar PB;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel Chrono;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P3;
    }
}