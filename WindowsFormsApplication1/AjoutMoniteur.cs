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
    public partial class AjoutMoniteur : Form
    {
        public AjoutMoniteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String firstName = firstNameBox.Text;
            String sexe = getSexe();
            List<String> errors = getErrors(name, firstName);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                addToMoniteur(name, firstName, sexe);
                new SuccessDialog(getSuccessMessage(name, firstName, sexe)).ShowDialog();
            }
        }

        private void addToMoniteur(String name, String firstName, String sexe)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter();
            con.Open();
            sda.InsertCommand = new SqlCommand("INSERT INTO moniteur(nom, prenom, sexe) VALUES('" + name + "','" + firstName +"','"+sexe+ "')", con);
            sda.InsertCommand.ExecuteNonQuery();
        }

        private List<String> getSuccessMessage(String n, String fn, String s)
        {
            List<String> success = new List<String>();
            success.Add("Un nouveau moniteur a été ajouté à la base de données. \n");
            success.Add("Nom : " + n);
            success.Add("Prénom : " + fn);
            if (s.Equals("h"))
                success.Add("Sexe : Homme");
            else
                success.Add("Sexe : Femme");
            return success;
        }


        private List<String> getErrors(String n, String fn)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(n))
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(fn))
                errors.Add("Il n'y a pas de prénom");
            return errors;
        }

        private String getSexe()
        {
            if (hommeRadio.Checked)
                return "h";
            else return "f";
        }
    }
}
