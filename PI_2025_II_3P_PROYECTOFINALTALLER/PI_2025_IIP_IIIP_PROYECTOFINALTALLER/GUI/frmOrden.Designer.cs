namespace PI_IIP_IIIP_PROYECTO_
{
    partial class frmOrden
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrden));
            this.grbEstadoOrden = new System.Windows.Forms.GroupBox();
            this.rbtEnProceso = new System.Windows.Forms.RadioButton();
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.rbtFinalizada = new System.Windows.Forms.RadioButton();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltítulo = new System.Windows.Forms.Label();
            this.cmbSexoCliente = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimientoEmpleado = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverMenuRegistro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbEstadoOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEstadoOrden
            // 
            this.grbEstadoOrden.Controls.Add(this.rbtEnProceso);
            this.grbEstadoOrden.Controls.Add(this.rbtPendiente);
            this.grbEstadoOrden.Controls.Add(this.rbtFinalizada);
            this.grbEstadoOrden.Location = new System.Drawing.Point(217, 209);
            this.grbEstadoOrden.Name = "grbEstadoOrden";
            this.grbEstadoOrden.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoOrden.TabIndex = 51;
            this.grbEstadoOrden.TabStop = false;
            this.grbEstadoOrden.Text = "Orden de Trabajo";
            // 
            // rbtEnProceso
            // 
            this.rbtEnProceso.Location = new System.Drawing.Point(7, 68);
            this.rbtEnProceso.Name = "rbtEnProceso";
            this.rbtEnProceso.Size = new System.Drawing.Size(85, 17);
            this.rbtEnProceso.TabIndex = 0;
            this.rbtEnProceso.TabStop = true;
            this.rbtEnProceso.Text = "En Proceso";
            this.rbtEnProceso.UseVisualStyleBackColor = true;
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.Location = new System.Drawing.Point(7, 44);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(85, 17);
            this.rbtPendiente.TabIndex = 0;
            this.rbtPendiente.TabStop = true;
            this.rbtPendiente.Text = "Pendiente";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtFinalizada
            // 
            this.rbtFinalizada.AutoSize = true;
            this.rbtFinalizada.Location = new System.Drawing.Point(7, 20);
            this.rbtFinalizada.Name = "rbtFinalizada";
            this.rbtFinalizada.Size = new System.Drawing.Size(69, 17);
            this.rbtFinalizada.TabIndex = 0;
            this.rbtFinalizada.TabStop = true;
            this.rbtFinalizada.Text = "finalizada";
            this.rbtFinalizada.UseVisualStyleBackColor = true;
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(47, 506);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.Size = new System.Drawing.Size(728, 150);
            this.dgvResumen.TabIndex = 50;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(217, 414);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(154, 21);
            this.cmbServicio.TabIndex = 43;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(47, 447);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(133, 20);
            this.lblFechaFinal.TabIndex = 36;
            this.lblFechaFinal.Text = "Fecha de Entrega:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(113, 414);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(67, 20);
            this.lblServicio.TabIndex = 35;
            this.lblServicio.Text = "Servicio:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(29, 382);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(151, 20);
            this.lblEmpleado.TabIndex = 34;
            this.lblEmpleado.Text = "Empleado Asignado:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(108, 351);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(72, 20);
            this.lblVehiculo.TabIndex = 33;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(120, 320);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 20);
            this.lblCliente.TabIndex = 32;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(120, 209);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(64, 178);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(116, 20);
            this.lblFechaCreacion.TabIndex = 30;
            this.lblFechaCreacion.Text = "Fecha de Inicio:";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.Location = new System.Drawing.Point(43, 142);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(137, 20);
            this.lblNumeroOrden.TabIndex = 29;
            this.lblNumeroOrden.Text = "Numero de Orden:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(82, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 20);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Ingrese el ID:";
            // 
            // lbltítulo
            // 
            this.lbltítulo.AutoSize = true;
            this.lbltítulo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltítulo.Location = new System.Drawing.Point(278, 43);
            this.lbltítulo.Name = "lbltítulo";
            this.lbltítulo.Size = new System.Drawing.Size(271, 33);
            this.lbltítulo.TabIndex = 27;
            this.lbltítulo.Text = "ORDENES DE TRABAJO";
            // 
            // cmbSexoCliente
            // 
            this.cmbSexoCliente.FormattingEnabled = true;
            this.cmbSexoCliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoCliente.Location = new System.Drawing.Point(217, 110);
            this.cmbSexoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexoCliente.Name = "cmbSexoCliente";
            this.cmbSexoCliente.Size = new System.Drawing.Size(154, 21);
            this.cmbSexoCliente.TabIndex = 83;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(217, 139);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 84;
            // 
            // dtpFechaNacimientoEmpleado
            // 
            this.dtpFechaNacimientoEmpleado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoEmpleado.Location = new System.Drawing.Point(217, 175);
            this.dtpFechaNacimientoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimientoEmpleado.Name = "dtpFechaNacimientoEmpleado";
            this.dtpFechaNacimientoEmpleado.Size = new System.Drawing.Size(157, 20);
            this.dtpFechaNacimientoEmpleado.TabIndex = 85;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox2.Location = new System.Drawing.Point(217, 319);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 86;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox3.Location = new System.Drawing.Point(217, 348);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 21);
            this.comboBox3.TabIndex = 87;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox4.Location = new System.Drawing.Point(217, 382);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(154, 21);
            this.comboBox4.TabIndex = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 447);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverMenuRegistro
            // 
            this.btnVolverMenuRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnVolverMenuRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuRegistro.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.volver;
            this.btnVolverMenuRegistro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolverMenuRegistro.Location = new System.Drawing.Point(599, 356);
            this.btnVolverMenuRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverMenuRegistro.Name = "btnVolverMenuRegistro";
            this.btnVolverMenuRegistro.Size = new System.Drawing.Size(160, 40);
            this.btnVolverMenuRegistro.TabIndex = 95;
            this.btnVolverMenuRegistro.Text = "Volver";
            this.btnVolverMenuRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminar.Location = new System.Drawing.Point(599, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 43);
            this.btnEliminar.TabIndex = 94;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.listar;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListar.Location = new System.Drawing.Point(599, 255);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 43);
            this.btnListar.TabIndex = 93;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(599, 204);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 43);
            this.btnActualizar.TabIndex = 92;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(599, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 43);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(599, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 43);
            this.btnAgregar.TabIndex = 90;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 678);
            this.Controls.Add(this.btnVolverMenuRegistro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dtpFechaNacimientoEmpleado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbSexoCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbEstadoOrden);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbltítulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrden";
            this.Text = "Orden de trabajo";
            this.Load += new System.EventHandler(this.frmOrden_Load);
            this.grbEstadoOrden.ResumeLayout(false);
            this.grbEstadoOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEstadoOrden;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbltítulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSexoCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbtEnProceso;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.RadioButton rbtFinalizada;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoEmpleado;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVolverMenuRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

