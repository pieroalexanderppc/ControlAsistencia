using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Asistencia_BLHH.DataClase;

namespace Sistema_Asistencia_BLHH
{
    public partial class Login : Form
    {
        String Usu, Pass;

        public Login()
        {
            InitializeComponent();
        }

        public bool ValidarUsuario(string Usuario, string Password)
        {
            DataClasesResumenDataContext dc = new DataClasesResumenDataContext();
            var query = new List<SP_LoginUsuarioResult>();

            query = dc.SP_LoginUsuario(Usuario, Password).ToList();

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usu = txtUsuario.Text;
            Pass = txtPasword.Text;
            if (ValidarUsuario(Usu, Pass))
            {
                MessageBox.Show("Bienvenido: " + Usu, "Login de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmInicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Password Incorrectos..!", "Login de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
