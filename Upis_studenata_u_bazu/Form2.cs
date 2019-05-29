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

namespace Upis_studenata_u_bazu
{
    public partial class Form2 : Form
    {
        //postavljanje nove veze sa SQL bazom podataka
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=Faks_Studenti;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        private void PrikazStudenata_Click(object sender, EventArgs e)
        {
            //otvaranje veze
            con.Open();

            //string koji sadrži SQL naredbu
            String query = "SELECT Studenti.OIB, Studenti.Ime, Studenti.Prezime, " +
                "Studenti.DatRod, Studij.Naziv_Studija, " +
                "Gradovi.Naziv_Grada, StatusStudenta.Naziv_Statusa " +
                "FROM Studenti INNER JOIN Studij ON " +
                "Studenti.ID_Studij = Studij.ID_Studij " +
                "INNER JOIN Gradovi ON " +
                "Studenti.ID_Grad = Gradovi.ID_Grad " +
                "INNER JOIN StatusStudenta ON " +
                "Studenti.ID_Status = StatusStudenta.ID_Status ";

            //stvaranje nove instance SqlDataAdapter klase
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            //instanciranje DataTable klase
            DataTable dt = new DataTable();

            // popunjavanje tablice 
            SDA.Fill(dt);           

            //prikaz upisanih u bazi podataka na Data Grid View
            PregledUpisanih.DataSource = dt;

            //zatvaranje veze
            con.Close();
        }
        /*
        private SqlDataAdapter Adaptacija(string unos, SqlConnection veza)
        {
            //stvaranje nove instance SqlDataAdapter klase
            SqlDataAdapter SDA = new SqlDataAdapter(unos, veza);
            return SDA;
        }
        */
        private void PrikazDrzava_Click(object sender, EventArgs e)
        {
            //otvaranje veze
            con.Open();

            //string koji sadrži SQL naredbu
            String query = "SELECT * FROM Drzave";

            //stvaranje nove instance SqlDataAdapter klase
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            //instanciranje DataTable klase
            DataTable dt = new DataTable();

            //popunjavanje tablice 
            SDA.Fill(dt);

            //prikaz upisanih u bazi podataka na Data Grid View
            PregledUpisanih.DataSource = dt;

            //zatvaranje veze
            con.Close();
        }
        private void PrikazGradova_Click(object sender, EventArgs e)
        {
            //otvaranje veze
            con.Open();

            //string koji sadrži SQL naredbu
            String query = "SELECT Gradovi.ID_Grad, Gradovi.Naziv_Grada, " +
                "PostanskiBroj, Drzave.Naziv_Drzave FROM Gradovi " +
                "INNER JOIN Drzave ON Gradovi.ID_Drzave=Drzave.ID_Drzave " +
                "ORDER BY Drzave.Naziv_Drzave ASC";

            //stvaranje nove instance SqlDataAdapter klase
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            //instanciranje DataTable klase
            DataTable dt = new DataTable();

            // popunjavanje tablice 
            SDA.Fill(dt);

            //prikaz upisanih u bazi podataka na Data Grid View
            PregledUpisanih.DataSource = dt;

            //zatvaranje veze
            con.Close();
        }
        private void PrikazStudija_Click(object sender, EventArgs e)
        {
            //otvaranje veze
            con.Open();

            //string koji sadrži SQL naredbu
            String query = "SELECT * FROM Studij";

            //stvaranje nove instance SqlDataAdapter klase
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            //instanciranje DataTable klase
            DataTable dt = new DataTable();

            // popunjavanje tablice 
            SDA.Fill(dt);

            //prikaz upisanih u bazi podataka na Data Grid View
            PregledUpisanih.DataSource = dt;

            //zatvaranje veze
            con.Close();

        }
        private void Povratak_Click(object sender, EventArgs e)
        {
            //zatvaranje prozora
            this.Close();
        }
    }
}