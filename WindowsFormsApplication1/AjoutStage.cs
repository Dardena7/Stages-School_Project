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
    public partial class AjoutStage : Form
    {
        private SqlConnection con;

        public AjoutStage()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String title = titleBox.Text;
            DateTime dateDebut = dateDebutBox.Value;
            DateTime dateFin = dateFinBox.Value;
            int places = Int32.Parse(placesBox.Value.ToString());
            int price = Int32.Parse(priceBox.Value.ToString());
            int ageMin = Int32.Parse(ageMinBox.Value.ToString());
            int ageMax = Int32.Parse(ageMaxBox.Value.ToString());
            Item family = (Item)familyBox.SelectedItem;
            Item center = (Item)centerBox.SelectedItem;

            List<String> errors = getErrors(title, dateDebut, dateFin, places, price, ageMin, ageMax);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                addToStage(title, dateDebut, dateFin, places, price, ageMin, ageMax, family, center);
                List<String> success = getSuccessMessage(title, dateDebut, dateFin, places, price, ageMin, ageMax, family, center);
                new SuccessDialog(success).ShowDialog();
            }
        }

        private void addToStage(String title, DateTime dateDebut, DateTime dateFin, int places, int price, int ageMin, int ageMax, Item family, Item center)
        {
            String dateDebutString = dateDebut.ToString("yyyy-MM-dd HH:mm:ss");
            String dateFinString = dateFin.ToString("yyyy-MM-dd HH:mm:ss");
            short placeshort = (short)places;
            short numF = (short)family.value;
            short numC = (short)center.value;
            if (ageMin == 0 && ageMax != 0)
                stageTableAdapter1.InsertQuery(title, dateDebutString, dateFinString, placeshort, price, numF, numC, null, ageMax);
            else if(ageMin != 0 && ageMax == 0)
                stageTableAdapter1.InsertQuery(title, dateDebutString, dateFinString, placeshort, price, numF, numC, ageMin, null);
            else if(ageMin == 0 && ageMax == 0)
                stageTableAdapter1.InsertQuery(title, dateDebutString, dateFinString, placeshort, price, numF, numC, null, null);
            else
                stageTableAdapter1.InsertQuery(title, dateDebutString, dateFinString, placeshort, price, numF, numC, ageMin, ageMax);
        }

        private List<String> getSuccessMessage(String title, DateTime dateDebut, DateTime dateFin, int places, int price, int ageMin, int ageMax, Item family, Item center)
        {
            List<String> success = new List<String>();
            success.Add("Un nouveau stage a été ajouté à la base de données. \n");
            success.Add("Titre : "+title);
            success.Add("Famille : "+family.name);
            success.Add("Centre : "+center.name);
            success.Add("Du : "+dateDebut.ToString("dd / MM / yyyy"));
            success.Add("Au : "+dateFin.ToString("dd / MM / yyyy"));
            success.Add("Nombre de places : "+places);
            if(ageMin == 0)
                success.Add("Age minimum : Aucun");
            else
                success.Add("Age minimum : "+ageMin);
            if(ageMax == 0)
                success.Add("Age maximum : Aucun");
            else
                success.Add("Age maximum : "+ageMax);
            success.Add("Prix : "+price);
            return success;
        }

        private List<String> getErrors(String title, DateTime dateDebut, DateTime dateFin, int places, int price, int ageMin, int ageMax){
            List<String> errors = new List<String>();
            if(String.IsNullOrWhiteSpace(title))
                errors.Add("Il n'y a pas de titre !");
            if(dateDebut.ToString("yyyy-MM-dd").CompareTo(DateTime.Today.ToString("yyyy-MM-dd")) < 0)
                errors.Add("La date de départ est antérieur à aujourd'hui !");
            if (dateDebut.ToString("yyyy-MM-dd").CompareTo(dateFin.ToString("yyyy-MM-dd")) > 0)
                errors.Add("La date de départ est ultérieur à la date de fin !");
            if(price < 0)
                errors.Add("Le prix est négatif !");
            if(places <= 0)
                errors.Add("Le nombre de places est négatif ou nul !");
            if(ageMin < 0)
                errors.Add("L'age minimum est négatif !");
            if(ageMin > ageMax)
                errors.Add("L'age minimum est plus grand que l'age maximum !");
            return errors;
        }

        private void AjoutStage_Load(object sender, EventArgs e)
        {
            loadFamilles();
            loadCenters();
            dateDebutBox.Value = DateTime.Today;
            dateFinBox.Value = DateTime.Today;
        }

        private void loadFamilles()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Famille ORDER BY description", con);
            DataTable dtFamille = new DataTable();
            sda.Fill(dtFamille);
            int nbRows = dtFamille.Rows.Count;
            String description = "";
            int id;
            for (int i = 0; i < nbRows; ++i)
            {
                description = dtFamille.Rows[i]["description"].ToString();
                id = Int32.Parse(dtFamille.Rows[i]["idF"].ToString());
                this.familyBox.Items.Add(new Item(description, id));
            }
            this.familyBox.SelectedIndex = 0;
        }

        private void loadCenters()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Centre ORDER BY ville, nom", con);
            DataTable dtCentre = new DataTable();
            sda.Fill(dtCentre);
            int nbRows = dtCentre.Rows.Count;
            String nom = "";
            int id;
            for (int i = 0; i < nbRows; ++i)
            {
                nom = dtCentre.Rows[i]["ville"].ToString();
                nom += " , "+dtCentre.Rows[i]["nom"].ToString();
                id = Int32.Parse(dtCentre.Rows[i]["idC"].ToString());
                this.centerBox.Items.Add(new Item(nom, id));
            }
            this.centerBox.SelectedIndex = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            new AjoutFamille().ShowDialog();
        }

        private void refreshFamille_Click(object sender, EventArgs e)
        {
            familyBox.Items.Clear();
            loadFamilles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AjoutCentre().ShowDialog();
        }

        private void refreshCentre_Click(object sender, EventArgs e)
        {
            centerBox.Items.Clear();
            loadCenters();
        }
    }
}
