using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CISEsport
{
    public partial class TeamInfo : Form
    {
        List<Playercontroller> listteam = new List<Playercontroller>();
        public TeamInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Teams";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listteam, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Teams";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listteam = JsonConvert.DeserializeObject<List<Playercontroller>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamSearch tr = new TeamSearch();
            tr.ShowDialog();
            if (tr.DialogResult == DialogResult.OK)
            {
                Playercontroller team = tr.getTeam();
                listteam.Add(team);
                RefreshDataGrid();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamSearch tr = new TeamSearch();
            tr.ShowDialog();
            if (tr.DialogResult == DialogResult.OK)
            {
                Playercontroller team = tr.getTeam();
                listteam.Add(team);
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Playercontroller player_ in listteam)
            {
                dataGridView1.Rows.Add(player_.TeamName, player_.Members[0].name, player_.Members[1].name, player_.Members[2].name, player_.Members[3].name, player_.Members[4].name);
            }
        }
    }
}
