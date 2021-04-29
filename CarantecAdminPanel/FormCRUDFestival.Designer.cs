using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormCRUDFestival
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
            this.tbNomFestival = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimeAnnee = new System.Windows.Forms.DateTimePicker();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.cbThematique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomFestival
            // 
            this.tbNomFestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbNomFestival.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomFestival.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.tbNomFestival.ForeColor = System.Drawing.Color.White;
            this.tbNomFestival.Location = new System.Drawing.Point(397, 396);
            this.tbNomFestival.Name = "tbNomFestival";
            this.tbNomFestival.Size = new System.Drawing.Size(349, 27);
            this.tbNomFestival.TabIndex = 33;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(339, 398);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 19);
            this.labelNom.TabIndex = 32;
            this.labelNom.Text = "Nom";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(365, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(371, 19);
            this.labelError.TabIndex = 31;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(418, 487);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 30;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
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
            this.gradientPanel1.TabIndex = 28;
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
            // dateTimeAnnee
            // 
            this.dateTimeAnnee.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnnee.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dateTimeAnnee.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnnee.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.dateTimeAnnee.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeAnnee.CustomFormat = "yyyy";
            this.dateTimeAnnee.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.dateTimeAnnee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAnnee.Location = new System.Drawing.Point(397, 199);
            this.dateTimeAnnee.Name = "dateTimeAnnee";
            this.dateTimeAnnee.ShowUpDown = true;
            this.dateTimeAnnee.Size = new System.Drawing.Size(104, 27);
            this.dateTimeAnnee.TabIndex = 34;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.labelAnnee.Location = new System.Drawing.Point(324, 204);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(53, 19);
            this.labelAnnee.TabIndex = 35;
            this.labelAnnee.Text = "Année";
            // 
            // cbThematique
            // 
            this.cbThematique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbThematique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThematique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbThematique.ForeColor = System.Drawing.Color.White;
            this.cbThematique.FormattingEnabled = true;
            this.cbThematique.Location = new System.Drawing.Point(397, 265);
            this.cbThematique.Name = "cbThematique";
            this.cbThematique.Size = new System.Drawing.Size(349, 21);
            this.cbThematique.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(274, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thématique";
            // 
            // cbResponsable
            // 
            this.cbResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResponsable.ForeColor = System.Drawing.Color.White;
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(397, 334);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(349, 21);
            this.cbResponsable.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(265, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Responsable";
            // 
            // FormCRUDFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThematique);
            this.Controls.Add(this.labelAnnee);
            this.Controls.Add(this.dateTimeAnnee);
            this.Controls.Add(this.tbNomFestival);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormCRUDFestival";
            this.Text = "FormCRUDFestival";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNomFestival;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.DateTimePicker dateTimeAnnee;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.ComboBox cbThematique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Label label2;

        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public TextBox TbNomFestival { get => tbNomFestival; set => tbNomFestival = value; }
        public Label LabelNom { get => labelNom; set => labelNom = value; }
        public Label LabelError { get => labelError; set => labelError = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public DateTimePicker DateTimeAnnee { get => dateTimeAnnee; set => dateTimeAnnee = value; }
        public Label LabelAnnee { get => labelAnnee; set => labelAnnee = value; }
        public ComboBox ComboBox1 { get => cbThematique; set => cbThematique = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox ComboBox2 { get => cbResponsable; set => cbResponsable = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbThematique { get => cbThematique; set => cbThematique = value; }
        public ComboBox CbResponsable { get => cbResponsable; set => cbResponsable = value; }
    }
}