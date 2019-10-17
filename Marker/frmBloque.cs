
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesMarcacion;
namespace Marker
{
    public partial class frmBloque : Form
    {

        string modo;

    
        public frmBloque()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var b = ObtenerBloqueFormulario();


            if (modo == "AGREGAR")
            {
                Bloque.AgregarBloque(b);
            }
            else if (modo == "EDITAR")
            {

                if (this.lstBloque.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstBloque.SelectedIndex;
                    Bloque.EditarBloque(b, indice);
                    ActualizarListaBloque();
                }


            }
            LimpiarFormulario();
            ActualizarListaBloque();
            BloquearFormulario();
        }

        private Bloque ObtenerBloqueFormulario()
        {
            Bloque bloque = new Bloque();
            bloque.CodigoHumano = txtbCodigoHumano.Text;
            bloque.FechaInicio = dtpbFechaInicio.Value.Date;
            bloque.FechaFin = dtpbFechaFin.Value.Date;

            bloque.NombreUsuario = (User)cbobNombre.SelectedItem;


            if (rbubDiurna.Checked)
            {
                bloque.Tipo_Hora = TipoHora.Diurna;
            }
            else if (rbubNocturna.Checked)
            {
                bloque.Tipo_Hora = TipoHora.Nocturna;
            }

            return bloque;
        }

        private void LimpiarFormulario()
        {
            cbobNombre.SelectedItem = null;
            txtbCodigoHumano.Text = "";
            rbubDiurna.Checked = false;
            rbubNocturna.Checked = false;
            dtpbFechaInicio.Value = DateTime.Now;
            dtpbFechaFin.Value = DateTime.Now;

        }
        private void frmBloque_Load(object sender, EventArgs e)
        {

            ActualizarListaBloque();
            cbobNombre.DataSource = User.ObtenerUser();
            cbobNombre.SelectedItem = null;
            BloquearFormulario();
        }



        private void BloquearFormulario()
        {
            cbobNombre.Enabled = false;
            txtbCodigoHumano.Enabled = false;
            rbubDiurna.Enabled = false;
            rbubNocturna.Enabled = false;
            dtpbFechaInicio.Enabled = false;
            dtpbFechaFin.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void DesbloquearFormulario()
        {
            cbobNombre.Enabled = true;
            txtbCodigoHumano.Enabled = true;
            rbubDiurna.Enabled = true;
            rbubNocturna.Enabled = true;
            dtpbFechaInicio.Enabled = true;
            dtpbFechaFin.Enabled = true;
            
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ActualizarListaBloque()
        {
            lstBloque.DataSource = null;
            lstBloque.DataSource = Bloque.ObtenerBloque();
        }

        


        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (this.lstBloque.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                modo = "EDITAR";
                DesbloquearFormulario();
                cbobNombre.Focus();
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (lstBloque.SelectedItems.Count > 0)
                {
                    Bloque bloque = (Bloque)lstBloque.SelectedItem;
                    Bloque.listaBloque.Remove(bloque);
                    ActualizarListaBloque();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar de la lista para eliminar");
                }

            }
        }

        private void lstBloque_Click(object sender, EventArgs e)
        {
            Bloque bloque = (Bloque)lstBloque.SelectedItem;

            if (bloque != null)
            {
                cbobNombre.SelectedItem = bloque.NombreUsuario;
                txtbCodigoHumano.Text = bloque.CodigoHumano;


                if (bloque.Tipo_Hora == TipoHora.Diurna)
                {
                    rbubDiurna.Checked = true;
                }
                else if (bloque.Tipo_Hora == TipoHora.Nocturna)
                {
                    rbubNocturna.Checked = true;
                }





            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "CANCELAR";
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            {
                if (modo == "AGREGAR")
                {
                    Bloque bloque = ObtenerBloqueFormulario();
                    Bloque.AgregarBloque(bloque);
                }
                else if (modo == "EDITAR")
                {
                    int index = lstBloque.SelectedIndex;

                    Bloque.listaBloque[index] = ObtenerBloqueFormulario();
                }

                ActualizarListaBloque();
                LimpiarFormulario();
                BloquearFormulario();
            }

        }


    }
}
