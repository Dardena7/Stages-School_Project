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
    public partial class AjoutMembre : Form
    {
        public AjoutMembre()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String firstName = firstNameBox.Text;
            DateTime ddn = dateTimePicker1.Value;
            String sexe = getSexe();
            List<String> errors = getErrors(name, firstName, ddn);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                addToParticipant(name, firstName, ddn, sexe);
                new SuccessDialog(getSuccessMessage(name, firstName, sexe, ddn)).ShowDialog();
            }
        }

        private List<String> getSuccessMessage(String name, String firstName, String sexe, DateTime ddn)
        {
            List<String> success = new List<String>();
            success.Add("Un nouveau membre a été ajouté à la base de données. \n");
            success.Add("Nom : " + name);
            success.Add("Prénom : " + firstName);
            if (sexe.Equals("h"))
                success.Add("Sexe : Homme");
            else
                success.Add("Sexe : Femme");
            success.Add("Date de naissance : "+ ddn.ToString("dd/MM/yyyy"));
            return success;
        }

        private void addToParticipant(String name, String firstName, DateTime ddn, String sexe)
        {
            String ddnString = getDdnToString(dateTimePicker1.Value);
            participantTableAdapter1.InsertQuery(name, firstName, sexe, ddnString);
        }

        private String getDdnToString(DateTime d)
        {
            String ddn = d.ToString("yyyy-MM-dd HH:mm:ss");
            return ddn;
        }

        private List<String> getErrors(String name, String firstName, DateTime ddn)
        {
            List <String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(name)) 
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(firstName))
                errors.Add("Il n'y a pas de prénom !");
            if (ddn.ToString("yyyy-MM-dd").CompareTo(DateTime.Today.ToString("yyyy-MM-dd")) >= 0)
                errors.Add("La date de naissance n'est pas valide !");
            return errors;
        }

        private String getSexe()
        {
            if (radioHomme.Checked)
                return "h";
            else
                return "f";
        }
    }
}
