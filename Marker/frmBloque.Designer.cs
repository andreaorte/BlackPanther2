namespace Marker
{
    partial class frmBloque
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
            this.lstBloque = new System.Windows.Forms.ListBox();
            this.lblINombre = new System.Windows.Forms.Label();
            this.cbobNombre = new System.Windows.Forms.ComboBox();
            this.lblTipoHora = new System.Windows.Forms.Label();
            this.rbubDiurna = new System.Windows.Forms.RadioButton();
            this.rbubNocturna = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpbFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpbFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblCodigoHumano = new System.Windows.Forms.Label();
            this.txtbCodigoHumano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBloque
            // 
            this.lstBloque.FormattingEnabled = true;
            this.lstBloque.Location = new System.Drawing.Point(30, 30);
            this.lstBloque.Name = "lstBloque";
            this.lstBloque.Size = new System.Drawing.Size(242, 368);
            this.lstBloque.TabIndex = 39;
            this.lstBloque.SelectedIndexChanged += new System.EventHandler(this.lstBloque_SelectedIndexChanged);
            // 
            // lblINombre
            // 
            this.lblINombre.AutoSize = true;
            this.lblINombre.Location = new System.Drawing.Point(294, 34);
            this.lblINombre.Name = "lblINombre";
            this.lblINombre.Size = new System.Drawing.Size(47, 13);
            this.lblINombre.TabIndex = 54;
            this.lblINombre.Text = "Nombre:";
            // 
            // cbobNombre
            // 
            this.cbobNombre.FormattingEnabled = true;
            this.cbobNombre.Location = new System.Drawing.Point(386, 30);
            this.cbobNombre.Name = "cbobNombre";
            this.cbobNombre.Size = new System.Drawing.Size(170, 21);
            this.cbobNombre.TabIndex = 62;
            // 
            // lblTipoHora
            // 
            this.lblTipoHora.AutoSize = true;
            this.lblTipoHora.Location = new System.Drawing.Point(294, 120);
            this.lblTipoHora.Name = "lblTipoHora";
            this.lblTipoHora.Size = new System.Drawing.Size(69, 13);
            this.lblTipoHora.TabIndex = 63;
            this.lblTipoHora.Text = "Tipo de Hora";
            // 
            // rbubDiurna
            // 
            this.rbubDiurna.AutoSize = true;
            this.rbubDiurna.Location = new System.Drawing.Point(392, 120);
            this.rbubDiurna.Name = "rbubDiurna";
            this.rbubDiurna.Size = new System.Drawing.Size(56, 17);
            this.rbubDiurna.TabIndex = 64;
            this.rbubDiurna.TabStop = true;
            this.rbubDiurna.Text = "Diurna";
            this.rbubDiurna.UseVisualStyleBackColor = true;
            // 
            // rbubNocturna
            // 
            this.rbubNocturna.AutoSize = true;
            this.rbubNocturna.Location = new System.Drawing.Point(464, 120);
            this.rbubNocturna.Name = "rbubNocturna";
            this.rbubNocturna.Size = new System.Drawing.Size(69, 17);
            this.rbubNocturna.TabIndex = 65;
            this.rbubNocturna.TabStop = true;
            this.rbubNocturna.Text = "Nocturna";
            this.rbubNocturna.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 424);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(125, 424);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(206, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(312, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(481, 242);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpbFechaInicio
            // 
            this.dtpbFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpbFechaInicio.Location = new System.Drawing.Point(386, 158);
            this.dtpbFechaInicio.Name = "dtpbFechaInicio";
            this.dtpbFechaInicio.Size = new System.Drawing.Size(170, 20);
            this.dtpbFechaInicio.TabIndex = 72;
            this.dtpbFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpbFechaFin
            // 
            this.dtpbFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpbFechaFin.Location = new System.Drawing.Point(386, 191);
            this.dtpbFechaFin.Name = "dtpbFechaFin";
            this.dtpbFechaFin.Size = new System.Drawing.Size(170, 20);
            this.dtpbFechaFin.TabIndex = 73;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(301, 165);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(35, 13);
            this.lblInicio.TabIndex = 74;
            this.lblInicio.Text = "Inicio:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(301, 198);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(24, 13);
            this.lblFin.TabIndex = 75;
            this.lblFin.Text = "Fin:";
            // 
            // lblCodigoHumano
            // 
            this.lblCodigoHumano.AutoSize = true;
            this.lblCodigoHumano.Location = new System.Drawing.Point(294, 79);
            this.lblCodigoHumano.Name = "lblCodigoHumano";
            this.lblCodigoHumano.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoHumano.TabIndex = 76;
            this.lblCodigoHumano.Text = "Codigo Humano";
            // 
            // txtbCodigoHumano
            // 
            this.txtbCodigoHumano.Location = new System.Drawing.Point(386, 76);
            this.txtbCodigoHumano.Name = "txtbCodigoHumano";
            this.txtbCodigoHumano.Size = new System.Drawing.Size(170, 20);
            this.txtbCodigoHumano.TabIndex = 77;
            // 
            // frmBloque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 486);
            this.Controls.Add(this.txtbCodigoHumano);
            this.Controls.Add(this.lblCodigoHumano);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpbFechaFin);
            this.Controls.Add(this.dtpbFechaInicio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbubNocturna);
            this.Controls.Add(this.rbubDiurna);
            this.Controls.Add(this.lblTipoHora);
            this.Controls.Add(this.cbobNombre);
            this.Controls.Add(this.lblINombre);
            this.Controls.Add(this.lstBloque);
            this.Name = "frmBloque";
            this.Text = "frmBloque";
            this.Load += new System.EventHandler(this.frmBloque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBloque;
        private System.Windows.Forms.Label lblINombre;
        private System.Windows.Forms.ComboBox cbobNombre;
        private System.Windows.Forms.Label lblTipoHora;
        private System.Windows.Forms.RadioButton rbubDiurna;
        private System.Windows.Forms.RadioButton rbubNocturna;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpbFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpbFechaFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblCodigoHumano;
        private System.Windows.Forms.TextBox txtbCodigoHumano;
    }
}