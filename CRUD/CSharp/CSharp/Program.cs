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
			// Select All
			List<Book> books =  GetBooks();
			foreach(Book book in books)
			{
				Console.WriteLine($"{book.bookId}) {book.title} by {book.author} {book.edition} at R{book.price}");
			}

			// Select Single
			int bookId = 7;
			Book bookX = GetBook(bookId);
			if (bookX != null)
			{
				Console.WriteLine($"Book {bookX.bookId}: {bookX.title} by {bookX.author}");
			}
			
			// Insert
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

			// Update
			Book updatedBook = UpdateBook(new Book
			{
				bookId = 156,
				title = "Further Mathematic for Kids",
				author = "Tochukwu Nwachukwu & Folks",
				price = 5580,
				edition = "5nd Edition",
				subcategoryId = 3,
			});
			if (updatedBook != null)
			{
				Console.WriteLine($"Update Book {updatedBook.bookId}: {updatedBook.title} by {updatedBook.author}, {updatedBook.edition} now R{updatedBook.price}");
			}

			// Delete 
			int bookIdToDel = 165;
			int result = DeleteBook(bookIdToDel);
			if (result > 0)
			{
				Console.WriteLine("Deleted Book: " + bookIdToDel);
			}
			else
			{
				Console.WriteLine($"No book {bookIdToDel} to delete");
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
			string query = "INSERT INTO books(title, author, price, edition, subcategoryId, createdAt, updatedAt) " +							
							"VALUES(@title, @author, @price, @edition, @subcategoryId, @createdAt, @updatedAt); "+
							"SELECT SCOPE_IDENTITY()";

			SqlCommand command = new SqlCommand(query, connection);
			string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			SqlParameter titleParam = new SqlParameter("@title", SqlDbType.VarChar, book.title.Length);
			SqlParameter authorParam = new SqlParameter("@author", SqlDbType.VarChar, book.author.Length);
			SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Float);
			SqlParameter editionParam = new SqlParameter("@edition", SqlDbType.VarChar, book.edition.Length);
			SqlParameter subCatParam = new SqlParameter("@subcategoryId", SqlDbType.Int);
			SqlParameter createdAtParam = new SqlParameter("@createdAt", SqlDbType.DateTime);
			SqlParameter updatedAtParam = new SqlParameter("@updatedAt", SqlDbType.DateTime);

			titleParam.Value = book.title;
			authorParam.Value = book.author;
			priceParam.Value = book.price;
			editionParam.Value = book.edition;
			subCatParam.Value = book.subcategoryId;
			createdAtParam.Value = now;
			updatedAtParam.Value = now;

			command.Parameters.Add(titleParam);
			command.Parameters.Add(authorParam);
			command.Parameters.Add(priceParam);
			command.Parameters.Add(editionParam);
			command.Parameters.Add(subCatParam);
			command.Parameters.Add(createdAtParam);
			command.Parameters.Add(updatedAtParam);

			command.Prepare();
			decimal bookId = (decimal)command.ExecuteScalar();
			Book newBook = GetBook(Decimal.ToInt32(bookId));
			command.Dispose();

			connection.Close();

			return newBook;
		}

		static Book UpdateBook(Book book)
		{
			using(SqlConnection connection = Connect())
			{
				string query = "UPDATE books SET edition=@edition, author=@author, price=@price WHERE bookId=@bookId";
				SqlCommand command = new SqlCommand(query, connection);

				SqlParameter editionParam = new SqlParameter("@edition", SqlDbType.VarChar, book.edition.Length);
				SqlParameter authorParam = new SqlParameter("@author", SqlDbType.VarChar, book.author.Length);
				SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Int);
				SqlParameter bookIdParam = new SqlParameter("@bookId", SqlDbType.Int);

				editionParam.Value = book.edition;
				authorParam.Value = book.author;
				priceParam.Value = book.price;
				bookIdParam.Value = book.bookId;

				command.Parameters.Add(editionParam);
				command.Parameters.Add(authorParam);
				command.Parameters.Add(priceParam);
				command.Parameters.Add(bookIdParam);

				command.Prepare();
				command.ExecuteNonQuery();
				command.Dispose();

				Book updateBook = GetBook(book.bookId);
				return updateBook;
			}
		}

		static int DeleteBook(int bookId)
		{
			using (SqlConnection connection = Connect())
			{
				SqlCommand command = new SqlCommand("DELETE FROM books where bookId=@bookId", connection);
				SqlParameter param = new SqlParameter("@bookId", SqlDbType.Int);
				param.Value = bookId;

				command.Parameters.Add(param);
				command.Prepare();
				int result = command.ExecuteNonQuery();
				command.Dispose();
				return result;
			}
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
