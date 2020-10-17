using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtBoxUsername.Text == "admin") && (txtBoxPassword.Text == "password"))
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error!. Please try again!","error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
