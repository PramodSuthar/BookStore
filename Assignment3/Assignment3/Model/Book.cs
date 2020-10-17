using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BookProgram.Controller;


namespace BookProgram.Model
{
    public class Book
    {
        public int isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }

        public int Search { get; set; }


        public DataTable ReadBook()
        {
            return BookDB.ReadBook();
        }
        public void SaveBook(Book book)
        {
            BookDB.SaveBook(book);
        }
        public void UpdateBook(Book book)
        {
            BookDB.UpdateBook(book);
        }

        public void DeleteBook(Book book)
        {
            BookDB.DeleteBook(book);
        }
        public DataTable SearchBook(int id)
        {
            return BookDB.SearchBook(id);
        }
    }
}
