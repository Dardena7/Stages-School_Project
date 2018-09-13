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
    public partial class ConsulterStages : Form
    {
        private HomeForm homeForm;
        private SqlConnection con;
        public ConsulterStages(HomeForm f)
        {
            InitializeComponent();
            homeForm = f;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void stageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stages2016DataSet);

        }

        private void ConsulterStages_Load(object sender, EventArgs e)
        {
            this.loadFilters();
            this.loadAllStages();
            
        }

        private void loadFilters()
        {
            this.loadFamilles();
            this.loadVilles();
            this.loadMinDate();
            this.loadMaxDate();
            this.numericUpDownPrixMin.Value = 0;
            this.loadMaxPrice();
            this.numericUpDownAgeMin.Value = 0;
            this.loadMaxAge();
        }

        private void loadMinDate()
        {
            this.dateTimePickerDebut.Value = DateTime.Today;
        }

        private void loadMaxDate()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(date_fin) FROM Stage", con);
            DataTable dtDate = new DataTable();
            sda.Fill(dtDate);
            this.dateTimePickerFin.Value = (DateTime)dtDate.Rows[0][0];
        }

        private void loadMaxPrice()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(prix) FROM Stage", con);
            DataTable dtPrice = new DataTable();
            sda.Fill(dtPrice);
            this.numericUpDownPrixMax.Value = decimal.Parse(dtPrice.Rows[0][0].ToString());
        }

        private void loadMaxAge()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(age_max) FROM Stage", con);
            DataTable dtAge = new DataTable();
            sda.Fill(dtAge);
            decimal maxMax = decimal.Parse(dtAge.Rows[0][0].ToString());

            sda = new SqlDataAdapter("SELECT MAX(age_min) FROM Stage", con);
            dtAge = new DataTable();
            sda.Fill(dtAge);
            decimal minMax = decimal.Parse(dtAge.Rows[0][0].ToString());

            if(minMax > maxMax)
                this.numericUpDownAgeMax.Value = minMax;
            else
                this.numericUpDownAgeMax.Value = maxMax;
        }

        private void loadVilles()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Centre", con);
            DataTable dtVille = new DataTable();
            sda.Fill(dtVille);
            int nbRows = dtVille.Rows.Count;
            String ville = "";
            int id;
            this.comboBoxVille.Items.Add(new Item("Toutes", 0));
            for (int i = 0; i < nbRows; ++i)
            {
                ville = dtVille.Rows[i]["ville"].ToString();
                id = Int32.Parse(dtVille.Rows[i]["idC"].ToString());
                this.comboBoxVille.Items.Add(new Item(ville, id));
            }
            this.comboBoxVille.SelectedIndex = 0;
        }

        private void loadFamilles()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Famille", con);
            DataTable dtFamille = new DataTable();
            sda.Fill(dtFamille);
            int nbRows = dtFamille.Rows.Count;
            String description = "";
            int id;
            this.comboBoxFamille.Items.Add(new Item("Toutes", 0));
            for (int i = 0; i < nbRows; ++i)
            {
                description = dtFamille.Rows[i]["description"].ToString();
                id = Int32.Parse(dtFamille.Rows[i]["idF"].ToString());
                this.comboBoxFamille.Items.Add(new Item(description, id));
            }
            this.comboBoxFamille.SelectedIndex = 0;
        }

        private void loadAllStages()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage", con);
            DataTable dtStages = new DataTable();
            sda.Fill(dtStages);
            this.fillGridStages(dtStages);
        }

        private void fillGridStages(DataTable dtStages)
        {
            this.dataGridView1.Rows.Clear();
            int nbRows = dtStages.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                this.dataGridView1.Rows.Add();
                SqlDataAdapter sdaVille = new SqlDataAdapter("SELECT ville FROM Centre WHERE idC = " + dtStages.Rows[i]["numC"], con);
                DataTable dtVille = new DataTable();
                sdaVille.Fill(dtVille);
                SqlDataAdapter sdaFamille = new SqlDataAdapter("SELECT description FROM Famille WHERE idF = " + dtStages.Rows[i]["numF"], con);
                DataTable dtFamille = new DataTable();
                sdaFamille.Fill(dtFamille);
                SqlDataAdapter sdaPlaces = new SqlDataAdapter("SELECT COUNT(*) AS nbPart FROM inscription WHERE numS = " + dtStages.Rows[i]["idS"], con);
                DataTable dtPlaces = new DataTable();
                sdaPlaces.Fill(dtPlaces);
                this.dataGridView1.Rows[i].Cells["numero"].Value = dtStages.Rows[i]["idS"];
                this.dataGridView1.Rows[i].Cells["titre"].Value = dtStages.Rows[i]["titre"];
                DateTime date = (DateTime)dtStages.Rows[i]["date_debut"];
                String dateString = date.ToString("dd/MM/yyyy");
                this.dataGridView1.Rows[i].Cells["debut"].Value = dateString;
                date = (DateTime)dtStages.Rows[i]["date_fin"];
                dateString = date.ToString("dd/MM/yyyy");
                this.dataGridView1.Rows[i].Cells["fin"].Value = dateString;
                this.dataGridView1.Rows[i].Cells["prix"].Value = dtStages.Rows[i]["prix"];
                this.dataGridView1.Rows[i].Cells["famille"].Value = dtFamille.Rows[0]["description"];
                this.dataGridView1.Rows[i].Cells["ville"].Value = dtVille.Rows[0]["ville"];
                int maxPlaces = Int32.Parse(dtStages.Rows[i]["nbMaxStagiaires"].ToString());
                int nbInscriptions = Int32.Parse(dtPlaces.Rows[0]["nbPart"].ToString());
                int freePlaces = maxPlaces - nbInscriptions;
                this.dataGridView1.Rows[i].Cells["places"].Value = freePlaces + " sur " + maxPlaces;
                this.dataGridView1.Rows[i].Cells["ageMin"].Value = dtStages.Rows[i]["age_min"];
                this.dataGridView1.Rows[i].Cells["ageMax"].Value = dtStages.Rows[i]["age_max"];
            }
        }

        private void stageDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsulterStages_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.loadAllStages();
            this.loadFilters();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item famille = (Item)this.comboBoxFamille.SelectedItem;
        }

        private void refreshStages()
        {
            Item famille = (Item)this.comboBoxFamille.SelectedItem;
            int idFamille = famille.getValue();
            Item ville = (Item)this.comboBoxVille.SelectedItem;
            int idVille = ville.getValue();
            decimal minPrice = this.numericUpDownPrixMin.Value;
            decimal maxPrice = this.numericUpDownPrixMax.Value;
            decimal minAge = this.numericUpDownAgeMin.Value;
            decimal maxAge = this.numericUpDownAgeMax.Value;
            String recherche = this.textBoxRecherche.Text;
            DateTime dateDebut = this.dateTimePickerDebut.Value;
            DateTime dateFin = this.dateTimePickerFin.Value;
            Boolean notFull = this.checkBox1.Checked;

            String requete = this.prepareFilterRequete(minPrice, maxPrice, minAge, maxAge, dateDebut, dateFin, recherche, idFamille, idVille, notFull);
         
            SqlDataAdapter sda = new SqlDataAdapter(requete, con);
            DataTable dtStages = new DataTable();
            sda.Fill(dtStages);
            this.fillGridStages(dtStages);
        }

        private String prepareFilterRequete(decimal minPrice, decimal maxPrice, decimal minAge, decimal maxAge, DateTime dateDebut, DateTime dateFin, String recherche, int idFamille, int idVille, Boolean notFull)
        {
            String requete = "SELECT * FROM Stage s, famille f, centre c WHERE numC = idC AND numF = idF";
            requete += " AND prix >= " + minPrice;
            requete += " AND prix <= " + maxPrice;
            requete += " AND ((age_min >= " + minAge + " OR age_min IS null) AND (age_max >= " + minAge + "OR age_max IS null))";
            requete += " AND ((age_max <= " + maxAge + " OR age_max IS null) AND (age_min <= " + maxAge + " OR age_min IS null))";
            requete += " AND date_debut >= '" + dateDebut.ToString("yyyy-MM-dd") + "' AND date_fin <= '" + dateFin.ToString("yyyy-MM-dd") + "'";
            requete += " AND (titre LIKE '%" + recherche + "%' OR ville LIKE '%" + recherche + "%' OR description LIKE '%" + recherche + "%')";
            if (idFamille != 0)
                requete += " AND numF = " + idFamille;
            if (idVille != 0)
                requete += " AND numC = " + idVille;
            if (notFull)
                requete += " AND nbMaxStagiaires > (SELECT COUNT(*) FROM inscription WHERE numS = idS)";

            return requete;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<String> errors = new List<String>();
            decimal minPrice = this.numericUpDownPrixMin.Value;
            decimal maxPrice = this.numericUpDownPrixMax.Value;
            decimal minAge = this.numericUpDownAgeMin.Value;
            decimal maxAge = this.numericUpDownAgeMax.Value;
            DateTime dateDebut = this.dateTimePickerDebut.Value;
            DateTime dateFin = this.dateTimePickerFin.Value;

            if (minPrice > maxPrice)
                errors.Add("le prix minimum est plus grand que le prix maximum !");
            if (minAge > maxAge)
                errors.Add("L'age minimum est plus grand que l'age maximum !");
            if (DateTime.Compare(dateDebut, dateFin) > 0)
                errors.Add("La date de début est ultérieur à la date de fin !");
            if (errors.Count > 0)
            {
                ErrorDialog ed = new ErrorDialog(errors);
                ed.ShowDialog();
            }
            else
                this.refreshStages();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Int32.Parse(this.dataGridView1.CurrentRow.Cells["numero"].Value.ToString());
            StageForm stageForm = new StageForm(index);
            stageForm.ShowDialog();
        }

        private void btAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AjoutStage().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refreshStages();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int id_stage = Int32.Parse(dataGridView1.CurrentRow.Cells["numero"].Value.ToString());
                inscriptionTableAdapter1.DeleteStage(id_stage);
                animerTableAdapter1.DeleteStage(id_stage);
                stageTableAdapter.DeleteQuery(id_stage);
                refreshStages();
            }
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

    }
}
