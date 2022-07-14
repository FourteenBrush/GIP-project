using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KlantDA
    {
        private MySqlConnection _connection;

        public KlantDA()
        {
            string connString = "server=localhost;user id=root;password=Leerling123;database=tcg_card_grading;persistsecurityinfo=True";
            _connection = new MySqlConnection(connString);
        }

        public List<Klant> ReadTable()
        {
            List<Klant> klanten = new List<Klant>();
            string sql = "SELECT * FROM tblklanten;";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            _connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int klantnummer = reader.GetInt32("klantnummer");
                string naam = reader.GetString("naam");
                string voornaam = reader.GetString("voornaam");
                string adres = reader.GetString("adres") + " " + reader.GetString("postcode") + ", " + reader.GetString("gemeente");
                string email = reader.GetString("email");
                string telefoonnummer = reader.GetString("telefoonnummer");

                klanten.Add(new Klant(klantnummer, naam, voornaam, adres, email, telefoonnummer));
            }
            _connection.Close();

            return klanten;
        }

        public void DeleteKlant(int id)
        {
            string sql = "DELETE FROM tblklanten WHERE klantnummer = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@id", id);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
