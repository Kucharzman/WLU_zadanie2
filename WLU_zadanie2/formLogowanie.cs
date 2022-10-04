namespace WLU_zadanie2
{
    public partial class formLogowanie : Form
    {
        public formLogowanie()
        {
            InitializeComponent();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string sUser = tbUser.Text;
            string sPass = tbPass.Text;
            string sVeri = tbVeri.Text;
            string sPicName = picVeri.
            bool bLogged = false;
            bool bVerified = false;


            if (sUser == "admin" & sPass == "Qwerty1@34")
            {
                bLogged = true;
            }

            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}