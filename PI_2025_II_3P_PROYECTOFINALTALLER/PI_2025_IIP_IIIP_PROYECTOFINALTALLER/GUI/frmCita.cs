using PI_2025_IIP_IIIP_PROYECTOFINALTALLER.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_IIP_IIIP_PROYECTO_.GUI
{
    public partial class frmCita : Form
    {
        private List<Cita> citas = new List<Cita>();
        public frmCita()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

        }

        private void grbEstadoCita_Enter(object sender, EventArgs e)
        {
            if (rbtConfirmada.Checked)
            {
                MessageBox.Show("La cita ha sido confirmada.");
            }
            else if (rbtPendiente.Checked)
            {
                MessageBox.Show("La cita está pendiente.");
            }
            else if (rbtDenegada.Checked)
            {
                MessageBox.Show("La cita ha sido cancelada.");
            }
            else
            {

            }

        }
    }
}
