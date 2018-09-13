namespace WindowsFormsApplication1
{
    partial class ConsulterMoniteurs
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
            this.stages2016DataSet = new WindowsFormsApplication1.Stages2016DataSet();
            this.moniteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moniteurTableAdapter = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.moniteurTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbStages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hommeRadio = new System.Windows.Forms.RadioButton();
            this.femmeRadio = new System.Windows.Forms.RadioButton();
            this.deuxRadio = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.animerTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.animerTableAdapter();
            this.moniteurTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.moniteurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moniteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stages2016DataSet
            // 
            this.stages2016DataSet.DataSetName = "Stages2016DataSet";
            this.stages2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moniteurBindingSource
            // 
            this.moniteurBindingSource.DataMember = "moniteur";
            this.moniteurBindingSource.DataSource = this.stages2016DataSet;
            // 
            // moniteurTableAdapter
            // 
            this.moniteurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CentreTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.inscriptionTableAdapter = null;
            this.tableAdapterManager.moniteurTableAdapter = this.moniteurTableAdapter;
            this.tableAdapterManager.ParticipantTableAdapter = null;
            this.tableAdapterManager.StageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des moniteurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nom,
            this.prenom,
            this.sexe,
            this.nbStages});
            this.dataGridView1.Location = new System.Drawing.Point(35, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // num
            // 
            this.num.HeaderText = "Numéro";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            // 
            // nbStages
            // 
            this.nbStages.HeaderText = "Nombre de stages";
            this.nbStages.Name = "nbStages";
            this.nbStages.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher tout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(481, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(276, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ajouter nouveau moniteur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(35, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recherche :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anime au moins un stage :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(180, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hommeRadio
            // 
            this.hommeRadio.AutoSize = true;
            this.hommeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hommeRadio.Location = new System.Drawing.Point(180, 114);
            this.hommeRadio.Name = "hommeRadio";
            this.hommeRadio.Size = new System.Drawing.Size(83, 24);
            this.hommeRadio.TabIndex = 13;
            this.hommeRadio.Text = "Homme";
            this.hommeRadio.UseVisualStyleBackColor = true;
            this.hommeRadio.CheckedChanged += new System.EventHandler(this.hommeRadio_CheckedChanged);
            // 
            // femmeRadio
            // 
            this.femmeRadio.AutoSize = true;
            this.femmeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femmeRadio.Location = new System.Drawing.Point(324, 114);
            this.femmeRadio.Name = "femmeRadio";
            this.femmeRadio.Size = new System.Drawing.Size(81, 24);
            this.femmeRadio.TabIndex = 14;
            this.femmeRadio.Text = "Femme";
            this.femmeRadio.UseVisualStyleBackColor = true;
            this.femmeRadio.CheckedChanged += new System.EventHandler(this.femmeRadio_CheckedChanged);
            // 
            // deuxRadio
            // 
            this.deuxRadio.AutoSize = true;
            this.deuxRadio.Checked = true;
            this.deuxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deuxRadio.Location = new System.Drawing.Point(477, 114);
            this.deuxRadio.Name = "deuxRadio";
            this.deuxRadio.Size = new System.Drawing.Size(91, 24);
            this.deuxRadio.TabIndex = 15;
            this.deuxRadio.TabStop = true;
            this.deuxRadio.Text = "Les deux";
            this.deuxRadio.UseVisualStyleBackColor = true;
            this.deuxRadio.CheckedChanged += new System.EventHandler(this.deuxRadio_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(324, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Oui";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "Accueil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // animerTableAdapter1
            // 
            this.animerTableAdapter1.ClearBeforeFill = true;
            // 
            // moniteurTableAdapter1
            // 
            this.moniteurTableAdapter1.ClearBeforeFill = true;
            // 
            // ConsulterMoniteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 562);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.deuxRadio);
            this.Controls.Add(this.femmeRadio);
            this.Controls.Add(this.hommeRadio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConsulterMoniteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des moniteurs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsulterMoniteurs_FormClosing);
            this.Load += new System.EventHandler(this.ConsulterMoniteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moniteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stages2016DataSet stages2016DataSet;
        private System.Windows.Forms.BindingSource moniteurBindingSource;
        private Stages2016DataSetTableAdapters.moniteurTableAdapter moniteurTableAdapter;
        private Stages2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton hommeRadio;
        private System.Windows.Forms.RadioButton femmeRadio;
        private System.Windows.Forms.RadioButton deuxRadio;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbStages;
        private System.Windows.Forms.Button button5;
        private Stages2016DataSetTableAdapters.animerTableAdapter animerTableAdapter1;
        private Stages2016DataSetTableAdapters.moniteurTableAdapter moniteurTableAdapter1;
    }
}