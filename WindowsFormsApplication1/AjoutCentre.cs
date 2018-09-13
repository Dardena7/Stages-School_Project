using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AjoutCentre : Form
    {
        public AjoutCentre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String city = textBox2.Text;
            List<String> errors = getErrors(name, city);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                centreTableAdapter1.InsertQuery(name, city);
                List<String> success = getSuccessMessage(name, city);
                new SuccessDialog(success).ShowDialog();
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private List<String> getSuccessMessage(String name, String city)
        {
            List<String> success = new List<String>();
            success.Add("Le centre a été ajoutée à la base de donnée. \n");
            success.Add("Nom : " + name);
            success.Add("Ville : " + city);
            return success;
        }

        private List<String> getErrors(String n, String c)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(n))
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(c))
                errors.Add("Il n'y a pas de ville !");
            if (centerExists(n, c))
                errors.Add("Ce centre existe déjà !");
            return errors;
        }

        private Boolean centerExists(String name, String city)
        {
            int nb = (int)centreTableAdapter1.centerExists(name, city);
            return nb > 0;
        }


    }
}
