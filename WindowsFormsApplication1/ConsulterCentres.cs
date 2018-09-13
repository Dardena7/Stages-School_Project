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
    public partial class ConsulterCentres : Form
    {
        private SqlConnection con;

        public ConsulterCentres()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ConsulterCentres_Load(object sender, EventArgs e)
        {
            loadCentres();
        }

        private void loadCentres()
        {
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM centre", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int nbRows = dt.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["num"].Value = dt.Rows[i]["idC"].ToString();
                dataGridView1.Rows[i].Cells["nom"].Value = dt.Rows[i]["nom"].ToString();
                dataGridView1.Rows[i].Cells["ville"].Value = dt.Rows[i]["ville"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadCentres();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idC = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM stage WHERE numC = " + idC, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int nbRows = dt.Rows.Count;
                if (nbRows > 0)
                {
                    List<String> errors = new List<string>();
                    errors.Add("suppression impossible !");
                    errors.Add(nbRows + " stages se déroulent dans ce centre !");
                    new ErrorDialog(errors).ShowDialog();
                }
                else
                    centreTableAdapter1.DeleteQuery((short)idC);
                loadCentres();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutCentre().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idC = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                new ModifierCentre(idC).ShowDialog();
            }
        }
    }
}
