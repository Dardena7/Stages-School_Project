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
    public partial class ModifierFamille : Form
    {
        private SqlConnection con;
        private int idF;

        public ModifierFamille(int idF)
        {
            InitializeComponent();
            this.idF = idF;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ModifierFamille_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM famille WHERE idF ="+idF, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            textBox1.Text = dt.Rows[0]["description"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBox1.Text;

            List<String> errors = getErrors(nom);

            if(errors.Count > 0)
                new ErrorDialog(errors).ShowDialog();
            else
            {
                List<String> success = new List<string>();
                success.Add("La famille a bien été modifiée !");
                new SuccessDialog(success).ShowDialog();
                familleTableAdapter1.UpdateQuery(nom, (short)idF);
            }
        }

        private List<String> getErrors(String nom)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM famille WHERE description = '" + nom + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            List<String> errors = new List<string>();

            if (dt.Rows.Count > 0)
                errors.Add("Cette famille existe déjà !");
            if(String.IsNullOrWhiteSpace(nom))
                errors.Add("Il n'y a pas de nom !");
            return errors;
        }
    }
}
