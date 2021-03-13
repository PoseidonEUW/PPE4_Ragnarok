namespace CarantecAdminPanel
{
    partial class FormTemplateCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemplateCRUD));
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelSample = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.tbSample = new System.Windows.Forms.TextBox();
            this.rtbSample = new System.Windows.Forms.RichTextBox();
            this.cbListSample = new System.Windows.Forms.CheckedListBox();
            this.cbbSample = new System.Windows.Forms.ComboBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.btnRetour);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 1);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1071, 103);
            this.gradientPanel1.TabIndex = 1;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.Snow;
            this.btnRetour.Location = new System.Drawing.Point(970, 10);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(85, 31);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
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
            // labelActionTitle
            // 
            this.labelActionTitle.AutoSize = true;
            this.labelActionTitle.Font = new System.Drawing.Font("Netflix Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionTitle.Location = new System.Drawing.Point(375, 126);
            this.labelActionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActionTitle.Name = "labelActionTitle";
            this.labelActionTitle.Size = new System.Drawing.Size(325, 27);
            this.labelActionTitle.TabIndex = 2;
            this.labelActionTitle.Text = "MODIFICATION/SUPPRESSION";
            this.labelActionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Snow;
            this.btnEnregistrer.Location = new System.Drawing.Point(420, 487);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSample.Location = new System.Drawing.Point(279, 193);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(71, 19);
            this.labelSample.TabIndex = 4;
            this.labelSample.Text = "SAMPLE";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(366, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(371, 19);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "ERROR SAMPLE ERROR SAMPLE ERROR SAMPLE";
            // 
            // tbSample
            // 
            this.tbSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSample.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSample.ForeColor = System.Drawing.Color.White;
            this.tbSample.Location = new System.Drawing.Point(360, 191);
            this.tbSample.Name = "tbSample";
            this.tbSample.Size = new System.Drawing.Size(349, 24);
            this.tbSample.TabIndex = 6;
            // 
            // rtbSample
            // 
            this.rtbSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rtbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSample.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSample.Location = new System.Drawing.Point(360, 237);
            this.rtbSample.Name = "rtbSample";
            this.rtbSample.Size = new System.Drawing.Size(349, 78);
            this.rtbSample.TabIndex = 11;
            this.rtbSample.Text = "";
            // 
            // cbListSample
            // 
            this.cbListSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbListSample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbListSample.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListSample.ForeColor = System.Drawing.Color.White;
            this.cbListSample.FormattingEnabled = true;
            this.cbListSample.Items.AddRange(new object[] {
            "cbListSample"});
            this.cbListSample.Location = new System.Drawing.Point(360, 334);
            this.cbListSample.Name = "cbListSample";
            this.cbListSample.Size = new System.Drawing.Size(138, 19);
            this.cbListSample.TabIndex = 13;
            // 
            // cbbSample
            // 
            this.cbbSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbbSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSample.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSample.ForeColor = System.Drawing.Color.White;
            this.cbbSample.FormattingEnabled = true;
            this.cbbSample.Location = new System.Drawing.Point(360, 370);
            this.cbbSample.Name = "cbbSample";
            this.cbbSample.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbSample.Size = new System.Drawing.Size(121, 24);
            this.cbbSample.TabIndex = 14;
            // 
            // FormTemplateCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbbSample);
            this.Controls.Add(this.cbListSample);
            this.Controls.Add(this.rtbSample);
            this.Controls.Add(this.tbSample);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelSample);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelActionTitle);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTemplateCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTemplateCRUD";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelActionTitle;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox tbSample;
        private System.Windows.Forms.RichTextBox rtbSample;
        private System.Windows.Forms.CheckedListBox cbListSample;
        private System.Windows.Forms.ComboBox cbbSample;
    }
}