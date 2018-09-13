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
    public partial class ModifierMoniteur : Form
    {
        private int idM;
        private SqlConnection con;

        public ModifierMoniteur(int idM)
        {
            InitializeComponent();
            this.idM = idM;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ModifierMoniteur_Load(object sender, EventArgs e)
        {
            loadDescription();
        }

        private void loadDescription()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM moniteur WHERE idM =" + idM, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            nomBox.Text = dt.Rows[0]["nom"].ToString();
            prenomBox.Text = dt.Rows[0]["prenom"].ToString();

            String sexe = dt.Rows[0]["sexe"].ToString();

            if (sexe.Equals("h"))
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = nomBox.Text;
            String prenom = prenomBox.Text;
            String sexe = getSexe();

            List<String> errors = getErrors(nom, prenom);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = getSuccess(nom, prenom, sexe);
                new SuccessDialog(success).ShowDialog();
                moniteurTableAdapter1.UpdateQuery(nom, prenom, sexe, idM);
            }
        }

        private List<String> getErrors(String nom, String prenom)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(nom))
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(prenom))
                errors.Add("Il n'y a pas de prénom !");
            return errors;
        }

        private List<String> getSuccess(String nom, String prenom, String sexe)
        {
            List<String> success = new List<String>();
            success.Add("Nom : "+nom);
            success.Add("Prénom : "+prenom);
            if (sexe.Equals("h"))
                sexe = "Homme";
            else
                sexe = "Femme";
            success.Add("Sexe : "+sexe);
            return success;
        }

        private String getSexe()
        {
            if (radioButton1.Checked)
                return "h";
            else
                return "f";
        }
    }
}
