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
    public partial class InscriptionMoniteur : Form
    {
        private int id_stage;
        private int id_moniteur;
        private SqlConnection con;

        public InscriptionMoniteur(int id_moniteur = 0, int id_stage = 0)
        {
            InitializeComponent();
            this.id_moniteur = id_moniteur;
            this.id_stage = id_stage;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            moniteurComboBox.Items.Clear();
            String recherche = moniteurTextBox.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Moniteur WHERE nom LIKE '%" + recherche + "%' OR prenom LIKE '%" + recherche + "%' ORDER BY nom, prenom", con);
            DataTable dtMoniteur = new DataTable();
            sda.Fill(dtMoniteur);
            int nbRows = dtMoniteur.Rows.Count;
            int idS;
            String name;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtMoniteur.Rows[i]["idM"].ToString());
                name = dtMoniteur.Rows[i]["nom"].ToString() + " " + dtMoniteur.Rows[i]["prenom"].ToString();
                moniteurComboBox.Items.Add(new Item(name, idS));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stageComboBox.Items.Clear();
            String recherche = stageTextBox.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage, centre, famille" +
                                                    " WHERE numC = idC AND numF = idF" +
                                                    " AND (titre LIKE '%" + recherche + "%'" +
                                                    " OR nom LIKE '%" + recherche + "%'" +
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
                stageComboBox.Items.Add(new Item(name, idS));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (moniteurComboBox.SelectedItem == null || stageComboBox.SelectedItem == null)
                noSelectionError();
            else
                inscrireMoniteur();
        }

        private void noSelectionError()
        {
            List<String> list = new List<String>();
            if (moniteurComboBox.SelectedItem == null)
                list.Add("Vous n'avez pas sélectionné de moniteur");
            if (stageComboBox.SelectedItem == null)
                list.Add("Vous n'avez pas sélectionné de stage");
            new ErrorDialog(list).ShowDialog();
        }

        private void inscrireMoniteur()
        {
            Item moniteur = (Item)moniteurComboBox.SelectedItem;
            int idM = moniteur.value;
            Item stage = (Item)stageComboBox.SelectedItem;
            int idS = stage.value;

            List<String> errors = getErrors(idM, idS);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = getSuccess(moniteur, stage);
                animerTableAdapter1.InsertQuery(idM, idS);
                new SuccessDialog(success).ShowDialog();
            }
        }

        private List<String> getErrors(int idM, int idS)
        {
            List<String> errors = new List<String>();
            if (animerExists(idM, idS))
                errors.Add("Ce moniteur anime déjà ce stage");
            return errors;
        }

        private Boolean animerExists(int idM, int idS)
        {
            int nb = (int)animerTableAdapter1.animerExists(idM, idS);
            return nb > 0;
        }

        private List<String> getSuccess(Item m, Item s)
        {
            List<String> success = new List<String>();
            success.Add("L'inscription a été ajoutée à la base de donnée :\n");
            success.Add("Moniteur : " + m.name);
            success.Add("Stage : " + s.name);
            return success;
        }

        private void InscriptionMoniteur_Load(object sender, EventArgs e)
        {
            load_moniteurs();
            load_stages();
        }

        private void load_moniteurs(){
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM moniteur ORDER BY nom, prenom", con);
            DataTable dtMoniteur = new DataTable();
            sda.Fill(dtMoniteur);
            int nbRows = dtMoniteur.Rows.Count;
            int idS;
            String name;
            int selectedRow = -1;
            for (int i = 0; i < nbRows; ++i)
            {
                idS = Int32.Parse(dtMoniteur.Rows[i]["idM"].ToString());
                name = dtMoniteur.Rows[i]["nom"].ToString() + " " + dtMoniteur.Rows[i]["prenom"].ToString();
                moniteurComboBox.Items.Add(new Item(name, idS));
                if (id_moniteur == idS)
                    selectedRow = i;
            }
            if (selectedRow != -1)
                moniteurComboBox.SelectedIndex = selectedRow;
        }

        private void load_stages(){
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage, centre, famille" +
                                                    " WHERE numC = idC AND numF = idF ORDER BY titre", con);
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
                stageComboBox.Items.Add(new Item(name, idS));
                if(id_stage == idS)
                    selectedRow = i;
            }
            if (selectedRow != -1)
                stageComboBox.SelectedIndex = selectedRow;
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
