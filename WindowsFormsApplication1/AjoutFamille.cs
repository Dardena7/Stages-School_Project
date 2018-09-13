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
    public partial class AjoutFamille : Form
    {
        public AjoutFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            List<String> errors = getErrors(name);
            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                familleTableAdapter1.InsertQuery(name);
                List<String> success = getSuccessMessage(name);
                new SuccessDialog(success).ShowDialog();
                textBox1.Clear();
            }
        }

        private List<String> getSuccessMessage(String name)
        {
            List<String> success = new List<String>();
            success.Add("La famille a été ajoutée à la base de donnée. \n");
            success.Add("Nom : "+name);
            return success;
        }

        private List<String> getErrors(String n)
        {
            List<String> errors = new List<String>();
            if (String.IsNullOrWhiteSpace(n))
                errors.Add("Il n'y a pas de nom !");
            if (familyExists(n))
                errors.Add("Cette famille existe déjà !");
            return errors;
        }

        private Boolean familyExists(String name)
        {
            int nb = (int)familleTableAdapter1.familyExists(name);
            return nb > 0;
        }
    }
}
