namespace WLU_zadanie2
{
    public partial class formLogowanie : Form
    {

        public string sCorrVeri = "befhd";

        public formLogowanie()
        {
            InitializeComponent();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string sUser = tbUser.Text.Trim();
            string sPass = tbPass.Text.Trim();
            string sVeri = tbVeri.Text.Trim();

            bool bLogged = false;
            bool bVerified = false;


            if (sUser == "admin" & sPass == "Qwerty1@34")
            {
                bLogged = true;
            }

            if (sVeri == sCorrVeri)
            {
                bVerified = true;
            }


            if (bLogged == true & bVerified == true)
            {
                //do form
                Form f2 = new formMain();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login, has≥o bπdü tekst weryfikacjyny niepoprawny", "B≥πd logowania");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //string[] sciezki = Directory.GetFiles(@"C:\Users\student\source\repos\WLU_zadanie2\WLU_zadanie2", "*.png");
            string[] sciezki = Directory.GetFiles(@"C:\Users\student\source\repos\Kucharzman\WLU_zadanie2\WLU_zadanie2", "*.png");
            List<string> zdjecia = sciezki.ToList();

            Random kotlet = new Random();

            picVeri.ImageLocation = sciezki[kotlet.Next(0, zdjecia.Count - 1)];

            if (picVeri.ImageLocation.Contains("1.png"))
            {
                sCorrVeri = "mxyxw";
            } else
            if (picVeri.ImageLocation.Contains("2.png"))
            {
                sCorrVeri = "b5nmm";
            }
            else
            if (picVeri.ImageLocation.Contains("3.png"))
            {
                sCorrVeri = "74853";
            }
            else
            if (picVeri.ImageLocation.Contains("4.png"))
            {
                sCorrVeri = "cg5dd";
            }
            else
            if (picVeri.ImageLocation.Contains("5.png"))
            {
                sCorrVeri = "x3deb";
            }
            else
            if (picVeri.ImageLocation.Contains("6.png"))
            {
                sCorrVeri = "befhd";
            }
            else
            if (picVeri.ImageLocation.Contains("7.png"))
            {
                sCorrVeri = "rc7gb3";
            }

        }
    }
}