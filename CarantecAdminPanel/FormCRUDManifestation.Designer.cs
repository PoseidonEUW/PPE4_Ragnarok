namespace CarantecAdminPanel
{
    partial class FormCRUDManifestation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLieuManif = new System.Windows.Forms.ComboBox();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.dateTimeAnneeManif = new System.Windows.Forms.DateTimePicker();
            this.tbLibelleManif = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbDescManif = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateManif = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeureManif = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJaugeManif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrixManif = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(60, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(82, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lieu";
            // 
            // comboBoxLieuManif
            // 
            this.comboBoxLieuManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxLieuManif.ForeColor = System.Drawing.Color.White;
            this.comboBoxLieuManif.FormattingEnabled = true;
            this.comboBoxLieuManif.Location = new System.Drawing.Point(137, 267);
            this.comboBoxLieuManif.Name = "comboBoxLieuManif";
            this.comboBoxLieuManif.Size = new System.Drawing.Size(349, 24);
            this.comboBoxLieuManif.TabIndex = 48;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.labelAnnee.Location = new System.Drawing.Point(64, 202);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(67, 24);
            this.labelAnnee.TabIndex = 47;
            this.labelAnnee.Text = "Année";
            // 
            // dateTimeAnneeManif
            // 
            this.dateTimeAnneeManif.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnneeManif.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dateTimeAnneeManif.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnneeManif.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnneeManif.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeAnneeManif.CustomFormat = "yyyy";
            this.dateTimeAnneeManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.dateTimeAnneeManif.Location = new System.Drawing.Point(137, 197);
            this.dateTimeAnneeManif.Name = "dateTimeAnneeManif";
            this.dateTimeAnneeManif.Size = new System.Drawing.Size(349, 31);
            this.dateTimeAnneeManif.TabIndex = 46;
            // 
            // tbLibelleManif
            // 
            this.tbLibelleManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbLibelleManif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLibelleManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbLibelleManif.ForeColor = System.Drawing.Color.White;
            this.tbLibelleManif.Location = new System.Drawing.Point(137, 326);
            this.tbLibelleManif.Name = "tbLibelleManif";
            this.tbLibelleManif.Size = new System.Drawing.Size(349, 31);
            this.tbLibelleManif.TabIndex = 45;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(365, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(465, 24);
            this.labelError.TabIndex = 43;
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
            this.btnEnregistrer.TabIndex = 42;
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
            this.labelActionTitle.TabIndex = 41;
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
            this.gradientPanel1.TabIndex = 40;
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
            // rtbDescManif
            // 
            this.rtbDescManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rtbDescManif.ForeColor = System.Drawing.Color.White;
            this.rtbDescManif.Location = new System.Drawing.Point(137, 380);
            this.rtbDescManif.Name = "rtbDescManif";
            this.rtbDescManif.Size = new System.Drawing.Size(907, 74);
            this.rtbDescManif.TabIndex = 52;
            this.rtbDescManif.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label3.Location = new System.Drawing.Point(18, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Description";
            // 
            // dateManif
            // 
            this.dateManif.CustomFormat = "MMMM - dd";
            this.dateManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.dateManif.Location = new System.Drawing.Point(695, 197);
            this.dateManif.Name = "dateManif";
            this.dateManif.Size = new System.Drawing.Size(349, 31);
            this.dateManif.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label4.Location = new System.Drawing.Point(637, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label5.Location = new System.Drawing.Point(540, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Heure de début";
            // 
            // HeureManif
            // 
            this.HeureManif.CustomFormat = "HH:mm";
            this.HeureManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.HeureManif.Location = new System.Drawing.Point(695, 259);
            this.HeureManif.Name = "HeureManif";
            this.HeureManif.Size = new System.Drawing.Size(347, 31);
            this.HeureManif.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label6.Location = new System.Drawing.Point(619, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "Jauge ";
            // 
            // tbJaugeManif
            // 
            this.tbJaugeManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbJaugeManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbJaugeManif.ForeColor = System.Drawing.Color.White;
            this.tbJaugeManif.Location = new System.Drawing.Point(695, 326);
            this.tbJaugeManif.Name = "tbJaugeManif";
            this.tbJaugeManif.Size = new System.Drawing.Size(142, 31);
            this.tbJaugeManif.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label7.Location = new System.Drawing.Point(848, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Prix";
            // 
            // tbPrixManif
            // 
            this.tbPrixManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbPrixManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbPrixManif.ForeColor = System.Drawing.Color.White;
            this.tbPrixManif.Location = new System.Drawing.Point(900, 326);
            this.tbPrixManif.Name = "tbPrixManif";
            this.tbPrixManif.Size = new System.Drawing.Size(142, 31);
            this.tbPrixManif.TabIndex = 61;
            // 
            // FormCRUDManifestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.tbPrixManif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbJaugeManif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HeureManif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateManif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescManif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLieuManif);
            this.Controls.Add(this.labelAnnee);
            this.Controls.Add(this.dateTimeAnneeManif);
            this.Controls.Add(this.tbLibelleManif);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelActionTitle);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormCRUDManifestation";
            this.Text = "FormCRUDManifestation";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLieuManif;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.DateTimePicker dateTimeAnneeManif;
        private System.Windows.Forms.TextBox tbLibelleManif;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelActionTitle;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbDescManif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateManif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HeureManif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJaugeManif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrixManif;
    }
}