namespace Marker
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUsuario = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblINombre = new System.Windows.Forms.Label();
            this.lblCodigoHumano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuNombre = new System.Windows.Forms.TextBox();
            this.txtuCodigoHumano = new System.Windows.Forms.TextBox();
            this.cbouDepartamento = new System.Windows.Forms.ComboBox();
            this.cbouCargo = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpuFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstUsuario
            // 
            this.lstUsuario.FormattingEnabled = true;
            this.lstUsuario.Location = new System.Drawing.Point(21, 12);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Size = new System.Drawing.Size(242, 316);
            this.lstUsuario.TabIndex = 38;
            this.lstUsuario.SelectedIndexChanged += new System.EventHandler(this.lstUsuario_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(287, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(385, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(480, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 358);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(101, 358);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(182, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblINombre
            // 
            this.lblINombre.AutoSize = true;
            this.lblINombre.Location = new System.Drawing.Point(277, 25);
            this.lblINombre.Name = "lblINombre";
            this.lblINombre.Size = new System.Drawing.Size(95, 13);
            this.lblINombre.TabIndex = 53;
            this.lblINombre.Text = "Nombre y Apellido:";
            this.lblINombre.Click += new System.EventHandler(this.lblINombre_Click);
            // 
            // lblCodigoHumano
            // 
            this.lblCodigoHumano.AutoSize = true;
            this.lblCodigoHumano.Location = new System.Drawing.Point(277, 65);
            this.lblCodigoHumano.Name = "lblCodigoHumano";
            this.lblCodigoHumano.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoHumano.TabIndex = 55;
            this.lblCodigoHumano.Text = "Codigo Humano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cargo:";
            // 
            // txtuNombre
            // 
            this.txtuNombre.Location = new System.Drawing.Point(385, 25);
            this.txtuNombre.Name = "txtuNombre";
            this.txtuNombre.Size = new System.Drawing.Size(267, 20);
            this.txtuNombre.TabIndex = 58;
            // 
            // txtuCodigoHumano
            // 
            this.txtuCodigoHumano.Location = new System.Drawing.Point(385, 58);
            this.txtuCodigoHumano.Name = "txtuCodigoHumano";
            this.txtuCodigoHumano.Size = new System.Drawing.Size(170, 20);
            this.txtuCodigoHumano.TabIndex = 60;
            // 
            // cbouDepartamento
            // 
            this.cbouDepartamento.FormattingEnabled = true;
            this.cbouDepartamento.Location = new System.Drawing.Point(385, 105);
            this.cbouDepartamento.Name = "cbouDepartamento";
            this.cbouDepartamento.Size = new System.Drawing.Size(170, 21);
            this.cbouDepartamento.TabIndex = 61;
            this.cbouDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // cbouCargo
            // 
            this.cbouCargo.FormattingEnabled = true;
            this.cbouCargo.Location = new System.Drawing.Point(385, 138);
            this.cbouCargo.Name = "cbouCargo";
            this.cbouCargo.Size = new System.Drawing.Size(170, 21);
            this.cbouCargo.TabIndex = 62;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(281, 177);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 63;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpuFechaIngreso
            // 
            this.dtpuFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpuFechaIngreso.Location = new System.Drawing.Point(385, 177);
            this.dtpuFechaIngreso.Name = "dtpuFechaIngreso";
            this.dtpuFechaIngreso.Size = new System.Drawing.Size(170, 20);
            this.dtpuFechaIngreso.TabIndex = 64;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 398);
            this.Controls.Add(this.dtpuFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.cbouCargo);
            this.Controls.Add(this.cbouDepartamento);
            this.Controls.Add(this.txtuCodigoHumano);
            this.Controls.Add(this.txtuNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoHumano);
            this.Controls.Add(this.lblINombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstUsuario);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblINombre;
        private System.Windows.Forms.Label lblCodigoHumano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuNombre;
        private System.Windows.Forms.TextBox txtuCodigoHumano;
        private System.Windows.Forms.ComboBox cbouDepartamento;
        private System.Windows.Forms.ComboBox cbouCargo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpuFechaIngreso;
    }
}