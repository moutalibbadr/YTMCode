namespace YTM
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ADDOp = new System.Windows.Forms.Button();
            this.CB_insertion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBut = new System.Windows.Forms.Button();
            this.SOBut = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Mainpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sign Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // ADDOp
            // 
            this.ADDOp.BackColor = System.Drawing.Color.Red;
            this.ADDOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDOp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ADDOp.FlatAppearance.BorderSize = 0;
            this.ADDOp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADDOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ADDOp.Location = new System.Drawing.Point(179, 313);
            this.ADDOp.Margin = new System.Windows.Forms.Padding(0);
            this.ADDOp.Name = "ADDOp";
            this.ADDOp.Size = new System.Drawing.Size(88, 29);
            this.ADDOp.TabIndex = 15;
            this.ADDOp.Text = "submit";
            this.ADDOp.UseVisualStyleBackColor = false;
            this.ADDOp.Click += new System.EventHandler(this.ADDOp_Click);
            // 
            // CB_insertion
            // 
            this.CB_insertion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_insertion.FormattingEnabled = true;
            this.CB_insertion.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.CB_insertion.Location = new System.Drawing.Point(122, 277);
            this.CB_insertion.Name = "CB_insertion";
            this.CB_insertion.Size = new System.Drawing.Size(210, 21);
            this.CB_insertion.TabIndex = 16;
            this.CB_insertion.Text = "Choose level";
            this.CB_insertion.SelectedIndexChanged += new System.EventHandler(this.Insertion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Insertion test";
            // 
            // BackBut
            // 
            this.BackBut.BackgroundImage = global::YTM.Properties.Resources.back_5121;
            this.BackBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBut.FlatAppearance.BorderSize = 0;
            this.BackBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBut.Location = new System.Drawing.Point(979, 12);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(34, 31);
            this.BackBut.TabIndex = 19;
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.Back_Click);
            // 
            // SOBut
            // 
            this.SOBut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SOBut.BackgroundImage = global::YTM.Properties.Resources.logout_512;
            this.SOBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SOBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SOBut.FlatAppearance.BorderSize = 0;
            this.SOBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SOBut.Location = new System.Drawing.Point(922, 12);
            this.SOBut.Margin = new System.Windows.Forms.Padding(0);
            this.SOBut.Name = "SOBut";
            this.SOBut.Size = new System.Drawing.Size(30, 31);
            this.SOBut.TabIndex = 18;
            this.SOBut.UseVisualStyleBackColor = false;
            this.SOBut.Click += new System.EventHandler(this.Button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::YTM.Properties.Resources.customer_512;
            this.pictureBox3.Location = new System.Drawing.Point(651, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Mainpicture
            // 
            this.Mainpicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mainpicture.BackColor = System.Drawing.Color.Transparent;
            this.Mainpicture.Image = global::YTM.Properties.Resources.Yazaki_company_logo_svg;
            this.Mainpicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mainpicture.Location = new System.Drawing.Point(11, 12);
            this.Mainpicture.Name = "Mainpicture";
            this.Mainpicture.Size = new System.Drawing.Size(272, 56);
            this.Mainpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mainpicture.TabIndex = 2;
            this.Mainpicture.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1025, 600);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.SOBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_insertion);
            this.Controls.Add(this.ADDOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Mainpicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mainpicture;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ADDOp;
        private System.Windows.Forms.ComboBox CB_insertion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SOBut;
        private System.Windows.Forms.Button BackBut;
    }
}