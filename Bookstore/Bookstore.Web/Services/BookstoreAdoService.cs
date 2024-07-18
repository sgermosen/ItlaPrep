using Bookstore.Web.Models;
using Microsoft.Data.SqlClient;

namespace Bookstore.Web.Services
{
    public class BookstoreAdoService
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public BookstoreAdoService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection"); 
        }

        public void Add(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
              

                //using (var transaction = connection.BeginTransaction())
                //{
                    try
                    {
                        var command = new SqlCommand("INSERT INTO Books (Name, Author, Type) VALUES (@Name, @Author, @Type)", connection);
                        command.Parameters.AddWithValue("@Name", book.Name);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@Type", book.Type);
                    connection.Open();
                    command.ExecuteNonQuery();
                       // transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                       // transaction.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }

                //}
            } 
        }

        public void Delete(int id)
        {
            var connection = new SqlConnection(_connectionString);

            var command = new SqlCommand("DELETE FROM Books WHERE ID   = @BookID", connection);
            command.Parameters.AddWithValue("@BookID", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close(); 
        }

        public Book GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Books WHERE ID = @BookID", connection);
                command.Parameters.AddWithValue("@BookID", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // var contact = new Contact();
                        // contact.Id = (int)reader[nameof(contact.Id)];
                        //  contact.Id = (int)reader["ContactID"];
                        return new Book
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Author = reader["Author"].ToString(),
                            Type = reader["Type"].ToString()
                        };
                    }
                }
            }
            return null;

        }

        public List<Book> GetAll()
        {
            var books = new List<Book>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Books", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Author = reader["Author"].ToString(),
                            Type = reader["Type"].ToString()
                        });
                    }
                }
            }
            return books;

        }

        public void Update(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Books SET Name = @Name, Author = @Author, Type = @Type WHERE  ID = @BookID", connection);
                command.Parameters.AddWithValue("@BookID", book.Id);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Type", book.Type); 

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }

        }
    }
}
