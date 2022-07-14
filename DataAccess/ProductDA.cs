using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDA
    {
        private MySqlConnection _connection;

        public ProductDA()
        {
            string connString = "server=localhost;user id=root;password=Leerling123;database=tcg_card_grading;persistsecurityinfo=True";
            _connection = new MySqlConnection(connString);
        }

        public List<Product> ReadTable()
        {
            List<Product> producten = new List<Product>();
            string sql = "SELECT * FROM tblproducten;";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            _connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int productID = reader.GetInt32("productID");
                string omschrijving = reader.GetString("omschrijving");
                decimal prijs = reader.GetDecimal("prijs");

                producten.Add(new Product(productID, omschrijving, prijs));
            }
            _connection.Close();

            return producten;
        }

        public void UpdateRecord(Product product)
        {
            string sql = "DELETE * FROM tblproducten WHERE productID = @Id;";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@Id", product.ProductID);

            _connection.Open();
            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        public void DeleteRecord(Product product)
        {
            string sql = "DELETE FROM tblproducten WHERE id = @Id;";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@Id", product.ProductID);

            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void CreateRecord(Product product)
        {
            string sql = "INSERT INTO tblproducten (productID, omschrijving, prijs) VALUES(@ProductId, @Omschrijving, @Prijs);";
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@ProductId", product.ProductID);
            cmd.Parameters.AddWithValue("@Omschrijving", product.Omschrijving);
            cmd.Parameters.AddWithValue("@Prijs", product.Prijs);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
