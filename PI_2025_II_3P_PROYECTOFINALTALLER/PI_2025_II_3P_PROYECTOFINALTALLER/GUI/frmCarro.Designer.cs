namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmCarro
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
            this.lblIdVehiculo = new System.Windows.Forms.Label();
            this.lblMarcaCarro = new System.Windows.Forms.Label();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.lblPlacaCarro = new System.Windows.Forms.Label();
            this.lblColorCarro = new System.Windows.Forms.Label();
            this.lblTipoCarro = new System.Windows.Forms.Label();
            this.lblAñoCarro = new System.Windows.Forms.Label();
            this.lblTraccionCarro = new System.Windows.Forms.Label();
            this.lblCantidadPuertas = new System.Windows.Forms.Label();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.txtPlacaCarro = new System.Windows.Forms.TextBox();
            this.txtColorCarro = new System.Windows.Forms.TextBox();
            this.txtAñoCarro = new System.Windows.Forms.TextBox();
            this.nudCantidadPuertas = new System.Windows.Forms.NumericUpDown();
            this.lblCostoPuerta = new System.Windows.Forms.Label();
            this.txtCostoPuerta = new System.Windows.Forms.TextBox();
            this.btnAgregarCarro = new System.Windows.Forms.Button();
            this.btnBuscarCarro = new System.Windows.Forms.Button();
            this.btnActualizarCarro = new System.Windows.Forms.Button();
            this.btnListarCarro = new System.Windows.Forms.Button();
            this.btnEliminarCarro = new System.Windows.Forms.Button();
            this.txtIdCarro = new System.Windows.Forms.TextBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.cmbTipoCarro = new System.Windows.Forms.ComboBox();
            this.cmbTraccionCarro = new System.Windows.Forms.ComboBox();
            this.dtvCarro = new System.Windows.Forms.DataGridView();
            this.btnVolverMenuRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPuertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdVehiculo
            // 
            this.lblIdVehiculo.AutoSize = true;
            this.lblIdVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVehiculo.Location = new System.Drawing.Point(80, 45);
            this.lblIdVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdVehiculo.Name = "lblIdVehiculo";
            this.lblIdVehiculo.Size = new System.Drawing.Size(110, 17);
            this.lblIdVehiculo.TabIndex = 0;
            this.lblIdVehiculo.Text = "Ingrese un ID:";
            // 
            // lblMarcaCarro
            // 
            this.lblMarcaCarro.AutoSize = true;
            this.lblMarcaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaCarro.Location = new System.Drawing.Point(80, 76);
            this.lblMarcaCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcaCarro.Name = "lblMarcaCarro";
            this.lblMarcaCarro.Size = new System.Drawing.Size(52, 17);
            this.lblMarcaCarro.TabIndex = 1;
            this.lblMarcaCarro.Text = "Marca";
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloCarro.Location = new System.Drawing.Point(80, 102);
            this.lblModeloCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(60, 17);
            this.lblModeloCarro.TabIndex = 2;
            this.lblModeloCarro.Text = "Modelo";
            // 
            // lblPlacaCarro
            // 
            this.lblPlacaCarro.AutoSize = true;
            this.lblPlacaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaCarro.Location = new System.Drawing.Point(80, 124);
            this.lblPlacaCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacaCarro.Name = "lblPlacaCarro";
            this.lblPlacaCarro.Size = new System.Drawing.Size(48, 17);
            this.lblPlacaCarro.TabIndex = 3;
            this.lblPlacaCarro.Text = "Placa";
            // 
            // lblColorCarro
            // 
            this.lblColorCarro.AutoSize = true;
            this.lblColorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorCarro.Location = new System.Drawing.Point(80, 147);
            this.lblColorCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorCarro.Name = "lblColorCarro";
            this.lblColorCarro.Size = new System.Drawing.Size(46, 17);
            this.lblColorCarro.TabIndex = 4;
            this.lblColorCarro.Text = "Color";
            // 
            // lblTipoCarro
            // 
            this.lblTipoCarro.AutoSize = true;
            this.lblTipoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCarro.Location = new System.Drawing.Point(80, 169);
            this.lblTipoCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCarro.Name = "lblTipoCarro";
            this.lblTipoCarro.Size = new System.Drawing.Size(40, 17);
            this.lblTipoCarro.TabIndex = 5;
            this.lblTipoCarro.Text = "Tipo";
            // 
            // lblAñoCarro
            // 
            this.lblAñoCarro.AutoSize = true;
            this.lblAñoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoCarro.Location = new System.Drawing.Point(80, 192);
            this.lblAñoCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoCarro.Name = "lblAñoCarro";
            this.lblAñoCarro.Size = new System.Drawing.Size(36, 17);
            this.lblAñoCarro.TabIndex = 6;
            this.lblAñoCarro.Text = "Año";
            // 
            // lblTraccionCarro
            // 
            this.lblTraccionCarro.AutoSize = true;
            this.lblTraccionCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraccionCarro.Location = new System.Drawing.Point(80, 214);
            this.lblTraccionCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTraccionCarro.Name = "lblTraccionCarro";
            this.lblTraccionCarro.Size = new System.Drawing.Size(71, 17);
            this.lblTraccionCarro.TabIndex = 7;
            this.lblTraccionCarro.Text = "Tracción";
            // 
            // lblCantidadPuertas
            // 
            this.lblCantidadPuertas.AutoSize = true;
            this.lblCantidadPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPuertas.Location = new System.Drawing.Point(80, 237);
            this.lblCantidadPuertas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadPuertas.Name = "lblCantidadPuertas";
            this.lblCantidadPuertas.Size = new System.Drawing.Size(64, 17);
            this.lblCantidadPuertas.TabIndex = 8;
            this.lblCantidadPuertas.Text = "Puertas";
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(182, 73);
            this.txtMarcaCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(143, 20);
            this.txtMarcaCarro.TabIndex = 9;
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(182, 97);
            this.txtModeloCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(143, 20);
            this.txtModeloCarro.TabIndex = 10;
            // 
            // txtPlacaCarro
            // 
            this.txtPlacaCarro.Location = new System.Drawing.Point(182, 119);
            this.txtPlacaCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlacaCarro.Name = "txtPlacaCarro";
            this.txtPlacaCarro.Size = new System.Drawing.Size(143, 20);
            this.txtPlacaCarro.TabIndex = 11;
            // 
            // txtColorCarro
            // 
            this.txtColorCarro.Location = new System.Drawing.Point(182, 142);
            this.txtColorCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColorCarro.Name = "txtColorCarro";
            this.txtColorCarro.Size = new System.Drawing.Size(143, 20);
            this.txtColorCarro.TabIndex = 12;
            // 
            // txtAñoCarro
            // 
            this.txtAñoCarro.Location = new System.Drawing.Point(182, 187);
            this.txtAñoCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAñoCarro.Name = "txtAñoCarro";
            this.txtAñoCarro.Size = new System.Drawing.Size(143, 20);
            this.txtAñoCarro.TabIndex = 14;
            // 
            // nudCantidadPuertas
            // 
            this.nudCantidadPuertas.Location = new System.Drawing.Point(182, 234);
            this.nudCantidadPuertas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCantidadPuertas.Name = "nudCantidadPuertas";
            this.nudCantidadPuertas.Size = new System.Drawing.Size(142, 20);
            this.nudCantidadPuertas.TabIndex = 16;
            // 
            // lblCostoPuerta
            // 
            this.lblCostoPuerta.AutoSize = true;
            this.lblCostoPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPuerta.Location = new System.Drawing.Point(80, 260);
            this.lblCostoPuerta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoPuerta.Name = "lblCostoPuerta";
            this.lblCostoPuerta.Size = new System.Drawing.Size(102, 17);
            this.lblCostoPuerta.TabIndex = 17;
            this.lblCostoPuerta.Text = "Costo Puerta";
            // 
            // txtCostoPuerta
            // 
            this.txtCostoPuerta.Location = new System.Drawing.Point(182, 258);
            this.txtCostoPuerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostoPuerta.Name = "txtCostoPuerta";
            this.txtCostoPuerta.Size = new System.Drawing.Size(143, 20);
            this.txtCostoPuerta.TabIndex = 18;
            // 
            // btnAgregarCarro
            // 
            this.btnAgregarCarro.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarro.Location = new System.Drawing.Point(396, 63);
            this.btnAgregarCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCarro.Name = "btnAgregarCarro";
            this.btnAgregarCarro.Size = new System.Drawing.Size(116, 39);
            this.btnAgregarCarro.TabIndex = 20;
            this.btnAgregarCarro.Text = "Agregar";
            this.btnAgregarCarro.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCarro
            // 
            this.btnBuscarCarro.BackColor = System.Drawing.Color.Coral;
            this.btnBuscarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarro.Location = new System.Drawing.Point(396, 107);
            this.btnBuscarCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCarro.Name = "btnBuscarCarro";
            this.btnBuscarCarro.Size = new System.Drawing.Size(116, 39);
            this.btnBuscarCarro.TabIndex = 21;
            this.btnBuscarCarro.Text = "Buscar";
            this.btnBuscarCarro.UseVisualStyleBackColor = false;
            // 
            // btnActualizarCarro
            // 
            this.btnActualizarCarro.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCarro.Location = new System.Drawing.Point(396, 151);
            this.btnActualizarCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarCarro.Name = "btnActualizarCarro";
            this.btnActualizarCarro.Size = new System.Drawing.Size(116, 39);
            this.btnActualizarCarro.TabIndex = 22;
            this.btnActualizarCarro.Text = "Actualizar";
            this.btnActualizarCarro.UseVisualStyleBackColor = false;
            // 
            // btnListarCarro
            // 
            this.btnListarCarro.BackColor = System.Drawing.Color.Coral;
            this.btnListarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCarro.Location = new System.Drawing.Point(396, 195);
            this.btnListarCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarCarro.Name = "btnListarCarro";
            this.btnListarCarro.Size = new System.Drawing.Size(116, 39);
            this.btnListarCarro.TabIndex = 23;
            this.btnListarCarro.Text = "Listar";
            this.btnListarCarro.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCarro
            // 
            this.btnEliminarCarro.BackColor = System.Drawing.Color.Coral;
            this.btnEliminarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarro.Location = new System.Drawing.Point(396, 236);
            this.btnEliminarCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCarro.Name = "btnEliminarCarro";
            this.btnEliminarCarro.Size = new System.Drawing.Size(116, 39);
            this.btnEliminarCarro.TabIndex = 24;
            this.btnEliminarCarro.Text = "Eliminar";
            this.btnEliminarCarro.UseVisualStyleBackColor = false;
            // 
            // txtIdCarro
            // 
            this.txtIdCarro.Location = new System.Drawing.Point(182, 45);
            this.txtIdCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCarro.Name = "txtIdCarro";
            this.txtIdCarro.Size = new System.Drawing.Size(143, 20);
            this.txtIdCarro.TabIndex = 25;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarro.Location = new System.Drawing.Point(224, 7);
            this.lblCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(167, 26);
            this.lblCarro.TabIndex = 26;
            this.lblCarro.Text = "Registro Carro";
            // 
            // cmbTipoCarro
            // 
            this.cmbTipoCarro.Location = new System.Drawing.Point(182, 162);
            this.cmbTipoCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoCarro.Name = "cmbTipoCarro";
            this.cmbTipoCarro.Size = new System.Drawing.Size(143, 21);
            this.cmbTipoCarro.TabIndex = 0;
            // 
            // cmbTraccionCarro
            // 
            this.cmbTraccionCarro.FormattingEnabled = true;
            this.cmbTraccionCarro.Location = new System.Drawing.Point(182, 210);
            this.cmbTraccionCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTraccionCarro.Name = "cmbTraccionCarro";
            this.cmbTraccionCarro.Size = new System.Drawing.Size(143, 21);
            this.cmbTraccionCarro.TabIndex = 27;
            // 
            // dtvCarro
            // 
            this.dtvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCarro.Location = new System.Drawing.Point(66, 288);
            this.dtvCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvCarro.Name = "dtvCarro";
            this.dtvCarro.RowHeadersWidth = 51;
            this.dtvCarro.RowTemplate.Height = 24;
            this.dtvCarro.Size = new System.Drawing.Size(473, 67);
            this.dtvCarro.TabIndex = 28;
            // 
            // btnVolverMenuRegistro
            // 
            this.btnVolverMenuRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnVolverMenuRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuRegistro.Location = new System.Drawing.Point(3, 336);
            this.btnVolverMenuRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverMenuRegistro.Name = "btnVolverMenuRegistro";
            this.btnVolverMenuRegistro.Size = new System.Drawing.Size(56, 25);
            this.btnVolverMenuRegistro.TabIndex = 29;
            this.btnVolverMenuRegistro.Text = "Volver";
            this.btnVolverMenuRegistro.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_II_3P_GUIPROYECTO.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // frmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolverMenuRegistro);
            this.Controls.Add(this.dtvCarro);
            this.Controls.Add(this.cmbTraccionCarro);
            this.Controls.Add(this.cmbTipoCarro);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.txtIdCarro);
            this.Controls.Add(this.btnEliminarCarro);
            this.Controls.Add(this.btnListarCarro);
            this.Controls.Add(this.btnActualizarCarro);
            this.Controls.Add(this.btnBuscarCarro);
            this.Controls.Add(this.btnAgregarCarro);
            this.Controls.Add(this.txtCostoPuerta);
            this.Controls.Add(this.lblCostoPuerta);
            this.Controls.Add(this.nudCantidadPuertas);
            this.Controls.Add(this.txtAñoCarro);
            this.Controls.Add(this.txtColorCarro);
            this.Controls.Add(this.txtPlacaCarro);
            this.Controls.Add(this.txtModeloCarro);
            this.Controls.Add(this.txtMarcaCarro);
            this.Controls.Add(this.lblCantidadPuertas);
            this.Controls.Add(this.lblTraccionCarro);
            this.Controls.Add(this.lblAñoCarro);
            this.Controls.Add(this.lblTipoCarro);
            this.Controls.Add(this.lblColorCarro);
            this.Controls.Add(this.lblPlacaCarro);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.lblMarcaCarro);
            this.Controls.Add(this.lblIdVehiculo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCarro";
            this.Text = "Registro de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPuertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdVehiculo;
        private System.Windows.Forms.Label lblMarcaCarro;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.Label lblPlacaCarro;
        private System.Windows.Forms.Label lblColorCarro;
        private System.Windows.Forms.Label lblTipoCarro;
        private System.Windows.Forms.Label lblAñoCarro;
        private System.Windows.Forms.Label lblTraccionCarro;
        private System.Windows.Forms.Label lblCantidadPuertas;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.TextBox txtPlacaCarro;
        private System.Windows.Forms.TextBox txtColorCarro;
        private System.Windows.Forms.TextBox txtAñoCarro;
        private System.Windows.Forms.NumericUpDown nudCantidadPuertas;
        private System.Windows.Forms.Label lblCostoPuerta;
        private System.Windows.Forms.TextBox txtCostoPuerta;
        private System.Windows.Forms.Button btnAgregarCarro;
        private System.Windows.Forms.Button btnBuscarCarro;
        private System.Windows.Forms.Button btnActualizarCarro;
        private System.Windows.Forms.Button btnListarCarro;
        private System.Windows.Forms.Button btnEliminarCarro;
        private System.Windows.Forms.TextBox txtIdCarro;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.ComboBox cmbTipoCarro;
        private System.Windows.Forms.ComboBox cmbTraccionCarro;
        private System.Windows.Forms.DataGridView dtvCarro;
        private System.Windows.Forms.Button btnVolverMenuRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}