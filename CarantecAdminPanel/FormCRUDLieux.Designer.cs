﻿using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormCRUDLieux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDLieux));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbLibelleLieux = new System.Windows.Forms.RichTextBox();
            this.gbIntExtLieux = new System.Windows.Forms.GroupBox();
            this.rbExtLieux = new System.Windows.Forms.RadioButton();
            this.rbIntLieux = new System.Windows.Forms.RadioButton();
            this.nudCapaciteLieu = new System.Windows.Forms.NumericUpDown();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbIntExtLieux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapaciteLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label6.Location = new System.Drawing.Point(220, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 78;
            this.label6.Text = "Capacité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(238, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Libelle";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(365, 457);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(371, 19);
            this.labelError.TabIndex = 65;
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
            this.btnEnregistrer.TabIndex = 64;
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
            this.gradientPanel1.TabIndex = 62;
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
            // rtbLibelleLieux
            // 
            this.rtbLibelleLieux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rtbLibelleLieux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLibelleLieux.ForeColor = System.Drawing.Color.White;
            this.rtbLibelleLieux.Location = new System.Drawing.Point(314, 180);
            this.rtbLibelleLieux.Name = "rtbLibelleLieux";
            this.rtbLibelleLieux.Size = new System.Drawing.Size(554, 82);
            this.rtbLibelleLieux.TabIndex = 80;
            this.rtbLibelleLieux.Text = "";
            // 
            // gbIntExtLieux
            // 
            this.gbIntExtLieux.Controls.Add(this.rbExtLieux);
            this.gbIntExtLieux.Controls.Add(this.rbIntLieux);
            this.gbIntExtLieux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIntExtLieux.ForeColor = System.Drawing.Color.White;
            this.gbIntExtLieux.Location = new System.Drawing.Point(314, 278);
            this.gbIntExtLieux.Name = "gbIntExtLieux";
            this.gbIntExtLieux.Size = new System.Drawing.Size(142, 117);
            this.gbIntExtLieux.TabIndex = 81;
            this.gbIntExtLieux.TabStop = false;
            this.gbIntExtLieux.Text = "Intérieur / Extérieur";
            // 
            // rbExtLieux
            // 
            this.rbExtLieux.AutoSize = true;
            this.rbExtLieux.Location = new System.Drawing.Point(31, 71);
            this.rbExtLieux.Name = "rbExtLieux";
            this.rbExtLieux.Size = new System.Drawing.Size(71, 18);
            this.rbExtLieux.TabIndex = 1;
            this.rbExtLieux.Text = "Extérieur";
            this.rbExtLieux.UseVisualStyleBackColor = true;
            // 
            // rbIntLieux
            // 
            this.rbIntLieux.AutoSize = true;
            this.rbIntLieux.Checked = true;
            this.rbIntLieux.Location = new System.Drawing.Point(31, 38);
            this.rbIntLieux.Name = "rbIntLieux";
            this.rbIntLieux.Size = new System.Drawing.Size(67, 18);
            this.rbIntLieux.TabIndex = 0;
            this.rbIntLieux.TabStop = true;
            this.rbIntLieux.Text = "Intérieur";
            this.rbIntLieux.UseVisualStyleBackColor = true;
            // 
            // nudCapaciteLieu
            // 
            this.nudCapaciteLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nudCapaciteLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCapaciteLieu.Font = new System.Drawing.Font("Netflix Sans", 11.25F);
            this.nudCapaciteLieu.ForeColor = System.Drawing.Color.White;
            this.nudCapaciteLieu.Location = new System.Drawing.Point(314, 413);
            this.nudCapaciteLieu.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCapaciteLieu.Name = "nudCapaciteLieu";
            this.nudCapaciteLieu.Size = new System.Drawing.Size(70, 27);
            this.nudCapaciteLieu.TabIndex = 94;
            this.nudCapaciteLieu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormCRUDLieux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.nudCapaciteLieu);
            this.Controls.Add(this.gbIntExtLieux);
            this.Controls.Add(this.rtbLibelleLieux);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Netflix Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCRUDLieux";
            this.Text = "FormCRUDLieux";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbIntExtLieux.ResumeLayout(false);
            this.gbIntExtLieux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapaciteLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbLibelleLieux;
        private System.Windows.Forms.GroupBox gbIntExtLieux;
        private System.Windows.Forms.RadioButton rbExtLieux;
        private System.Windows.Forms.RadioButton rbIntLieux;
        private NumericUpDown nudCapaciteLieu;

        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label LabelError { get => labelError; set => labelError = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public RichTextBox RtbLibelleLieux { get => rtbLibelleLieux; set => rtbLibelleLieux = value; }
        public GroupBox GbIntExtLieux { get => gbIntExtLieux; set => gbIntExtLieux = value; }
        public RadioButton RbExtLieux { get => rbExtLieux; set => rbExtLieux = value; }
        public RadioButton RbIntLieux { get => rbIntLieux; set => rbIntLieux = value; }
        public NumericUpDown NudCapaciteLieu { get => nudCapaciteLieu; set => nudCapaciteLieu = value; }
    }
}