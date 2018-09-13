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
    public partial class ModifierCentre : Form
    {
        private SqlConnection con;
        private int idC;

        public ModifierCentre(int idC)
        {
            InitializeComponent();
            this.idC = idC;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ModifierCentre_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM centre WHERE idC =" + idC, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            textBox1.Text = dt.Rows[0]["nom"].ToString();
            textBox2.Text = dt.Rows[0]["ville"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBox1.Text;
            String ville = textBox2.Text;

            List<String> errors = getErrors(nom, ville);

            if (errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = new List<string>();
                success.Add("Le centre a bien été modifié !");
                new SuccessDialog(success).ShowDialog();
                centreTableAdapter1.UpdateQuery(nom, ville, (short)idC);
            }
        }

        private List<String> getErrors(String nom, String ville)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM centre WHERE nom = '" + nom + "' AND ville = '"+ville+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            List<String> errors = new List<string>();

            if (dt.Rows.Count > 0)
                errors.Add("Cette famille existe déjà !");
            if (String.IsNullOrWhiteSpace(nom))
                errors.Add("Il n'y a pas de nom !");
            if (String.IsNullOrWhiteSpace(ville))
                errors.Add("Il n'y a pas de ville !");
            return errors;
        }
    }
}
