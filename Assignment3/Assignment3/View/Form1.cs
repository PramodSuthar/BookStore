using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookProgram.Model;

namespace BookProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book = new Book();
            var dt = book.ReadBook();
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtboxIsbn.Text == "" || txtboxTitle.Text == "" || txtboxAuthor.Text == "")
            {
                MessageBox.Show("Please enter valid data into fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((Convert.ToInt32(txtboxIsbn.Text) >= 0) && (Convert.ToInt32(txtboxIsbn.Text) <= 99))
            {
                MessageBox.Show("Please enter a valid ISBN number for the Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var book1 = new Book();
                book1.isbn = Convert.ToInt32(txtboxIsbn.Text);
                book1.title = txtboxTitle.Text;
                book1.author = txtboxAuthor.Text;
                book1.SaveBook(book1);
                MessageBox.Show("The book has been inserted Successfully", "Confirmation");
                var dt = book1.ReadBook();
                dataGridView1.DataSource = dt;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var book1 = new Book();
            book1.isbn = Convert.ToInt32(txtboxIsbn.Text);
            book1.title = txtboxTitle.Text;
            book1.author = txtboxAuthor.Text;
            book1.UpdateBook(book1);
            MessageBox.Show("Updation Successfully!!!");
            var dt = book1.ReadBook();
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtboxIsbn.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtboxTitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtboxAuthor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void TxtboxIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var book1 = new Book();
           // book1.isbn = Convert.ToInt32(txtboxIsbn.Text);
            book1.title = txtboxTitle.Text;
            book1.author = txtboxAuthor.Text;
            book1.DeleteBook(book1);
            MessageBox.Show("Record Deleted Successfully!!!");
            var dt = book1.ReadBook();
            dataGridView1.DataSource = dt;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtboxSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "")
            {
                MessageBox.Show("Please Enter ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var b1 = new Book();
                var dt = b1.SearchBook(Convert.ToInt32(txtboxSearch.Text));
                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("The Book not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                txtboxSearch.Text = "";

            }
        }

        private void TxtboxSearch_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dataGridView2.DataSource = dt;
        }
    }
    
}
