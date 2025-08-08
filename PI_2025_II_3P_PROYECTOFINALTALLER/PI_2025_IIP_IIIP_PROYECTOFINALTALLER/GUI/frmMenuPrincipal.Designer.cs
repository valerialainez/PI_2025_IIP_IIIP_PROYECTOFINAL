namespace PI_2025_II_3P_GUIPROYECTO.GUI
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.lblTallerMecánico = new System.Windows.Forms.Label();
            this.btnConfigurarCai = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTallerMecánico
            // 
            this.lblTallerMecánico.AutoSize = true;
            this.lblTallerMecánico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallerMecánico.Location = new System.Drawing.Point(159, 37);
            this.lblTallerMecánico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTallerMecánico.Name = "lblTallerMecánico";
            this.lblTallerMecánico.Size = new System.Drawing.Size(306, 26);
            this.lblTallerMecánico.TabIndex = 79;
            this.lblTallerMecánico.Text = "Sistema de Taller Mecánico";
            // 
            // btnConfigurarCai
            // 
            this.btnConfigurarCai.BackColor = System.Drawing.Color.Coral;
            this.btnConfigurarCai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarCai.Location = new System.Drawing.Point(223, 98);
            this.btnConfigurarCai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfigurarCai.Name = "btnConfigurarCai";
            this.btnConfigurarCai.Size = new System.Drawing.Size(153, 62);
            this.btnConfigurarCai.TabIndex = 80;
            this.btnConfigurarCai.Text = "Configurar CAI";
            this.btnConfigurarCai.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Coral;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(223, 185);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 62);
            this.btnRegistrar.TabIndex = 81;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Coral;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(223, 268);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(153, 62);
            this.btnFacturar.TabIndex = 82;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI_2025_IIP_IIIP_PROYECTOFINALTALLER.Properties.Resources.Icono_Taller;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConfigurarCai);
            this.Controls.Add(this.lblTallerMecánico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTallerMecánico;
        private System.Windows.Forms.Button btnConfigurarCai;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}