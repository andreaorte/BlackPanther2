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
    public partial class frmMarcacion : Form
    {
        public frmMarcacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hora;
            
            
            hora = DateTime.Now;
            txtMarcacionEntrada.Text = hora.ToShortTimeString();
            Marcacion m = ObtenerFormularioMarcacion();
            Marcacion.AgregarMarcacion(m);
            ActualizarListaMarcacion();          
            MessageBox.Show("Entrada MarcadaExitosamente");
            DesbloquearFormulario();
            BloquearFormulario();

        }

        private void DesbloquearFormulario()
        {
            btnMarcarSalida.Enabled = true;
        }

        private Marcacion ObtenerFormularioMarcacion()
        {
            Marcacion m = new Marcacion();
            m.empleado = (Usuari)cboEmpleado.SelectedItem;
            m.MarcacionEntrada = txtMarcacionEntrada.Text;
            m.MarcacionSalida = txtMarcacionSalida.Text;
           
            return m;
        }

        private void BloquearFormulario()
        {
            btnMarcarEntrada.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                    }

        private void btnHoraActual_Click(object sender, EventArgs e)
        {
          
           
            lblHoraActual.Text = DateTime.Now.ToShortTimeString();
        }

        private void frmMarcacion_Load(object sender, EventArgs e)
        {
           ActualizarListaMarcacion();
            BloquearFormulario2();
            cboEmpleado.DataSource = Usuari.ObtenerUsuario();
            cboEmpleado.SelectedItem = null;
        }

        private void ActualizarListaMarcacion()
        {

            lstMarcacion.DataSource = null;
            lstMarcacion.DataSource = Marcacion.ObtenerMarcacion();
        }

        private void lblMarcacionEntrada_Click(object sender, EventArgs e)
        {

        }

        private void lstMarcacion_Click(object sender, EventArgs e)
        {
            Marcacion m = (Marcacion)lstMarcacion.SelectedItem;
            if (m != null)
            {
                
                txtMarcacionEntrada.Text = m.MarcacionEntrada;
                cboEmpleado.SelectedItem = m.empleado;
                txtMarcacionSalida.Text = m.MarcacionSalida;
                btnMarcarEntrada.Enabled = false;
             
            }
            //if (txtMarcacionSalida.Text != "")
            //{
            //    BloquearFormulario2();
            //}

           
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            DateTime hora;
            hora = DateTime.Now;
            if (this.lstMarcacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                if (txtMarcacionSalida.Text != "")
                {
                    MessageBox.Show("Usted ya marco su salida");

                }
                else
                { 
                txtMarcacionSalida.Text = hora.ToShortTimeString();
                int index = lstMarcacion.SelectedIndex;
                Marcacion.listaMarcacion[index] = ObtenerFormularioMarcacion();
                BloquearFormulario2();
                ActualizarListaMarcacion();
                MessageBox.Show("Salida Marcada Exitosamente");
                }
            }




        }

        

        private void BloquearFormulario2()
        {
            btnMarcarSalida.Enabled = false;
        }

        private void lstMarcacion_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                
            }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtMarcacionEntrada.Text = "";
            txtMarcacionSalida.Text = "";
            btnMarcarEntrada.Enabled = true;
        }
    }
}
