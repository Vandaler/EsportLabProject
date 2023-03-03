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
    public partial class FindPlayers : Form
    {
        Player playerClassed;
        public FindPlayers()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach (Player player_ in FormAllPlayer.Instance.playerList)
            {
                dataGridView1.Rows.Add(player_.name, player_.studentid, player_.major, player_.displayname, player_.mail, player_.phonenum, player_.age);
            }
        }
        public Player GetPlayer()
        {
            return playerClassed;
        }
        private void submitclickk_Click(object sender, EventArgs e)
        {
            Player playerClass = FormAllPlayer.Instance.playerList[dataGridView1.CurrentRow.Index];
            playerClassed = playerClass;
            this.DialogResult = DialogResult.OK;
        }
    }
}
