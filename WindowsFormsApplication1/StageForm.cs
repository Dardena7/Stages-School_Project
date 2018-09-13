using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class StageForm : Form
    {
        private SqlConnection con;
        private int id_stage;
        private DataTable tableStage = new DataTable();
        public StageForm(int index)
        {
            InitializeComponent();
            id_stage = index;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
            this.fillTableStage();
        }

        private void fillTableStage()
        {
            SqlDataAdapter sdaStage = new SqlDataAdapter("SELECT * FROM Stage WHERE idS =" + id_stage, con);
            sdaStage.Fill(tableStage); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StageForm_Load(object sender, EventArgs e)
        {
            this.loadStageDescription();
            this.loadParticipants();
            this.loadMoniteurs();
        }

        private void loadParticipants()
        {
            SqlDataAdapter sdaParticipants = new SqlDataAdapter("SELECT * FROM participant, inscription WHERE numS =" + id_stage+"AND idP = numP", con);
            DataTable dtParticipants = new DataTable();
            sdaParticipants.Fill(dtParticipants);
            int nbRows = dtParticipants.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                String paye = getPaye(dtParticipants.Rows[i]["paye"].ToString());
                DateTime date = (DateTime)dtParticipants.Rows[i]["ddn"];
                String ddn = date.ToString("dd/MM/yyyy");
                String sexe = this.getSexe(dtParticipants.Rows[i]["sexe"].ToString());

                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].Cells["Num_part"].Value = dtParticipants.Rows[i]["idP"].ToString();
                this.dataGridView1.Rows[i].Cells["Nom_part"].Value = dtParticipants.Rows[i]["nom"].ToString();
                this.dataGridView1.Rows[i].Cells["Prenom_part"].Value = dtParticipants.Rows[i]["prenom"].ToString();
                this.dataGridView1.Rows[i].Cells["Sexe_part"].Value = sexe;
                this.dataGridView1.Rows[i].Cells["Ddn_part"].Value = ddn;
                this.dataGridView1.Rows[i].Cells["Paye_part"].Value = paye;
            }

        }

        private String getSexe(String s)
        {
            if (s.Equals("f"))
                return "Femme";
            else return "Homme";
        }

        private String getPaye(String paye)
        {
            if (paye.Equals("o"))
                return "Oui";
            else
                return "Non";
        }

        private void loadMoniteurs()
        {
            SqlDataAdapter sdaMoniteurs = new SqlDataAdapter("SELECT * FROM moniteur, animer WHERE numS =" + id_stage + "AND idM = numM", con);
            DataTable dtMoniteurs = new DataTable();
            sdaMoniteurs.Fill(dtMoniteurs);
            int nbRows = dtMoniteurs.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                this.dataGridView2.Rows.Add();
                String sexe = this.getSexe(dtMoniteurs.Rows[i]["sexe"].ToString());
                this.dataGridView2.Rows[i].Cells["Num_Moniteur"].Value = dtMoniteurs.Rows[i]["idM"].ToString();
                this.dataGridView2.Rows[i].Cells["Nom_Moniteur"].Value = dtMoniteurs.Rows[i]["nom"].ToString();
                this.dataGridView2.Rows[i].Cells["Prenom_Moniteur"].Value = dtMoniteurs.Rows[i]["prenom"].ToString();
                this.dataGridView2.Rows[i].Cells["Sexe_Moniteur"].Value = sexe;

            }
        }

        private void loadStageDescription()
        {
            String nbStagiaires = getNbStagiaires();
            String ville = getVille(Int32.Parse(tableStage.Rows[0]["numC"].ToString()));
            String famille = getFamille(Int32.Parse(tableStage.Rows[0]["numF"].ToString()));

            DateTime date = (DateTime)tableStage.Rows[0]["date_debut"];
            String dateDebut = date.ToString("dd/MM/yyyy");
            date = (DateTime)tableStage.Rows[0]["date_fin"];
            String dateFin = date.ToString("dd/MM/yyyy");

            stageTitre.Text = tableStage.Rows[0]["titre"].ToString();
            familleRep.Text = famille;
            centreRep.Text = ville;
            dateDebutRep.Text = dateDebut;
            dateFinRep.Text = dateFin;
            ageMinRep.Text = tableStage.Rows[0]["age_min"].ToString();
            ageMaxRep.Text = tableStage.Rows[0]["age_max"].ToString();
            prixRep.Text = tableStage.Rows[0]["prix"].ToString();
            nbPart.Text = nbStagiaires+" sur "+tableStage.Rows[0]["nbMaxStagiaires"].ToString();

        }

        private String getFamille(int numF)
        {
            SqlDataAdapter sdaFamille = new SqlDataAdapter("SELECT * FROM famille WHERE idF =" + numF, con);
            DataTable dtFamille = new DataTable();
            sdaFamille.Fill(dtFamille);
            return dtFamille.Rows[0]["description"].ToString();
        }

        private String getVille(int numC)
        {
            SqlDataAdapter sdaVille = new SqlDataAdapter("SELECT * FROM centre WHERE idC =" + numC, con);
            DataTable dtVille = new DataTable();
            sdaVille.Fill(dtVille);
            return dtVille.Rows[0]["ville"].ToString();
        }

        private String getNbStagiaires()
        {
            SqlDataAdapter sdaNbPart = new SqlDataAdapter("SELECT COUNT(*) AS NbPart FROM inscription WHERE numS =" + id_stage, con);
            DataTable dtNbPart = new DataTable();
            sdaNbPart.Fill(dtNbPart);
            return dtNbPart.Rows[0]["NbPart"].ToString();
        }

        private void labelMoniteurs_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView2.CurrentRow != null) && (dataGridView2.Rows.Count != 0))
            {
                int id_moniteur = Int32.Parse(dataGridView2.CurrentRow.Cells["Num_moniteur"].Value.ToString());
                animerTableAdapter1.DeleteQuery(id_moniteur, id_stage);
                refreshMoniteurs();
            }
        }

        private void famille_Click(object sender, EventArgs e)
        {

        }

        private void centre_Click(object sender, EventArgs e)
        {

        }

        private void dateDebut_Click(object sender, EventArgs e)
        {

        }

        private void dateFin_Click(object sender, EventArgs e)
        {

        }

        private void ageMin_Click(object sender, EventArgs e)
        {

        }

        private void ageMax_Click(object sender, EventArgs e)
        {

        }

        private void prix_Click(object sender, EventArgs e)
        {

        }

        private void prixRep_Click(object sender, EventArgs e)
        {

        }

        private void ageMaxRep_Click(object sender, EventArgs e)
        {

        }

        private void ageMinRep_Click(object sender, EventArgs e)
        {

        }

        private void dateFinRep_Click(object sender, EventArgs e)
        {

        }

        private void dateDebutRep_Click(object sender, EventArgs e)
        {

        }

        private void centreRep_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stageComplet())
            {
                List<String> errors = new List<String>();
                errors.Add("Le stage est complet !");
                new ErrorDialog(errors).ShowDialog();
            }
            else
                new InscriptionParticipant(0, id_stage).ShowDialog();
        }

        private Boolean stageComplet()
        {
            int nbMax = Int32.Parse(tableStage.Rows[0]["nbMaxStagiaires"].ToString());
            int nbPart = Int32.Parse(getNbStagiaires());
            return nbPart >= nbMax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.refreshStagiaires();
        }

        private void btUnsign_Click(object sender, EventArgs e)
        {
            if((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0)){
                int id_participant = Int32.Parse(dataGridView1.CurrentRow.Cells["Num_part"].Value.ToString());
                inscriptionTableAdapter1.DeleteQuery(id_stage, id_participant);
                refreshStagiaires();
            }
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int id_participant = Int32.Parse(dataGridView1.CurrentRow.Cells["Num_part"].Value.ToString());
                SqlDataAdapter sda = new SqlDataAdapter("SELECT paye FROM inscription WHERE numS = " + id_stage + " AND numP = " + id_participant, con);
                DataTable dtPaye = new DataTable();
                sda.Fill(dtPaye);
                String paye = dtPaye.Rows[0]["paye"].ToString();

                if (paye.Equals("o"))
                    paye = "n";
                else
                    paye = "o";

                inscriptionTableAdapter1.UpdatePaye(paye, id_stage, id_participant);
                refreshStagiaires();
            }
        }

        private void refreshStagiaires()
        {
            String nbStagiaires = getNbStagiaires();
            nbPart.Text = nbStagiaires + " sur " + tableStage.Rows[0]["nbMaxStagiaires"].ToString();
            this.dataGridView1.Rows.Clear();
            this.loadParticipants();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshMoniteurs();
        }

        private void refreshMoniteurs()
        {
            this.dataGridView2.Rows.Clear();
            this.loadMoniteurs();
        }

        private void btAddMoniteur_Click(object sender, EventArgs e)
        {
            new InscriptionMoniteur(0, id_stage).ShowDialog();
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            new ModifierStage(id_stage).ShowDialog();
            this.Close();
        }
       
    }
}
