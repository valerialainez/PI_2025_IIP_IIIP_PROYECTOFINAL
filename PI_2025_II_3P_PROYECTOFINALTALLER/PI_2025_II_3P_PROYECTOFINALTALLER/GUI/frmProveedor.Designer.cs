namespace PI_IIP_IIIP_PROYECTO_.GUI
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.lbltítulo = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMaterialSolicitado = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lbTeléfono = new System.Windows.Forms.Label();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.lblICorreo = new System.Windows.Forms.Label();
            this.lblIDProveedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Location = new System.Drawing.Point(246, 355);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(154, 20);
            this.txtFechaRegistro.TabIndex = 101;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(246, 222);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(154, 20);
            this.txtTelefonoProveedor.TabIndex = 100;
            // 
            // lbltítulo
            // 
            this.lbltítulo.AutoSize = true;
            this.lbltítulo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltítulo.Location = new System.Drawing.Point(266, 47);
            this.lbltítulo.Name = "lbltítulo";
            this.lbltítulo.Size = new System.Drawing.Size(323, 33);
            this.lbltítulo.TabIndex = 99;
            this.lbltítulo.Text = "SISTEMA DE PROVEEDORES";
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(35, 426);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.Size = new System.Drawing.Size(728, 156);
            this.dgvResumen.TabIndex = 98;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(613, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 43);
            this.btnEliminar.TabIndex = 97;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Coral;
            this.btnListar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(613, 262);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 43);
            this.btnListar.TabIndex = 96;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Coral;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(613, 211);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 43);
            this.btnActualizar.TabIndex = 95;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(613, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 43);
            this.btnBuscar.TabIndex = 94;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(613, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 43);
            this.btnAgregar.TabIndex = 93;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtMaterialSolicitado
            // 
            this.txtMaterialSolicitado.Location = new System.Drawing.Point(246, 320);
            this.txtMaterialSolicitado.Name = "txtMaterialSolicitado";
            this.txtMaterialSolicitado.Size = new System.Drawing.Size(154, 20);
            this.txtMaterialSolicitado.TabIndex = 92;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(246, 285);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(154, 20);
            this.txtDireccionEmpresa.TabIndex = 91;
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(246, 254);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(154, 20);
            this.txtCorreoProveedor.TabIndex = 90;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(246, 185);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(154, 20);
            this.txtContacto.TabIndex = 89;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(246, 148);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(154, 20);
            this.txtEmpresa.TabIndex = 88;
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(246, 117);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(154, 20);
            this.txtIDProveedor.TabIndex = 87;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(83, 148);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(143, 20);
            this.lblNombreEmpresa.TabIndex = 86;
            this.lblNombreEmpresa.Text = "Empresa a proveer:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(93, 355);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(133, 20);
            this.lblFechaRegistro.TabIndex = 85;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(31, 320);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(207, 20);
            this.lblTipoMaterial.TabIndex = 84;
            this.lblTipoMaterial.Text = "Tipo de Material a solicitado:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(45, 285);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(181, 20);
            this.lblDireccion.TabIndex = 83;
            this.lblDireccion.Text = "Dirección de la Empresa:";
            // 
            // lbTeléfono
            // 
            this.lbTeléfono.AutoSize = true;
            this.lbTeléfono.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeléfono.Location = new System.Drawing.Point(54, 222);
            this.lbTeléfono.Name = "lbTeléfono";
            this.lbTeléfono.Size = new System.Drawing.Size(172, 20);
            this.lbTeléfono.TabIndex = 82;
            this.lbTeléfono.Text = "Teléfono del proveedor:";
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreContacto.Location = new System.Drawing.Point(68, 185);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(158, 20);
            this.lblNombreContacto.TabIndex = 81;
            this.lblNombreContacto.Text = "Nombre de Contacto:";
            // 
            // lblICorreo
            // 
            this.lblICorreo.AutoSize = true;
            this.lblICorreo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICorreo.Location = new System.Drawing.Point(70, 254);
            this.lblICorreo.Name = "lblICorreo";
            this.lblICorreo.Size = new System.Drawing.Size(156, 20);
            this.lblICorreo.TabIndex = 80;
            this.lblICorreo.Text = "Correo de proveedor:";
            // 
            // lblIDProveedor
            // 
            this.lblIDProveedor.AutoSize = true;
            this.lblIDProveedor.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProveedor.Location = new System.Drawing.Point(122, 117);
            this.lblIDProveedor.Name = "lblIDProveedor";
            this.lblIDProveedor.Size = new System.Drawing.Size(104, 20);
            this.lblIDProveedor.TabIndex = 79;
            this.lblIDProveedor.Text = "ID Proveedor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_II_3P_GUIPROYECTO.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFechaRegistro);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.lbltítulo);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMaterialSolicitado);
            this.Controls.Add(this.txtDireccionEmpresa);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblTipoMaterial);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lbTeléfono);
            this.Controls.Add(this.lblNombreContacto);
            this.Controls.Add(this.lblICorreo);
            this.Controls.Add(this.lblIDProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedor";
            this.Text = "Sistema de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label lbltítulo;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMaterialSolicitado;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lbTeléfono;
        private System.Windows.Forms.Label lblNombreContacto;
        private System.Windows.Forms.Label lblICorreo;
        private System.Windows.Forms.Label lblIDProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}