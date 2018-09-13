namespace WindowsFormsApplication1
{
    partial class AjoutStage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dateDebutBox = new System.Windows.Forms.DateTimePicker();
            this.dateFinBox = new System.Windows.Forms.DateTimePicker();
            this.placesBox = new System.Windows.Forms.NumericUpDown();
            this.ageMinBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.ageMaxBox = new System.Windows.Forms.NumericUpDown();
            this.familyBox = new System.Windows.Forms.ComboBox();
            this.centerBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.refreshFamille = new System.Windows.Forms.Button();
            this.refreshCentre = new System.Windows.Forms.Button();
            this.stageTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.StageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.placesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un stage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Du :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Au :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de places :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Famille :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Centre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Age minimum :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Age maximum :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(190, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(161, 63);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(361, 26);
            this.titleBox.TabIndex = 11;
            // 
            // dateDebutBox
            // 
            this.dateDebutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutBox.Location = new System.Drawing.Point(161, 105);
            this.dateDebutBox.Name = "dateDebutBox";
            this.dateDebutBox.Size = new System.Drawing.Size(267, 26);
            this.dateDebutBox.TabIndex = 12;
            // 
            // dateFinBox
            // 
            this.dateFinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinBox.Location = new System.Drawing.Point(161, 144);
            this.dateFinBox.Name = "dateFinBox";
            this.dateFinBox.Size = new System.Drawing.Size(267, 26);
            this.dateFinBox.TabIndex = 13;
            // 
            // placesBox
            // 
            this.placesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesBox.Location = new System.Drawing.Point(233, 256);
            this.placesBox.Name = "placesBox";
            this.placesBox.Size = new System.Drawing.Size(81, 26);
            this.placesBox.TabIndex = 14;
            this.placesBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ageMinBox
            // 
            this.ageMinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMinBox.Location = new System.Drawing.Point(198, 195);
            this.ageMinBox.Name = "ageMinBox";
            this.ageMinBox.Size = new System.Drawing.Size(61, 26);
            this.ageMinBox.TabIndex = 15;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(441, 256);
            this.priceBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(81, 26);
            this.priceBox.TabIndex = 16;
            // 
            // ageMaxBox
            // 
            this.ageMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMaxBox.Location = new System.Drawing.Point(481, 192);
            this.ageMaxBox.Name = "ageMaxBox";
            this.ageMaxBox.Size = new System.Drawing.Size(61, 26);
            this.ageMaxBox.TabIndex = 17;
            // 
            // familyBox
            // 
            this.familyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyBox.FormattingEnabled = true;
            this.familyBox.Location = new System.Drawing.Point(131, 321);
            this.familyBox.Name = "familyBox";
            this.familyBox.Size = new System.Drawing.Size(312, 28);
            this.familyBox.TabIndex = 18;
            // 
            // centerBox
            // 
            this.centerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerBox.FormattingEnabled = true;
            this.centerBox.Location = new System.Drawing.Point(131, 364);
            this.centerBox.Name = "centerBox";
            this.centerBox.Size = new System.Drawing.Size(312, 28);
            this.centerBox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.Location = new System.Drawing.Point(506, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ajouter famille";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.BlueViolet;
            this.button3.Location = new System.Drawing.Point(506, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ajouter centre";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refreshFamille
            // 
            this.refreshFamille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshFamille.Location = new System.Drawing.Point(449, 321);
            this.refreshFamille.Name = "refreshFamille";
            this.refreshFamille.Size = new System.Drawing.Size(53, 29);
            this.refreshFamille.TabIndex = 22;
            this.refreshFamille.Text = "refresh";
            this.refreshFamille.UseVisualStyleBackColor = true;
            this.refreshFamille.Click += new System.EventHandler(this.refreshFamille_Click);
            // 
            // refreshCentre
            // 
            this.refreshCentre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshCentre.Location = new System.Drawing.Point(447, 364);
            this.refreshCentre.Name = "refreshCentre";
            this.refreshCentre.Size = new System.Drawing.Size(53, 28);
            this.refreshCentre.TabIndex = 23;
            this.refreshCentre.Text = "refresh";
            this.refreshCentre.UseVisualStyleBackColor = true;
            this.refreshCentre.Click += new System.EventHandler(this.refreshCentre_Click);
            // 
            // stageTableAdapter1
            // 
            this.stageTableAdapter1.ClearBeforeFill = true;
            // 
            // AjoutStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 482);
            this.Controls.Add(this.refreshCentre);
            this.Controls.Add(this.refreshFamille);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.centerBox);
            this.Controls.Add(this.familyBox);
            this.Controls.Add(this.ageMaxBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.ageMinBox);
            this.Controls.Add(this.placesBox);
            this.Controls.Add(this.dateFinBox);
            this.Controls.Add(this.dateDebutBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un stage";
            this.Load += new System.EventHandler(this.AjoutStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMaxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.DateTimePicker dateDebutBox;
        private System.Windows.Forms.DateTimePicker dateFinBox;
        private System.Windows.Forms.NumericUpDown placesBox;
        private System.Windows.Forms.NumericUpDown ageMinBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown ageMaxBox;
        private System.Windows.Forms.ComboBox familyBox;
        private System.Windows.Forms.ComboBox centerBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button refreshFamille;
        private System.Windows.Forms.Button refreshCentre;
        private Stages2016DataSetTableAdapters.StageTableAdapter stageTableAdapter1;
    }
}