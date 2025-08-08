namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.chkRtn = new System.Windows.Forms.CheckBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.dgbFactura = new System.Windows.Forms.DataGridView();
            this.mstmenu = new System.Windows.Forms.MenuStrip();
            this.párametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.btnActualizarFactura = new System.Windows.Forms.Button();
            this.btnSalirFactura = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFactura)).BeginInit();
            this.mstmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(67, 85);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(212, 15);
            this.lblOrden.TabIndex = 1;
            this.lblOrden.Text = "ID Numero de Orden a Facturar:";
            this.lblOrden.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(307, 105);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(251, 18);
            this.txtCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(67, 105);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 15);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(67, 127);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(72, 15);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(67, 148);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(62, 15);
            this.lblVehiculo.TabIndex = 5;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(307, 125);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpleado.Multiline = true;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(251, 18);
            this.txtEmpleado.TabIndex = 7;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(307, 146);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVehiculo.Multiline = true;
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(251, 18);
            this.txtVehiculo.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Orden1",
            "Orden2"});
            this.listBox1.Location = new System.Drawing.Point(307, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 17);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(393, 239);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(87, 18);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(336, 239);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(393, 215);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(87, 18);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "0";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(336, 215);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 15);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // chkRtn
            // 
            this.chkRtn.AutoSize = true;
            this.chkRtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRtn.Location = new System.Drawing.Point(115, 269);
            this.chkRtn.Margin = new System.Windows.Forms.Padding(2);
            this.chkRtn.Name = "chkRtn";
            this.chkRtn.Size = new System.Drawing.Size(133, 19);
            this.chkRtn.TabIndex = 13;
            this.chkRtn.Text = "Factura con RTN";
            this.chkRtn.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(339, 259);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(141, 49);
            this.btnGenerarFactura.TabIndex = 14;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // txtServicios
            // 
            this.txtServicios.Location = new System.Drawing.Point(307, 167);
            this.txtServicios.Margin = new System.Windows.Forms.Padding(2);
            this.txtServicios.Multiline = true;
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(251, 18);
            this.txtServicios.TabIndex = 16;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(67, 168);
            this.lblServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(74, 17);
            this.lblServicios.TabIndex = 15;
            this.lblServicios.Text = "Servicios";
            // 
            // dgbFactura
            // 
            this.dgbFactura.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgbFactura.Location = new System.Drawing.Point(17, 313);
            this.dgbFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgbFactura.Name = "dgbFactura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbFactura.RowHeadersWidth = 62;
            this.dgbFactura.RowTemplate.Height = 28;
            this.dgbFactura.Size = new System.Drawing.Size(579, 58);
            this.dgbFactura.TabIndex = 17;
            // 
            // mstmenu
            // 
            this.mstmenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mstmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.párametrosToolStripMenuItem});
            this.mstmenu.Location = new System.Drawing.Point(0, 24);
            this.mstmenu.Name = "mstmenu";
            this.mstmenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mstmenu.Size = new System.Drawing.Size(621, 24);
            this.mstmenu.TabIndex = 18;
            this.mstmenu.Text = "menu";
            this.mstmenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // párametrosToolStripMenuItem
            // 
            this.párametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeFacturaToolStripMenuItem});
            this.párametrosToolStripMenuItem.Name = "párametrosToolStripMenuItem";
            this.párametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.párametrosToolStripMenuItem.Text = "Parámetros";
            // 
            // baseDeFacturaToolStripMenuItem
            // 
            this.baseDeFacturaToolStripMenuItem.Name = "baseDeFacturaToolStripMenuItem";
            this.baseDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.baseDeFacturaToolStripMenuItem.Text = "Base de Factura";
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.Coral;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.Location = new System.Drawing.Point(164, 375);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(116, 40);
            this.btnNuevaFactura.TabIndex = 73;
            this.btnNuevaFactura.Text = "Agregar";
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.BackColor = System.Drawing.Color.Coral;
            this.btnBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFactura.Location = new System.Drawing.Point(316, 376);
            this.btnBuscarFactura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(116, 39);
            this.btnBuscarFactura.TabIndex = 74;
            this.btnBuscarFactura.Text = "Buscar";
            this.btnBuscarFactura.UseVisualStyleBackColor = false;
            // 
            // btnActualizarFactura
            // 
            this.btnActualizarFactura.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFactura.Location = new System.Drawing.Point(481, 375);
            this.btnActualizarFactura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActualizarFactura.Name = "btnActualizarFactura";
            this.btnActualizarFactura.Size = new System.Drawing.Size(116, 39);
            this.btnActualizarFactura.TabIndex = 75;
            this.btnActualizarFactura.Text = "Actualizar";
            this.btnActualizarFactura.UseVisualStyleBackColor = false;
            // 
            // btnSalirFactura
            // 
            this.btnSalirFactura.BackColor = System.Drawing.Color.Coral;
            this.btnSalirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirFactura.Location = new System.Drawing.Point(17, 374);
            this.btnSalirFactura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalirFactura.Name = "btnSalirFactura";
            this.btnSalirFactura.Size = new System.Drawing.Size(116, 40);
            this.btnSalirFactura.TabIndex = 76;
            this.btnSalirFactura.Text = "Salir";
            this.btnSalirFactura.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirFactura);
            this.Controls.Add(this.btnActualizarFactura);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.dgbFactura);
            this.Controls.Add(this.txtServicios);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.chkRtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mstmenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstmenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbFactura)).EndInit();
            this.mstmenu.ResumeLayout(false);
            this.mstmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.CheckBox chkRtn;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.DataGridView dgbFactura;
        private System.Windows.Forms.MenuStrip mstmenu;
        private System.Windows.Forms.ToolStripMenuItem párametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeFacturaToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Button btnActualizarFactura;
        private System.Windows.Forms.Button btnSalirFactura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}