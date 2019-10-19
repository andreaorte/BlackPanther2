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
        string modo;
        public frmMarcacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cboEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Favor seleccione un Empleado");
            }
            else if (txtMarcacionEntrada.Text=="")  
            {
                modo = "entrada";
                var m = ObtenerFormularioMarcacion();
                //DateTime hora;
                //hora = DateTime.Now;
                //txtMarcacionEntrada.Text = hora.ToShortTimeString();
                Marcacion.AgregarMarcacion(m);
                MessageBox.Show("Entrada Marcada Exitosamente");
                DesbloquearSalida();
                ActualizarListaMarcacion();
                BloquearEntrada();
                DesbloquearSalida();
            }
            
           
            
        }

        private void DesbloquearSalida()
        {
            btnMarcarSalida.Enabled = true;
        }

        private Marcacion ObtenerFormularioMarcacion()
        {
            
            if (modo == "entrada")
            {
                DateTime hora;
                hora = DateTime.Now;
                txtMarcacionEntrada.Text = hora.ToShortTimeString();
            }
            else if (modo=="salida")
            {
                DateTime hora;
                hora = DateTime.Now;
                txtMarcacionSalida.Text = hora.ToShortTimeString();
            }
            Marcacion m = new Marcacion();
            m.empleado = (Usuari)cboEmpleado.SelectedItem;
            m.MarcacionEntrada = txtMarcacionEntrada.Text;
            m.MarcacionSalida = txtMarcacionSalida.Text;
           
            return m;
        }

        private void BloquearEntrada()
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
                cboEmpleado.SelectedItem = m.empleado;
                txtMarcacionEntrada.Text = m.MarcacionEntrada;
                txtMarcacionSalida.Text = m.MarcacionSalida;
                if ( txtMarcacionEntrada.Text != "" && txtMarcacionSalida.Text != "" )
                {
                    BloquearEntrada();
                    BloquearSalida();
                }
                else if ( txtMarcacionSalida.Text =="" && txtMarcacionEntrada.Text != "")
                {
                    DesbloquearSalida();
                    BloquearEntrada();
                }
                
             
            }
           

           
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            modo = "salida";
            if (this.lstMarcacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                if (txtMarcacionSalida.Text != "")
                {
                    //MessageBox.Show("Usted ya marco su salida");
                    btnMarcarSalida.Enabled = false;

                }
                else if (txtMarcacionSalida.Text == "")
                
                {

                    //int indice = lstDepartamento.SelectedIndex;
                    //Departamento.EditarDepartamento(d, indice);
                    //ActualizarListaDepartamentos();

                    int index = lstMarcacion.SelectedIndex;
                    //DateTime hora;
                    //hora = DateTime.Now;
                    //txtMarcacionSalida.Text = hora.ToShortTimeString();
                    Marcacion.listaMarcacion[index] = ObtenerFormularioMarcacion();
                    ActualizarListaMarcacion();
                    MessageBox.Show("Salida Marcada Exitosamente");
                    BloquearSalida();

                }
            }




        }

        

        private void BloquearSalida()
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

        private void txtMarcacionSalida_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
