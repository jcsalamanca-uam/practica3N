using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3N
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbUser.Text) || string.IsNullOrEmpty(TbPass.Text))
            {
                MessageBox.Show("Porfavor llene ambos campos.");
            }
            if ((TbUser.Text == "admin") && (TbPass.Text == "1234"))
            {
                MessageBox.Show("Bienvenido, Admin");
            }

        }
    }
}
