namespace WindowsFormsApplication1
{
    partial class StageForm
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
            this.stageTitre = new System.Windows.Forms.Label();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.labelMoniteurs = new System.Windows.Forms.Label();
            this.famille = new System.Windows.Forms.Label();
            this.centre = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.Label();
            this.ageMin = new System.Windows.Forms.Label();
            this.ageMax = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.buttonModif = new System.Windows.Forms.Button();
            this.btUnsign = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddn_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paye_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Num_moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe_moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPart = new System.Windows.Forms.Label();
            this.familleRep = new System.Windows.Forms.Label();
            this.centreRep = new System.Windows.Forms.Label();
            this.dateDebutRep = new System.Windows.Forms.Label();
            this.dateFinRep = new System.Windows.Forms.Label();
            this.ageMinRep = new System.Windows.Forms.Label();
            this.ageMaxRep = new System.Windows.Forms.Label();
            this.prixRep = new System.Windows.Forms.Label();
            this.btPay = new System.Windows.Forms.Button();
            this.btMoniteur = new System.Windows.Forms.Button();
            this.btAddMoniteur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inscriptionTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.inscriptionTableAdapter();
            this.animerTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.animerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stageTitre
            // 
            this.stageTitre.AutoSize = true;
            this.stageTitre.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageTitre.ForeColor = System.Drawing.Color.DarkRed;
            this.stageTitre.Location = new System.Drawing.Point(6, 235);
            this.stageTitre.Name = "stageTitre";
            this.stageTitre.Size = new System.Drawing.Size(76, 32);
            this.stageTitre.TabIndex = 1;
            this.stageTitre.Text = "Titre";
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticipants.Location = new System.Drawing.Point(6, 10);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(205, 24);
            this.labelParticipants.TabIndex = 2;
            this.labelParticipants.Text = "Liste des participants";
            // 
            // labelMoniteurs
            // 
            this.labelMoniteurs.AutoSize = true;
            this.labelMoniteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoniteurs.Location = new System.Drawing.Point(6, 9);
            this.labelMoniteurs.Name = "labelMoniteurs";
            this.labelMoniteurs.Size = new System.Drawing.Size(191, 24);
            this.labelMoniteurs.TabIndex = 3;
            this.labelMoniteurs.Text = "Liste des moniteurs";
            this.labelMoniteurs.Click += new System.EventHandler(this.labelMoniteurs_Click);
            // 
            // famille
            // 
            this.famille.AutoSize = true;
            this.famille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famille.Location = new System.Drawing.Point(9, 295);
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(67, 16);
            this.famille.TabIndex = 4;
            this.famille.Text = "Famille :";
            this.famille.Click += new System.EventHandler(this.famille_Click);
            // 
            // centre
            // 
            this.centre.AutoSize = true;
            this.centre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centre.Location = new System.Drawing.Point(9, 321);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(61, 16);
            this.centre.TabIndex = 5;
            this.centre.Text = "Centre :";
            this.centre.Click += new System.EventHandler(this.centre_Click);
            // 
            // dateDebut
            // 
            this.dateDebut.AutoSize = true;
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Location = new System.Drawing.Point(9, 352);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(35, 16);
            this.dateDebut.TabIndex = 6;
            this.dateDebut.Text = "Du :";
            this.dateDebut.Click += new System.EventHandler(this.dateDebut_Click);
            // 
            // dateFin
            // 
            this.dateFin.AutoSize = true;
            this.dateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Location = new System.Drawing.Point(9, 377);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(34, 16);
            this.dateFin.TabIndex = 7;
            this.dateFin.Text = "Au: ";
            this.dateFin.Click += new System.EventHandler(this.dateFin_Click);
            // 
            // ageMin
            // 
            this.ageMin.AutoSize = true;
            this.ageMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMin.Location = new System.Drawing.Point(9, 407);
            this.ageMin.Name = "ageMin";
            this.ageMin.Size = new System.Drawing.Size(72, 16);
            this.ageMin.TabIndex = 8;
            this.ageMin.Text = "Age min :";
            this.ageMin.Click += new System.EventHandler(this.ageMin_Click);
            // 
            // ageMax
            // 
            this.ageMax.AutoSize = true;
            this.ageMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMax.Location = new System.Drawing.Point(9, 433);
            this.ageMax.Name = "ageMax";
            this.ageMax.Size = new System.Drawing.Size(76, 16);
            this.ageMax.TabIndex = 9;
            this.ageMax.Text = "Age max :";
            this.ageMax.Click += new System.EventHandler(this.ageMax_Click);
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(9, 467);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(42, 16);
            this.prix.TabIndex = 10;
            this.prix.Text = "Prix :";
            this.prix.Click += new System.EventHandler(this.prix_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModif.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonModif.Location = new System.Drawing.Point(12, 509);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(332, 41);
            this.buttonModif.TabIndex = 11;
            this.buttonModif.Text = "Modifier les informations";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // btUnsign
            // 
            this.btUnsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnsign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btUnsign.Location = new System.Drawing.Point(250, 210);
            this.btUnsign.Name = "btUnsign";
            this.btUnsign.Size = new System.Drawing.Size(118, 30);
            this.btUnsign.TabIndex = 12;
            this.btUnsign.Text = "Désinscrire";
            this.btUnsign.UseVisualStyleBackColor = true;
            this.btUnsign.Click += new System.EventHandler(this.btUnsign_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_part,
            this.Nom_part,
            this.Prenom_part,
            this.Sexe_part,
            this.Ddn_part,
            this.Paye_part});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 165);
            this.dataGridView1.TabIndex = 13;
            // 
            // Num_part
            // 
            this.Num_part.HeaderText = "Num";
            this.Num_part.Name = "Num_part";
            this.Num_part.ReadOnly = true;
            // 
            // Nom_part
            // 
            this.Nom_part.HeaderText = "Nom";
            this.Nom_part.Name = "Nom_part";
            this.Nom_part.ReadOnly = true;
            // 
            // Prenom_part
            // 
            this.Prenom_part.HeaderText = "Prénom";
            this.Prenom_part.Name = "Prenom_part";
            this.Prenom_part.ReadOnly = true;
            // 
            // Sexe_part
            // 
            this.Sexe_part.HeaderText = "Sexe";
            this.Sexe_part.Name = "Sexe_part";
            this.Sexe_part.ReadOnly = true;
            // 
            // Ddn_part
            // 
            this.Ddn_part.HeaderText = "Ddn";
            this.Ddn_part.Name = "Ddn_part";
            this.Ddn_part.ReadOnly = true;
            // 
            // Paye_part
            // 
            this.Paye_part.HeaderText = "A payé";
            this.Paye_part.Name = "Paye_part";
            this.Paye_part.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_moniteur,
            this.Nom_moniteur,
            this.Prenom_moniteur,
            this.Sexe_moniteur});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView2.Location = new System.Drawing.Point(6, 36);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(417, 102);
            this.dataGridView2.TabIndex = 14;
            // 
            // Num_moniteur
            // 
            this.Num_moniteur.HeaderText = "Num";
            this.Num_moniteur.Name = "Num_moniteur";
            this.Num_moniteur.ReadOnly = true;
            // 
            // Nom_moniteur
            // 
            this.Nom_moniteur.HeaderText = "Nom";
            this.Nom_moniteur.Name = "Nom_moniteur";
            this.Nom_moniteur.ReadOnly = true;
            // 
            // Prenom_moniteur
            // 
            this.Prenom_moniteur.HeaderText = "Prénom";
            this.Prenom_moniteur.Name = "Prenom_moniteur";
            this.Prenom_moniteur.ReadOnly = true;
            // 
            // Sexe_moniteur
            // 
            this.Sexe_moniteur.HeaderText = "Sexe";
            this.Sexe_moniteur.Name = "Sexe_moniteur";
            this.Sexe_moniteur.ReadOnly = true;
            // 
            // nbPart
            // 
            this.nbPart.AutoSize = true;
            this.nbPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPart.Location = new System.Drawing.Point(260, 16);
            this.nbPart.Name = "nbPart";
            this.nbPart.Size = new System.Drawing.Size(61, 16);
            this.nbPart.TabIndex = 15;
            this.nbPart.Text = "nbParts";
            // 
            // familleRep
            // 
            this.familleRep.AutoSize = true;
            this.familleRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familleRep.Location = new System.Drawing.Point(91, 295);
            this.familleRep.Name = "familleRep";
            this.familleRep.Size = new System.Drawing.Size(45, 16);
            this.familleRep.TabIndex = 16;
            this.familleRep.Text = "label1";
            this.familleRep.Click += new System.EventHandler(this.label1_Click);
            // 
            // centreRep
            // 
            this.centreRep.AutoSize = true;
            this.centreRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centreRep.Location = new System.Drawing.Point(91, 323);
            this.centreRep.Name = "centreRep";
            this.centreRep.Size = new System.Drawing.Size(45, 16);
            this.centreRep.TabIndex = 17;
            this.centreRep.Text = "label2";
            this.centreRep.Click += new System.EventHandler(this.centreRep_Click);
            // 
            // dateDebutRep
            // 
            this.dateDebutRep.AutoSize = true;
            this.dateDebutRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutRep.Location = new System.Drawing.Point(91, 354);
            this.dateDebutRep.Name = "dateDebutRep";
            this.dateDebutRep.Size = new System.Drawing.Size(45, 16);
            this.dateDebutRep.TabIndex = 18;
            this.dateDebutRep.Text = "label3";
            this.dateDebutRep.Click += new System.EventHandler(this.dateDebutRep_Click);
            // 
            // dateFinRep
            // 
            this.dateFinRep.AutoSize = true;
            this.dateFinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinRep.Location = new System.Drawing.Point(91, 379);
            this.dateFinRep.Name = "dateFinRep";
            this.dateFinRep.Size = new System.Drawing.Size(45, 16);
            this.dateFinRep.TabIndex = 19;
            this.dateFinRep.Text = "label4";
            this.dateFinRep.Click += new System.EventHandler(this.dateFinRep_Click);
            // 
            // ageMinRep
            // 
            this.ageMinRep.AutoSize = true;
            this.ageMinRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMinRep.Location = new System.Drawing.Point(91, 409);
            this.ageMinRep.Name = "ageMinRep";
            this.ageMinRep.Size = new System.Drawing.Size(45, 16);
            this.ageMinRep.TabIndex = 20;
            this.ageMinRep.Text = "label5";
            this.ageMinRep.Click += new System.EventHandler(this.ageMinRep_Click);
            // 
            // ageMaxRep
            // 
            this.ageMaxRep.AutoSize = true;
            this.ageMaxRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMaxRep.Location = new System.Drawing.Point(91, 435);
            this.ageMaxRep.Name = "ageMaxRep";
            this.ageMaxRep.Size = new System.Drawing.Size(45, 16);
            this.ageMaxRep.TabIndex = 21;
            this.ageMaxRep.Text = "label6";
            this.ageMaxRep.Click += new System.EventHandler(this.ageMaxRep_Click);
            // 
            // prixRep
            // 
            this.prixRep.AutoSize = true;
            this.prixRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixRep.Location = new System.Drawing.Point(91, 469);
            this.prixRep.Name = "prixRep";
            this.prixRep.Size = new System.Drawing.Size(45, 16);
            this.prixRep.TabIndex = 22;
            this.prixRep.Text = "label7";
            this.prixRep.Click += new System.EventHandler(this.prixRep_Click);
            // 
            // btPay
            // 
            this.btPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPay.Location = new System.Drawing.Point(56, 210);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(174, 30);
            this.btPay.TabIndex = 23;
            this.btPay.Text = "Ajouter/Retirer payement";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btMoniteur
            // 
            this.btMoniteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMoniteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoniteur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMoniteur.Location = new System.Drawing.Point(215, 144);
            this.btMoniteur.Name = "btMoniteur";
            this.btMoniteur.Size = new System.Drawing.Size(153, 30);
            this.btMoniteur.TabIndex = 24;
            this.btMoniteur.Text = "Retirer moniteur";
            this.btMoniteur.UseVisualStyleBackColor = true;
            this.btMoniteur.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAddMoniteur
            // 
            this.btAddMoniteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddMoniteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddMoniteur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAddMoniteur.Location = new System.Drawing.Point(56, 144);
            this.btAddMoniteur.Name = "btAddMoniteur";
            this.btAddMoniteur.Size = new System.Drawing.Size(153, 30);
            this.btAddMoniteur.TabIndex = 25;
            this.btAddMoniteur.Text = "Ajouter moniteur";
            this.btAddMoniteur.UseVisualStyleBackColor = true;
            this.btAddMoniteur.Click += new System.EventHandler(this.btAddMoniteur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btSign);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.labelParticipants);
            this.groupBox1.Controls.Add(this.nbPart);
            this.groupBox1.Controls.Add(this.btPay);
            this.groupBox1.Controls.Add(this.btUnsign);
            this.groupBox1.Location = new System.Drawing.Point(350, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 281);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSign
            // 
            this.btSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSign.Location = new System.Drawing.Point(56, 246);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(222, 30);
            this.btSign.TabIndex = 24;
            this.btSign.Text = "Inscrire participant";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.labelMoniteurs);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btAddMoniteur);
            this.groupBox2.Controls.Add(this.btMoniteur);
            this.groupBox2.Location = new System.Drawing.Point(350, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 216);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(173, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.monopoly_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inscriptionTableAdapter1
            // 
            this.inscriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // animerTableAdapter1
            // 
            this.animerTableAdapter1.ClearBeforeFill = true;
            // 
            // StageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prixRep);
            this.Controls.Add(this.ageMaxRep);
            this.Controls.Add(this.ageMinRep);
            this.Controls.Add(this.dateFinRep);
            this.Controls.Add(this.dateDebutRep);
            this.Controls.Add(this.centreRep);
            this.Controls.Add(this.familleRep);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.ageMax);
            this.Controls.Add(this.ageMin);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.centre);
            this.Controls.Add(this.famille);
            this.Controls.Add(this.stageTitre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Description du stage";
            this.Load += new System.EventHandler(this.StageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stageTitre;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Label labelMoniteurs;
        private System.Windows.Forms.Label famille;
        private System.Windows.Forms.Label centre;
        private System.Windows.Forms.Label dateDebut;
        private System.Windows.Forms.Label dateFin;
        private System.Windows.Forms.Label ageMin;
        private System.Windows.Forms.Label ageMax;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button btUnsign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label nbPart;
        private System.Windows.Forms.Label familleRep;
        private System.Windows.Forms.Label centreRep;
        private System.Windows.Forms.Label dateDebutRep;
        private System.Windows.Forms.Label dateFinRep;
        private System.Windows.Forms.Label ageMinRep;
        private System.Windows.Forms.Label ageMaxRep;
        private System.Windows.Forms.Label prixRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_moniteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_moniteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_moniteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe_moniteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ddn_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paye_part;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btMoniteur;
        private System.Windows.Forms.Button btAddMoniteur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Stages2016DataSetTableAdapters.inscriptionTableAdapter inscriptionTableAdapter1;
        private Stages2016DataSetTableAdapters.animerTableAdapter animerTableAdapter1;
    }
}