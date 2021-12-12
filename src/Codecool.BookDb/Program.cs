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

                //Author updatedAuthor = new Author("John", "Smith", DateTime.Now);
                //updatedAuthor.Id = 6;
                //authorDao.Update(updatedAuthor);

                //foreach (var author in authorDao.GetAll())
                //{
                //    Console.WriteLine(author);
                //}

                int id = 1;

                Author autor = authorDao.Get(id);
                Console.WriteLine(autor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
