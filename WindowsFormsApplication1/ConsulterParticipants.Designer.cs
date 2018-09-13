namespace WindowsFormsApplication1
{
    partial class ConsulterParticipants
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rechercheBox = new System.Windows.Forms.TextBox();
            this.hommeRadio = new System.Windows.Forms.RadioButton();
            this.femmeRadio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deuxRadio = new System.Windows.Forms.RadioButton();
            this.participantDataGridView = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbStages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.stages2016DataSet = new WindowsFormsApplication1.Stages2016DataSet();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantTableAdapter = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.ParticipantTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager();
            this.participantTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.ParticipantTableAdapter();
            this.inscriptionTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.inscriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des membres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recherche  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Né à partir du :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Est inscrit à au moins un stage :";
            // 
            // rechercheBox
            // 
            this.rechercheBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheBox.Location = new System.Drawing.Point(229, 65);
            this.rechercheBox.Name = "rechercheBox";
            this.rechercheBox.Size = new System.Drawing.Size(309, 26);
            this.rechercheBox.TabIndex = 7;
            this.rechercheBox.TextChanged += new System.EventHandler(this.rechercheBox_TextChanged);
            // 
            // hommeRadio
            // 
            this.hommeRadio.AutoSize = true;
            this.hommeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hommeRadio.Location = new System.Drawing.Point(229, 100);
            this.hommeRadio.Name = "hommeRadio";
            this.hommeRadio.Size = new System.Drawing.Size(83, 24);
            this.hommeRadio.TabIndex = 8;
            this.hommeRadio.Text = "Homme";
            this.hommeRadio.UseVisualStyleBackColor = true;
            this.hommeRadio.CheckedChanged += new System.EventHandler(this.hommeRadio_CheckedChanged);
            // 
            // femmeRadio
            // 
            this.femmeRadio.AutoSize = true;
            this.femmeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femmeRadio.Location = new System.Drawing.Point(319, 100);
            this.femmeRadio.Name = "femmeRadio";
            this.femmeRadio.Size = new System.Drawing.Size(81, 24);
            this.femmeRadio.TabIndex = 9;
            this.femmeRadio.Text = "Femme";
            this.femmeRadio.UseVisualStyleBackColor = true;
            this.femmeRadio.CheckedChanged += new System.EventHandler(this.femmeRadio_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(312, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Oui";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(412, 191);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(146, 29);
            this.buttonAll.TabIndex = 12;
            this.buttonAll.Text = "Afficher tout";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(15, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deuxRadio
            // 
            this.deuxRadio.AutoSize = true;
            this.deuxRadio.Checked = true;
            this.deuxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deuxRadio.Location = new System.Drawing.Point(412, 100);
            this.deuxRadio.Name = "deuxRadio";
            this.deuxRadio.Size = new System.Drawing.Size(91, 24);
            this.deuxRadio.TabIndex = 15;
            this.deuxRadio.TabStop = true;
            this.deuxRadio.Text = "Les deux";
            this.deuxRadio.UseVisualStyleBackColor = true;
            this.deuxRadio.CheckedChanged += new System.EventHandler(this.deuxRadio_CheckedChanged);
            // 
            // participantDataGridView
            // 
            this.participantDataGridView.AllowUserToAddRows = false;
            this.participantDataGridView.AllowUserToDeleteRows = false;
            this.participantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.participantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nom,
            this.prenom,
            this.sexe,
            this.ddn,
            this.nbStages});
            this.participantDataGridView.Location = new System.Drawing.Point(35, 226);
            this.participantDataGridView.Name = "participantDataGridView";
            this.participantDataGridView.ReadOnly = true;
            this.participantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.participantDataGridView.Size = new System.Drawing.Size(520, 272);
            this.participantDataGridView.TabIndex = 16;
            this.participantDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.participantDataGridView_MouseDoubleClick);
            // 
            // num
            // 
            this.num.HeaderText = "Num";
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
            // ddn
            // 
            this.ddn.HeaderText = "Date de naissance";
            this.ddn.Name = "ddn";
            this.ddn.ReadOnly = true;
            // 
            // nbStages
            // 
            this.nbStages.HeaderText = "Nombre de stages";
            this.nbStages.Name = "nbStages";
            this.nbStages.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(276, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ajouter nouveau membre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(35, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(480, 504);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // stages2016DataSet
            // 
            this.stages2016DataSet.DataSetName = "Stages2016DataSet";
            this.stages2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "Participant";
            this.participantBindingSource.DataSource = this.stages2016DataSet;
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CentreTableAdapter = null;
            this.tableAdapterManager.FamilleTableAdapter = null;
            this.tableAdapterManager.inscriptionTableAdapter = null;
            this.tableAdapterManager.moniteurTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = this.participantTableAdapter;
            this.tableAdapterManager.StageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Stages2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // inscriptionTableAdapter1
            // 
            this.inscriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // ConsulterParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.participantDataGridView);
            this.Controls.Add(this.deuxRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.femmeRadio);
            this.Controls.Add(this.hommeRadio);
            this.Controls.Add(this.rechercheBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsulterParticipants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des participants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsulterParticipants_FormClosing);
            this.Load += new System.EventHandler(this.ConsulterParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stages2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stages2016DataSet stages2016DataSet;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private Stages2016DataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
        private Stages2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rechercheBox;
        private System.Windows.Forms.RadioButton hommeRadio;
        private System.Windows.Forms.RadioButton femmeRadio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton deuxRadio;
        private System.Windows.Forms.DataGridView participantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbStages;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Stages2016DataSetTableAdapters.ParticipantTableAdapter participantTableAdapter1;
        private Stages2016DataSetTableAdapters.inscriptionTableAdapter inscriptionTableAdapter1;
    }
}