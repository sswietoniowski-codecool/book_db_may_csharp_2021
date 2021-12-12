using System;
using Codecool.BookDb.Manager;
using Codecool.BookDb.Model;

namespace Codecool.BookDb
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                BookDbManager manager = new BookDbManager();
                manager.Connect();

                IAuthorDao authorDao = new AuthorDao(manager.ConnectionString);

                //Author author = new Author("Adam", "Nowak", DateTime.Now);

                //Console.WriteLine($"Id = {author.Id}");
                //authorDao.Add(author);
                //Console.WriteLine($"Id = {author.Id}");

                foreach (var author in authorDao.GetAll())
                {
                    Console.WriteLine(author);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
