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
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.rbtConfirmada = new System.Windows.Forms.RadioButton();
            this.rbtDenegada = new System.Windows.Forms.RadioButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbltítulo = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblEstadoCita = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lbHoraFecha = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.lblIDcita = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoEmpleado = new System.Windows.Forms.DateTimePicker();
            this.cmbSexoCliente = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.btnVolverMenuRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbEstadoCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEstadoCita
            // 
            this.grbEstadoCita.Controls.Add(this.rbtPendiente);
            this.grbEstadoCita.Controls.Add(this.rbtConfirmada);
            this.grbEstadoCita.Controls.Add(this.rbtDenegada);
            this.grbEstadoCita.Location = new System.Drawing.Point(294, 281);
            this.grbEstadoCita.Name = "grbEstadoCita";
            this.grbEstadoCita.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoCita.TabIndex = 79;
            this.grbEstadoCita.TabStop = false;
            this.grbEstadoCita.Text = "Agenda de citas";
            this.grbEstadoCita.Enter += new System.EventHandler(this.grbEstadoCita_Enter);
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.AutoSize = true;
            this.rbtPendiente.Location = new System.Drawing.Point(7, 66);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbtPendiente.TabIndex = 2;
            this.rbtPendiente.TabStop = true;
            this.rbtPendiente.Text = "Pendiente";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtConfirmada
            // 
            this.rbtConfirmada.AutoSize = true;
            this.rbtConfirmada.Location = new System.Drawing.Point(7, 43);
            this.rbtConfirmada.Name = "rbtConfirmada";
            this.rbtConfirmada.Size = new System.Drawing.Size(78, 17);
            this.rbtConfirmada.TabIndex = 1;
            this.rbtConfirmada.TabStop = true;
            this.rbtConfirmada.Text = "Confirmada";
            this.rbtConfirmada.UseVisualStyleBackColor = true;
            // 
            // rbtDenegada
            // 
            this.rbtDenegada.AutoSize = true;
            this.rbtDenegada.Location = new System.Drawing.Point(7, 20);
            this.rbtDenegada.Name = "rbtDenegada";
            this.rbtDenegada.Size = new System.Drawing.Size(75, 17);
            this.rbtDenegada.TabIndex = 0;
            this.rbtDenegada.TabStop = true;
            this.rbtDenegada.Text = "Denegada";
            this.rbtDenegada.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(294, 449);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(154, 20);
            this.txtObservaciones.TabIndex = 78;
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
            // dtpFechaNacimientoEmpleado
            // 
            this.dtpFechaNacimientoEmpleado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoEmpleado.Location = new System.Drawing.Point(294, 178);
            this.dtpFechaNacimientoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimientoEmpleado.Name = "dtpFechaNacimientoEmpleado";
            this.dtpFechaNacimientoEmpleado.Size = new System.Drawing.Size(157, 20);
            this.dtpFechaNacimientoEmpleado.TabIndex = 81;
            // 
            // cmbSexoCliente
            // 
            this.cmbSexoCliente.FormattingEnabled = true;
            this.cmbSexoCliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoCliente.Location = new System.Drawing.Point(294, 77);
            this.cmbSexoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexoCliente.Name = "cmbSexoCliente";
            this.cmbSexoCliente.Size = new System.Drawing.Size(154, 21);
            this.cmbSexoCliente.TabIndex = 82;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(294, 108);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 83;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox2.Location = new System.Drawing.Point(294, 215);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 84;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox3.Location = new System.Drawing.Point(294, 248);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 21);
            this.comboBox3.TabIndex = 85;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox4.Location = new System.Drawing.Point(294, 407);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(154, 21);
            this.comboBox4.TabIndex = 86;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox5.Location = new System.Drawing.Point(294, 146);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(154, 21);
            this.comboBox5.TabIndex = 87;
            // 
            // btnVolverMenuRegistro
            // 
            this.btnVolverMenuRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnVolverMenuRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuRegistro.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.volver;
            this.btnVolverMenuRegistro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolverMenuRegistro.Location = new System.Drawing.Point(624, 324);
            this.btnVolverMenuRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverMenuRegistro.Name = "btnVolverMenuRegistro";
            this.btnVolverMenuRegistro.Size = new System.Drawing.Size(160, 40);
            this.btnVolverMenuRegistro.TabIndex = 88;
            this.btnVolverMenuRegistro.Text = "Volver";
            this.btnVolverMenuRegistro.UseVisualStyleBackColor = false;
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminar.Location = new System.Drawing.Point(624, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 43);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.listar;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListar.Location = new System.Drawing.Point(624, 223);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 43);
            this.btnListar.TabIndex = 73;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(624, 172);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 43);
            this.btnActualizar.TabIndex = 72;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(624, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 43);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(624, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 43);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 685);
            this.Controls.Add(this.btnVolverMenuRegistro);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbSexoCliente);
            this.Controls.Add(this.dtpFechaNacimientoEmpleado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbEstadoCita);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lbltítulo);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
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
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lbltítulo;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
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
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoEmpleado;
        private System.Windows.Forms.ComboBox cmbSexoCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.RadioButton rbtConfirmada;
        private System.Windows.Forms.RadioButton rbtDenegada;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button btnVolverMenuRegistro;
    }
}