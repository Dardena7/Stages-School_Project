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
    public partial class ConsulterFamilles : Form
    {
        private SqlConnection con;

        public ConsulterFamilles()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ConsulterFamilles_Load(object sender, EventArgs e)
        {
            loadFamilles();
        }

        private void loadFamilles()
        {
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM famille", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int nbRows = dt.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["num"].Value = dt.Rows[i]["idF"].ToString();
                dataGridView1.Rows[i].Cells["nom"].Value = dt.Rows[i]["description"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idF = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE numF = "+idF, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int nbRows = dt.Rows.Count;
                if (nbRows > 0)
                {
                    List<String> errors = new List<string>();
                    errors.Add("suppression impossible !");
                    errors.Add(nbRows + " stages font partie de cette famille.");
                    new ErrorDialog(errors).ShowDialog();
                }
                else
                    familleTableAdapter1.DeleteQuery((short)idF);
                loadFamilles();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AjoutFamille().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFamilles();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idF = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                new ModifierFamille(idF).ShowDialog();
            }
        }
    }
}
