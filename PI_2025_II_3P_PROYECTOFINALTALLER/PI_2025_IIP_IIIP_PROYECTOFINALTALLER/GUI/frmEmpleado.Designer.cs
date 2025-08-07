namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNacionalidadEmpleado = new System.Windows.Forms.Label();
            this.lblFechaNacimientoEmpleado = new System.Windows.Forms.Label();
            this.lblSexoEmpleado = new System.Windows.Forms.Label();
            this.lblDireccionEmpleado = new System.Windows.Forms.Label();
            this.lblEmailEmpleado = new System.Windows.Forms.Label();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblDniEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtNacionalidadEmpleado = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoEmpleado = new System.Windows.Forms.DateTimePicker();
            this.cmbSexoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmailEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.dtvCliente = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnListarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.lblEspecializacion = new System.Windows.Forms.Label();
            this.cmbEspecializacionEmpleado = new System.Windows.Forms.ComboBox();
            this.lblTrabajosRealizados = new System.Windows.Forms.Label();
            this.nudTrabajosRealizados = new System.Windows.Forms.NumericUpDown();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.btnVolverMenuRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(331, 40);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(314, 32);
            this.lblEmpleado.TabIndex = 54;
            this.lblEmpleado.Text = "REGISTRO EMPLEADO";
            // 
            // lblNacionalidadEmpleado
            // 
            this.lblNacionalidadEmpleado.AutoSize = true;
            this.lblNacionalidadEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidadEmpleado.Location = new System.Drawing.Point(107, 445);
            this.lblNacionalidadEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidadEmpleado.Name = "lblNacionalidadEmpleado";
            this.lblNacionalidadEmpleado.Size = new System.Drawing.Size(100, 16);
            this.lblNacionalidadEmpleado.TabIndex = 64;
            this.lblNacionalidadEmpleado.Text = "Nacionalidad:";
            // 
            // lblFechaNacimientoEmpleado
            // 
            this.lblFechaNacimientoEmpleado.AutoSize = true;
            this.lblFechaNacimientoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimientoEmpleado.Location = new System.Drawing.Point(69, 412);
            this.lblFechaNacimientoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimientoEmpleado.Name = "lblFechaNacimientoEmpleado";
            this.lblFechaNacimientoEmpleado.Size = new System.Drawing.Size(131, 16);
            this.lblFechaNacimientoEmpleado.TabIndex = 63;
            this.lblFechaNacimientoEmpleado.Text = "Fecha Nacimiento:";
            // 
            // lblSexoEmpleado
            // 
            this.lblSexoEmpleado.AutoSize = true;
            this.lblSexoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoEmpleado.Location = new System.Drawing.Point(177, 374);
            this.lblSexoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexoEmpleado.Name = "lblSexoEmpleado";
            this.lblSexoEmpleado.Size = new System.Drawing.Size(43, 16);
            this.lblSexoEmpleado.TabIndex = 62;
            this.lblSexoEmpleado.Text = "Sexo:";
            // 
            // lblDireccionEmpleado
            // 
            this.lblDireccionEmpleado.AutoSize = true;
            this.lblDireccionEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEmpleado.Location = new System.Drawing.Point(137, 339);
            this.lblDireccionEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionEmpleado.Name = "lblDireccionEmpleado";
            this.lblDireccionEmpleado.Size = new System.Drawing.Size(75, 16);
            this.lblDireccionEmpleado.TabIndex = 61;
            this.lblDireccionEmpleado.Text = "Dirección:";
            // 
            // lblEmailEmpleado
            // 
            this.lblEmailEmpleado.AutoSize = true;
            this.lblEmailEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailEmpleado.Location = new System.Drawing.Point(171, 304);
            this.lblEmailEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailEmpleado.Name = "lblEmailEmpleado";
            this.lblEmailEmpleado.Size = new System.Drawing.Size(48, 16);
            this.lblEmailEmpleado.TabIndex = 60;
            this.lblEmailEmpleado.Text = "Email:";
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(113, 269);
            this.lblTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(96, 16);
            this.lblTelefonoEmpleado.TabIndex = 59;
            this.lblTelefonoEmpleado.Text = "No. Teléfono:";
            // 
            // lblDniEmpleado
            // 
            this.lblDniEmpleado.AutoSize = true;
            this.lblDniEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEmpleado.Location = new System.Drawing.Point(186, 234);
            this.lblDniEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniEmpleado.Name = "lblDniEmpleado";
            this.lblDniEmpleado.Size = new System.Drawing.Size(36, 16);
            this.lblDniEmpleado.TabIndex = 58;
            this.lblDniEmpleado.Text = "DNI:";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(148, 199);
            this.lblApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(67, 16);
            this.lblApellidoEmpleado.TabIndex = 57;
            this.lblApellidoEmpleado.Text = "Apellido:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(151, 164);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(65, 16);
            this.lblNombreEmpleado.TabIndex = 56;
            this.lblNombreEmpleado.Text = "Nombre:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(112, 105);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(96, 16);
            this.lblIdCliente.TabIndex = 55;
            this.lblIdCliente.Text = "ID Empleado:";
            // 
            // txtNacionalidadEmpleado
            // 
            this.txtNacionalidadEmpleado.Location = new System.Drawing.Point(239, 442);
            this.txtNacionalidadEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacionalidadEmpleado.Name = "txtNacionalidadEmpleado";
            this.txtNacionalidadEmpleado.Size = new System.Drawing.Size(278, 23);
            this.txtNacionalidadEmpleado.TabIndex = 74;
            // 
            // dtpFechaNacimientoEmpleado
            // 
            this.dtpFechaNacimientoEmpleado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoEmpleado.Location = new System.Drawing.Point(239, 407);
            this.dtpFechaNacimientoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimientoEmpleado.Name = "dtpFechaNacimientoEmpleado";
            this.dtpFechaNacimientoEmpleado.Size = new System.Drawing.Size(274, 23);
            this.dtpFechaNacimientoEmpleado.TabIndex = 73;
            // 
            // cmbSexoEmpleado
            // 
            this.cmbSexoEmpleado.FormattingEnabled = true;
            this.cmbSexoEmpleado.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoEmpleado.Location = new System.Drawing.Point(239, 371);
            this.cmbSexoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexoEmpleado.Name = "cmbSexoEmpleado";
            this.cmbSexoEmpleado.Size = new System.Drawing.Size(278, 24);
            this.cmbSexoEmpleado.TabIndex = 72;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(239, 336);
            this.txtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(336, 23);
            this.txtDireccionEmpleado.TabIndex = 71;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Location = new System.Drawing.Point(239, 301);
            this.txtEmailEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.Size = new System.Drawing.Size(336, 23);
            this.txtEmailEmpleado.TabIndex = 70;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(239, 266);
            this.txtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(278, 23);
            this.txtTelefonoEmpleado.TabIndex = 69;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Location = new System.Drawing.Point(239, 231);
            this.txtDniEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(278, 23);
            this.txtDniEmpleado.TabIndex = 68;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(239, 196);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(336, 23);
            this.txtApellidoEmpleado.TabIndex = 67;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(239, 161);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(336, 23);
            this.txtNombreEmpleado.TabIndex = 66;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(239, 102);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(186, 23);
            this.txtIdEmpleado.TabIndex = 65;
            // 
            // dtvCliente
            // 
            this.dtvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCliente.Location = new System.Drawing.Point(111, 558);
            this.dtvCliente.Name = "dtvCliente";
            this.dtvCliente.RowHeadersWidth = 51;
            this.dtvCliente.RowTemplate.Height = 24;
            this.dtvCliente.Size = new System.Drawing.Size(782, 249);
            this.dtvCliente.TabIndex = 80;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Coral;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(766, 427);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(127, 42);
            this.btnEliminarEmpleado.TabIndex = 79;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnListarEmpleado
            // 
            this.btnListarEmpleado.BackColor = System.Drawing.Color.Coral;
            this.btnListarEmpleado.Location = new System.Drawing.Point(766, 363);
            this.btnListarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarEmpleado.Name = "btnListarEmpleado";
            this.btnListarEmpleado.Size = new System.Drawing.Size(127, 42);
            this.btnListarEmpleado.TabIndex = 78;
            this.btnListarEmpleado.Text = "Listar";
            this.btnListarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(766, 293);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(127, 42);
            this.btnActualizarEmpleado.TabIndex = 77;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.Coral;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(766, 231);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(127, 42);
            this.btnBuscarEmpleado.TabIndex = 76;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(766, 160);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(127, 43);
            this.btnAgregarEmpleado.TabIndex = 75;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblEspecializacion
            // 
            this.lblEspecializacion.AutoSize = true;
            this.lblEspecializacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecializacion.Location = new System.Drawing.Point(41, 480);
            this.lblEspecializacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecializacion.Name = "lblEspecializacion";
            this.lblEspecializacion.Size = new System.Drawing.Size(155, 16);
            this.lblEspecializacion.TabIndex = 81;
            this.lblEspecializacion.Text = "A. de Especialización:";
            // 
            // cmbEspecializacionEmpleado
            // 
            this.cmbEspecializacionEmpleado.FormattingEnabled = true;
            this.cmbEspecializacionEmpleado.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbEspecializacionEmpleado.Location = new System.Drawing.Point(239, 477);
            this.cmbEspecializacionEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecializacionEmpleado.Name = "cmbEspecializacionEmpleado";
            this.cmbEspecializacionEmpleado.Size = new System.Drawing.Size(212, 24);
            this.cmbEspecializacionEmpleado.TabIndex = 82;
            // 
            // lblTrabajosRealizados
            // 
            this.lblTrabajosRealizados.AutoSize = true;
            this.lblTrabajosRealizados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajosRealizados.Location = new System.Drawing.Point(459, 480);
            this.lblTrabajosRealizados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabajosRealizados.Name = "lblTrabajosRealizados";
            this.lblTrabajosRealizados.Size = new System.Drawing.Size(149, 16);
            this.lblTrabajosRealizados.TabIndex = 83;
            this.lblTrabajosRealizados.Text = "Trabajos Realizados:";
            // 
            // nudTrabajosRealizados
            // 
            this.nudTrabajosRealizados.Location = new System.Drawing.Point(648, 478);
            this.nudTrabajosRealizados.Name = "nudTrabajosRealizados";
            this.nudTrabajosRealizados.Size = new System.Drawing.Size(43, 23);
            this.nudTrabajosRealizados.TabIndex = 84;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(114, 516);
            this.lblSalarioBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(96, 16);
            this.lblSalarioBase.TabIndex = 85;
            this.lblSalarioBase.Text = "Salario Base:";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(239, 513);
            this.txtSalarioBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(278, 23);
            this.txtSalarioBase.TabIndex = 86;
            // 
            // btnVolverMenuRegistro
            // 
            this.btnVolverMenuRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnVolverMenuRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuRegistro.Location = new System.Drawing.Point(13, 814);
            this.btnVolverMenuRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverMenuRegistro.Name = "btnVolverMenuRegistro";
            this.btnVolverMenuRegistro.Size = new System.Drawing.Size(127, 42);
            this.btnVolverMenuRegistro.TabIndex = 96;
            this.btnVolverMenuRegistro.Text = "Volver";
            this.btnVolverMenuRegistro.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolverMenuRegistro);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.nudTrabajosRealizados);
            this.Controls.Add(this.lblTrabajosRealizados);
            this.Controls.Add(this.cmbEspecializacionEmpleado);
            this.Controls.Add(this.lblEspecializacion);
            this.Controls.Add(this.dtvCliente);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnListarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.txtNacionalidadEmpleado);
            this.Controls.Add(this.dtpFechaNacimientoEmpleado);
            this.Controls.Add(this.cmbSexoEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtEmailEmpleado);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtDniEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblNacionalidadEmpleado);
            this.Controls.Add(this.lblFechaNacimientoEmpleado);
            this.Controls.Add(this.lblSexoEmpleado);
            this.Controls.Add(this.lblDireccionEmpleado);
            this.Controls.Add(this.lblEmailEmpleado);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblDniEmpleado);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblEmpleado);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleado";
            this.Text = "Registro Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNacionalidadEmpleado;
        private System.Windows.Forms.Label lblFechaNacimientoEmpleado;
        private System.Windows.Forms.Label lblSexoEmpleado;
        private System.Windows.Forms.Label lblDireccionEmpleado;
        private System.Windows.Forms.Label lblEmailEmpleado;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblDniEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtNacionalidadEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoEmpleado;
        private System.Windows.Forms.ComboBox cmbSexoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtEmailEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.DataGridView dtvCliente;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnListarEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label lblEspecializacion;
        private System.Windows.Forms.ComboBox cmbEspecializacionEmpleado;
        private System.Windows.Forms.Label lblTrabajosRealizados;
        private System.Windows.Forms.NumericUpDown nudTrabajosRealizados;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Button btnVolverMenuRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}