using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormCRUDReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDReservation));
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbManifReservation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdhReservation = new System.Windows.Forms.ComboBox();
            this.nudPersReservation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(366, 408);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(371, 19);
            this.labelError.TabIndex = 85;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(419, 438);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 84;
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
            this.gradientPanel1.TabIndex = 82;
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
            // cbManifReservation
            // 
            this.cbManifReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbManifReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManifReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbManifReservation.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.cbManifReservation.ForeColor = System.Drawing.Color.White;
            this.cbManifReservation.FormattingEnabled = true;
            this.cbManifReservation.Location = new System.Drawing.Point(360, 208);
            this.cbManifReservation.Name = "cbManifReservation";
            this.cbManifReservation.Size = new System.Drawing.Size(349, 27);
            this.cbManifReservation.TabIndex = 89;
            this.cbManifReservation.SelectedIndexChanged += new System.EventHandler(this.cbManifReservation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(232, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Manifestation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(261, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "Adhérent";
            // 
            // cbAdhReservation
            // 
            this.cbAdhReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbAdhReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdhReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAdhReservation.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.cbAdhReservation.ForeColor = System.Drawing.Color.White;
            this.cbAdhReservation.FormattingEnabled = true;
            this.cbAdhReservation.Location = new System.Drawing.Point(360, 275);
            this.cbAdhReservation.Name = "cbAdhReservation";
            this.cbAdhReservation.Size = new System.Drawing.Size(349, 27);
            this.cbAdhReservation.TabIndex = 91;
            this.cbAdhReservation.SelectedIndexChanged += new System.EventHandler(this.cbAdhReservation_SelectedIndexChanged);
            // 
            // nudPersReservation
            // 
            this.nudPersReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nudPersReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPersReservation.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.nudPersReservation.ForeColor = System.Drawing.Color.White;
            this.nudPersReservation.Location = new System.Drawing.Point(360, 336);
            this.nudPersReservation.Name = "nudPersReservation";
            this.nudPersReservation.Size = new System.Drawing.Size(70, 27);
            this.nudPersReservation.TabIndex = 93;
            this.nudPersReservation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersReservation.ValueChanged += new System.EventHandler(this.nudPersReservation_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label3.Location = new System.Drawing.Point(163, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Nombre de personnes";
            // 
            // FormCRUDReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPersReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdhReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbManifReservation);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCRUDReservation";
            this.Text = "FormCRUDReservation";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbManifReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAdhReservation;
        private System.Windows.Forms.NumericUpDown nudPersReservation;
        private System.Windows.Forms.Label label3;

        public Label LabelError { get => labelError; set => labelError = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public ComboBox CbManifReservation { get => cbManifReservation; set => cbManifReservation = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbAdhReservation { get => cbAdhReservation; set => cbAdhReservation = value; }
        public NumericUpDown NudPersReservation { get => nudPersReservation; set => nudPersReservation = value; }
        public Label Label3 { get => label3; set => label3 = value; }
    }
}