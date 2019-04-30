using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "GH123")
            {
                if (txtPassword.Text == "123456789")
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Id or Password are incorrect");
                        }
            }
            else
            {
                MessageBox.Show("Error: Id or Password are incorrect"); 
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtID.Text == "GH123")
                {
                    if (txtPassword.Text == "123456789")
                    {
                        new Form2().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: Id or Password are incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Id or Password are incorrect");
                }
            }
        }
    }               
}


