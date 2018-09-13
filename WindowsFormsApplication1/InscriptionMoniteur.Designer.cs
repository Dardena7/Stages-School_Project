namespace WindowsFormsApplication1
{
    partial class InscriptionMoniteur
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
            this.moniteurTextBox = new System.Windows.Forms.TextBox();
            this.stageTextBox = new System.Windows.Forms.TextBox();
            this.moniteurComboBox = new System.Windows.Forms.ComboBox();
            this.stageComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animerTableAdapter1 = new WindowsFormsApplication1.Stages2016DataSetTableAdapters.animerTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscrire un moniteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechercher moniteur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moniteur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rechercher stage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stage :";
            // 
            // moniteurTextBox
            // 
            this.moniteurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moniteurTextBox.Location = new System.Drawing.Point(275, 87);
            this.moniteurTextBox.Name = "moniteurTextBox";
            this.moniteurTextBox.Size = new System.Drawing.Size(337, 26);
            this.moniteurTextBox.TabIndex = 5;
            this.moniteurTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stageTextBox
            // 
            this.stageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageTextBox.Location = new System.Drawing.Point(275, 180);
            this.stageTextBox.Name = "stageTextBox";
            this.stageTextBox.Size = new System.Drawing.Size(337, 26);
            this.stageTextBox.TabIndex = 6;
            this.stageTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // moniteurComboBox
            // 
            this.moniteurComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moniteurComboBox.FormattingEnabled = true;
            this.moniteurComboBox.Location = new System.Drawing.Point(107, 121);
            this.moniteurComboBox.Name = "moniteurComboBox";
            this.moniteurComboBox.Size = new System.Drawing.Size(505, 28);
            this.moniteurComboBox.TabIndex = 7;
            // 
            // stageComboBox
            // 
            this.stageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageComboBox.FormattingEnabled = true;
            this.stageComboBox.Location = new System.Drawing.Point(107, 212);
            this.stageComboBox.Name = "stageComboBox";
            this.stageComboBox.Size = new System.Drawing.Size(505, 28);
            this.stageComboBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(189, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inscrire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animerTableAdapter1
            // 
            this.animerTableAdapter1.ClearBeforeFill = true;
            // 
            // InscriptionMoniteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stageComboBox);
            this.Controls.Add(this.moniteurComboBox);
            this.Controls.Add(this.stageTextBox);
            this.Controls.Add(this.moniteurTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InscriptionMoniteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InscriptionMoniteur";
            this.Load += new System.EventHandler(this.InscriptionMoniteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox moniteurTextBox;
        private System.Windows.Forms.TextBox stageTextBox;
        private System.Windows.Forms.ComboBox moniteurComboBox;
        private System.Windows.Forms.ComboBox stageComboBox;
        private System.Windows.Forms.Button button1;
        private Stages2016DataSetTableAdapters.animerTableAdapter animerTableAdapter1;
    }
}