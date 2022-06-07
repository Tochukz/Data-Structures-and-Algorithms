using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CSharp
{
	class Program
	{
        private static readonly string BaseUrl = "http://ojlinks-api.test:8084";

        private static readonly string Token = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

        static void Main(string[] args)
		{
            Result result = new Result();

            //Get /books;
            Task.Run(() => GetBooks(result));
            while(!result.done)
			{
                Thread.Sleep(1000);
            }
  
            if (result.books.Count > 0)
			{
                Console.WriteLine($"First Book: {result.books[0].title} by {result.books[0].author}");

            }

            // reset
            result.done = false;
            result.books = null;

            // Get /books/7
            int bookId = 7;
            //Task.Run(() => GetBook(result, bookId));
            GetBook(result, bookId);
            while (!result.done)
			{
                Thread.Sleep(1000);
			}
            if (result.book != null)
			{
                Console.WriteLine($"Book {bookId}: {result.book.title} by {result.book.author}");
			}


            // reset 
            result.done = false;
            result.book = null;

            // Post /admin/create/book
            dynamic data = new { title = "Physics Books for Kids", author = "James Slay", edition = "3rd", price = 1650, detail = "<p>Physics book for kids</p>" };
            //Task.Run(() => AddBookFail(result, data));
            Task.Run(() => AddBook(result, data));
            while (!result.done)
			{
                Thread.Sleep(1000);
			}

            if (result.book != null)
			{
                Console.WriteLine($"New Book: {result.book.bookId} {result.book.title} by {result.book.author}");
			}


            //reset
            result.done = false;
            result.admins = null;

            // Get /admin/admins
            GetAdmins(result);
            while (!result.done)
			{
                Thread.Sleep(1000);
			}
            if (result.admins != null)
			{
                foreach(Admin admin in result.admins)
				{
                    Console.WriteLine($"{admin.firstname} {admin.lastname}");
				}
			}

            Console.WriteLine("The end!");
            Console.ReadLine();
		}

        /**
         * Get call for public endpoint
         */
        public static async Task<List<Book>> GetBooks(Result result)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{BaseUrl}/api/books");
            string responseStr = await responseMessage.Content.ReadAsStringAsync();
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(responseStr);
            result.books = books;
            result.done = true;
            return books;
        }

        /**
         * Get call for public endpoint
         */
        public static async Task<Book> GetBook(Result result, int bookId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{BaseUrl}/api/books/{bookId}");
            string responseStr = await responseMessage.Content.ReadAsStringAsync();
            Book book = JsonConvert.DeserializeObject<Book>(responseStr);
            result.book = book;
            result.done = true;
            return book;
        }

        /**
         * Post call with token for protected endpoint w
         */
        public static async Task<Book> AddBook(Result result, dynamic data)
        {
            try
            {
                HttpClient client = new HttpClient();               
                string jsonStr = JsonConvert.SerializeObject(data);
                ByteArrayContent content = new ByteArrayContent(Encoding.UTF8.GetBytes(jsonStr));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpRequestMessage requestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri($"{BaseUrl}/admin/book/create"),
                    Method = HttpMethod.Post,
					Content = content,
                };
                requestMessage.Headers.Add("Authorization", $"Bearer {Token}");
                HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);
                string responseStr = await responseMessage.Content.ReadAsStringAsync();
                Book book = JsonConvert.DeserializeObject<Book>(responseStr);
                result.book = book;
                result.done = true;
                return book;
            }
            catch(Exception e)
			{
                Console.WriteLine("Add Book Exception: " + e.Message);
                throw e;
			}
        }

        /**
         * Get call without token for protected endpoint. It fails.
         */
        public static async Task<Book> AddBookFail(Result result, dynamic data)
        {
            HttpClient client = new HttpClient();
            //FormUrlEncodedContent content = new FormUrlEncodedContent(data);   
            StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{BaseUrl}/admin/book/create", content);
            string responseStr = await responseMessage.Content.ReadAsStringAsync();
            Book book = JsonConvert.DeserializeObject<Book>(responseStr);
            result.book = book;
            result.done = true;
            return book;
        }

        /**
         * Get call with token 
         */
        public static async Task<List<Admin>> GetAdmins(Result result)
		{
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{BaseUrl}/admin/admins")
            };
            requestMessage.Headers.Add("Authorization", $"Bearer {Token}");          
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);
            string responseStr = await responseMessage.Content.ReadAsStringAsync();
            List<Admin> admins = JsonConvert.DeserializeObject<List<Admin>>(responseStr);
            result.admins = admins;
            result.done = true;
            return admins;
		}
    }

    class Result
	{
        public bool done;

        public List<Book> books;

        public Book book;

        public List<Admin> admins;
	}

    class Book
    {
        public int bookId;
        public string title;
        public string author;
        public string edition;
        public string price;
        public string img;
        public string availability;
        public string subcategoryId;
        public string details;
    }

    class Admin
	{
        public int adminId;
        public string firstname;
        public string lastname;
        public string email;
        public string createdAt;
        public string updatedAt;
	}
}
