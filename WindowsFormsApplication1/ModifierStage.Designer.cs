namespace WindowsFormsApplication1
{
    partial class ModifierStage
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titreBox = new System.Windows.Forms.TextBox();
            this.familleBox = new System.Windows.Forms.ComboBox();
            this.centreBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.partMaxBox = new System.Windows.Forms.NumericUpDown();
            this.prixBox = new System.Windows.Forms.NumericUpDown();
            this.ageMinBox = new System.Windows.Forms.NumericUpDown();
            this.ageMaxBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.stageTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.StageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partMaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier description du stage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Du :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Au :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Famille :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Age minimum :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prix :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Age maximum :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre maximum de participants :";
            // 
            // titreBox
            // 
            this.titreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreBox.Location = new System.Drawing.Point(131, 69);
            this.titreBox.Name = "titreBox";
            this.titreBox.Size = new System.Drawing.Size(344, 26);
            this.titreBox.TabIndex = 10;
            // 
            // familleBox
            // 
            this.familleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familleBox.FormattingEnabled = true;
            this.familleBox.Location = new System.Drawing.Point(131, 101);
            this.familleBox.Name = "familleBox";
            this.familleBox.Size = new System.Drawing.Size(344, 28);
            this.familleBox.TabIndex = 11;
            // 
            // centreBox
            // 
            this.centreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centreBox.FormattingEnabled = true;
            this.centreBox.Location = new System.Drawing.Point(131, 135);
            this.centreBox.Name = "centreBox";
            this.centreBox.Size = new System.Drawing.Size(344, 28);
            this.centreBox.TabIndex = 12;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Location = new System.Drawing.Point(131, 208);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(251, 26);
            this.dateTimePickerFin.TabIndex = 13;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Location = new System.Drawing.Point(131, 176);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(251, 26);
            this.dateTimePickerDebut.TabIndex = 14;
            // 
            // partMaxBox
            // 
            this.partMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMaxBox.Location = new System.Drawing.Point(331, 252);
            this.partMaxBox.Name = "partMaxBox";
            this.partMaxBox.Size = new System.Drawing.Size(56, 26);
            this.partMaxBox.TabIndex = 15;
            // 
            // prixBox
            // 
            this.prixBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixBox.Location = new System.Drawing.Point(104, 291);
            this.prixBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.prixBox.Name = "prixBox";
            this.prixBox.Size = new System.Drawing.Size(57, 26);
            this.prixBox.TabIndex = 16;
            // 
            // ageMinBox
            // 
            this.ageMinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMinBox.Location = new System.Drawing.Point(169, 340);
            this.ageMinBox.Name = "ageMinBox";
            this.ageMinBox.Size = new System.Drawing.Size(58, 26);
            this.ageMinBox.TabIndex = 17;
            // 
            // ageMaxBox
            // 
            this.ageMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMaxBox.Location = new System.Drawing.Point(411, 340);
            this.ageMaxBox.Name = "ageMaxBox";
            this.ageMaxBox.Size = new System.Drawing.Size(64, 26);
            this.ageMaxBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(131, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Centre :";
            // 
            // stageTableAdapter1
            // 
            this.stageTableAdapter1.ClearBeforeFill = true;
            // 
            // ModifierStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 455);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ageMaxBox);
            this.Controls.Add(this.ageMinBox);
            this.Controls.Add(this.prixBox);
            this.Controls.Add(this.partMaxBox);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.centreBox);
            this.Controls.Add(this.familleBox);
            this.Controls.Add(this.titreBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifierStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partMaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinBox)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox titreBox;
        private System.Windows.Forms.ComboBox familleBox;
        private System.Windows.Forms.ComboBox centreBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.NumericUpDown partMaxBox;
        private System.Windows.Forms.NumericUpDown prixBox;
        private System.Windows.Forms.NumericUpDown ageMinBox;
        private System.Windows.Forms.NumericUpDown ageMaxBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private Stages2016DataSetTableAdapters.StageTableAdapter stageTableAdapter1;
    }
}