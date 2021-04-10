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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTrier = new System.Windows.Forms.Label();
            this.cbTrier = new System.Windows.Forms.ComboBox();
            this.gradientPanel1 = new CarantecAdminPanel.GradientPanel();
            this.btnAvis = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnLieux = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnManifestation = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnFestival = new System.Windows.Forms.Button();
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
            this.dgvDonnees.AllowUserToResizeColumns = false;
            this.dgvDonnees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDonnees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonnees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvDonnees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDonnees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonnees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonnees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonnees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvDonnees.Location = new System.Drawing.Point(67, 222);
            this.dgvDonnees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonnees.MultiSelect = false;
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.ReadOnly = true;
            this.dgvDonnees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonnees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDonnees.RowHeadersVisible = false;
            this.dgvDonnees.RowHeadersWidth = 51;
            this.dgvDonnees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDonnees.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDonnees.RowTemplate.Height = 25;
            this.dgvDonnees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonnees.Size = new System.Drawing.Size(2388, 1041);
            this.dgvDonnees.TabIndex = 1;
            this.dgvDonnees.Visible = false;
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
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // labelTrier
            // 
            this.labelTrier.AutoSize = true;
            this.labelTrier.Font = new System.Drawing.Font("Netflix Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrier.Location = new System.Drawing.Point(2176, 174);
            this.labelTrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrier.Name = "labelTrier";
            this.labelTrier.Size = new System.Drawing.Size(102, 25);
            this.labelTrier.TabIndex = 2;
            this.labelTrier.Text = "Trier par :";
            this.labelTrier.Visible = false;
            // 
            // cbTrier
            // 
            this.cbTrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbTrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrier.Font = new System.Drawing.Font("Netflix Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrier.ForeColor = System.Drawing.Color.White;
            this.cbTrier.FormattingEnabled = true;
            this.cbTrier.Items.AddRange(new object[] {
            "Tous",
            "Adhérents",
            "Artistes",
            "Animateur",
            "Intervenants spécialisés"});
            this.cbTrier.Location = new System.Drawing.Point(2293, 175);
            this.cbTrier.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrier.Name = "cbTrier";
            this.cbTrier.Size = new System.Drawing.Size(160, 26);
            this.cbTrier.TabIndex = 3;
            this.cbTrier.Visible = false;
            this.cbTrier.SelectedIndexChanged += new System.EventHandler(this.cbTrier_SelectedIndexChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.btnAvis);
            this.gradientPanel1.Controls.Add(this.btnReservation);
            this.gradientPanel1.Controls.Add(this.btnLieux);
            this.gradientPanel1.Controls.Add(this.btnPublic);
            this.gradientPanel1.Controls.Add(this.btnUsers);
            this.gradientPanel1.Controls.Add(this.btnManifestation);
            this.gradientPanel1.Controls.Add(this.btnDeco);
            this.gradientPanel1.Controls.Add(this.btnFestival);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -4);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(2567, 148);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btnAvis
            // 
            this.btnAvis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvis.FlatAppearance.BorderSize = 0;
            this.btnAvis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAvis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAvis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvis.ForeColor = System.Drawing.Color.White;
            this.btnAvis.Image = global::CarantecAdminPanel.Properties.Resources.AvisInverse;
            this.btnAvis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAvis.Location = new System.Drawing.Point(1755, 29);
            this.btnAvis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvis.Name = "btnAvis";
            this.btnAvis.Size = new System.Drawing.Size(119, 102);
            this.btnAvis.TabIndex = 9;
            this.btnAvis.Text = "Avis";
            this.btnAvis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAvis.UseVisualStyleBackColor = true;
            this.btnAvis.Click += new System.EventHandler(this.btnAvis_Click_1);
            // 
            // btnReservation
            // 
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = global::CarantecAdminPanel.Properties.Resources.ReservationInverse;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservation.Location = new System.Drawing.Point(1553, 29);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(119, 102);
            this.btnReservation.TabIndex = 8;
            this.btnReservation.Text = "Réservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click_1);
            // 
            // btnLieux
            // 
            this.btnLieux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLieux.FlatAppearance.BorderSize = 0;
            this.btnLieux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLieux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLieux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLieux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLieux.ForeColor = System.Drawing.Color.White;
            this.btnLieux.Image = global::CarantecAdminPanel.Properties.Resources.LieuxInverse;
            this.btnLieux.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLieux.Location = new System.Drawing.Point(1347, 29);
            this.btnLieux.Margin = new System.Windows.Forms.Padding(4);
            this.btnLieux.Name = "btnLieux";
            this.btnLieux.Size = new System.Drawing.Size(119, 102);
            this.btnLieux.TabIndex = 7;
            this.btnLieux.Text = "Lieux";
            this.btnLieux.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLieux.UseVisualStyleBackColor = true;
            this.btnLieux.Click += new System.EventHandler(this.btnLieux_Click_1);
            // 
            // btnPublic
            // 
            this.btnPublic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublic.FlatAppearance.BorderSize = 0;
            this.btnPublic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPublic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublic.ForeColor = System.Drawing.Color.White;
            this.btnPublic.Image = global::CarantecAdminPanel.Properties.Resources.PublicInverse;
            this.btnPublic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPublic.Location = new System.Drawing.Point(1148, 29);
            this.btnPublic.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(119, 102);
            this.btnPublic.TabIndex = 6;
            this.btnPublic.Text = "Public";
            this.btnPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublic.UseVisualStyleBackColor = true;
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click_1);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::CarantecAdminPanel.Properties.Resources.UserInverse;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(941, 29);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(119, 102);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Utilisateurs";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // btnManifestation
            // 
            this.btnManifestation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManifestation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManifestation.FlatAppearance.BorderSize = 0;
            this.btnManifestation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnManifestation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnManifestation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManifestation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManifestation.ForeColor = System.Drawing.Color.White;
            this.btnManifestation.Image = global::CarantecAdminPanel.Properties.Resources.ManifestationsInverse;
            this.btnManifestation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManifestation.Location = new System.Drawing.Point(731, 29);
            this.btnManifestation.Margin = new System.Windows.Forms.Padding(4);
            this.btnManifestation.Name = "btnManifestation";
            this.btnManifestation.Size = new System.Drawing.Size(134, 102);
            this.btnManifestation.TabIndex = 4;
            this.btnManifestation.Text = "Manifestations";
            this.btnManifestation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManifestation.UseVisualStyleBackColor = true;
            this.btnManifestation.Click += new System.EventHandler(this.btnManifestation_Click_1);
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
            this.btnDeco.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(188, 31);
            this.btnDeco.TabIndex = 3;
            this.btnDeco.Text = "Se déconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // btnFestival
            // 
            this.btnFestival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFestival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFestival.FlatAppearance.BorderSize = 0;
            this.btnFestival.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFestival.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFestival.ForeColor = System.Drawing.Color.White;
            this.btnFestival.Image = global::CarantecAdminPanel.Properties.Resources.FestivalInverse;
            this.btnFestival.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFestival.Location = new System.Drawing.Point(508, 29);
            this.btnFestival.Margin = new System.Windows.Forms.Padding(4);
            this.btnFestival.Name = "btnFestival";
            this.btnFestival.Size = new System.Drawing.Size(119, 102);
            this.btnFestival.TabIndex = 2;
            this.btnFestival.Text = "Festivals";
            this.btnFestival.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFestival.UseVisualStyleBackColor = true;
            this.btnFestival.Click += new System.EventHandler(this.btnFestival_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CarantecAdminPanel.Properties.Resources.carantec;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 127);
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
            this.Controls.Add(this.cbTrier);
            this.Controls.Add(this.labelTrier);
            this.Controls.Add(this.dgvDonnees);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnFestival;
        private System.Windows.Forms.DataGridView dgvDonnees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Label labelTrier;
        private System.Windows.Forms.ComboBox cbTrier;
        private System.Windows.Forms.Button btnAvis;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnLieux;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnManifestation;
    }
}

