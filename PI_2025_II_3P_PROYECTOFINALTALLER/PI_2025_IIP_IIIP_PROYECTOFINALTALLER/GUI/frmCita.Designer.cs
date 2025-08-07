namespace PI_IIP_IIIP_PROYECTO_.GUI
{
    partial class frmCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCita));
            this.grbEstadoCita = new System.Windows.Forms.GroupBox();
            this.chkDenegada = new System.Windows.Forms.CheckBox();
            this.chkAprobada = new System.Windows.Forms.CheckBox();
            this.chkPendiente = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.lbltítulo = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtMotivoVisita = new System.Windows.Forms.TextBox();
            this.txtIDCita = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblEstadoCita = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lbHoraFecha = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.lblIDcita = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEstadoCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEstadoCita
            // 
            this.grbEstadoCita.Controls.Add(this.chkDenegada);
            this.grbEstadoCita.Controls.Add(this.chkAprobada);
            this.grbEstadoCita.Controls.Add(this.chkPendiente);
            this.grbEstadoCita.Location = new System.Drawing.Point(294, 281);
            this.grbEstadoCita.Name = "grbEstadoCita";
            this.grbEstadoCita.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoCita.TabIndex = 79;
            this.grbEstadoCita.TabStop = false;
            this.grbEstadoCita.Text = "Agenda de citas";
            // 
            // chkDenegada
            // 
            this.chkDenegada.AutoSize = true;
            this.chkDenegada.Location = new System.Drawing.Point(7, 62);
            this.chkDenegada.Name = "chkDenegada";
            this.chkDenegada.Size = new System.Drawing.Size(76, 17);
            this.chkDenegada.TabIndex = 2;
            this.chkDenegada.Text = "Denegada";
            this.chkDenegada.UseVisualStyleBackColor = true;
            // 
            // chkAprobada
            // 
            this.chkAprobada.AutoSize = true;
            this.chkAprobada.Location = new System.Drawing.Point(7, 38);
            this.chkAprobada.Name = "chkAprobada";
            this.chkAprobada.Size = new System.Drawing.Size(72, 17);
            this.chkAprobada.TabIndex = 1;
            this.chkAprobada.Text = "Aprobada";
            this.chkAprobada.UseVisualStyleBackColor = true;
            // 
            // chkPendiente
            // 
            this.chkPendiente.AutoSize = true;
            this.chkPendiente.Location = new System.Drawing.Point(7, 14);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(74, 17);
            this.chkPendiente.TabIndex = 0;
            this.chkPendiente.Text = "Pendiente";
            this.chkPendiente.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(294, 449);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(154, 20);
            this.txtObservaciones.TabIndex = 78;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(294, 183);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(154, 20);
            this.txtFechaHora.TabIndex = 77;
            // 
            // lbltítulo
            // 
            this.lbltítulo.AutoSize = true;
            this.lbltítulo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltítulo.Location = new System.Drawing.Point(336, 11);
            this.lbltítulo.Name = "lbltítulo";
            this.lbltítulo.Size = new System.Drawing.Size(217, 33);
            this.lbltítulo.TabIndex = 76;
            this.lbltítulo.Text = "AGENDA DE CITAS";
            // 
            // dgvResumen
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResumen.Location = new System.Drawing.Point(56, 518);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.Size = new System.Drawing.Size(728, 156);
            this.dgvResumen.TabIndex = 75;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(624, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 43);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(624, 223);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 43);
            this.btnListar.TabIndex = 73;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(624, 172);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 43);
            this.btnActualizar.TabIndex = 72;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(624, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 43);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(624, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 43);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(294, 408);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(154, 20);
            this.txtEmpleado.TabIndex = 69;
            // 
            // txtMotivoVisita
            // 
            this.txtMotivoVisita.Location = new System.Drawing.Point(294, 249);
            this.txtMotivoVisita.Name = "txtMotivoVisita";
            this.txtMotivoVisita.Size = new System.Drawing.Size(154, 20);
            this.txtMotivoVisita.TabIndex = 68;
            // 
            // txtIDCita
            // 
            this.txtIDCita.Location = new System.Drawing.Point(294, 215);
            this.txtIDCita.Name = "txtIDCita";
            this.txtIDCita.Size = new System.Drawing.Size(154, 20);
            this.txtIDCita.TabIndex = 67;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(294, 146);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(154, 20);
            this.txtPlaca.TabIndex = 66;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(294, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(154, 20);
            this.txtTelefono.TabIndex = 65;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(294, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 20);
            this.txtID.TabIndex = 64;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(72, 109);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(216, 20);
            this.lblTelefono.TabIndex = 63;
            this.lblTelefono.Text = "Ingrese su número telefónico:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(170, 449);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(114, 20);
            this.lblObservaciones.TabIndex = 62;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(133, 408);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(151, 20);
            this.lblEmpleado.TabIndex = 61;
            this.lblEmpleado.Text = "Empleado Asignado:";
            // 
            // lblEstadoCita
            // 
            this.lblEstadoCita.AutoSize = true;
            this.lblEstadoCita.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCita.Location = new System.Drawing.Point(157, 281);
            this.lblEstadoCita.Name = "lblEstadoCita";
            this.lblEstadoCita.Size = new System.Drawing.Size(131, 20);
            this.lblEstadoCita.TabIndex = 60;
            this.lblEstadoCita.Text = "Estado de su cita:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(162, 249);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(122, 20);
            this.lblMotivo.TabIndex = 59;
            this.lblMotivo.Text = "Motivo de visita:";
            // 
            // lbHoraFecha
            // 
            this.lbHoraFecha.AutoSize = true;
            this.lbHoraFecha.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraFecha.Location = new System.Drawing.Point(32, 181);
            this.lbHoraFecha.Name = "lbHoraFecha";
            this.lbHoraFecha.Size = new System.Drawing.Size(252, 20);
            this.lbHoraFecha.TabIndex = 58;
            this.lbHoraFecha.Text = "Ingrese la hora y la fecha de la cita:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(150, 146);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(138, 20);
            this.lblPlacaVehiculo.TabIndex = 57;
            this.lblPlacaVehiculo.Text = "Placa del vehículo:";
            // 
            // lblIDcita
            // 
            this.lblIDcita.AutoSize = true;
            this.lblIDcita.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDcita.Location = new System.Drawing.Point(139, 215);
            this.lblIDcita.Name = "lblIDcita";
            this.lblIDcita.Size = new System.Drawing.Size(149, 20);
            this.lblIDcita.TabIndex = 56;
            this.lblIDcita.Text = "Ingrese ID de la cita:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(206, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 20);
            this.lblID.TabIndex = 55;
            this.lblID.Text = "ID cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbEstadoCita);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.lbltítulo);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtMotivoVisita);
            this.Controls.Add(this.txtIDCita);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblEstadoCita);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lbHoraFecha);
            this.Controls.Add(this.lblPlacaVehiculo);
            this.Controls.Add(this.lblIDcita);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCita";
            this.Text = "Registro de citas";
            this.grbEstadoCita.ResumeLayout(false);
            this.grbEstadoCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEstadoCita;
        private System.Windows.Forms.CheckBox chkDenegada;
        private System.Windows.Forms.CheckBox chkAprobada;
        private System.Windows.Forms.CheckBox chkPendiente;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtFechaHora;
        private System.Windows.Forms.Label lbltítulo;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtMotivoVisita;
        private System.Windows.Forms.TextBox txtIDCita;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblEstadoCita;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lbHoraFecha;
        private System.Windows.Forms.Label lblPlacaVehiculo;
        private System.Windows.Forms.Label lblIDcita;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}