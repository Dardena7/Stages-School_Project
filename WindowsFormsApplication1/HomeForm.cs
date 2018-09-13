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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsulterStages form = new ConsulterStages(this);
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AjoutMembre().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AjoutMoniteur().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AjoutStage().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new InscriptionParticipant(0, 0).ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new InscriptionMoniteur(0, 0).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsulterParticipants form = new ConsulterParticipants(this);
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsulterMoniteurs form = new ConsulterMoniteurs(this);
            this.Hide();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new AjoutCentre().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AjoutFamille().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new ConsulterFamilles().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new ConsulterCentres().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
