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
    public partial class TeamSearch : Form
    {
        Playercontroller team;
        List<Player> listplayer = new List<Player>();
        public TeamSearch()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                Player player = new Player();
                player.name = "";
                player.studentid = "";
                player.major = "";
                player.displayname = "";
                player.mail = "";
                player.phonenum = "";
                player.age = 0;
                listplayer.Add(player);
            }
        }
        private void EventOnClickFind(object sender, EventArgs e)
        {
            
        }
        private void FindPlayer(int index, TextBox textbox)
        {
            FindPlayers fp = new FindPlayers();
            fp.ShowDialog();
            if (fp.DialogResult == DialogResult.OK)
            {
                listplayer[index] = fp.GetPlayer();
                textbox.Text = listplayer[index].name;
            }
        }
        public Playercontroller getTeam()
        {
            return this.team;
        }

        private void Btsubmit_Click(object sender, EventArgs e)
        {
            string TeamName = Teamname.Text;
            team = new Playercontroller();
            team.TeamName = TeamName;
            team.Members = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "button1")
            {
                FindPlayer(0, Tmem1);
            }
            else if (btn.Name == "button2")
            {
                FindPlayer(1, Tmem2);
            }
            else if (btn.Name == "button3")
            {
                FindPlayer(2, Tmem3);
            }
            else if (btn.Name == "button4")
            {
                FindPlayer(3, Tmem4);
            }
            else if (btn.Name == "button5")
            {
                FindPlayer(4, Tmem5);
            }
        }

    }
}