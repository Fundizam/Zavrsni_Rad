using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Upis_studenata_u_bazu
{
    public partial class Form1 : Form
    {
        // Postavljanje nove veze sa SQL bazom podataka
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=Faks_Studenti;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Implementacija funkcije PostaviPodatke
            PostaviPodatke();

            // Postavljanje tekstova u combobox-evima
            Studij.Text = "";
            GradStudenta.Text = "";
            StatusStudenta.Text = "";
        }
        private void UnosUBazu_Click(object sender, EventArgs e)
        {
            // Otvaranje veze
            con.Open();

            // String koji u sebi sadrži SQL naredbu za unos podataka
            // i vrijednosti text box-ova
            String unosPodataka ="INSERT INTO Studenti (OIB, Ime, Prezime, DatRod, " +
                "ID_Studij, ID_Grad, ID_Status) VALUES ('"+OIBStudenta.Text+"', " +
                "'"+ImeStudenta.Text+"', '"+PrezimeStudenta.Text+"', " +
                "'"+DatumRodenja.Text+"', "+Studij.SelectedValue+", " +
                ""+GradStudenta.SelectedValue+", "+StatusStudenta.SelectedValue+")";

            // Stvaranje nove instance SqlDataAdapter klase
            SqlCommand SCU = new SqlCommand(unosPodataka, con);

            // Provođenje naredbe za unos u bazu
            SCU.ExecuteNonQuery();

            // Zatvaranje veze 
            con.Close();           

            // Poruka koja nam javlja o uspješnom unosu u bazu podataka
            MessageBox.Show("Uspjeh.");
        }
        private void PregledUpisanihStudenata_Click(object sender, EventArgs e)
        {
            // Otvaranje druge forme tj. prozora
            new Form2().Show();
        }
        private void PostaviPodatke()
        {
            // Otvaranje veze s bazom podataka
            con.Open();

            // Objekti klase String koji u sebi sadrže upite za prikaz podataka iz 
            // tablica Studij, Gradovi i StatusStudenta
            String upitStudij = "SELECT ID_Studij, Naziv_Studija FROM Studij";
            String upitGrad = "SELECT ID_Grad, Naziv_Grada FROM Gradovi ORDER BY " +
                              " Naziv_Grada ASC";
            String upitStatus = "SELECT ID_Status, Naziv_Statusa FROM StatusStudenta";

            // Objekti klase SqlCommand
            SqlCommand SCSt = new SqlCommand(upitStudij, con);
            SqlCommand SCG = new SqlCommand(upitGrad, con);
            SqlCommand SCSs = new SqlCommand(upitStatus, con);

            // Objekt klase SqlDataReader
            SqlDataReader SDR;

            //Pozivanje metode SqlCommand-e za studij
            SDR = SCSt.ExecuteReader();

            // Popunjavanje podatkovne tablice dataStudij
            DataTable dataStudij = new DataTable();
            dataStudij.Columns.Add("ID_Studij", typeof(int));
            dataStudij.Columns.Add("Naziv_Studija", typeof(string));
            dataStudij.Load(SDR);

            // Definiranje prave vrijednosti studij i vrijednosti koja će se prikazati
            // to jest, naziv studija
            Studij.DataSource = dataStudij;
            Studij.DisplayMember = "Naziv_Studija";
            Studij.ValueMember = "ID_Studij";

            // Zatvaranje čitača podataka
            SDR.Close();

            // Pozivanje metode SQLCommand-e za gradove
            SDR = SCG.ExecuteReader();

            // Popunjavanje Podatkovne tablice dataGrad
            DataTable dataGrad = new DataTable();
            dataGrad.Columns.Add("ID_Grad", typeof(int));
            dataGrad.Columns.Add("Naziv_Grada", typeof(string));
            dataGrad.Columns.Add("PostanskiBroj", typeof(int));
            dataGrad.Columns.Add("ID_Drzave", typeof(int));
            dataGrad.Load(SDR);

            // Definiranje prave vrijednosti studij i vrijednosti koja će se prikazati
            // to jest, naziv grada
            GradStudenta.DataSource = dataGrad;
            GradStudenta.DisplayMember = "Naziv_Grada";
            GradStudenta.ValueMember = "ID_Grad";

            // Zatvaranje čitača podataka
            SDR.Close();

            // Pozivanje metode SQLCommand-e za status studenta
            SDR = SCSs.ExecuteReader();

            // Popunjavanje Podatkovne tablice dataStatus
            DataTable dataStatus = new DataTable();
            dataStatus.Columns.Add("ID_Status", typeof(int));
            dataStatus.Columns.Add("Naziv_Statusa", typeof(string));
            dataStatus.Load(SDR);

            // Definiranje prave vrijednosti studij i vrijednosti koja će se prikazati
            // to jest naziv statusa studenta
            StatusStudenta.DataSource = dataStatus;
            StatusStudenta.DisplayMember = "Naziv_Statusa";
            StatusStudenta.ValueMember = "ID_Status";

            // Zatvaranje čitača podataka
            SDR.Close();

            // Zatvaranje veze s bazom
            con.Close();
        }
    }
}