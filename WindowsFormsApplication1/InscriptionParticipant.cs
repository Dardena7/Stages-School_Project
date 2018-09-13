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
    public partial class InscriptionParticipant : Form
    {
        private int idParticipant;
        private int idStage;
        private SqlConnection con;

        public InscriptionParticipant(int idParticipant = 0, int idStage = 0)
        {
            InitializeComponent();
            this.idParticipant = idParticipant;
            this.idStage = idStage;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void InscriptionParticipant_Load(object sender, EventArgs e)
        {
            loadParticipants(idParticipant);
            loadStages(idStage);
        }

        private void loadParticipants(int idParticipants)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Participant ORDER BY nom, prenom", con);
            DataTable dtParticipant = new DataTable();
            sda.Fill(dtParticipant);
            int nbRows = dtParticipant.Rows.Count;
            int idS;
            String name;
            int selectedRow = -1;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtParticipant.Rows[i]["idP"].ToString());
                name = dtParticipant.Rows[i]["nom"].ToString() + " " + dtParticipant.Rows[i]["prenom"].ToString();
                DateTime ddn = (DateTime)dtParticipant.Rows[i]["ddn"];
                name += ", " + ddn.ToString("dd/MM/yyyy");
                participantBox.Items.Add(new Item(name, idS));
                if (idParticipant == idS)
                    selectedRow = i;
            }
            if (selectedRow != -1)
                participantBox.SelectedIndex = selectedRow;
        }

        private void loadStages(int idStage){
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage, centre, famille WHERE numC = idC AND numF = idF" +
                                                    " AND nbMaxStagiaires > (SELECT COUNT(*) FROM inscription WHERE numS = "+idStage+")"+
                                                    " ORDER BY titre", con);
            DataTable dtStage = new DataTable();
            sda.Fill(dtStage);
            int nbRows = dtStage.Rows.Count;
            int idS;
            String name;
            int selectedRow = -1;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtStage.Rows[i]["idS"].ToString());
                name = dtStage.Rows[i]["titre"].ToString();
                name += ", " + dtStage.Rows[i]["nom"].ToString();
                name += ", " + dtStage.Rows[i]["ville"].ToString();
                name += ", " + dtStage.Rows[i]["description"].ToString();
                stageBox.Items.Add(new Item(name, idS));
                if(idStage == idS)
                    selectedRow = i;
            }
            if (selectedRow != -1)
                stageBox.SelectedIndex = selectedRow;
        }

        private class Item
        {
            public string name;
            public int value;
            public Item(string name, int value)
            {
                this.name = name;
                this.value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return name;
            }

            public int getValue()
            {
                return value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            participantBox.Items.Clear();
            String recherche = recherchePartBox.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Participant WHERE nom LIKE '%"+recherche+"%' OR prenom LIKE '%"+recherche+"%' ORDER BY nom, prenom", con);
            DataTable dtParticipant = new DataTable();
            sda.Fill(dtParticipant);
            int nbRows = dtParticipant.Rows.Count;
            int idS;
            String name;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtParticipant.Rows[i]["idP"].ToString());
                name = dtParticipant.Rows[i]["nom"].ToString() + " " + dtParticipant.Rows[i]["prenom"].ToString();
                DateTime ddn = (DateTime)dtParticipant.Rows[i]["ddn"];
                name += ", " + ddn.ToString("dd/MM/yyyy");
                participantBox.Items.Add(new Item(name, idS));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stageBox.Items.Clear();
            String recherche = rechercheStageBox.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage, centre, famille"+
                                                    " WHERE numC = idC AND numF = idF"+
                                                    " AND (titre LIKE '%" + recherche + "%'" +
                                                    " OR nom LIKE '%"+recherche+"%'"+
                                                    " OR ville LIKE '%" + recherche + "%'" +
                                                    " OR description LIKE '%" + recherche + "%')" +
                                                    " ORDER BY titre", con);
            DataTable dtStage = new DataTable();
            sda.Fill(dtStage);
            int nbRows = dtStage.Rows.Count;
            int idS;
            String name;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtStage.Rows[i]["idS"].ToString());
                name = dtStage.Rows[i]["titre"].ToString();
                name += ", " + dtStage.Rows[i]["nom"].ToString();
                name += ", " + dtStage.Rows[i]["ville"].ToString();
                name += ", " + dtStage.Rows[i]["description"].ToString();
                stageBox.Items.Add(new Item(name, idS));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (participantBox.SelectedItem == null || stageBox.SelectedItem == null)
                noSelectionError();
            else
                inscrireParticipant();
        }

        private void inscrireParticipant()
        {
            Item participant = (Item)participantBox.SelectedItem;
            int idP = participant.value;
            Item stage = (Item)stageBox.SelectedItem;
            int idS = stage.value;
            String paye = "";
            if (checkBox1.Checked)
                paye = "oui";
            else
                paye = "non";

            List<String> errors = getErrors(idP, idS);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = getSuccess(participant, stage, paye);
                inscriptionTableAdapter1.InsertQuery(idS, idP, paye);
                new SuccessDialog(success).ShowDialog();
            }
        }

        private void noSelectionError()
        {
            List<String> list = new List<String>();
            if (participantBox.SelectedItem == null)
                list.Add("Vous n'avez pas sélectionné de participant");
            if (stageBox.SelectedItem == null)
                list.Add("Vous n'avez pas sélectionné de stage");
            new ErrorDialog(list).ShowDialog();
        }

        private List<String> getErrors(int idP, int idS){
            List<String> errors = new List<String>();
            if (stageComplet(idS))
                errors.Add("Le stage est complet !");
            if (tropJeune(idP, idS))
                errors.Add("Le participant est trop jeune");
            if (tropVieux(idP, idS))
                errors.Add("Le participant est trop vieux");
            if(inscriptionExists(idP, idS))
                errors.Add("Ce participant est déjà inscrit à ce stage");
            return errors;
        }

        private Boolean stageComplet(int idS)
        {
            int nbPart = getNbPart(idS);
            int nbMaxPart = getNbMaxPart(idS);
            return nbPart >= nbMaxPart;
        }

        private int getNbPart(int idS)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) AS nbPart FROM inscription WHERE numS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int nbPart = Int32.Parse(dt.Rows[0]["nbPart"].ToString());
            return nbPart;
        }

        private int getNbMaxPart(int idS)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE idS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int nbMaxPart = Int32.Parse(dt.Rows[0]["nbMaxStagiaires"].ToString());
            return nbMaxPart;
        }

        private Boolean tropJeune(int idP, int idS)
        {
            DateTime ddn = getDdn(idP);
            DateTime dateDebut = getDateDebut(idS);
            int ageAtDebutStage = getAgeAtDebut(ddn, dateDebut);
            int ageMin = getAgeMin(idS);
            return ageAtDebutStage < ageMin;
        }

        private Boolean tropVieux(int idP, int idS)
        {
            DateTime ddn = getDdn(idP);
            DateTime dateDebut = getDateDebut(idS);
            int ageAtDebutStage = getAgeAtDebut(ddn, dateDebut);
            int ageMax = getAgeMax(idS);
            return ageAtDebutStage > ageMax;
        }

        private int getAgeMin(int idS)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE idS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int ageMin = 0;
            if(!((dt.Rows[0]["age_min"].ToString()).Equals("")))
                ageMin = Int32.Parse(dt.Rows[0]["age_min"].ToString());
            return ageMin;
        }

        private int getAgeMax(int idS)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE idS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int ageMax = 200;
            if(!((dt.Rows[0]["age_max"].ToString()).Equals("")))
                ageMax = Int32.Parse(dt.Rows[0]["age_max"].ToString());
            return ageMax;
        }

        private int getAgeAtDebut(DateTime ddn, DateTime debut)
        {
            int anneeDdn = Int32.Parse(ddn.ToString("yyyy"));
            int moisDdn = Int32.Parse(ddn.ToString("MM"));
            int jourDdn = Int32.Parse(ddn.ToString("dd"));
            int anneeDebut = Int32.Parse(debut.ToString("yyyy"));
            int moisDebut = Int32.Parse(debut.ToString("MM"));
            int jourDebut = Int32.Parse(debut.ToString("dd"));
            int age = anneeDebut - anneeDdn;
            if (moisDdn < moisDebut)
                age -= 1;
            else if (moisDdn == moisDebut)
                if (jourDdn < jourDebut)
                    age -= 1;
            return age;
        }

        private DateTime getDdn(int idP)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM participant WHERE idP = " + idP, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DateTime ddn = (DateTime)dt.Rows[0]["ddn"];
            return ddn;
        }

        private DateTime getDateDebut(int idS)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE idS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DateTime dateDebut = (DateTime)dt.Rows[0]["date_debut"];
            return dateDebut;
        }

        private Boolean inscriptionExists(int idP, int idS)
        {
            int nb = (int)inscriptionTableAdapter1.inscriptionExists(idP, idS);
            return nb > 0;
        }

        private List<String> getSuccess(Item p, Item s, String paye)
        {
            List<String> success = new List<String>();
            success.Add("L'inscription a été ajoutée à la base de donnée :\n");
            success.Add("Participant : "+p.name);
            success.Add("Stage : "+s.name);
            success.Add("A payé: "+paye);
            return success;
        }
    }
}
