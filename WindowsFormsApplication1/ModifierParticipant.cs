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
    public partial class ModifierParticipant : Form
    {
        private int idP;
        private SqlConnection con;

        public ModifierParticipant(int idP)
        {
            InitializeComponent();
            this.idP = idP;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ModifierParticipant_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM participant WHERE idP =" + idP, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            nomBox.Text = dt.Rows[0]["nom"].ToString();
            prenomBox.Text = dt.Rows[0]["prenom"].ToString();

            String sexe = dt.Rows[0]["sexe"].ToString();

            if (sexe.Equals("h"))
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

            dateTimePicker1.Value = (DateTime)dt.Rows[0]["ddn"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = nomBox.Text;
            String prenom = prenomBox.Text;
            String sexe = getSexe();
            DateTime ddn = dateTimePicker1.Value;

            List<String> errors = getErrors(nom, prenom, ddn);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = getSuccess(nom, prenom, sexe, ddn);
                new SuccessDialog(success).ShowDialog();
                participantTableAdapter1.UpdateQuery(nom, prenom, sexe, ddn.ToString("yyyy-MM-dd HH:mm:ss"), idP);
            }
        }

        private List<String> getErrors(String nom, String prenom, DateTime ddn)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(nom))
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(prenom))
                errors.Add("Il n'y a pas de prénom !");
            if (ddn.ToString("yyyy-MM-dd").CompareTo(DateTime.Today.ToString("yyyy-MM-dd")) > 0)
                errors.Add("La date de naissance est ultérieur à aujourd'hui");
            return errors;
        }

        private List<String> getSuccess(String nom, String prenom, String sexe, DateTime ddn)
        {
            List<String> success = new List<String>();
            success.Add("Nom : " + nom);
            success.Add("Prénom : " + prenom);
            if (sexe.Equals("h"))
                sexe = "Homme";
            else
                sexe = "Femme";
            success.Add("Sexe : " + sexe);
            success.Add("Date de naissance : " + ddn.ToString("dd/MM/yyyy"));
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
