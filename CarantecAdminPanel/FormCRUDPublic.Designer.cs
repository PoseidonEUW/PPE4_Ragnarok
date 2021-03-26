namespace CarantecAdminPanel
{
    partial class FormCRUDPublic
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbManifReservation = new System.Windows.Forms.ComboBox();
            this.tbLibellePublic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(222, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Manifestation";
            // 
            // cbManifReservation
            // 
            this.cbManifReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbManifReservation.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.cbManifReservation.ForeColor = System.Drawing.Color.White;
            this.cbManifReservation.FormattingEnabled = true;
            this.cbManifReservation.Location = new System.Drawing.Point(360, 274);
            this.cbManifReservation.Name = "cbManifReservation";
            this.cbManifReservation.Size = new System.Drawing.Size(349, 32);
            this.cbManifReservation.TabIndex = 101;
            // 
            // tbLibellePublic
            // 
            this.tbLibellePublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbLibellePublic.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbLibellePublic.ForeColor = System.Drawing.Color.White;
            this.tbLibellePublic.Location = new System.Drawing.Point(360, 203);
            this.tbLibellePublic.Name = "tbLibellePublic";
            this.tbLibellePublic.Size = new System.Drawing.Size(349, 31);
            this.tbLibellePublic.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label6.Location = new System.Drawing.Point(283, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "Libelle";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(365, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(465, 24);
            this.labelError.TabIndex = 98;
            this.labelError.Text = "ERROR SAMPLE ERROR SAMPLE ERROR SAMPLE";
            this.labelError.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btnEnregistrer.Location = new System.Drawing.Point(418, 487);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 97;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // labelActionTitle
            // 
            this.labelActionTitle.AutoSize = true;
            this.labelActionTitle.Font = new System.Drawing.Font("Netflix Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionTitle.Location = new System.Drawing.Point(363, 133);
            this.labelActionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActionTitle.Name = "labelActionTitle";
            this.labelActionTitle.Size = new System.Drawing.Size(420, 34);
            this.labelActionTitle.TabIndex = 96;
            this.labelActionTitle.Text = "MODIFICATION/SUPPRESSION";
            this.labelActionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 8);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1071, 103);
            this.gradientPanel1.TabIndex = 95;
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
            // FormCRUDPublic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbManifReservation);
            this.Controls.Add(this.tbLibellePublic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelActionTitle);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormCRUDPublic";
            this.Text = "FormCRUDPublic";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbManifReservation;
        private System.Windows.Forms.TextBox tbLibellePublic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelActionTitle;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}