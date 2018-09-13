namespace WindowsFormsApplication1
{
    partial class BasicForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrireÀUnStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désinscrireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreÀJourPayemebtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMoniteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesStagesToolStripMenuItem,
            this.inscriptionsToolStripMenuItem,
            this.gestionnaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesStagesToolStripMenuItem
            // 
            this.listeDesStagesToolStripMenuItem.Name = "listeDesStagesToolStripMenuItem";
            this.listeDesStagesToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.listeDesStagesToolStripMenuItem.Text = "Liste des stages";
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.inscrireÀUnStageToolStripMenuItem,
            this.désinscrireToolStripMenuItem,
            this.mettreÀJourPayemebtToolStripMenuItem});
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter client";
            // 
            // inscrireÀUnStageToolStripMenuItem
            // 
            this.inscrireÀUnStageToolStripMenuItem.Name = "inscrireÀUnStageToolStripMenuItem";
            this.inscrireÀUnStageToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.inscrireÀUnStageToolStripMenuItem.Text = "Inscrire à un stage";
            // 
            // désinscrireToolStripMenuItem
            // 
            this.désinscrireToolStripMenuItem.Name = "désinscrireToolStripMenuItem";
            this.désinscrireToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.désinscrireToolStripMenuItem.Text = "Désinscrire";
            // 
            // mettreÀJourPayemebtToolStripMenuItem
            // 
            this.mettreÀJourPayemebtToolStripMenuItem.Name = "mettreÀJourPayemebtToolStripMenuItem";
            this.mettreÀJourPayemebtToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.mettreÀJourPayemebtToolStripMenuItem.Text = "Mettre à jour payement";
            // 
            // gestionnaireToolStripMenuItem
            // 
            this.gestionnaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnStageToolStripMenuItem,
            this.ajouterUnMoniteurToolStripMenuItem,
            this.ajouterUnCentreToolStripMenuItem,
            this.ajouterUneCatégorieToolStripMenuItem});
            this.gestionnaireToolStripMenuItem.Name = "gestionnaireToolStripMenuItem";
            this.gestionnaireToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.gestionnaireToolStripMenuItem.Text = "Gestionnaire";
            // 
            // ajouterUnStageToolStripMenuItem
            // 
            this.ajouterUnStageToolStripMenuItem.Name = "ajouterUnStageToolStripMenuItem";
            this.ajouterUnStageToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ajouterUnStageToolStripMenuItem.Text = "Ajouter un stage";
            // 
            // ajouterUnMoniteurToolStripMenuItem
            // 
            this.ajouterUnMoniteurToolStripMenuItem.Name = "ajouterUnMoniteurToolStripMenuItem";
            this.ajouterUnMoniteurToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ajouterUnMoniteurToolStripMenuItem.Text = "Ajouter un moniteur";
            // 
            // ajouterUnCentreToolStripMenuItem
            // 
            this.ajouterUnCentreToolStripMenuItem.Name = "ajouterUnCentreToolStripMenuItem";
            this.ajouterUnCentreToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ajouterUnCentreToolStripMenuItem.Text = "Ajouter un centre";
            // 
            // ajouterUneCatégorieToolStripMenuItem
            // 
            this.ajouterUneCatégorieToolStripMenuItem.Name = "ajouterUneCatégorieToolStripMenuItem";
            this.ajouterUneCatégorieToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ajouterUneCatégorieToolStripMenuItem.Text = "Ajouter une catégorie";
            // 
            // BasicForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BasicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesStagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrireÀUnStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désinscrireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mettreÀJourPayemebtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMoniteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneCatégorieToolStripMenuItem;
    }
}

