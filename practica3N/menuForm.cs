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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (loginForm login = new loginForm())
            {
                login.ShowDialog();
            }
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RegistrationForm registration = new RegistrationForm())
            {
                registration.ShowDialog();
            }
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CalculatorForm calculator = new CalculatorForm())
            {
                calculator.ShowDialog();
            }
        }
    }
}
