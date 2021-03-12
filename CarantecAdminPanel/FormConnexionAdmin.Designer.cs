namespace CarantecAdminPanel
{
    partial class FormConnexionAdmin
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
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.BoutonExitCoAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLogAdmin = new System.Windows.Forms.TextBox();
            this.TextBoxMdpAdmin = new System.Windows.Forms.TextBox();
            this.BoutonValiderCoAdmin = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.BoutonExitCoAdmin);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(799, 103);
            this.gradientPanel1.TabIndex = 0;
            // 
            // BoutonExitCoAdmin
            // 
            this.BoutonExitCoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BoutonExitCoAdmin.ForeColor = System.Drawing.Color.Snow;
            this.BoutonExitCoAdmin.Location = new System.Drawing.Point(747, 12);
            this.BoutonExitCoAdmin.Name = "BoutonExitCoAdmin";
            this.BoutonExitCoAdmin.Size = new System.Drawing.Size(41, 30);
            this.BoutonExitCoAdmin.TabIndex = 2;
            this.BoutonExitCoAdmin.Text = "X";
            this.BoutonExitCoAdmin.UseVisualStyleBackColor = false;
            this.BoutonExitCoAdmin.Click += new System.EventHandler(this.BoutonExitCoAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(227, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 356);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(42, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connexion Administrateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(143, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(77, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe :";
            // 
            // TextBoxLogAdmin
            // 
            this.TextBoxLogAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBoxLogAdmin.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLogAdmin.ForeColor = System.Drawing.Color.Snow;
            this.TextBoxLogAdmin.Location = new System.Drawing.Point(230, 229);
            this.TextBoxLogAdmin.Name = "TextBoxLogAdmin";
            this.TextBoxLogAdmin.Size = new System.Drawing.Size(354, 33);
            this.TextBoxLogAdmin.TabIndex = 4;
            // 
            // TextBoxMdpAdmin
            // 
            this.TextBoxMdpAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBoxMdpAdmin.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMdpAdmin.ForeColor = System.Drawing.Color.Snow;
            this.TextBoxMdpAdmin.Location = new System.Drawing.Point(230, 304);
            this.TextBoxMdpAdmin.Name = "TextBoxMdpAdmin";
            this.TextBoxMdpAdmin.PasswordChar = '*';
            this.TextBoxMdpAdmin.Size = new System.Drawing.Size(354, 33);
            this.TextBoxMdpAdmin.TabIndex = 5;
            // 
            // BoutonValiderCoAdmin
            // 
            this.BoutonValiderCoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BoutonValiderCoAdmin.Font = new System.Drawing.Font("Netflix Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonValiderCoAdmin.ForeColor = System.Drawing.Color.Snow;
            this.BoutonValiderCoAdmin.Location = new System.Drawing.Point(629, 391);
            this.BoutonValiderCoAdmin.Name = "BoutonValiderCoAdmin";
            this.BoutonValiderCoAdmin.Size = new System.Drawing.Size(158, 42);
            this.BoutonValiderCoAdmin.TabIndex = 6;
            this.BoutonValiderCoAdmin.Text = "VALIDER";
            this.BoutonValiderCoAdmin.UseVisualStyleBackColor = false;
            this.BoutonValiderCoAdmin.Click += new System.EventHandler(this.BoutonValiderCoAdmin_Click);
            // 
            // FormConnexionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoutonValiderCoAdmin);
            this.Controls.Add(this.TextBoxMdpAdmin);
            this.Controls.Add(this.TextBoxLogAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnexionAdmin";
            this.Text = "FormConnexionAdmin";
            this.Load += new System.EventHandler(this.FormConnexionAdmin_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLogAdmin;
        private System.Windows.Forms.TextBox TextBoxMdpAdmin;
        private System.Windows.Forms.Button BoutonExitCoAdmin;
        private System.Windows.Forms.Button BoutonValiderCoAdmin;
    }
}