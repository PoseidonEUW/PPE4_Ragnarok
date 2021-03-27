using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormCRUDUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDUtilisateur));
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdherentUser = new System.Windows.Forms.RadioButton();
            this.rbAnimUser = new System.Windows.Forms.RadioButton();
            this.rbArtisteUser = new System.Windows.Forms.RadioButton();
            this.rbIntSpeUser = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmailAdherentUser = new System.Windows.Forms.TextBox();
            this.tbLogAdherentUser = new System.Windows.Forms.TextBox();
            this.tbMdpAdherentUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRoleArtisteUser = new System.Windows.Forms.TextBox();
            this.tbLienFBArtisteUser = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(374, 938);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(465, 24);
            this.labelError.TabIndex = 19;
            this.labelError.Text = "ERROR SAMPLE ERROR SAMPLE ERROR SAMPLE";
            this.labelError.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btnEnregistrer.Location = new System.Drawing.Point(427, 968);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // labelActionTitle
            // 
            this.labelActionTitle.AutoSize = true;
            this.labelActionTitle.Font = new System.Drawing.Font("Netflix Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionTitle.Location = new System.Drawing.Point(375, 129);
            this.labelActionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActionTitle.Name = "labelActionTitle";
            this.labelActionTitle.Size = new System.Drawing.Size(420, 34);
            this.labelActionTitle.TabIndex = 16;
            this.labelActionTitle.Text = "MODIFICATION/SUPPRESSION";
            this.labelActionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 4);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1071, 103);
            this.gradientPanel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(360, -25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrenom.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.ForeColor = System.Drawing.Color.White;
            this.tbPrenom.Location = new System.Drawing.Point(395, 301);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(349, 28);
            this.tbPrenom.TabIndex = 27;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(310, 300);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(79, 24);
            this.labelPrenom.TabIndex = 26;
            this.labelPrenom.Text = "Prénom";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNom.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.ForeColor = System.Drawing.Color.White;
            this.tbNom.Location = new System.Drawing.Point(395, 226);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(349, 28);
            this.tbNom.TabIndex = 25;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(337, 225);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(52, 24);
            this.labelNom.TabIndex = 24;
            this.labelNom.Text = "Nom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIntSpeUser);
            this.groupBox1.Controls.Add(this.rbArtisteUser);
            this.groupBox1.Controls.Add(this.rbAnimUser);
            this.groupBox1.Controls.Add(this.rbAdherentUser);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(79, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 91);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rôles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbAdherentUser
            // 
            this.rbAdherentUser.AutoSize = true;
            this.rbAdherentUser.Checked = true;
            this.rbAdherentUser.Location = new System.Drawing.Point(55, 39);
            this.rbAdherentUser.Name = "rbAdherentUser";
            this.rbAdherentUser.Size = new System.Drawing.Size(105, 25);
            this.rbAdherentUser.TabIndex = 0;
            this.rbAdherentUser.TabStop = true;
            this.rbAdherentUser.Text = "Adhérent";
            this.rbAdherentUser.UseVisualStyleBackColor = true;
            // 
            // rbAnimUser
            // 
            this.rbAnimUser.AutoSize = true;
            this.rbAnimUser.Location = new System.Drawing.Point(279, 39);
            this.rbAnimUser.Name = "rbAnimUser";
            this.rbAnimUser.Size = new System.Drawing.Size(113, 25);
            this.rbAnimUser.TabIndex = 1;
            this.rbAnimUser.Text = "Animateur";
            this.rbAnimUser.UseVisualStyleBackColor = true;
            // 
            // rbArtisteUser
            // 
            this.rbArtisteUser.AutoSize = true;
            this.rbArtisteUser.Location = new System.Drawing.Point(501, 39);
            this.rbArtisteUser.Name = "rbArtisteUser";
            this.rbArtisteUser.Size = new System.Drawing.Size(93, 25);
            this.rbArtisteUser.TabIndex = 2;
            this.rbArtisteUser.Text = "Artistes";
            this.rbArtisteUser.UseVisualStyleBackColor = true;
            // 
            // rbIntSpeUser
            // 
            this.rbIntSpeUser.AutoSize = true;
            this.rbIntSpeUser.Location = new System.Drawing.Point(678, 39);
            this.rbIntSpeUser.Name = "rbIntSpeUser";
            this.rbIntSpeUser.Size = new System.Drawing.Size(222, 25);
            this.rbIntSpeUser.TabIndex = 3;
            this.rbIntSpeUser.Text = "Intervenants spécialisés";
            this.rbIntSpeUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email adhérent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Login adhérent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 796);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mot de passe adhérent";
            // 
            // tbEmailAdherentUser
            // 
            this.tbEmailAdherentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbEmailAdherentUser.ForeColor = System.Drawing.Color.White;
            this.tbEmailAdherentUser.Location = new System.Drawing.Point(211, 586);
            this.tbEmailAdherentUser.Name = "tbEmailAdherentUser";
            this.tbEmailAdherentUser.Size = new System.Drawing.Size(260, 28);
            this.tbEmailAdherentUser.TabIndex = 32;
            // 
            // tbLogAdherentUser
            // 
            this.tbLogAdherentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbLogAdherentUser.Enabled = false;
            this.tbLogAdherentUser.ForeColor = System.Drawing.Color.White;
            this.tbLogAdherentUser.Location = new System.Drawing.Point(211, 690);
            this.tbLogAdherentUser.Name = "tbLogAdherentUser";
            this.tbLogAdherentUser.Size = new System.Drawing.Size(260, 28);
            this.tbLogAdherentUser.TabIndex = 33;
            // 
            // tbMdpAdherentUser
            // 
            this.tbMdpAdherentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbMdpAdherentUser.Enabled = false;
            this.tbMdpAdherentUser.ForeColor = System.Drawing.Color.White;
            this.tbMdpAdherentUser.Location = new System.Drawing.Point(211, 793);
            this.tbMdpAdherentUser.Name = "tbMdpAdherentUser";
            this.tbMdpAdherentUser.Size = new System.Drawing.Size(260, 28);
            this.tbMdpAdherentUser.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Rôle artiste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 748);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Lien Facebook artiste";
            // 
            // tbRoleArtisteUser
            // 
            this.tbRoleArtisteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbRoleArtisteUser.Enabled = false;
            this.tbRoleArtisteUser.ForeColor = System.Drawing.Color.White;
            this.tbRoleArtisteUser.Location = new System.Drawing.Point(742, 642);
            this.tbRoleArtisteUser.Name = "tbRoleArtisteUser";
            this.tbRoleArtisteUser.Size = new System.Drawing.Size(260, 28);
            this.tbRoleArtisteUser.TabIndex = 37;
            // 
            // tbLienFBArtisteUser
            // 
            this.tbLienFBArtisteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbLienFBArtisteUser.Enabled = false;
            this.tbLienFBArtisteUser.ForeColor = System.Drawing.Color.White;
            this.tbLienFBArtisteUser.Location = new System.Drawing.Point(742, 745);
            this.tbLienFBArtisteUser.Name = "tbLienFBArtisteUser";
            this.tbLienFBArtisteUser.Size = new System.Drawing.Size(260, 28);
            this.tbLienFBArtisteUser.TabIndex = 38;
            // 
            // FormCRUDUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1146, 1055);
            this.Controls.Add(this.tbLienFBArtisteUser);
            this.Controls.Add(this.tbRoleArtisteUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMdpAdherentUser);
            this.Controls.Add(this.tbLogAdherentUser);
            this.Controls.Add(this.tbEmailAdherentUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelActionTitle);
            this.Controls.Add(this.gradientPanel1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCRUDUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRUDUtilisateur";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelActionTitle;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label labelNom;
        private GroupBox groupBox1;
        private RadioButton rbIntSpeUser;
        private RadioButton rbArtisteUser;
        private RadioButton rbAnimUser;
        private RadioButton rbAdherentUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbEmailAdherentUser;
        private TextBox tbLogAdherentUser;
        private TextBox tbMdpAdherentUser;
        private Label label4;
        private Label label5;
        private TextBox tbRoleArtisteUser;
        private TextBox tbLienFBArtisteUser;

        public TextBox TbNom { get => tbNom; set => tbNom = value; }
        public Label LabelNom { get => labelNom; set => labelNom = value; }
        public TextBox TbPrenom { get => tbPrenom; set => tbPrenom = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        public Label LabelActionTitle { get => labelActionTitle; set => labelActionTitle = value; }
    }
}