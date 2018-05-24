using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_1_pirmas
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\24_1_pirmas\KCS.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            /*
            using (SqlCommand sqlComand = new SqlCommand("INSERT INTO Students(Name, Surename, Phone, Email) VALUES (@Name, @Surname, @Phone, @Email)", sqlConnection))
            {
                sqlConnection.Open();
                Console.WriteLine("Nurodykite varda:");
                sqlComand.Parameters.AddWithValue("@Name", Console.ReadLine());
                Console.WriteLine("Nurodykite pavarde:");
                sqlComand.Parameters.AddWithValue("@Surname", Console.ReadLine());
                Console.WriteLine("Nurodykite telefono numeri:");
                sqlComand.Parameters.AddWithValue("@Phone", Console.ReadLine());
                Console.WriteLine("Nurodykite e-mail:");
                sqlComand.Parameters.AddWithValue("@Email", Console.ReadLine());
                sqlComand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            */

            /*
            using (SqlCommand sqlComand = new SqlCommand("INSERT INTO Student_address(Student_Id, Country, City, Street, Post_code) VALUES (@Student_Id, @Country, @City, @Street, @Post_code)", sqlConnection))
            {
                sqlConnection.Open();
                Console.WriteLine("Nurodykite studento ID:");
                sqlComand.Parameters.AddWithValue("@Student_Id", Console.ReadLine());
                sqlComand.Parameters.AddWithValue("@Country", "Lithuania");
                sqlComand.Parameters.AddWithValue("@City", "Jonava");
                Console.WriteLine("Nurodykite gatve:");
                sqlComand.Parameters.AddWithValue("@Street", Console.ReadLine());
                Console.WriteLine("Nurodykite pasto indeksa:");
                sqlComand.Parameters.AddWithValue("@Post_code", Console.ReadLine());
                sqlComand.ExecuteNonQuery();
                sqlConnection.Close();
                sqlComand.Parameters.Clear();
            }
            */

            // ------- SELECT visus studentus ir surikiuokite pagal studento vardą nuo A iki Z
            /*
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleni\source\repos\Programavimo_Kursai_C_sharp\24_1_pirmas\KCS.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string querry = "SELECT * FROM Students ORDER BY Name ASC";
            using (SqlCommand com = new SqlCommand(querry, sqlConnection))
            {
                sqlConnection.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Id"].ToString() + " " + reader["Name"].ToString());
                    //Console.WriteLine(reader["Id"].ToString());
                    //Console.WriteLine(reader["Name"].ToString());
                }
            }
            sqlConnection.Close();
            */


            // -------- SELECT studentus kurių vardai ir pavardės baigėsi ‚as‘, surikiuokite rezultatus nuo Z iki A pagal pavardes
            /*
            string querry = "SELECT * FROM Students WHERE Name like '%us' AND Surename like '%as' ORDER BY Surename DESC";
            using (SqlCommand com = new SqlCommand(querry, sqlConnection))
            {
                sqlConnection.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1} {2}", reader["Id"].ToString(), reader["Name"].ToString(), reader["Surename"].ToString());
                    // Console.WriteLine(reader["Id"].ToString() + " " + reader["Name"].ToString() + " " + reader["Surename"].ToString());
                    //Console.WriteLine(reader["Id"].ToString());
                    //Console.WriteLine(reader["Name"].ToString());
                }
            }
            sqlConnection.Close();
            */

            // --------- SELECT studentus ir jų adresus panaudojant LEFT JOIN rezultatus surikiuoti pagal vardus
            /*
            string querrry = "SELECT * FROM Students INNER JOIN Student_address on Students.Id = Student_address.Student_Id ORDER BY Name ASC";
            using (SqlCommand com = new SqlCommand(querrry, sqlConnection))
            {
                sqlConnection.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1} {2}", reader["Id"].ToString(), reader["Name"].ToString(), reader["Surename"].ToString());
                    //Console.WriteLine(reader["Id"].ToString());
                    //Console.WriteLine(reader["Name"].ToString());
                    //Console.WriteLine(reader["Surename"].ToString());
                }
            }
            */


            // ----- SELECT top 10 geriausiai besimokančių studentu. Naudokite LIMIT 10 (P.S. limit turi eiti paskutinis)
            string querrry = "SELECT TOP 10 Student_marks.Mark AS ID FROM Student_marks INNER JOIN Students on Students.Id = Student_marks.Student_Id ORDER BY ID ASC";
            using (SqlCommand com = new SqlCommand(querrry, sqlConnection))
            {
                sqlConnection.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}", reader["Id"].ToString());
                    //Console.WriteLine(reader["Id"].ToString());
                    //Console.WriteLine(reader["Name"].ToString());
                    //Console.WriteLine(reader["Surename"].ToString());
                }
            }

        }
    }
}
