namespace WindowsFormsApplication1
{
    partial class ConsulterStages
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPrixMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrixMax = new System.Windows.Forms.NumericUpDown();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.numericUpDownAgeMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAgeMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxFamille = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btAccueil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stages2016DataSet = new WindowsFormsApplication1.Stages2016DataSet();
            this.stageTableAdapter = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.StageTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager();
            this.animerTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.animerTableAdapter();
            this.inscriptionTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.inscriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(262, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des stages";
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(120, 214);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerDebut.TabIndex = 3;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(120, 240);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerFin.TabIndex = 4;
            // 
            // numericUpDownPrixMin
            // 
            this.numericUpDownPrixMin.Location = new System.Drawing.Point(535, 109);
            this.numericUpDownPrixMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrixMin.Name = "numericUpDownPrixMin";
            this.numericUpDownPrixMin.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownPrixMin.TabIndex = 5;
            // 
            // numericUpDownPrixMax
            // 
            this.numericUpDownPrixMax.Location = new System.Drawing.Point(667, 109);
            this.numericUpDownPrixMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrixMax.Name = "numericUpDownPrixMax";
            this.numericUpDownPrixMax.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownPrixMax.TabIndex = 6;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(120, 105);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(189, 20);
            this.textBoxRecherche.TabIndex = 7;
            // 
            // numericUpDownAgeMax
            // 
            this.numericUpDownAgeMax.Location = new System.Drawing.Point(667, 149);
            this.numericUpDownAgeMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownAgeMax.Name = "numericUpDownAgeMax";
            this.numericUpDownAgeMax.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownAgeMax.TabIndex = 8;
            // 
            // numericUpDownAgeMin
            // 
            this.numericUpDownAgeMin.Location = new System.Drawing.Point(535, 149);
            this.numericUpDownAgeMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownAgeMin.Name = "numericUpDownAgeMin";
            this.numericUpDownAgeMin.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownAgeMin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recherche :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Famille :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ville :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(413, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Afficher tout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(568, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Filtrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxFamille
            // 
            this.comboBoxFamille.FormattingEnabled = true;
            this.comboBoxFamille.Location = new System.Drawing.Point(120, 140);
            this.comboBoxFamille.Name = "comboBoxFamille";
            this.comboBoxFamille.Size = new System.Drawing.Size(189, 21);
            this.comboBoxFamille.TabIndex = 19;
            this.comboBoxFamille.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(120, 174);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(189, 21);
            this.comboBoxVille.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Du :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Au :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(409, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Prix :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(409, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Age :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.titre,
            this.debut,
            this.fin,
            this.prix,
            this.famille,
            this.ville,
            this.places,
            this.ageMin,
            this.ageMax});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 238);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Numéro";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // titre
            // 
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            // 
            // debut
            // 
            this.debut.HeaderText = "Début";
            this.debut.Name = "debut";
            this.debut.ReadOnly = true;
            // 
            // fin
            // 
            this.fin.HeaderText = "Fin";
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // famille
            // 
            this.famille.HeaderText = "Famille";
            this.famille.Name = "famille";
            this.famille.ReadOnly = true;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // places
            // 
            this.places.HeaderText = "Places restantes";
            this.places.Name = "places";
            this.places.ReadOnly = true;
            // 
            // ageMin
            // 
            this.ageMin.HeaderText = "Age min";
            this.ageMin.Name = "ageMin";
            this.ageMin.ReadOnly = true;
            // 
            // ageMax
            // 
            this.ageMax.HeaderText = "Age max";
            this.ageMax.Name = "ageMax";
            this.ageMax.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(463, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "masquer les stages complets";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btAccueil
            // 
            this.btAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAccueil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccueil.ForeColor = System.Drawing.Color.Green;
            this.btAccueil.Location = new System.Drawing.Point(12, 38);
            this.btAccueil.Name = "btAccueil";
            this.btAccueil.Size = new System.Drawing.Size(93, 39);
            this.btAccueil.TabIndex = 27;
            this.btAccueil.Text = "Accueil";
            this.btAccueil.UseVisualStyleBackColor = true;
            this.btAccueil.Click += new System.EventHandler(this.btAccueil_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(195, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 28;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(432, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 38);
            this.button4.TabIndex = 29;
            this.button4.Text = "Ajouter nouveau stage";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(697, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 30;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // stageBindingSource
            // 
            this.stageBindingSource.DataMember = "Stage";
            this.stageBindingSource.DataSource = this.stages2016DataSet;
            // 
            // stages2016DataSet
            // 
            this.stages2016DataSet.DataSetName = "Stages2016DataSet";
            this.stages2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stageTableAdapter
            // 
            this.stageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CentreTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.inscriptionTableAdapter = null;
            this.tableAdapterManager.moniteurTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = null;
            this.tableAdapterManager.StageTableAdapter = this.stageTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animerTableAdapter1
            // 
            this.animerTableAdapter1.ClearBeforeFill = true;
            // 
            // inscriptionTableAdapter1
            // 
            this.inscriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // ConsulterStages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAccueil);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxFamille);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAgeMin);
            this.Controls.Add(this.numericUpDownAgeMax);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.numericUpDownPrixMax);
            this.Controls.Add(this.numericUpDownPrixMin);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.label1);
            this.Name = "ConsulterStages";
            this.Text = "Liste des stages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsulterStages_FormClosing);
            this.Load += new System.EventHandler(this.ConsulterStages_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDebut, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFin, 0);
            this.Controls.SetChildIndex(this.numericUpDownPrixMin, 0);
            this.Controls.SetChildIndex(this.numericUpDownPrixMax, 0);
            this.Controls.SetChildIndex(this.textBoxRecherche, 0);
            this.Controls.SetChildIndex(this.numericUpDownAgeMax, 0);
            this.Controls.SetChildIndex(this.numericUpDownAgeMin, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.comboBoxFamille, 0);
            this.Controls.SetChildIndex(this.comboBoxVille, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.btAccueil, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Stages2016DataSet stages2016DataSet;
        private System.Windows.Forms.BindingSource stageBindingSource;
        private Stages2016DataSetTableAdapters.StageTableAdapter stageTableAdapter;
        private Stages2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.NumericUpDown numericUpDownPrixMin;
        private System.Windows.Forms.NumericUpDown numericUpDownPrixMax;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeMax;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxFamille;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn places;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMax;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btAccueil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Stages2016DataSetTableAdapters.animerTableAdapter animerTableAdapter1;
        private Stages2016DataSetTableAdapters.inscriptionTableAdapter inscriptionTableAdapter1;
    }
}