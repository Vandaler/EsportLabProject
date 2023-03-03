namespace CISEsport
{
    public partial class FormInfo : Form
    {
        Player player;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btnclick_click(object sender, EventArgs e)
        {
            string name = TBname.Text;
            string studentid = TBid.Text;
            string major = TBmajor.Text;
            string displayname = TBingamename.Text;
            string mail = TBemail.Text;
            string phonenum = TBphonenum.Text;
            int age = int.Parse(TBage.Text);
            player = new Player()
            {
                name = name,
                studentid = studentid,
                major = major,
                displayname = displayname,
                mail = mail,
                phonenum = phonenum,
                age = age
            };

            DialogResult = DialogResult.OK;
            

        }
        public Player getPlayer()
        {
            return player;
        }

    }
}