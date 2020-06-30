using System;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Quiz
{
    public partial class Quiz : Form
    {
        protected string antwort; //die angeklickte Antwort

        protected int anzahlDatensaetze;
        
        protected string Datenbankabfrage;
        
        protected string antwort1; // gleichzeitig auch die Lösung 
        protected string antwort2;
        protected string antwort3;
        protected string antwort4;
        protected string frage;

        protected int richtig, falsch;
                
        protected OleDbConnection con = new OleDbConnection();
        protected OleDbCommand cmd = new OleDbCommand();
        protected OleDbDataReader reader;


        public void DatenbankVorbereiten ()
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=quiz_db.accdb"; // "Data Source=C:\\Users\\Dietmar\\Documents\\quiz_db.accdb";
            cmd.Connection = con;
        }

        public Quiz()
        {
            InitializeComponent();
            LabelsLoeschen();
            HoleEinenDS();
         }

        public void Auswerten()
        {
            if (antwort == antwort1)
            {
                ++richtig;
            }
            else
            {
                ++falsch;
            }
            Lblrichtig.Text = Convert.ToString(richtig);
            LblFalsch.Text =  Convert.ToString(falsch);

        }
        public void LabelsLoeschen()
        {
            LblFalsch.Text = "0";
            Lblrichtig.Text = "0";
            richtig = 0;
            falsch = 0;
        }


        public void SchuettleAntworten()
        {

            int zuff;
            Random zufall = new Random();
            zuff = zufall.Next(1, 8);

            switch (zuff)
            {
                case 1:
                    btnEins.Text = antwort1;
                    btnZwei.Text = antwort2;
                    btnDrei.Text = antwort3;
                    btnVier.Text = antwort4;
                break;

                case 2:
                    btnEins.Text = antwort2;
                    btnZwei.Text = antwort1;
                    btnDrei.Text = antwort3;
                    btnVier.Text = antwort4;
                break;
                
                case 3:
                    btnEins.Text = antwort3;
                    btnZwei.Text = antwort2;
                    btnDrei.Text = antwort1;
                    btnVier.Text = antwort4;
               break;

               case 4:
                    btnEins.Text = antwort4;
                    btnZwei.Text = antwort2;
                    btnDrei.Text = antwort3;
                    btnVier.Text = antwort1;
               break;

                default:
                    btnEins.Text = antwort4;
                    btnZwei.Text = antwort3;
                    btnDrei.Text = antwort2;
                    btnVier.Text = antwort1;
               break;

            }
        }


        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void btnEins_Click(object sender, EventArgs e)
        {
            antwort = btnEins.Text;
            Auswerten();
            HoleEinenDS();
        }

        private void btnZwei_Click(object sender, EventArgs e)
        {
            antwort = btnZwei.Text;
            Auswerten();
            HoleEinenDS();
        }

        private void btnDrei_Click(object sender, EventArgs e)
        {
            antwort = btnDrei.Text;
            Auswerten();
            HoleEinenDS();
        }

        private void btnVier_Click(object sender, EventArgs e)
        {
            antwort = btnVier.Text;
            Auswerten();
            HoleEinenDS();
        }

        //private void btnInfo_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnI_Click(object sender, EventArgs e)
        //{
          
        //}

        private void pciInfo_Click(object sender, EventArgs e)
        {
            FrmInfo infos = new FrmInfo();

            infos.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        /*
         * Datenbank testen, mehr nicht
         */
        {

            MessageBox.Show("Soviele sind es  ::: " + DieDatensaetze());


        }
        public void HoleEinenDS()
        {
            Random zufall = new Random();
            int zuffi;
            DatenbankVorbereiten();

            zuffi = zufall.Next(1, DieDatensaetze());

            Datenbankabfrage = "Select * from quiz where ID = " + zuffi;
            
            try
            {
                con.Open();
                cmd.CommandText = Datenbankabfrage;
                reader = cmd.ExecuteReader();
                reader.Read();

                antwort1 = (string) reader["antwort1"];
                antwort2 = (string) reader["antwort2"];
                antwort3 = (string) reader["antwort3"];
                antwort4 = (string) reader["antwort4"];
                frage = (string) reader["frage"];

                reader.Close();

                lblFrage.Text = frage + "?";

                SchuettleAntworten();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public int DieDatensaetze()
        {
            DatenbankVorbereiten();
            Datenbankabfrage = "select * from quiz";
            anzahlDatensaetze = 0;

            try
            {
                con.Open();
   
                cmd.CommandText = Datenbankabfrage; 
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    //  Durchzählen
                {
                    ++anzahlDatensaetze;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return anzahlDatensaetze+1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoleEinenDS();
        }
    }
}
