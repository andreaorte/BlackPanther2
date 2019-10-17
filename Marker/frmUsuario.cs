using ClasesMarcacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marker
{
    public partial class frmUsuario : Form
    {

        string modo;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void lblINombre_Click(object sender, EventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtuNombre.Focus();
        }
        private void LimpiarFormulario()
        {
            txtuNombre.Text = "";
            txtuCodigoHumano.Text = "";
            cbouDepartamento.SelectedItem = null;
            cbouCargo.SelectedItem = null;
            dtpuFechaIngreso.Value = DateTime.Now;

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            ActualizarListaUser();
            cbouDepartamento.DataSource = Departamento.ObtenerDepartamento();
            cbouCargo.DataSource = Cargo.ObtenerCargo();
            cbouDepartamento.SelectedItem = null;
            cbouCargo.SelectedItem = null;
            BloquearFormulario();
        }

        private void BloquearFormulario()
        {
            txtuNombre.Enabled = false;
            txtuCodigoHumano.Enabled = false;
            cbouDepartamento.Enabled = false;
            cbouCargo.Enabled = false;
            dtpuFechaIngreso.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }



        private void DesbloquearFormulario()
        {
            txtuNombre.Enabled = true;
            txtuCodigoHumano.Enabled = true;
            cbouDepartamento.Enabled = true;
            cbouCargo.Enabled = true;
            dtpuFechaIngreso.Enabled = true;
            
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void ActualizarListaUser()
        {
            lstUsuario.DataSource = null;
            lstUsuario.DataSource = User.ObtenerUser();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
          // var u = ObtenerUserFormulario();

            {
                if (modo == "AGREGAR")
                {
                    User user = ObtenerUserFormulario();
                    User.AgregarUser(user);
                }
                else if (modo == "EDITAR")
                {
                    if (this.lstUsuario.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Favor seleccione una fila");
                    }

                    else
                    {
                        // int indice = lstUsuario.SelectedIndex;
                        //  User.EditarUser(user, indice);
                        int index = lstUsuario.SelectedIndex;
                        User.listaUser[index] = ObtenerUserFormulario();
                        //ActualizarListaUser();
                    }

                }

                LimpiarFormulario();
                ActualizarListaUser();
                BloquearFormulario();


            }
        }

        private User ObtenerUserFormulario()
        {
            User user = new User();
            user.NombreApellido = txtuNombre.Text;
            user.CodigoHumano = txtuCodigoHumano.Text;
            user.FechaIngreso = dtpuFechaIngreso.Value.Date;

            user.Departamento = (Departamento)cbouDepartamento.SelectedItem;
            user.Cargo = (Cargo)cbouCargo.SelectedItem;


            return user;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                modo = "EDITAR";
                DesbloquearFormulario();
                txtuNombre.Focus();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (lstUsuario.SelectedItems.Count > 0)
                {
                    User user = (User)lstUsuario.SelectedItem;
                    User.listaUser.Remove(user);
                    ActualizarListaUser();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar de la lista para eliminar");
                }

            }
        }

        private void lstUsuario_Click(object sender, EventArgs e)
        {
            User user = (User)lstUsuario.SelectedItem;

            if (user != null)
            {
                txtuNombre.Text = user.NombreApellido;
                txtuCodigoHumano.Text = user.CodigoHumano;
                cbouDepartamento.SelectedItem = user.Departamento;
                cbouCargo.SelectedItem = user.Cargo;

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "CANCELAR";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
