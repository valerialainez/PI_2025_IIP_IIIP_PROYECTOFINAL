namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicio));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lbxNombreServicio = new System.Windows.Forms.ListBox();
            this.lblMaterialUsado = new System.Windows.Forms.Label();
            this.lbxMaterialUsado = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblEstadoServicio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgbServicios = new System.Windows.Forms.DataGridView();
            this.btnSalirServicio = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnActualizarServicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVICIOS DE MANTENIMIENTO DE AUTOS";
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(105, 72);
            this.lblNombreServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(157, 17);
            this.lblNombreServicio.TabIndex = 1;
            this.lblNombreServicio.Text = "Nombre del servicio:";
            this.lblNombreServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombreServicio.Click += new System.EventHandler(this.lblNombreServicio_Click);
            // 
            // lbxNombreServicio
            // 
            this.lbxNombreServicio.FormattingEnabled = true;
            this.lbxNombreServicio.Items.AddRange(new object[] {
            "Cambio de aceite",
            "Revisión de frenos",
            "Alineación y balanceo",
            "Cambio de llantas",
            "Reparación de motor",
            "Revisión de suspensión",
            "Cambio de batería",
            "Revisión de sistema eléctrico",
            "Limpieza de inyectores",
            "Cambio de bujías",
            "Revisión de sistema de escape",
            "Reparación de transmisión",
            "Revisión de sistema de refrigeración",
            "Cambio de filtro de aire",
            "Cambio de filtro de combustible"});
            this.lbxNombreServicio.Location = new System.Drawing.Point(259, 73);
            this.lbxNombreServicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxNombreServicio.Name = "lbxNombreServicio";
            this.lbxNombreServicio.Size = new System.Drawing.Size(309, 17);
            this.lbxNombreServicio.TabIndex = 2;
            // 
            // lblMaterialUsado
            // 
            this.lblMaterialUsado.AutoSize = true;
            this.lblMaterialUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUsado.Location = new System.Drawing.Point(105, 103);
            this.lblMaterialUsado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialUsado.Name = "lblMaterialUsado";
            this.lblMaterialUsado.Size = new System.Drawing.Size(117, 17);
            this.lblMaterialUsado.TabIndex = 3;
            this.lblMaterialUsado.Text = "Material Usado";
            // 
            // lbxMaterialUsado
            // 
            this.lbxMaterialUsado.FormattingEnabled = true;
            this.lbxMaterialUsado.Items.AddRange(new object[] {
            "Llantas",
            "Engranajes",
            "Parabrisas",
            "Balineras"});
            this.lbxMaterialUsado.Location = new System.Drawing.Point(259, 103);
            this.lbxMaterialUsado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxMaterialUsado.Name = "lbxMaterialUsado";
            this.lbxMaterialUsado.Size = new System.Drawing.Size(309, 17);
            this.lbxMaterialUsado.TabIndex = 5;
            this.lbxMaterialUsado.SelectedIndexChanged += new System.EventHandler(this.lbxMaterialUsado_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(259, 138);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Finalizado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(345, 138);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "En curso";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblEstadoServicio
            // 
            this.lblEstadoServicio.AutoSize = true;
            this.lblEstadoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoServicio.Location = new System.Drawing.Point(105, 138);
            this.lblEstadoServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoServicio.Name = "lblEstadoServicio";
            this.lblEstadoServicio.Size = new System.Drawing.Size(146, 17);
            this.lblEstadoServicio.TabIndex = 4;
            this.lblEstadoServicio.Text = "Estado del servicio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parámetrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeServicioToolStripMenuItem});
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.parámetrosToolStripMenuItem.Text = "Parámetros";
            // 
            // baseDeServicioToolStripMenuItem
            // 
            this.baseDeServicioToolStripMenuItem.Name = "baseDeServicioToolStripMenuItem";
            this.baseDeServicioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.baseDeServicioToolStripMenuItem.Text = "Base de Servicio";
            // 
            // dgbServicios
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbServicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgbServicios.Location = new System.Drawing.Point(109, 176);
            this.dgbServicios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgbServicios.Name = "dgbServicios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbServicios.RowHeadersWidth = 62;
            this.dgbServicios.RowTemplate.Height = 28;
            this.dgbServicios.Size = new System.Drawing.Size(458, 98);
            this.dgbServicios.TabIndex = 9;
            // 
            // btnSalirServicio
            // 
            this.btnSalirServicio.BackColor = System.Drawing.Color.Coral;
            this.btnSalirServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirServicio.Location = new System.Drawing.Point(63, 314);
            this.btnSalirServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalirServicio.Name = "btnSalirServicio";
            this.btnSalirServicio.Size = new System.Drawing.Size(116, 40);
            this.btnSalirServicio.TabIndex = 77;
            this.btnSalirServicio.Text = "Salir";
            this.btnSalirServicio.UseVisualStyleBackColor = false;
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.BackColor = System.Drawing.Color.Coral;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoServicio.Location = new System.Drawing.Point(214, 314);
            this.btnNuevoServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(116, 40);
            this.btnNuevoServicio.TabIndex = 78;
            this.btnNuevoServicio.Text = "Agregar";
            this.btnNuevoServicio.UseVisualStyleBackColor = false;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.BackColor = System.Drawing.Color.Coral;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.Location = new System.Drawing.Point(374, 314);
            this.btnBuscarServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(116, 39);
            this.btnBuscarServicio.TabIndex = 79;
            this.btnBuscarServicio.Text = "Buscar";
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            // 
            // btnActualizarServicio
            // 
            this.btnActualizarServicio.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarServicio.Location = new System.Drawing.Point(516, 314);
            this.btnActualizarServicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActualizarServicio.Name = "btnActualizarServicio";
            this.btnActualizarServicio.Size = new System.Drawing.Size(116, 39);
            this.btnActualizarServicio.TabIndex = 80;
            this.btnActualizarServicio.Text = "Actualizar";
            this.btnActualizarServicio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_II_3P_GUIPROYECTO.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizarServicio);
            this.Controls.Add(this.btnBuscarServicio);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.btnSalirServicio);
            this.Controls.Add(this.dgbServicios);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbxMaterialUsado);
            this.Controls.Add(this.lblEstadoServicio);
            this.Controls.Add(this.lblMaterialUsado);
            this.Controls.Add(this.lbxNombreServicio);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.ListBox lbxNombreServicio;
        private System.Windows.Forms.Label lblMaterialUsado;
        private System.Windows.Forms.ListBox lbxMaterialUsado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblEstadoServicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeServicioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgbServicios;
        private System.Windows.Forms.Button btnSalirServicio;
        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnActualizarServicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}