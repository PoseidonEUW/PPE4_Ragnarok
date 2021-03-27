namespace CarantecAdminPanel
{
    partial class FormCRUDAvis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDAvis));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelActionTitle = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdhAvis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbManifAvis = new System.Windows.Forms.ComboBox();
            this.gbNoteAvis = new System.Windows.Forms.GroupBox();
            this.bNote5Avis = new System.Windows.Forms.Button();
            this.bNote4Avis = new System.Windows.Forms.Button();
            this.bNote3Avis = new System.Windows.Forms.Button();
            this.bNote2Avis = new System.Windows.Forms.Button();
            this.bNote1Avis = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNoteAvis.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(150, 369);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(802, 75);
            this.richTextBox1.TabIndex = 111;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "Description";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(365, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(465, 24);
            this.labelError.TabIndex = 107;
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
            this.btnEnregistrer.TabIndex = 106;
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
            this.labelActionTitle.TabIndex = 105;
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
            this.gradientPanel1.TabIndex = 104;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(51, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "Adhérent";
            // 
            // cbAdhAvis
            // 
            this.cbAdhAvis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbAdhAvis.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.cbAdhAvis.ForeColor = System.Drawing.Color.White;
            this.cbAdhAvis.FormattingEnabled = true;
            this.cbAdhAvis.Location = new System.Drawing.Point(150, 297);
            this.cbAdhAvis.Name = "cbAdhAvis";
            this.cbAdhAvis.Size = new System.Drawing.Size(349, 32);
            this.cbAdhAvis.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 113;
            this.label3.Text = "Manifestation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbManifAvis
            // 
            this.cbManifAvis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbManifAvis.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.cbManifAvis.ForeColor = System.Drawing.Color.White;
            this.cbManifAvis.FormattingEnabled = true;
            this.cbManifAvis.Location = new System.Drawing.Point(150, 213);
            this.cbManifAvis.Name = "cbManifAvis";
            this.cbManifAvis.Size = new System.Drawing.Size(349, 32);
            this.cbManifAvis.TabIndex = 112;
            // 
            // gbNoteAvis
            // 
            this.gbNoteAvis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbNoteAvis.Controls.Add(this.bNote5Avis);
            this.gbNoteAvis.Controls.Add(this.bNote4Avis);
            this.gbNoteAvis.Controls.Add(this.bNote3Avis);
            this.gbNoteAvis.Controls.Add(this.bNote2Avis);
            this.gbNoteAvis.Controls.Add(this.bNote1Avis);
            this.gbNoteAvis.Font = new System.Drawing.Font("Netflix Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNoteAvis.ForeColor = System.Drawing.Color.White;
            this.gbNoteAvis.Location = new System.Drawing.Point(610, 196);
            this.gbNoteAvis.Name = "gbNoteAvis";
            this.gbNoteAvis.Size = new System.Drawing.Size(342, 156);
            this.gbNoteAvis.TabIndex = 116;
            this.gbNoteAvis.TabStop = false;
            this.gbNoteAvis.Text = "Note";
            // 
            // bNote5Avis
            // 
            this.bNote5Avis.BackColor = System.Drawing.Color.White;
            this.bNote5Avis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNote5Avis.BackgroundImage")));
            this.bNote5Avis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNote5Avis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNote5Avis.Location = new System.Drawing.Point(248, 54);
            this.bNote5Avis.Name = "bNote5Avis";
            this.bNote5Avis.Size = new System.Drawing.Size(50, 50);
            this.bNote5Avis.TabIndex = 4;
            this.bNote5Avis.UseVisualStyleBackColor = false;
            // 
            // bNote4Avis
            // 
            this.bNote4Avis.BackColor = System.Drawing.Color.White;
            this.bNote4Avis.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.EtoileVide;
            this.bNote4Avis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNote4Avis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNote4Avis.Location = new System.Drawing.Point(198, 54);
            this.bNote4Avis.Name = "bNote4Avis";
            this.bNote4Avis.Size = new System.Drawing.Size(50, 50);
            this.bNote4Avis.TabIndex = 3;
            this.bNote4Avis.UseVisualStyleBackColor = false;
            // 
            // bNote3Avis
            // 
            this.bNote3Avis.BackColor = System.Drawing.Color.White;
            this.bNote3Avis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNote3Avis.BackgroundImage")));
            this.bNote3Avis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNote3Avis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNote3Avis.Location = new System.Drawing.Point(151, 54);
            this.bNote3Avis.Name = "bNote3Avis";
            this.bNote3Avis.Size = new System.Drawing.Size(50, 50);
            this.bNote3Avis.TabIndex = 2;
            this.bNote3Avis.UseVisualStyleBackColor = false;
            // 
            // bNote2Avis
            // 
            this.bNote2Avis.BackColor = System.Drawing.Color.White;
            this.bNote2Avis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNote2Avis.BackgroundImage")));
            this.bNote2Avis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNote2Avis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNote2Avis.Location = new System.Drawing.Point(102, 54);
            this.bNote2Avis.Name = "bNote2Avis";
            this.bNote2Avis.Size = new System.Drawing.Size(50, 50);
            this.bNote2Avis.TabIndex = 1;
            this.bNote2Avis.UseVisualStyleBackColor = false;
            // 
            // bNote1Avis
            // 
            this.bNote1Avis.BackColor = System.Drawing.Color.White;
            this.bNote1Avis.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.EtoileVide;
            this.bNote1Avis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNote1Avis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNote1Avis.Location = new System.Drawing.Point(52, 54);
            this.bNote1Avis.Name = "bNote1Avis";
            this.bNote1Avis.Size = new System.Drawing.Size(50, 50);
            this.bNote1Avis.TabIndex = 0;
            this.bNote1Avis.UseVisualStyleBackColor = false;
            // 
            // FormCRUDAvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.gbNoteAvis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdhAvis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbManifAvis);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.labelActionTitle);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormCRUDAvis";
            this.Text = "FormCRUDAvis";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNoteAvis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelActionTitle;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAdhAvis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbManifAvis;
        private System.Windows.Forms.GroupBox gbNoteAvis;
        private System.Windows.Forms.Button bNote5Avis;
        private System.Windows.Forms.Button bNote4Avis;
        private System.Windows.Forms.Button bNote3Avis;
        private System.Windows.Forms.Button bNote2Avis;
        private System.Windows.Forms.Button bNote1Avis;
    }
}