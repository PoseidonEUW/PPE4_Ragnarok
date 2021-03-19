namespace CarantecAdminPanel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.btnAvis = new System.Windows.Forms.Button();
            this.btnLieux = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnManifestation = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnFestival = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.AllowUserToAddRows = false;
            this.dgvDonnees.AllowUserToDeleteRows = false;
            this.dgvDonnees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvDonnees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDonnees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvDonnees.Location = new System.Drawing.Point(80, 214);
            this.dgvDonnees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.ReadOnly = true;
            this.dgvDonnees.RowHeadersWidth = 51;
            this.dgvDonnees.Size = new System.Drawing.Size(2388, 1049);
            this.dgvDonnees.TabIndex = 1;
            this.dgvDonnees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonnees_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.btnAvis);
            this.gradientPanel1.Controls.Add(this.btnLieux);
            this.gradientPanel1.Controls.Add(this.btnPublic);
            this.gradientPanel1.Controls.Add(this.btnReservation);
            this.gradientPanel1.Controls.Add(this.btnManifestation);
            this.gradientPanel1.Controls.Add(this.btnDeco);
            this.gradientPanel1.Controls.Add(this.btnFestival);
            this.gradientPanel1.Controls.Add(this.btnUsers);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -4);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(2567, 148);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btnAvis
            // 
            this.btnAvis.FlatAppearance.BorderSize = 0;
            this.btnAvis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAvis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAvis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvis.ForeColor = System.Drawing.Color.White;
            this.btnAvis.Location = new System.Drawing.Point(1671, 101);
            this.btnAvis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvis.Name = "btnAvis";
            this.btnAvis.Size = new System.Drawing.Size(60, 31);
            this.btnAvis.TabIndex = 8;
            this.btnAvis.Text = "Avis";
            this.btnAvis.UseVisualStyleBackColor = true;
            this.btnAvis.Click += new System.EventHandler(this.btnAvis_Click);
            // 
            // btnLieux
            // 
            this.btnLieux.FlatAppearance.BorderSize = 0;
            this.btnLieux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLieux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLieux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLieux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLieux.ForeColor = System.Drawing.Color.White;
            this.btnLieux.Location = new System.Drawing.Point(1992, 101);
            this.btnLieux.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLieux.Name = "btnLieux";
            this.btnLieux.Size = new System.Drawing.Size(72, 31);
            this.btnLieux.TabIndex = 7;
            this.btnLieux.Text = "Lieux";
            this.btnLieux.UseVisualStyleBackColor = true;
            this.btnLieux.Click += new System.EventHandler(this.btnLieux_Click);
            // 
            // btnPublic
            // 
            this.btnPublic.FlatAppearance.BorderSize = 0;
            this.btnPublic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPublic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublic.ForeColor = System.Drawing.Color.White;
            this.btnPublic.Location = new System.Drawing.Point(1249, 101);
            this.btnPublic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(84, 31);
            this.btnPublic.TabIndex = 6;
            this.btnPublic.Text = "Public";
            this.btnPublic.UseVisualStyleBackColor = true;
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Location = new System.Drawing.Point(1428, 101);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(147, 31);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "Réservations";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnManifestation
            // 
            this.btnManifestation.FlatAppearance.BorderSize = 0;
            this.btnManifestation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnManifestation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnManifestation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManifestation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManifestation.ForeColor = System.Drawing.Color.White;
            this.btnManifestation.Location = new System.Drawing.Point(725, 101);
            this.btnManifestation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManifestation.Name = "btnManifestation";
            this.btnManifestation.Size = new System.Drawing.Size(147, 31);
            this.btnManifestation.TabIndex = 4;
            this.btnManifestation.Text = "Manifestations";
            this.btnManifestation.UseVisualStyleBackColor = true;
            this.btnManifestation.Click += new System.EventHandler(this.btnManifestation_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.FlatAppearance.BorderSize = 0;
            this.btnDeco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeco.ForeColor = System.Drawing.Color.White;
            this.btnDeco.Location = new System.Drawing.Point(2320, 32);
            this.btnDeco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(188, 31);
            this.btnDeco.TabIndex = 3;
            this.btnDeco.Text = "Se déconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // btnFestival
            // 
            this.btnFestival.FlatAppearance.BorderSize = 0;
            this.btnFestival.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFestival.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFestival.ForeColor = System.Drawing.Color.White;
            this.btnFestival.Location = new System.Drawing.Point(493, 101);
            this.btnFestival.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFestival.Name = "btnFestival";
            this.btnFestival.Size = new System.Drawing.Size(119, 31);
            this.btnFestival.TabIndex = 2;
            this.btnFestival.Text = "Festivals";
            this.btnFestival.UseVisualStyleBackColor = true;
            this.btnFestival.Click += new System.EventHandler(this.btnFestival_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(1002, 101);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(113, 31);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Utilisateurs";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.dgvDonnees);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvis;
        private System.Windows.Forms.Button btnLieux;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnManifestation;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnFestival;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.DataGridView dgvDonnees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

