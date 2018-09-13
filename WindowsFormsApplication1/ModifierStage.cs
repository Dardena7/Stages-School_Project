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
    public partial class ModifierStage : Form
    {
        private int idS;
        private SqlConnection con;

        public ModifierStage(int idS)
        {
            InitializeComponent();
            this.idS = idS;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ModifierStage_Load(object sender, EventArgs e)
        {
            loadDescription();
        }

        private void loadDescription()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE idS = " + idS, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            titreBox.Text = dt.Rows[0]["titre"].ToString();
            dateTimePickerDebut.Value = (DateTime)dt.Rows[0]["date_debut"];
            dateTimePickerFin.Value = (DateTime)dt.Rows[0]["date_fin"];
            partMaxBox.Value = Int16.Parse(dt.Rows[0]["nbMaxStagiaires"].ToString());
            ageMinBox.Value = getAgeMin(dt.Rows[0]["age_min"].ToString());
            ageMaxBox.Value = getAgeMax(dt.Rows[0]["age_max"].ToString());
            prixBox.Value = Int32.Parse(dt.Rows[0]["prix"].ToString());

            loadCentres(Int32.Parse(dt.Rows[0]["numC"].ToString()));
            loadFamilles(Int32.Parse(dt.Rows[0]["numF"].ToString()));
        }

        private int getAgeMin(String age)
        {
            if (age.Equals(""))
                return 0;
            else
                return Int16.Parse(age);
        }

        private int getAgeMax(String age)
        {
            if (age.Equals(""))
                return 0;
            else
                return Int16.Parse(age);
        }

        private void loadCentres(int idC)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM centre", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int selectedRow = -1;
            int nbRows = dt.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                String name = dt.Rows[i]["ville"].ToString()+" , "+dt.Rows[i]["nom"].ToString();
                int value = Int32.Parse(dt.Rows[i]["idC"].ToString());
                centreBox.Items.Add(new Item(name, value));
                if (value == idC)
                    selectedRow = i;
            }
            if(selectedRow != -1)
                centreBox.SelectedIndex = selectedRow;
        }

        private void loadFamilles(int idF)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM famille", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int selectedRow = -1;
            int nbRows = dt.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                String name = dt.Rows[i]["description"].ToString();
                int value = Int32.Parse(dt.Rows[i]["idF"].ToString());
                familleBox.Items.Add(new Item(name, value));
                if (value == idF)
                    selectedRow = i;
            }
            if (selectedRow != -1)
                familleBox.SelectedIndex = selectedRow;
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

        private void button1_Click(object sender, EventArgs e)
        {
            String titre = titreBox.Text;
            Item famille = (Item)familleBox.SelectedItem;
            Item centre = (Item)centreBox.SelectedItem;
            DateTime date_debut = dateTimePickerDebut.Value;
            DateTime date_fin = dateTimePickerFin.Value;
            int nbMaxPart = (int)partMaxBox.Value;
            int prix = (int)prixBox.Value;
            int ageMin = (int)ageMinBox.Value;
            int ageMax = (int)ageMaxBox.Value;

            List<String> errors = getErrors(titre, date_debut, date_fin, nbMaxPart, prix, ageMin, ageMax);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = getSuccess(titre, famille, centre, date_debut, date_fin, nbMaxPart, prix, ageMin, ageMax);
                new SuccessDialog(success).ShowDialog();
                if (ageMin == 0 && ageMax == 0)
                    stageTableAdapter1.UpdateQuery(titre, date_debut.ToString("yyyy-MM-dd HH:mm:ss"), date_fin.ToString("yyyy-MM-dd HH:mm:ss"), (short)nbMaxPart, prix, (short)famille.value, (short)centre.value, null, null, idS);
                else if (ageMin == 0 && ageMax != 0)
                    stageTableAdapter1.UpdateQuery(titre, date_debut.ToString("yyyy-MM-dd HH:mm:ss"), date_fin.ToString("yyyy-MM-dd HH:mm:ss"), (short)nbMaxPart, prix, (short)famille.value, (short)centre.value, null, ageMax, idS);
                if (ageMin != 0 && ageMax == 0)
                    stageTableAdapter1.UpdateQuery(titre, date_debut.ToString("yyyy-MM-dd HH:mm:ss"), date_fin.ToString("yyyy-MM-dd HH:mm:ss"), (short)nbMaxPart, prix, (short)famille.value, (short)centre.value, ageMin, null, idS);
                else
                    stageTableAdapter1.UpdateQuery(titre, date_debut.ToString("yyyy-MM-dd HH:mm:ss"), date_fin.ToString("yyyy-MM-dd HH:mm:ss"), (short)nbMaxPart, prix, (short)famille.value, (short)centre.value, ageMin, ageMax, idS);
            }
        }

        private List<String> getSuccess(String titre, Item centre, Item famille, DateTime debut, DateTime fin, int nbMax, int prix, int ageMin, int ageMax)
        {
            List<String> success = new List<String>();
            success.Add("Le stage a bien été modifié ! \n");
            success.Add("Titre : " + titre);
            success.Add("Famille : "+famille.name);
            success.Add("Centre : "+centre.name);
            success.Add("Début :"+debut.ToString("dd/MM/yyyy")+"    Fin :"+fin.ToString("dd/MM/yyyy"));
            success.Add("Prix : " + prix);
            success.Add("Nombre max de participants : " + nbMax);
            success.Add("Age min : " + ageMin +"    Age max : " + ageMax);
            return success;
        }

        private List<String> getErrors(String titre, DateTime debut, DateTime fin, int nbMax, int prix, int ageMin, int ageMax)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(titre))
                errors.Add("Il n'y a pas de titre !");
            if( debut.ToString("yyyy-MM-dd").CompareTo( DateTime.Today.ToString("yyyy-MM-dd")) < 0)
                errors.Add("La date de début est antérieur à aujourd'hui !");
            if (fin.ToString("yyyy-MM-dd").CompareTo(debut.ToString("yyyy-MM-dd")) < 0)
                errors.Add("La date de début est ultérieur à la date de fin !");
            if(nbMax < 1)
                errors.Add("Le nombre max de participant est inférieur à 1 !");
            if (prix < 0)
                errors.Add("Le prix est inférieur à 0 !");
            if (ageMin < 0)
                errors.Add("L'age minimum est inférieur à 0 !");
            if (nbMax < ageMin && ageMax != 0)
                errors.Add("L'age minimum est plus grand que l'age maximum !");

            return errors;
        }


    }
}
