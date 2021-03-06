﻿using System;
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
    public partial class ParticipantForm : Form
    {
        private int idP;
        private SqlConnection con;

        public ParticipantForm(int idP)
        {
            InitializeComponent();
            this.idP = idP;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\AlexiD\Stages2016.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            loadDescription();
            loadStages();
        }

        private void loadDescription()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM participant WHERE idP = " + idP, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            nomLabel.Text = dt.Rows[0]["nom"].ToString();
            prenomLabel.Text = dt.Rows[0]["prenom"].ToString();
            String sexe = dt.Rows[0]["sexe"].ToString();
            if (sexe.Equals("h"))
                sexe = "Homme";
            else
                sexe = "Femme";
            sexeLabel.Text = sexe;
            DateTime ddn = (DateTime)dt.Rows[0]["ddn"];
            ddnLabel.Text = ddn.ToString("dd/MM/yyyy");
        }

        private void loadStages()
        {
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Stage, inscription WHERE idS = numS AND numP = " + idP, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int nbRows = dt.Rows.Count;

            for (int i = 0; i < nbRows; ++i)
            {
                dataGridView1.Rows.Add();
                String ville = getVille(Int32.Parse(dt.Rows[i]["numC"].ToString()));
                String famille = getFamille(Int32.Parse(dt.Rows[i]["numF"].ToString()));
                DateTime date_debut = (DateTime)dt.Rows[i]["date_debut"];
                DateTime date_fin = (DateTime)dt.Rows[i]["date_fin"];
                String debut = date_debut.ToString("dd/MM/yyyy");
                String fin = date_fin.ToString("dd/MM/yyyy");

                dataGridView1.Rows[i].Cells["num"].Value = dt.Rows[i]["idS"];
                dataGridView1.Rows[i].Cells["titre"].Value = dt.Rows[i]["titre"];
                dataGridView1.Rows[i].Cells["famille"].Value = famille;
                dataGridView1.Rows[i].Cells["ville"].Value = ville;
                dataGridView1.Rows[i].Cells["prix"].Value = dt.Rows[i]["prix"];
                dataGridView1.Rows[i].Cells["date_debut"].Value = debut;
                dataGridView1.Rows[i].Cells["date_fin"].Value = fin;
            }
        }

        private String getVille(int idC)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM centre WHERE idC = " + idC, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0]["ville"].ToString();
        }

        private String getFamille(int idF)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM famille WHERE idF = " + idF, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0]["description"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadStages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InscriptionParticipant(idP, 0).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow != null) && (dataGridView1.Rows.Count != 0))
            {
                int idS = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
                inscriptionTableAdapter1.DeleteQuery(idS, idP);
                loadStages();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idS = Int32.Parse(dataGridView1.CurrentRow.Cells["num"].Value.ToString());
            new StageForm(idS).ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ModifierParticipant(idP).ShowDialog();
            this.Close();
        }
    }
}
