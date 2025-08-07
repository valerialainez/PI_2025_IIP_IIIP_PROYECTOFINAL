namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            this.cmbEstadoMantenimiento = new System.Windows.Forms.ComboBox();
            this.dtvMantenimiento = new System.Windows.Forms.DataGridView();
            this.cmbTipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.lblHistorialMantenimiento = new System.Windows.Forms.Label();
            this.txtIdMantenimiento = new System.Windows.Forms.TextBox();
            this.btnEliminarMantenimiento = new System.Windows.Forms.Button();
            this.btnListarMantenimiento = new System.Windows.Forms.Button();
            this.btnActualizarMantenimiento = new System.Windows.Forms.Button();
            this.btnBuscarMantenimiento = new System.Windows.Forms.Button();
            this.btnAgregarMantenimiento = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.txtFechaMantenimiento = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.lblEstadoMantenimiento = new System.Windows.Forms.Label();
            this.lblCostoMantenimiento = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lnlIdVehiculo = new System.Windows.Forms.Label();
            this.lblFechaMantenimiento = new System.Windows.Forms.Label();
            this.lblTipoMantenimiento = new System.Windows.Forms.Label();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.lblIdHistorial = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtCostoMantenimiento = new System.Windows.Forms.TextBox();
            this.btnVolverMenuRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoMantenimiento
            // 
            this.cmbEstadoMantenimiento.FormattingEnabled = true;
            this.cmbEstadoMantenimiento.Location = new System.Drawing.Point(179, 236);
            this.cmbEstadoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstadoMantenimiento.Name = "cmbEstadoMantenimiento";
            this.cmbEstadoMantenimiento.Size = new System.Drawing.Size(143, 21);
            this.cmbEstadoMantenimiento.TabIndex = 81;
            // 
            // dtvMantenimiento
            // 
            this.dtvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMantenimiento.Location = new System.Drawing.Point(64, 290);
            this.dtvMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvMantenimiento.Name = "dtvMantenimiento";
            this.dtvMantenimiento.RowHeadersWidth = 51;
            this.dtvMantenimiento.RowTemplate.Height = 24;
            this.dtvMantenimiento.Size = new System.Drawing.Size(473, 67);
            this.dtvMantenimiento.TabIndex = 80;
            // 
            // cmbTipoMantenimiento
            // 
            this.cmbTipoMantenimiento.Location = new System.Drawing.Point(179, 97);
            this.cmbTipoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoMantenimiento.Name = "cmbTipoMantenimiento";
            this.cmbTipoMantenimiento.Size = new System.Drawing.Size(143, 21);
            this.cmbTipoMantenimiento.TabIndex = 58;
            // 
            // lblHistorialMantenimiento
            // 
            this.lblHistorialMantenimiento.AutoSize = true;
            this.lblHistorialMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialMantenimiento.Location = new System.Drawing.Point(126, 7);
            this.lblHistorialMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistorialMantenimiento.Name = "lblHistorialMantenimiento";
            this.lblHistorialMantenimiento.Size = new System.Drawing.Size(392, 26);
            this.lblHistorialMantenimiento.TabIndex = 78;
            this.lblHistorialMantenimiento.Text = "Registro Historial de Mantenimiento";
            // 
            // txtIdMantenimiento
            // 
            this.txtIdMantenimiento.Location = new System.Drawing.Point(179, 46);
            this.txtIdMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdMantenimiento.Name = "txtIdMantenimiento";
            this.txtIdMantenimiento.Size = new System.Drawing.Size(143, 20);
            this.txtIdMantenimiento.TabIndex = 77;
            // 
            // btnEliminarMantenimiento
            // 
            this.btnEliminarMantenimiento.BackColor = System.Drawing.Color.Coral;
            this.btnEliminarMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMantenimiento.Location = new System.Drawing.Point(394, 238);
            this.btnEliminarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            this.btnEliminarMantenimiento.Size = new System.Drawing.Size(116, 39);
            this.btnEliminarMantenimiento.TabIndex = 76;
            this.btnEliminarMantenimiento.Text = "Eliminar";
            this.btnEliminarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnListarMantenimiento
            // 
            this.btnListarMantenimiento.BackColor = System.Drawing.Color.Coral;
            this.btnListarMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMantenimiento.Location = new System.Drawing.Point(394, 197);
            this.btnListarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarMantenimiento.Name = "btnListarMantenimiento";
            this.btnListarMantenimiento.Size = new System.Drawing.Size(116, 39);
            this.btnListarMantenimiento.TabIndex = 75;
            this.btnListarMantenimiento.Text = "Listar";
            this.btnListarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnActualizarMantenimiento
            // 
            this.btnActualizarMantenimiento.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMantenimiento.Location = new System.Drawing.Point(394, 153);
            this.btnActualizarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarMantenimiento.Name = "btnActualizarMantenimiento";
            this.btnActualizarMantenimiento.Size = new System.Drawing.Size(116, 39);
            this.btnActualizarMantenimiento.TabIndex = 74;
            this.btnActualizarMantenimiento.Text = "Actualizar";
            this.btnActualizarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMantenimiento
            // 
            this.btnBuscarMantenimiento.BackColor = System.Drawing.Color.Coral;
            this.btnBuscarMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMantenimiento.Location = new System.Drawing.Point(394, 109);
            this.btnBuscarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarMantenimiento.Name = "btnBuscarMantenimiento";
            this.btnBuscarMantenimiento.Size = new System.Drawing.Size(116, 39);
            this.btnBuscarMantenimiento.TabIndex = 73;
            this.btnBuscarMantenimiento.Text = "Buscar";
            this.btnBuscarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMantenimiento
            // 
            this.btnAgregarMantenimiento.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMantenimiento.Location = new System.Drawing.Point(394, 65);
            this.btnAgregarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            this.btnAgregarMantenimiento.Size = new System.Drawing.Size(116, 39);
            this.btnAgregarMantenimiento.TabIndex = 72;
            this.btnAgregarMantenimiento.Text = "Agregar";
            this.btnAgregarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(179, 188);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(143, 20);
            this.txtDiagnostico.TabIndex = 71;
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(179, 144);
            this.txtIdVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(143, 20);
            this.txtIdVehiculo.TabIndex = 70;
            // 
            // txtFechaMantenimiento
            // 
            this.txtFechaMantenimiento.Location = new System.Drawing.Point(179, 121);
            this.txtFechaMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaMantenimiento.Name = "txtFechaMantenimiento";
            this.txtFechaMantenimiento.Size = new System.Drawing.Size(143, 20);
            this.txtFechaMantenimiento.TabIndex = 69;
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(179, 75);
            this.txtMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(143, 20);
            this.txtMantenimiento.TabIndex = 67;
            // 
            // lblEstadoMantenimiento
            // 
            this.lblEstadoMantenimiento.AutoSize = true;
            this.lblEstadoMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMantenimiento.Location = new System.Drawing.Point(78, 239);
            this.lblEstadoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoMantenimiento.Name = "lblEstadoMantenimiento";
            this.lblEstadoMantenimiento.Size = new System.Drawing.Size(58, 17);
            this.lblEstadoMantenimiento.TabIndex = 66;
            this.lblEstadoMantenimiento.Text = "Estado";
            // 
            // lblCostoMantenimiento
            // 
            this.lblCostoMantenimiento.AutoSize = true;
            this.lblCostoMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMantenimiento.Location = new System.Drawing.Point(78, 216);
            this.lblCostoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoMantenimiento.Name = "lblCostoMantenimiento";
            this.lblCostoMantenimiento.Size = new System.Drawing.Size(49, 17);
            this.lblCostoMantenimiento.TabIndex = 65;
            this.lblCostoMantenimiento.Text = "Costo";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(78, 193);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(93, 17);
            this.lblDiagnostico.TabIndex = 64;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(78, 171);
            this.lblIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(99, 17);
            this.lblIdEmpleado.TabIndex = 63;
            this.lblIdEmpleado.Text = "ID Empleado";
            // 
            // lnlIdVehiculo
            // 
            this.lnlIdVehiculo.AutoSize = true;
            this.lnlIdVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlIdVehiculo.Location = new System.Drawing.Point(78, 149);
            this.lnlIdVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnlIdVehiculo.Name = "lnlIdVehiculo";
            this.lnlIdVehiculo.Size = new System.Drawing.Size(90, 17);
            this.lnlIdVehiculo.TabIndex = 62;
            this.lnlIdVehiculo.Text = "ID Vehiculo";
            // 
            // lblFechaMantenimiento
            // 
            this.lblFechaMantenimiento.AutoSize = true;
            this.lblFechaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMantenimiento.Location = new System.Drawing.Point(78, 126);
            this.lblFechaMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaMantenimiento.Name = "lblFechaMantenimiento";
            this.lblFechaMantenimiento.Size = new System.Drawing.Size(52, 17);
            this.lblFechaMantenimiento.TabIndex = 61;
            this.lblFechaMantenimiento.Text = "Fecha";
            // 
            // lblTipoMantenimiento
            // 
            this.lblTipoMantenimiento.AutoSize = true;
            this.lblTipoMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMantenimiento.Location = new System.Drawing.Point(78, 103);
            this.lblTipoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoMantenimiento.Name = "lblTipoMantenimiento";
            this.lblTipoMantenimiento.Size = new System.Drawing.Size(40, 17);
            this.lblTipoMantenimiento.TabIndex = 60;
            this.lblTipoMantenimiento.Text = "Tipo";
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(78, 77);
            this.lblMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(113, 17);
            this.lblMantenimiento.TabIndex = 59;
            this.lblMantenimiento.Text = "Mantenimiento";
            // 
            // lblIdHistorial
            // 
            this.lblIdHistorial.AutoSize = true;
            this.lblIdHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdHistorial.Location = new System.Drawing.Point(78, 46);
            this.lblIdHistorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdHistorial.Name = "lblIdHistorial";
            this.lblIdHistorial.Size = new System.Drawing.Size(110, 17);
            this.lblIdHistorial.TabIndex = 57;
            this.lblIdHistorial.Text = "Ingrese un ID:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(179, 167);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(143, 20);
            this.txtIdEmpleado.TabIndex = 82;
            // 
            // txtCostoMantenimiento
            // 
            this.txtCostoMantenimiento.Location = new System.Drawing.Point(179, 211);
            this.txtCostoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostoMantenimiento.Name = "txtCostoMantenimiento";
            this.txtCostoMantenimiento.Size = new System.Drawing.Size(143, 20);
            this.txtCostoMantenimiento.TabIndex = 83;
            // 
            // btnVolverMenuRegistro
            // 
            this.btnVolverMenuRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnVolverMenuRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuRegistro.Location = new System.Drawing.Point(3, 340);
            this.btnVolverMenuRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverMenuRegistro.Name = "btnVolverMenuRegistro";
            this.btnVolverMenuRegistro.Size = new System.Drawing.Size(56, 25);
            this.btnVolverMenuRegistro.TabIndex = 84;
            this.btnVolverMenuRegistro.Text = "Volver";
            this.btnVolverMenuRegistro.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_II_3P_GUIPROYECTO.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolverMenuRegistro);
            this.Controls.Add(this.txtCostoMantenimiento);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.cmbEstadoMantenimiento);
            this.Controls.Add(this.dtvMantenimiento);
            this.Controls.Add(this.cmbTipoMantenimiento);
            this.Controls.Add(this.lblHistorialMantenimiento);
            this.Controls.Add(this.txtIdMantenimiento);
            this.Controls.Add(this.btnEliminarMantenimiento);
            this.Controls.Add(this.btnListarMantenimiento);
            this.Controls.Add(this.btnActualizarMantenimiento);
            this.Controls.Add(this.btnBuscarMantenimiento);
            this.Controls.Add(this.btnAgregarMantenimiento);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.txtFechaMantenimiento);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.lblEstadoMantenimiento);
            this.Controls.Add(this.lblCostoMantenimiento);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.lnlIdVehiculo);
            this.Controls.Add(this.lblFechaMantenimiento);
            this.Controls.Add(this.lblTipoMantenimiento);
            this.Controls.Add(this.lblMantenimiento);
            this.Controls.Add(this.lblIdHistorial);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHistorial";
            this.Text = "Historial de mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtvMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoMantenimiento;
        private System.Windows.Forms.DataGridView dtvMantenimiento;
        private System.Windows.Forms.ComboBox cmbTipoMantenimiento;
        private System.Windows.Forms.Label lblHistorialMantenimiento;
        private System.Windows.Forms.TextBox txtIdMantenimiento;
        private System.Windows.Forms.Button btnEliminarMantenimiento;
        private System.Windows.Forms.Button btnListarMantenimiento;
        private System.Windows.Forms.Button btnActualizarMantenimiento;
        private System.Windows.Forms.Button btnBuscarMantenimiento;
        private System.Windows.Forms.Button btnAgregarMantenimiento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.TextBox txtFechaMantenimiento;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.Label lblEstadoMantenimiento;
        private System.Windows.Forms.Label lblCostoMantenimiento;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lnlIdVehiculo;
        private System.Windows.Forms.Label lblFechaMantenimiento;
        private System.Windows.Forms.Label lblTipoMantenimiento;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.Label lblIdHistorial;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtCostoMantenimiento;
        private System.Windows.Forms.Button btnVolverMenuRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}