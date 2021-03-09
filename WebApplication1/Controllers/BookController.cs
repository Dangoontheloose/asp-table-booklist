using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;

        public BookController()
        {
            listBooks = new List<Book>
            {
                new Book(1, "Book 1", "Author 1", "../Content/img/book1.jpg"),
                new Book(2, "Book 2", "Author 2", "../Content/img/book2.png"),
                new Book(3, "Book 3", "Author 3", "../Content/img/book3.jpg"),
                new Book(4, "Book 4", "Author 4", "../Content/img/book4.png"),
                new Book(5, "Book 5", "Author 5", "../Content/img/book5.jpg"),
                new Book(6, "Book 6", "Author 6", "../Content/img/book6.jpeg"),
            };
        }

        // GET
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "Book View Page";
            return View(listBooks);
        }

        // public ActionResult Details(int id)
        // {
        //     Book book = listBooks[id];
        //     return View(book);
        // }

        public ActionResult Edit(int id)
        {
            Book book = listBooks[id];
            return View(book);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string title, string author, string cover)
        {
            try
            {
                Book book = listBooks[id];
                book.Title = title;
                book.Author = author;
                book.Cover = cover;
                return View("ListBooks", listBooks);
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }

        }
        public ActionResult Delete(int id)
        {
            listBooks.RemoveAt(id);
            return View("ListBooks", listBooks);
        }
    }
}