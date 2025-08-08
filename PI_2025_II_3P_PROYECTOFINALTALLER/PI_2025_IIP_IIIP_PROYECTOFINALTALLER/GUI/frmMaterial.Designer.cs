﻿namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterial));
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblFechaNacimientoEmpleado = new System.Windows.Forms.Label();
            this.lblProveedorMaterial = new System.Windows.Forms.Label();
            this.lblMarcaMaterial = new System.Windows.Forms.Label();
            this.lblCantidadMaterial = new System.Windows.Forms.Label();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblCostoMaterial = new System.Windows.Forms.Label();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.txtTipoMaterial = new System.Windows.Forms.TextBox();
            this.txtCostoMaterial = new System.Windows.Forms.TextBox();
            this.cmbEstadoMaterial = new System.Windows.Forms.ComboBox();
            this.nudTrabajosRealizados = new System.Windows.Forms.NumericUpDown();
            this.txtMarcaMaterial = new System.Windows.Forms.TextBox();
            this.txtProveedorMaterial = new System.Windows.Forms.TextBox();
            this.dtpFechaIngresoMaterial = new System.Windows.Forms.DateTimePicker();
            this.dtvCliente = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(248, 32);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(300, 32);
            this.lblMaterial.TabIndex = 55;
            this.lblMaterial.Text = "REGISTRO MATERIAL";
            // 
            // lblFechaNacimientoEmpleado
            // 
            this.lblFechaNacimientoEmpleado.AutoSize = true;
            this.lblFechaNacimientoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimientoEmpleado.Location = new System.Drawing.Point(90, 310);
            this.lblFechaNacimientoEmpleado.Name = "lblFechaNacimientoEmpleado";
            this.lblFechaNacimientoEmpleado.Size = new System.Drawing.Size(106, 16);
            this.lblFechaNacimientoEmpleado.TabIndex = 71;
            this.lblFechaNacimientoEmpleado.Text = "Fecha Ingreso:";
            // 
            // lblProveedorMaterial
            // 
            this.lblProveedorMaterial.AutoSize = true;
            this.lblProveedorMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorMaterial.Location = new System.Drawing.Point(112, 280);
            this.lblProveedorMaterial.Name = "lblProveedorMaterial";
            this.lblProveedorMaterial.Size = new System.Drawing.Size(81, 16);
            this.lblProveedorMaterial.TabIndex = 70;
            this.lblProveedorMaterial.Text = "Proveedor:";
            // 
            // lblMarcaMaterial
            // 
            this.lblMarcaMaterial.AutoSize = true;
            this.lblMarcaMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaMaterial.Location = new System.Drawing.Point(138, 252);
            this.lblMarcaMaterial.Name = "lblMarcaMaterial";
            this.lblMarcaMaterial.Size = new System.Drawing.Size(53, 16);
            this.lblMarcaMaterial.TabIndex = 69;
            this.lblMarcaMaterial.Text = "Marca:";
            // 
            // lblCantidadMaterial
            // 
            this.lblCantidadMaterial.AutoSize = true;
            this.lblCantidadMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMaterial.Location = new System.Drawing.Point(120, 223);
            this.lblCantidadMaterial.Name = "lblCantidadMaterial";
            this.lblCantidadMaterial.Size = new System.Drawing.Size(72, 16);
            this.lblCantidadMaterial.TabIndex = 68;
            this.lblCantidadMaterial.Text = "Cantidad:";
            this.lblCantidadMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(134, 197);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(58, 16);
            this.lblTelefonoEmpleado.TabIndex = 67;
            this.lblTelefonoEmpleado.Text = "Estado:";
            // 
            // lblCostoMaterial
            // 
            this.lblCostoMaterial.AutoSize = true;
            this.lblCostoMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaterial.Location = new System.Drawing.Point(140, 171);
            this.lblCostoMaterial.Name = "lblCostoMaterial";
            this.lblCostoMaterial.Size = new System.Drawing.Size(50, 16);
            this.lblCostoMaterial.TabIndex = 66;
            this.lblCostoMaterial.Text = "Costo:";
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(148, 142);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(41, 16);
            this.lblTipoMaterial.TabIndex = 65;
            this.lblTipoMaterial.Text = "Tipo:";
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.AutoSize = true;
            this.lblNombreMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterial.Location = new System.Drawing.Point(127, 114);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(65, 16);
            this.lblNombreMaterial.TabIndex = 64;
            this.lblNombreMaterial.Text = "Nombre:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMaterial.Location = new System.Drawing.Point(193, 111);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(253, 23);
            this.txtNombreMaterial.TabIndex = 72;
            // 
            // txtTipoMaterial
            // 
            this.txtTipoMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMaterial.Location = new System.Drawing.Point(193, 140);
            this.txtTipoMaterial.Name = "txtTipoMaterial";
            this.txtTipoMaterial.Size = new System.Drawing.Size(253, 23);
            this.txtTipoMaterial.TabIndex = 73;
            // 
            // txtCostoMaterial
            // 
            this.txtCostoMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoMaterial.Location = new System.Drawing.Point(193, 168);
            this.txtCostoMaterial.Name = "txtCostoMaterial";
            this.txtCostoMaterial.Size = new System.Drawing.Size(253, 23);
            this.txtCostoMaterial.TabIndex = 74;
            // 
            // cmbEstadoMaterial
            // 
            this.cmbEstadoMaterial.FormattingEnabled = true;
            this.cmbEstadoMaterial.Items.AddRange(new object[] {
            "Usado",
            "Nuevo"});
            this.cmbEstadoMaterial.Location = new System.Drawing.Point(193, 197);
            this.cmbEstadoMaterial.Name = "cmbEstadoMaterial";
            this.cmbEstadoMaterial.Size = new System.Drawing.Size(152, 21);
            this.cmbEstadoMaterial.TabIndex = 75;
            // 
            // nudTrabajosRealizados
            // 
            this.nudTrabajosRealizados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTrabajosRealizados.Location = new System.Drawing.Point(193, 222);
            this.nudTrabajosRealizados.Margin = new System.Windows.Forms.Padding(2);
            this.nudTrabajosRealizados.Name = "nudTrabajosRealizados";
            this.nudTrabajosRealizados.Size = new System.Drawing.Size(32, 23);
            this.nudTrabajosRealizados.TabIndex = 85;
            // 
            // txtMarcaMaterial
            // 
            this.txtMarcaMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaMaterial.Location = new System.Drawing.Point(193, 249);
            this.txtMarcaMaterial.Name = "txtMarcaMaterial";
            this.txtMarcaMaterial.Size = new System.Drawing.Size(253, 23);
            this.txtMarcaMaterial.TabIndex = 86;
            // 
            // txtProveedorMaterial
            // 
            this.txtProveedorMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorMaterial.Location = new System.Drawing.Point(193, 278);
            this.txtProveedorMaterial.Name = "txtProveedorMaterial";
            this.txtProveedorMaterial.Size = new System.Drawing.Size(253, 23);
            this.txtProveedorMaterial.TabIndex = 87;
            // 
            // dtpFechaIngresoMaterial
            // 
            this.dtpFechaIngresoMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngresoMaterial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngresoMaterial.Location = new System.Drawing.Point(193, 306);
            this.dtpFechaIngresoMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaIngresoMaterial.Name = "dtpFechaIngresoMaterial";
            this.dtpFechaIngresoMaterial.Size = new System.Drawing.Size(151, 23);
            this.dtpFechaIngresoMaterial.TabIndex = 88;
            // 
            // dtvCliente
            // 
            this.dtvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCliente.Location = new System.Drawing.Point(78, 409);
            this.dtvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dtvCliente.Name = "dtvCliente";
            this.dtvCliente.RowHeadersWidth = 51;
            this.dtvCliente.RowTemplate.Height = 24;
            this.dtvCliente.Size = new System.Drawing.Size(586, 202);
            this.dtvCliente.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.volver;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(556, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 103;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminar.Location = new System.Drawing.Point(556, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 43);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.listar;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListar.Location = new System.Drawing.Point(556, 238);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(163, 43);
            this.btnListar.TabIndex = 101;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(556, 187);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(163, 43);
            this.btnActualizar.TabIndex = 100;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(556, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 43);
            this.btnBuscar.TabIndex = 99;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(556, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 43);
            this.btnAgregar.TabIndex = 98;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtvCliente);
            this.Controls.Add(this.dtpFechaIngresoMaterial);
            this.Controls.Add(this.txtProveedorMaterial);
            this.Controls.Add(this.txtMarcaMaterial);
            this.Controls.Add(this.nudTrabajosRealizados);
            this.Controls.Add(this.cmbEstadoMaterial);
            this.Controls.Add(this.txtCostoMaterial);
            this.Controls.Add(this.txtTipoMaterial);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.lblFechaNacimientoEmpleado);
            this.Controls.Add(this.lblProveedorMaterial);
            this.Controls.Add(this.lblMarcaMaterial);
            this.Controls.Add(this.lblCantidadMaterial);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblCostoMaterial);
            this.Controls.Add(this.lblTipoMaterial);
            this.Controls.Add(this.lblNombreMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaterial";
            this.Text = "Registro Material";
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblFechaNacimientoEmpleado;
        private System.Windows.Forms.Label lblProveedorMaterial;
        private System.Windows.Forms.Label lblMarcaMaterial;
        private System.Windows.Forms.Label lblCantidadMaterial;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblCostoMaterial;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.Label lblNombreMaterial;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.TextBox txtTipoMaterial;
        private System.Windows.Forms.TextBox txtCostoMaterial;
        private System.Windows.Forms.ComboBox cmbEstadoMaterial;
        private System.Windows.Forms.NumericUpDown nudTrabajosRealizados;
        private System.Windows.Forms.TextBox txtMarcaMaterial;
        private System.Windows.Forms.TextBox txtProveedorMaterial;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoMaterial;
        private System.Windows.Forms.DataGridView dtvCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
    }
}