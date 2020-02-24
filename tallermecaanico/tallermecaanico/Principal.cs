using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tallermecaanico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmcliente llamar = new frmcliente();
            llamar.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmempleados llamar = new frmempleados();
            llamar.Show();
            this.Hide();
        }

          
        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin llamar = new frmlogin();
            llamar.Show();
            this.Hide();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            frmDiagnostico llamar = new frmDiagnostico();
            llamar.Show();
            this.Hide();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            frmDepartamentos llamar = new frmDepartamentos();
            llamar.Show();
            this.Hide();
        }
    }
}
