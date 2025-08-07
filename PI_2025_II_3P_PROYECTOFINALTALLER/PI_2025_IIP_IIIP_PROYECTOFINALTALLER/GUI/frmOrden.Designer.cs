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
            this.chkProceso = new System.Windows.Forms.CheckBox();
            this.chkPendiente = new System.Windows.Forms.CheckBox();
            this.chkFinalizado = new System.Windows.Forms.CheckBox();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtEmpleadoAsignado = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEstadoOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEstadoOrden
            // 
            this.grbEstadoOrden.Controls.Add(this.chkProceso);
            this.grbEstadoOrden.Controls.Add(this.chkPendiente);
            this.grbEstadoOrden.Controls.Add(this.chkFinalizado);
            this.grbEstadoOrden.Location = new System.Drawing.Point(217, 209);
            this.grbEstadoOrden.Name = "grbEstadoOrden";
            this.grbEstadoOrden.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoOrden.TabIndex = 51;
            this.grbEstadoOrden.TabStop = false;
            this.grbEstadoOrden.Text = "Orden de Trabajo";
            // 
            // chkProceso
            // 
            this.chkProceso.AutoSize = true;
            this.chkProceso.Location = new System.Drawing.Point(7, 67);
            this.chkProceso.Name = "chkProceso";
            this.chkProceso.Size = new System.Drawing.Size(80, 17);
            this.chkProceso.TabIndex = 2;
            this.chkProceso.Text = "En proceso";
            this.chkProceso.UseVisualStyleBackColor = true;
            // 
            // chkPendiente
            // 
            this.chkPendiente.AutoSize = true;
            this.chkPendiente.Location = new System.Drawing.Point(7, 43);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(74, 17);
            this.chkPendiente.TabIndex = 1;
            this.chkPendiente.Text = "Pendiente";
            this.chkPendiente.UseVisualStyleBackColor = true;
            // 
            // chkFinalizado
            // 
            this.chkFinalizado.AutoSize = true;
            this.chkFinalizado.Location = new System.Drawing.Point(7, 19);
            this.chkFinalizado.Name = "chkFinalizado";
            this.chkFinalizado.Size = new System.Drawing.Size(73, 17);
            this.chkFinalizado.TabIndex = 0;
            this.chkFinalizado.Text = "Finalizada";
            this.chkFinalizado.UseVisualStyleBackColor = true;
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(47, 506);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.Size = new System.Drawing.Size(728, 150);
            this.dgvResumen.TabIndex = 50;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(615, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 37);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(615, 256);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 37);
            this.btnListar.TabIndex = 48;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(615, 209);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 37);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(615, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 37);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(615, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 37);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(217, 447);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(154, 20);
            this.txtFechaEntrega.TabIndex = 44;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(217, 414);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(154, 21);
            this.cmbServicio.TabIndex = 43;
            // 
            // txtEmpleadoAsignado
            // 
            this.txtEmpleadoAsignado.Location = new System.Drawing.Point(217, 382);
            this.txtEmpleadoAsignado.Name = "txtEmpleadoAsignado";
            this.txtEmpleadoAsignado.Size = new System.Drawing.Size(154, 20);
            this.txtEmpleadoAsignado.TabIndex = 42;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(217, 351);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(154, 20);
            this.txtVehiculo.TabIndex = 41;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(217, 320);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(154, 20);
            this.txtCliente.TabIndex = 40;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(217, 177);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(154, 20);
            this.txtFechaInicio.TabIndex = 39;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(217, 141);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(154, 20);
            this.txtNumeroOrden.TabIndex = 38;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(217, 111);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 20);
            this.txtID.TabIndex = 37;
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
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbEstadoOrden);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.txtEmpleadoAsignado);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.txtID);
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
            this.grbEstadoOrden.ResumeLayout(false);
            this.grbEstadoOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEstadoOrden;
        private System.Windows.Forms.CheckBox chkProceso;
        private System.Windows.Forms.CheckBox chkPendiente;
        private System.Windows.Forms.CheckBox chkFinalizado;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtEmpleadoAsignado;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.TextBox txtID;
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
    }
}

