using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormUpdateAvis
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRefuser = new System.Windows.Forms.RadioButton();
            this.rbAccepter = new System.Windows.Forms.RadioButton();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btnEnregistrer.Location = new System.Drawing.Point(150, 315);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(186, 46);
            this.btnEnregistrer.TabIndex = 119;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 1);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(496, 84);
            this.gradientPanel1.TabIndex = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(108, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRefuser);
            this.groupBox1.Controls.Add(this.rbAccepter);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(55, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 118);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avis";
            // 
            // rbRefuser
            // 
            this.rbRefuser.AutoSize = true;
            this.rbRefuser.Location = new System.Drawing.Point(230, 56);
            this.rbRefuser.Name = "rbRefuser";
            this.rbRefuser.Size = new System.Drawing.Size(70, 20);
            this.rbRefuser.TabIndex = 1;
            this.rbRefuser.TabStop = true;
            this.rbRefuser.Text = "Refuser";
            this.rbRefuser.UseVisualStyleBackColor = true;
            this.rbRefuser.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAccepter
            // 
            this.rbAccepter.AutoSize = true;
            this.rbAccepter.Location = new System.Drawing.Point(73, 56);
            this.rbAccepter.Name = "rbAccepter";
            this.rbAccepter.Size = new System.Drawing.Size(79, 20);
            this.rbAccepter.TabIndex = 0;
            this.rbAccepter.TabStop = true;
            this.rbAccepter.Text = "Accepter";
            this.rbAccepter.UseVisualStyleBackColor = true;
            // 
            // FormUpdateAvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(497, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormUpdateAvis";
            this.Text = "FormUpdateAvis";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRefuser;
        private System.Windows.Forms.RadioButton rbAccepter;

        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public RadioButton RbRefuser { get => rbRefuser; set => rbRefuser = value; }
        public RadioButton RbAccepter { get => rbAccepter; set => rbAccepter = value; }
    }
}