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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbEmail.Text) || string.IsNullOrEmpty(TbPass.Text) || string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(TbLastName.Text) || string.IsNullOrEmpty(TbConfirmPass.Text))
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else if (TbEmail.Text.Contains("@"))
            {
                if ((TbPass.Text) == (TbConfirmPass.Text))
                {


                    MessageBox.Show("El usuario ha sido registrado exitosamente");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
            else
            {
                MessageBox.Show("Porfavor introduzca un correo electronico valido");
            }
        }
    }
}
