using Sistema_Asistencia_BLHH.DataClase;
using Sistema_Asistencia_BLHH.Modelo;
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
using Sistema_Asistencia_BLHH.Clases;

namespace Sistema_Asistencia_BLHH
{
    public partial class FrmAsistencias : Form
    {
        private ClsEmpleado Empleados = new ClsEmpleado();

        public FrmAsistencias()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.DataSource = Empleados.ListarDia();
        }


        private void btnMarcar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;

            try
            {
                using (DataClasesResumenDataContext dc = new DataClasesResumenDataContext())
                {
                    // Llamada al procedimiento almacenado SP_MarcarAsistencia
                    dc.SP_MarcarAsistencia(nombre, dni);

                    DateTime fechaSeleccionada = DateTime.Now.Date;
                    var query = dc.SP_BuscarAsistenciasPorDia(fechaSeleccionada);

                    dgvLista.DataSource = query;

                    MessageBox.Show("Asistencia marcada correctamente.", "Resultado de Marcar Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DataClasesResumenDataContext dc = new DataClasesResumenDataContext();
            dc.SP_ObtenerFaltasPorEmpleado("");
            FrmInicio frm = new FrmInicio();
            this.Dispose();
            frm.ShowDialog();
        }
    }
}
