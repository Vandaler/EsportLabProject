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
    public partial class FormAllPlayer : Form
    {
        public static FormAllPlayer Instance;
        public List<Player> playerList = new List<Player>();

        public FormAllPlayer()
        {
            InitializeComponent();
            Instance = this;
            
        }
        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                playerList.Add(formInfo.getPlayer());
                RefreshDataGrid();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Players";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(playerList, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Players";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                playerList = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void FormAllPlayer_Load(object sender, EventArgs e)
        {

        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamInfo teamInfo = new TeamInfo();
            teamInfo.ShowDialog();
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Player player_ in playerList)
            {
                dataGridView1.Rows.Add(player_.name, player_.studentid, player_.major, player_.displayname, player_.mail, player_.phonenum, player_.age);
            }
        }
    }
}
