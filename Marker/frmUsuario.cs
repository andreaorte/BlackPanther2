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
            txtCodigoHumano.Focus();
        }
        private void LimpiarFormulario()
        {
            txtCodigoHumano.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDocumento.Text = "";
            cboDepartamento.SelectedItem = null;
            cboCargo.SelectedItem = null;
            cboTipoUsuario.SelectedItem = null;
            dtpuFechaIngreso.Value = DateTime.Now;

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {

            ActualizarListaUser();

            cboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            cboDepartamento.DataSource = Departamento.ObtenerDepartamentos();
            cboCargo.DataSource = Cargo.ObtenerCargos();
            cboCargo.SelectedItem = null;
            cboDepartamento.SelectedItem = null;
            cboTipoUsuario.SelectedItem = null;
            BloquearFormulario();
        }

        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCodigoHumano.Enabled = false;
            txtNroDocumento.Enabled = false;
            cboCargo.Enabled = false;
            cboDepartamento.Enabled = false;
            cboTipoUsuario.Enabled = false;
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
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCodigoHumano.Enabled = true;
            txtNroDocumento.Enabled = true;
            cboCargo.Enabled = true;
            cboDepartamento.Enabled = true;
            cboTipoUsuario.Enabled = true;
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
            lstUsuario.DataSource = Usuari.ObtenerUsuario();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
          // var u = ObtenerUserFormulario();

            {
                if (modo == "AGREGAR")
                {
                    Usuari user = ObtenerUserFormulario();
                    Usuari.AgregarUsuario(user);
                }
                else if (modo == "EDITAR")
                {
                    if (this.lstUsuario.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Favor seleccione una fila");
                    }

                    else
                    {
                        
                        int index = lstUsuario.SelectedIndex;
                        Usuari.listarUsuario[index] = ObtenerUserFormulario();
                        
                    }

                }

                LimpiarFormulario();
                ActualizarListaUser();
                BloquearFormulario();


            }
        }

        private Usuari ObtenerUserFormulario()
        {
            Usuari u = new Usuari();
            u.CodigoHumano = txtCodigoHumano.Text;
            u.Nombre = txtNombre.Text;
            u.Apellido= txtApellido.Text;
            u.NroDocumento = txtNroDocumento.Text;
            u.FechaIngreso = dtpuFechaIngreso.Value.Date;
           u.departamento = (Departamento)cboDepartamento.SelectedItem;
            u.cargo = (Cargo)cboCargo.SelectedItem;
            u.tipoUsuario = (TipoUsuario)cboTipoUsuario.SelectedItem;


            return u;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                modo = "EDITAR";
                DesbloquearFormulario();
                txtCodigoHumano.Focus();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (lstUsuario.SelectedItems.Count > 0)
                {
                    Usuari user = (Usuari)lstUsuario.SelectedItem;
                    Usuari.listarUsuario.Remove(user);
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
            Usuari u = (Usuari)lstUsuario.SelectedItem;
            if (u != null)
            {
                txtCodigoHumano.Text = u.CodigoHumano;
                txtNombre.Text = u.Nombre;
                txtApellido.Text = u.Apellido;
                txtNroDocumento.Text = u.NroDocumento;
                cboCargo.SelectedItem = u.cargo;
                cboDepartamento.SelectedItem = u.departamento;
                cboTipoUsuario.SelectedItem = u.tipoUsuario;
                dtpuFechaIngreso.Value = u.FechaIngreso;

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

        private void lstUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuari u = (Usuari)lstUsuario.SelectedItem;

            if (u != null)
            {
                txtNombre.Text = u.Nombre;
                txtApellido.Text = u.Apellido;
                txtCodigoHumano.Text = u.CodigoHumano;
                txtNroDocumento.Text = u.NroDocumento;
                cboDepartamento.SelectedItem = u.departamento;
                cboCargo.SelectedItem = u.cargo;
                cboTipoUsuario.SelectedItem = u.tipoUsuario;
                dtpuFechaIngreso.Value = u.FechaIngreso;

            }


        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodigoHumano.Focus();
        }

        private void lstUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.lstUsuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                modo = "EDITAR";
                DesbloquearFormulario();
                txtCodigoHumano.Focus();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.lstUsuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Usuari u = (Usuari)lstUsuario.SelectedItem;
                Usuari.EliminiarUsuario(u);
                ActualizarListaUser();
                LimpiarFormulario();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (modo == "AGREGAR")
            {
                Usuari usuario = ObtenerUserFormulario();
                Usuari.AgregarUsuario(usuario);
            }
            else if (modo == "EDITAR")
            {
                int index = lstUsuario.SelectedIndex;

                Usuari.listarUsuario[index] = ObtenerUserFormulario();
            }

            ActualizarListaUser();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}
