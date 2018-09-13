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
    public partial class ConsulterMoniteurs : Form
    {
        private HomeForm homeForm;
        private SqlConnection con;
        public ConsulterMoniteurs(HomeForm hf)
        {
            InitializeComponent();
            homeForm = hf;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void moniteurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moniteurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stages2016DataSet);

        }

        private void ConsulterMoniteurs_Load(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void loadMoniteurs()
        {
            dataGridView1.Rows.Clear();
            String recherche = "%"+textBox1.Text+"%";
            String sexe = getSexe();
            Boolean minOneStage = checkBox1.Checked;
            String request = getRequest(recherche, sexe, minOneStage);
            SqlDataAdapter sda = new SqlDataAdapter(request, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int nbRows = dt.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                dataGridView1.Rows.Add();
                int idM = Int32.Parse(dt.Rows[i]["idM"].ToString());
                dataGridView1.Rows[i].Cells["num"].Value = dt.Rows[i]["idM"].ToString();
                dataGridView1.Rows[i].Cells["nom"].Value = dt.Rows[i]["nom"].ToString();
                dataGridView1.Rows[i].Cells["prenom"].Value = dt.Rows[i]["prenom"].ToString();
                sexe = dt.Rows[i]["sexe"].ToString();
                if (sexe.Equals("h"))
                    sexe = "Homme";
                else
                    sexe = "Femme";
                dataGridView1.Rows[i].Cells["sexe"].Value = sexe;
                dataGridView1.Rows[i].Cells["nbStages"].Value = getNbStages(idM);
            }
        }

        private String getNbStages(int idM)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) AS nbStages FROM animer WHERE numM = " + idM, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0]["nbStages"].ToString();
        }

        private String getRequest(String recherche, String sexe, Boolean minOneStage)
        {
            String request = "SELECT * FROM moniteur WHERE (nom LIKE '" + recherche + "' OR prenom LIKE '" + recherche + "')";
            if(!sexe.Equals("hf"))
                request += " AND sexe = '"+sexe+"'";
            if (minOneStage)
                request += " AND (SELECT COUNT(*) FROM animer WHERE numM = idM) > 0";
            return request;
        }

        private String getSexe()
        {
            if (hommeRadio.Checked)
                return "h";
            else if (femmeRadio.Checked)
                return "f";
            else
                return "hf";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AjoutMoniteur().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void ConsulterMoniteurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void hommeRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void femmeRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void deuxRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loadMoniteurs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            deuxRadio.Checked = true;
            checkBox1.Checked = false;
            loadMoniteurs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idM = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                animerTableAdapter1.DeleteMoniteur(idM);
                moniteurTableAdapter.DeleteQuery(idM);
                loadMoniteurs();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Int32.Parse(this.dataGridView1.CurrentRow.Cells["num"].Value.ToString());
            MoniteurForm form = new MoniteurForm(index);
            form.ShowDialog();
        }
    }
}
