using System.Windows.Forms;

namespace CarantecAdminPanel
{
    partial class FormUpdateUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateUtilisateur));
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrenom.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.ForeColor = System.Drawing.Color.White;
            this.tbPrenom.Location = new System.Drawing.Point(263, 239);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(349, 24);
            this.tbPrenom.TabIndex = 33;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(178, 238);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(63, 19);
            this.labelPrenom.TabIndex = 32;
            this.labelPrenom.Text = "Prénom";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNom.Font = new System.Drawing.Font("Netflix Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.ForeColor = System.Drawing.Color.White;
            this.tbNom.Location = new System.Drawing.Point(263, 171);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(349, 24);
            this.tbNom.TabIndex = 31;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(205, 170);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 19);
            this.labelNom.TabIndex = 30;
            this.labelNom.Text = "Nom";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 2);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(807, 103);
            this.gradientPanel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(242, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Netflix Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(227, 297);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(371, 19);
            this.labelError.TabIndex = 42;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(280, 327);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(248, 56);
            this.btnEnregistrer.TabIndex = 41;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // FormUpdateUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateUtilisateur";
            this.Text = "FormUpdateUtilisateur";
            this.Load += new System.EventHandler(this.FormUpdateUtilisateur_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label labelNom;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnEnregistrer;

        public TextBox TbPrenom { get => tbPrenom; set => tbPrenom = value; }
        public Label LabelPrenom { get => labelPrenom; set => labelPrenom = value; }
        public TextBox TbNom { get => tbNom; set => tbNom = value; }
        public Label LabelNom { get => labelNom; set => labelNom = value; }
        internal GradientPanel GradientPanel1 { get => gradientPanel1; set => gradientPanel1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label LabelError { get => labelError; set => labelError = value; }
        public Button BtnEnregistrer { get => btnEnregistrer; set => btnEnregistrer = value; }
    }
}