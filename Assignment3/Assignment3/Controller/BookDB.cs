using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BookProgram.Model;


namespace BookProgram.Controller
{
    public static class BookDB
    {
        public static SqlConnection connDb = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();
        public static DataTable ReadBook()
        {
            connDb = UtilityDB.ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = connDb;
            cmd.CommandText = "select * from book";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();

            cmd.Dispose();
            connDb.Close();
            return dt;
        }
        public static void SaveBook(Book book)
        {
            SqlConnection connDb = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDb;
            cmd.CommandText = string.Format("insert into book (isbn, title, author) values ({0},'{1}','{2}') ", book.isbn, book.title, book.author);
            cmd.ExecuteNonQuery();
            connDb.Close();

        }

        public static void UpdateBook(Book book)
        {
            SqlConnection conDb = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conDb;
            cmd.CommandText = string.Format("update book SET isbn = '" + book.isbn + "',title='" + book.title + "',author='" + book.author + "'WHERE isbn = '" + book.isbn + "'");
            cmd.ExecuteNonQuery();
            connDb.Close();
        }

        public static void DeleteBook(Book book)
        {
            SqlConnection conDb = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conDb;
            cmd.CommandText = string.Format("DELETE from book where isbn = '" + book.isbn + "'") ;
            cmd.ExecuteNonQuery();
            connDb.Close();

        }
        public static DataTable SearchBook(int id)
        {

                SqlConnection connDb = UtilityDB.ConnectDB();
                SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDb;
            cmd.CommandText = "select * from book where isbn= " + id;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
           // cmd.ExecuteNonQuery();
            connDb.Close();
            return dt;
        }
    }
}

