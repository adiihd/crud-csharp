using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            txtPass.BackColor = SystemColors.Control;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            txtUser.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;


        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            pictureBox4.Image = Properties.Resources.view;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            pictureBox4.Image = Properties.Resources.hide;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
