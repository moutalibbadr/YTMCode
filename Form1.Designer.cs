namespace YTM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.Mainpicture = new System.Windows.Forms.PictureBox();
            this.bunifuColorTransition1 = new BunifuColorTransition.BunifuColorTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.LogIn, "LogIn");
            this.LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogIn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LogIn.FlatAppearance.BorderSize = 0;
            this.LogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogIn.Name = "LogIn";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Mainpicture
            // 
            this.Mainpicture.Image = global::YTM.Properties.Resources.Yazaki_company_logo_svg;
            resources.ApplyResources(this.Mainpicture, "Mainpicture");
            this.Mainpicture.Name = "Mainpicture";
            this.Mainpicture.TabStop = false;
            this.Mainpicture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.AutoTransition = false;
            this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Orange};
            this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.Interval = 10;
            this.bunifuColorTransition1.ProgessValue = 0;
            this.bunifuColorTransition1.StartColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.TransitionControl = null;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Mainpicture);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox Mainpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BunifuColorTransition.BunifuColorTransition bunifuColorTransition1;
    }
}

