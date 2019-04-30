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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ADDOp_Click(object sender, EventArgs e)
        {
            if (CB_insertion.Text == "Beginner") { new Form4().Show();
                this.Hide();
            }
            if (CB_insertion.Text == "Intermediate")
            {
                new FormInsertionI().Show();
                this.Hide();
            }
            if (CB_insertion.Text == "Advanced")
            {
                new FormInsertionA().Show();
                this.Hide();
            }
        }

        private void Insertion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
