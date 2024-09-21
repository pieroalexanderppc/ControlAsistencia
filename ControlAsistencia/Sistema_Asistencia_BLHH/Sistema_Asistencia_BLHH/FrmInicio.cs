using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia_BLHH
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();

            //Primer Cuadro
            this.ptbAgregarEmpleado.MouseEnter += new System.EventHandler(this.ptbAgregarEmpleado_MouseEnter);
            this.ptbAgregarEmpleado.MouseLeave += new System.EventHandler(this.ptbAgregarEmpleado_MouseLeave);

            //Segundo Cuadro
            this.ptbMarcarAsistencia.MouseEnter += new System.EventHandler(this.ptbMarcarAsistencia_MouseEnter);
            this.ptbMarcarAsistencia.MouseLeave += new System.EventHandler(this.ptbMarcarAsistencia_MouseLeave);

            //Tercer Cuadro
            this.ptbDetallesAsistencia.MouseEnter += new System.EventHandler(this.ptbDetallesAsistencia_MouseEnter);
            this.ptbDetallesAsistencia.MouseLeave += new System.EventHandler(this.ptbDetallesAsistencia_MouseLeave);

            //Cuarto Cuadro
            this.ptbEstadistica.MouseEnter += new System.EventHandler(this.ptbEstadistica_MouseEnter);
            this.ptbEstadistica.MouseLeave += new System.EventHandler(this.ptbEstadistica_MouseLeave);
        }

        private void ptbAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            this.Hide();
            frm.ShowDialog();
        }

        private void ptbMarcarAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencias frm = new FrmAsistencias();
            this.Hide();
            frm.ShowDialog();
        }

        private void ptbDetallesAsistencia_Click(object sender, EventArgs e)
        {
            FrmLista frm = new FrmLista();
            this.Hide();
            frm.ShowDialog();
        }

        private void ptbEstadistica_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frm = new FrmEstadisticas();
            this.Hide();
            frm.ShowDialog();
        }

        private void ptbAgregarEmpleado_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.Fixed3D; // Cambia el estilo del borde al pasar el mouse
            pictureBox.BackColor = Color.Black; // Cambia el color del fondo (opcional)
        }

        private void ptbAgregarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.None; // Restaura el estilo del borde al salir el mouse
            pictureBox.BackColor = Color.Transparent; // Restaura el color del fondo (opcional)
        }

        private void ptbMarcarAsistencia_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.Fixed3D; // Cambia el estilo del borde al pasar el mouse
            pictureBox.BackColor = Color.Black; // Cambia el color del fondo (opcional)
        }

        private void ptbMarcarAsistencia_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.None; // Restaura el estilo del borde al salir el mouse
            pictureBox.BackColor = Color.Transparent; // Restaura el color del fondo (opcional)
        }

        private void ptbDetallesAsistencia_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.Fixed3D; // Cambia el estilo del borde al pasar el mouse
            pictureBox.BackColor = Color.Black; // Cambia el color del fondo (opcional)
        }

        private void ptbDetallesAsistencia_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.None; // Restaura el estilo del borde al salir el mouse
            pictureBox.BackColor = Color.Transparent; // Restaura el color del fondo (opcional)
        }

        private void ptbEstadistica_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.Fixed3D; // Cambia el estilo del borde al pasar el mouse
            pictureBox.BackColor = Color.Black; // Cambia el color del fondo (opcional)
        }

        private void ptbEstadistica_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.None; // Restaura el estilo del borde al salir el mouse
            pictureBox.BackColor = Color.Transparent; // Restaura el color del fondo (opcional)
        }
    }
}
