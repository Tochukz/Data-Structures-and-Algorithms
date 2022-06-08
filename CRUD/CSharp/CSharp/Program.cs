using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSharp
{
	class Program
	{

		public static void Main(string[] args)
		{
			List<Book> books =  GetBooks();
			foreach(Book book in books)
			{
				Console.WriteLine($"{book.bookId}) {book.title} by {book.author} {book.edition} at R{book.price}");
			}

			int bookId = 7;
			Book bookX = GetBook(bookId);
			if (bookX != null)
			{
				Console.WriteLine($"Book {bookX.bookId}: {bookX.title} by {bookX.author}");
			}
			

			Book newBook = AddBook(new Book
			{
				title = "Further Mathematic for Kids",
				author = "Tochukwu Nwachukwu", 
				price = 2980, 
				edition = "2nd Edition", 
				subcategoryId = 3,
			});
			if (newBook != null)
			{
				Console.WriteLine($"New Book {newBook.bookId}: {newBook.title} by {newBook.author}");
			}
			Console.ReadLine();
		}

		static SqlConnection Connect()
		{
			string connectionStr = @"Data Source=CHUCKSM; Initial Catalog=OjlinksDB; User ID=ojlinks_user; Password=ojlinks_pass";
			SqlConnection connection = new SqlConnection(connectionStr);
			connection.Open();
			Console.WriteLine("Connected!");
			return connection;
			
		}

		static Book GetBook(int bookId)
		{
			List<Book> books = GetBooks(bookId, $"Where bookId = {bookId}");
			if (books.Count > 0)
			{
				return books[0];
			}
			return null;
		}

		static List<Book> GetBooks(int limit = 5, string whereClause = "")
		{
			using (SqlConnection connection = Connect())
			{
				string query = $"SELECT TOP {limit} * FROM Books {whereClause}";
				SqlCommand command = new SqlCommand(query, connection);
				SqlDataReader reader = command.ExecuteReader();
				List<Book> books = new List<Book>();
				while (reader.Read())
				{
					int idIndex = reader.GetOrdinal("bookId");
					int bookId = (int)reader.GetValue(idIndex);

					int titleIndex = reader.GetOrdinal("title");
					string title = (string)reader.GetValue(titleIndex);

					int authorIndex = reader.GetOrdinal("author");
					string author = (string)reader.GetValue(authorIndex);

					int priceIndex = reader.GetOrdinal("price");
					double price = (double)reader.GetValue(priceIndex);

					int editionIndex = reader.GetOrdinal("edition");
					string edition = (string)reader.GetValue(editionIndex);

					Book book = new Book
					{
						bookId = bookId,
						title = title,
						author = author,
						price = price,
						edition = edition
					};
					books.Add(book);
				}

				reader.Close();
				command.Dispose();

				Console.WriteLine("Disposing connection");
				return books;
			}
		}

		static Book AddBook(Book book)
		{
			SqlConnection connection = Connect();
			SqlCommand command = new SqlCommand(null, connection);
			command.CommandText = "INSERT INTO books(title, author, price, edition, subcategoryId) VALUES(@title, @author, @price, @edition, @subcategoryId)";

			SqlParameter titleParam = new SqlParameter("@title", SqlDbType.VarChar, book.title.Length);
			SqlParameter authorParam = new SqlParameter("@author", SqlDbType.VarChar, book.author.Length);
			SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Float, (int)book.price);
			SqlParameter editionParam = new SqlParameter("@edition", SqlDbType.VarChar, book.edition.Length);
			SqlParameter subCatParam = new SqlParameter("@subcategoryId", SqlDbType.Int, book.subcategoryId);

			command.Parameters.Add(titleParam);
			command.Parameters.Add(authorParam);
			command.Parameters.Add(priceParam);
			command.Parameters.Add(editionParam);
			command.Parameters.Add(subCatParam);
			int bookId = (int)command.ExecuteScalar();
			Book newBook = GetBook(bookId);
			command.Prepare();
			command.ExecuteNonQuery();
			command.Dispose();
			connection.Close();
			return newBook;
		}
	}

	class Book
	{
		public int bookId;

		public string title;

		public string author;

		public double price;

		public string edition;

		public int subcategoryId;
	}
}
