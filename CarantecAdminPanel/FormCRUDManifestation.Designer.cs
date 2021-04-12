using System.Windows.Forms;

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
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.gbTypeManif = new System.Windows.Forms.GroupBox();
            this.rbAtelierManif = new System.Windows.Forms.RadioButton();
            this.rbConcertManif = new System.Windows.Forms.RadioButton();
            this.rbConferenceManif = new System.Windows.Forms.RadioButton();
            this.rbDebatManif = new System.Windows.Forms.RadioButton();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTypeManif.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(59, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(81, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lieu";
            // 
            // comboBoxLieuManif
            // 
            this.comboBoxLieuManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxLieuManif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLieuManif.ForeColor = System.Drawing.Color.White;
            this.comboBoxLieuManif.FormattingEnabled = true;
            this.comboBoxLieuManif.Location = new System.Drawing.Point(136, 387);
            this.comboBoxLieuManif.Name = "comboBoxLieuManif";
            this.comboBoxLieuManif.Size = new System.Drawing.Size(349, 24);
            this.comboBoxLieuManif.TabIndex = 48;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.labelAnnee.Location = new System.Drawing.Point(63, 322);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(67, 24);
            this.labelAnnee.TabIndex = 47;
            this.labelAnnee.Text = "Année";
            // 
            // tbLibelleManif
            // 
            this.tbLibelleManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbLibelleManif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLibelleManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbLibelleManif.ForeColor = System.Drawing.Color.White;
            this.tbLibelleManif.Location = new System.Drawing.Point(136, 446);
            this.tbLibelleManif.Name = "tbLibelleManif";
            this.tbLibelleManif.Size = new System.Drawing.Size(349, 31);
            this.tbLibelleManif.TabIndex = 45;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
<<<<<<< HEAD
            this.labelError.Location = new System.Drawing.Point(365, 467);
=======
            this.labelError.Location = new System.Drawing.Point(364, 577);
>>>>>>> localC#eg
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(465, 24);
            this.labelError.TabIndex = 43;
            this.labelError.Text = "ERROR SAMPLE ERROR SAMPLE ERROR SAMPLE";
            this.labelError.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnEnregistrer.Location = new System.Drawing.Point(418, 497);
=======
            this.btnEnregistrer.Location = new System.Drawing.Point(417, 607);
>>>>>>> localC#eg
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
            this.labelActionTitle.Location = new System.Drawing.Point(336, 133);
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
            this.rtbDescManif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescManif.ForeColor = System.Drawing.Color.White;
            this.rtbDescManif.Location = new System.Drawing.Point(136, 500);
            this.rtbDescManif.Name = "rtbDescManif";
            this.rtbDescManif.Size = new System.Drawing.Size(907, 74);
            this.rtbDescManif.TabIndex = 52;
            this.rtbDescManif.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label3.Location = new System.Drawing.Point(17, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Description";
            // 
            // dateManif
            // 
            this.dateManif.CustomFormat = "dd MMMM";
            this.dateManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.dateManif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateManif.Location = new System.Drawing.Point(710, 317);
            this.dateManif.Name = "dateManif";
            this.dateManif.Size = new System.Drawing.Size(172, 31);
            this.dateManif.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label4.Location = new System.Drawing.Point(636, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label5.Location = new System.Drawing.Point(554, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Heure de début";
            // 
            // HeureManif
            // 
            this.HeureManif.CustomFormat = "HH:mm";
            this.HeureManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.HeureManif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HeureManif.Location = new System.Drawing.Point(709, 379);
            this.HeureManif.Name = "HeureManif";
            this.HeureManif.Size = new System.Drawing.Size(96, 31);
            this.HeureManif.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label6.Location = new System.Drawing.Point(622, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "Jauge ";
            // 
            // tbJaugeManif
            // 
            this.tbJaugeManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbJaugeManif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJaugeManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbJaugeManif.ForeColor = System.Drawing.Color.White;
            this.tbJaugeManif.Location = new System.Drawing.Point(694, 446);
            this.tbJaugeManif.Name = "tbJaugeManif";
            this.tbJaugeManif.Size = new System.Drawing.Size(142, 31);
            this.tbJaugeManif.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label7.Location = new System.Drawing.Point(847, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Prix";
            // 
            // tbPrixManif
            // 
            this.tbPrixManif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbPrixManif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrixManif.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbPrixManif.ForeColor = System.Drawing.Color.White;
            this.tbPrixManif.Location = new System.Drawing.Point(899, 446);
            this.tbPrixManif.Name = "tbPrixManif";
            this.tbPrixManif.Size = new System.Drawing.Size(142, 31);
            this.tbPrixManif.TabIndex = 61;
            // 
            // cbAnnee
            // 
            this.cbAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnee.ForeColor = System.Drawing.Color.White;
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(136, 322);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.Size = new System.Drawing.Size(97, 24);
            this.cbAnnee.TabIndex = 62;
            // 
            // gbTypeManif
            // 
            this.gbTypeManif.Controls.Add(this.rbDebatManif);
            this.gbTypeManif.Controls.Add(this.rbConferenceManif);
            this.gbTypeManif.Controls.Add(this.rbConcertManif);
            this.gbTypeManif.Controls.Add(this.rbAtelierManif);
            this.gbTypeManif.ForeColor = System.Drawing.Color.White;
            this.gbTypeManif.Location = new System.Drawing.Point(46, 183);
            this.gbTypeManif.Name = "gbTypeManif";
            this.gbTypeManif.Size = new System.Drawing.Size(994, 113);
            this.gbTypeManif.TabIndex = 63;
            this.gbTypeManif.TabStop = false;
            this.gbTypeManif.Text = "Type";
            // 
            // rbAtelierManif
            // 
            this.rbAtelierManif.AutoSize = true;
            this.rbAtelierManif.Font = new System.Drawing.Font("Netflix Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtelierManif.Location = new System.Drawing.Point(90, 47);
            this.rbAtelierManif.Name = "rbAtelierManif";
            this.rbAtelierManif.Size = new System.Drawing.Size(85, 25);
            this.rbAtelierManif.TabIndex = 0;
            this.rbAtelierManif.TabStop = true;
            this.rbAtelierManif.Text = "Atelier";
            this.rbAtelierManif.UseVisualStyleBackColor = true;
            // 
            // rbConcertManif
            // 
            this.rbConcertManif.AutoSize = true;
            this.rbConcertManif.Font = new System.Drawing.Font("Netflix Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConcertManif.Location = new System.Drawing.Point(296, 47);
            this.rbConcertManif.Name = "rbConcertManif";
            this.rbConcertManif.Size = new System.Drawing.Size(95, 25);
            this.rbConcertManif.TabIndex = 1;
            this.rbConcertManif.TabStop = true;
            this.rbConcertManif.Text = "Concert";
            this.rbConcertManif.UseVisualStyleBackColor = true;
            // 
            // rbConferenceManif
            // 
            this.rbConferenceManif.AutoSize = true;
            this.rbConferenceManif.Font = new System.Drawing.Font("Netflix Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConferenceManif.Location = new System.Drawing.Point(521, 47);
            this.rbConferenceManif.Name = "rbConferenceManif";
            this.rbConferenceManif.Size = new System.Drawing.Size(125, 25);
            this.rbConferenceManif.TabIndex = 2;
            this.rbConferenceManif.TabStop = true;
            this.rbConferenceManif.Text = "Conférence";
            this.rbConferenceManif.UseVisualStyleBackColor = true;
            // 
            // rbDebatManif
            // 
            this.rbDebatManif.AutoSize = true;
            this.rbDebatManif.Font = new System.Drawing.Font("Netflix Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebatManif.Location = new System.Drawing.Point(778, 47);
            this.rbDebatManif.Name = "rbDebatManif";
            this.rbDebatManif.Size = new System.Drawing.Size(78, 25);
            this.rbDebatManif.TabIndex = 3;
            this.rbDebatManif.TabStop = true;
            this.rbDebatManif.Text = "Débat";
            this.rbDebatManif.UseVisualStyleBackColor = true;
            // 
            // FormCRUDManifestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1070, 564);
=======
            this.ClientSize = new System.Drawing.Size(1070, 680);
            this.Controls.Add(this.gbTypeManif);
>>>>>>> localC#eg
            this.Controls.Add(this.cbAnnee);
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
            this.gbTypeManif.ResumeLayout(false);
            this.gbTypeManif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLieuManif;
        private System.Windows.Forms.Label labelAnnee;
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
        private System.Windows.Forms.ComboBox cbAnnee;
        private GroupBox gbTypeManif;
        private RadioButton rbDebatManif;
        private RadioButton rbConferenceManif;
        private RadioButton rbConcertManif;
        private RadioButton rbAtelierManif;

        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox ComboBoxLieuManif { get => comboBoxLieuManif; set => comboBoxLieuManif = value; }
        public Label LabelAnnee { get => labelAnnee; set => labelAnnee = value; }
        public TextBox TbLibelleManif { get => tbLibelleManif; set => tbLibelleManif = value; }
        public Label LabelError { get => labelError; set => labelError = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        public Label LabelActionTitle { get => labelActionTitle; set => labelActionTitle = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public RichTextBox RtbDescManif { get => rtbDescManif; set => rtbDescManif = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DateTimePicker DateManif { get => dateManif; set => dateManif = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public DateTimePicker HeureManif1 { get => HeureManif; set => HeureManif = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TbJaugeManif { get => tbJaugeManif; set => tbJaugeManif = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public TextBox TbPrixManif { get => tbPrixManif; set => tbPrixManif = value; }
        public ComboBox CbAnnee { get => cbAnnee; set => cbAnnee = value; }
    }
}