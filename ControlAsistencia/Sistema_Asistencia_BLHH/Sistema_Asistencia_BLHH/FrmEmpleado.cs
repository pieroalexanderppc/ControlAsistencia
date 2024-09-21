using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Asistencia_BLHH.Clases;
using Sistema_Asistencia_BLHH;
using Sistema_Asistencia_BLHH.DataClase;

namespace Sistema_Asistencia_BLHH
{
    public partial class FrmEmpleado : Form
    {
        private static int id = 0;
        private ClsEmpleado Empleados = new ClsEmpleado();
        DataClase.Empleado objEmpleado = new DataClase.Empleado();
        DataClase.Empleado_Puesto objempleadoPuesto = new DataClase.Empleado_Puesto();

        public FrmEmpleado()
        {
            InitializeComponent();
            ptbMasculino.Visible = false;
            ptbFemenino.Visible = false;
            Listar();
        }

        private void Limpiar()
        {
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            cmbArea.SelectedIndex = -1;
            cmbPuesto.SelectedIndex = -1;
        }

        private void Listar()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.DataSource = Empleados.ListarEmpleados();
        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            Hide();
            frmInicio.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Empleado con los datos del nuevo empleado
                objEmpleado.Nombre = txtNombre.Text;
                objEmpleado.Apellido = txtApellido.Text;
                objEmpleado.DNI = txtDni.Text;
                objEmpleado.Telefono = txtCelular.Text;
                //AREA
                if (cmbArea.SelectedIndex >= 0) 
                {
                    int idAreaSeleccionada = Convert.ToInt32(cmbArea.SelectedValue);
                    objEmpleado.IdArea = idAreaSeleccionada;
                }
                //Puesto
                if (cmbPuesto.SelectedIndex >= 0)
                {
                    int idPuestoSeleccionado = Convert.ToInt32(cmbArea.SelectedValue);
                    objempleadoPuesto.IdPuesto = idPuestoSeleccionado;
                }
                //Estado
                if (rbtnActivo.Checked == true)
                {
                    objEmpleado.Estado = 'A';
                }
                else if (rbtnInactivo.Checked == true)
                {
                    objEmpleado.Estado = 'I';
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion en Estado: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Gerenro
                if (rbtnMasculino.Checked == true)
                {
                    objEmpleado.Genero = 'M';
                }
                else if(rbtnFemenino.Checked == true)
                {
                    objEmpleado.Genero = 'F';
                }
                // Llamar al método InsertarEmpleado para agregar el nuevo empleado a la base de datos
                Empleados.InsertarEmpleado(objEmpleado);
                // Limpiar los campos después de agregar el empleado
                Limpiar();
                Listar();
                // Mostrar un mensaje de éxito
                MessageBox.Show("Empleado agregado correctamente.", "Gestion de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de inserción
                MessageBox.Show("Error al agregar el empleado: " + ex.Message, "Gestion de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                objEmpleado.IdEmpleado = id;
                objEmpleado.Nombre = txtNombre.Text;
                objEmpleado.Apellido = txtApellido.Text;
                objEmpleado.DNI = txtDni.Text;
                objEmpleado.Telefono = txtCelular.Text;
                //AREA
                if (cmbArea.SelectedIndex >= 0)
                {
                    int idAreaSeleccionada = Convert.ToInt32(cmbArea.SelectedValue);
                    objEmpleado.IdArea = idAreaSeleccionada;
                }
                //Puesto
                if (cmbPuesto.SelectedIndex >= 0)
                {
                    int idPuestoSeleccionado = Convert.ToInt32(cmbArea.SelectedValue);
                    objempleadoPuesto.IdPuesto = idPuestoSeleccionado;
                }
                //Estado
                if (rbtnActivo.Checked == true)
                {
                    objEmpleado.Estado = 'A';
                }
                else if (rbtnInactivo.Checked == true)
                {
                    objEmpleado.Estado = 'I';
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion en Estado: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Gerenro
                if (rbtnMasculino.Checked == true)
                {
                    objEmpleado.Genero = 'M';
                }
                else if (rbtnFemenino.Checked == true)
                {
                    objEmpleado.Genero = 'F';
                }

                Empleados.ModificarEmpleado(objEmpleado);
                Limpiar();
                MessageBox.Show("El Registro se ha Modificado correctamente..!", "Gestion de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eliminar a el empleado...", "Gestion de Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (id != 0)
                {
                    Empleados.EliminarEmpleado(id);
                    Limpiar();
                    MessageBox.Show("El Registro se ha eliminado correctamente..!", "Gestion de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            ListarComboArea();
            ListarComboPuesto();
        }

        public void ListarComboArea()
        {
            // Obtener la lista de áreas usando el método ObtenerListaDeAreas de ClsEmpleado
            List<Sistema_Asistencia_BLHH.Modelo.Area> listaAreas = Empleados.ObtenerListaDeAreas().Select(a => new Sistema_Asistencia_BLHH.Modelo.Area
            {
                IdArea = a.IdArea,
                NombreArea = a.NombreArea,
                Descripcion = a.Descripcion
            }).ToList();
            // Asignar la lista de áreas al combobox
            cmbArea.DataSource = listaAreas;
            // Configurar el campo que se mostrará en el combobox (nombre del área)
            cmbArea.DisplayMember = "NombreArea";
            // Configurar el campo que se utilizará como valor seleccionado (IdArea)
            cmbArea.ValueMember = "IdArea";
        }

        public void ListarComboPuesto()
        {
            List<Sistema_Asistencia_BLHH.Modelo.Puesto> listaPuestos = Empleados.ObtenerListaDePuestos().Select(p => new Sistema_Asistencia_BLHH.Modelo.Puesto
            {
                IdPuesto = p.IdPuesto,
                NombrePuesto = p.NombrePuesto,
                Descripcion = p.Descripcion
            }).ToList();
            cmbPuesto.DataSource = listaPuestos;
            cmbPuesto.DisplayMember = "NombrePuesto";
            cmbPuesto.ValueMember = "IdPuesto";
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            ptbMasculino.Visible = true;
            ptbFemenino.Visible = false;
        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            ptbMasculino.Visible = false;
            ptbFemenino.Visible = true;
        }

        private void Obtener(int id)
        {
            
            Empleado objEmpleado = Empleados.ObtenerEmpleado(id);
            txtNombre.Text = objEmpleado.Nombre;
            txtApellido.Text = objEmpleado.Apellido;
            txtDni.Text = objEmpleado.DNI;
            txtCelular.Text = objEmpleado.Telefono;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    Obtener(id);
                }
            }
        }
    }
}
