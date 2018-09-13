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
    public partial class ConsulterParticipants : Form
    {
        private HomeForm homeForm;
        private SqlConnection con;
        public ConsulterParticipants(HomeForm hf)
        {
            InitializeComponent();
            homeForm = hf;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void participantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stages2016DataSet);

        }

        private void ConsulterParticipants_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(1900, 01, 01);
            loadMembers();
        }

        private void loadMembers()
        {
            participantDataGridView.Rows.Clear();
            String recherche = "%"+rechercheBox.Text+"%";
            DateTime ddn = dateTimePicker1.Value;
            String sexe = getSexe();
            Boolean minOneStage = checkBox1.Checked;
            String request = getRequest(recherche, ddn, sexe, minOneStage);
            SqlDataAdapter sda = new SqlDataAdapter(request, con);
            DataTable dtPart = new DataTable();
            sda.Fill(dtPart);
            int nbRows = dtPart.Rows.Count;
            for (int i = 0; i < nbRows; ++i)
            {
                this.participantDataGridView.Rows.Add();
                int idP = Int32.Parse(dtPart.Rows[i]["idP"].ToString());
                participantDataGridView.Rows[i].Cells["num"].Value = dtPart.Rows[i]["idP"];
                participantDataGridView.Rows[i].Cells["nom"].Value = dtPart.Rows[i]["nom"];
                participantDataGridView.Rows[i].Cells["prenom"].Value = dtPart.Rows[i]["prenom"];
                sexe = dtPart.Rows[i]["sexe"].ToString();
                if (sexe.Equals("h"))
                    sexe = "Homme";
                else
                    sexe = "femme";
                participantDataGridView.Rows[i].Cells["sexe"].Value = sexe;
                ddn = (DateTime)dtPart.Rows[i]["ddn"];
                String dateString = ddn.ToString("dd/MM/yyyy");
                participantDataGridView.Rows[i].Cells["ddn"].Value = dateString;

                int nbStages = getNbStages(idP);
                participantDataGridView.Rows[i].Cells["nbStages"].Value = nbStages;
            }
        }

        private int getNbStages(int idP)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) AS nbStages FROM inscription WHERE numP = " + idP, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Int32.Parse(dt.Rows[0]["nbStages"].ToString());
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

        private String getRequest(String recherche, DateTime ddn, String sexe, Boolean minOneStage)
        {
            String req = "SELECT * FROM participant WHERE (nom LIKE '"+recherche+"' OR prenom LIKE '"+recherche+"')";
            String date = ddn.ToString("yyyy-MM-dd");
            req += " AND ddn >= '" + date +"'";
            if (!sexe.Equals("hf"))
                req += " AND sexe = '" + sexe+"'";
            if (minOneStage)
                req += " AND (SELECT COUNT(*) FROM inscription WHERE numP = idP) > 0";
            return req;
        }

        private void ConsulterParticipants_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Close();
        }

        private void rechercheBox_TextChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void deuxRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void femmeRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void hommeRadio_CheckedChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(1900, 01, 01);
            rechercheBox.Text = "";
            deuxRadio.Checked = true;
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((participantDataGridView.CurrentRow != null) && (participantDataGridView.Rows.Count != 0))
            {
                int id_participant = Int32.Parse(participantDataGridView.CurrentRow.Cells["num"].Value.ToString());
                inscriptionTableAdapter1.DeleteParticipant(id_participant);
                participantTableAdapter.DeleteQuery(id_participant);
                loadMembers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AjoutMembre().ShowDialog();
        }

        private void participantDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Int32.Parse(this.participantDataGridView.CurrentRow.Cells["num"].Value.ToString());
            ParticipantForm partForm = new ParticipantForm(index);
            partForm.ShowDialog();
        }
    }
}
