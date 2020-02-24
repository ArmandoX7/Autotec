using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tallermecaanico
{
    public partial class frmDiagnostico : Form
    {
        public frmDiagnostico()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal llamar = new frmPrincipal();
            llamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFallas llamar = new frmFallas();
            llamar.Show();
            this.Hide();
        }

        private void frmDiagnostico_Load(object sender, EventArgs e)
        {
            txtIDDiagnostico.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIDDiagnostico.Clear();
            txtIDEmpleado.Clear();
            txtIDCliente.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text == "" || txtIDCliente.Text == "")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO diagnostico VALUES(null," + txtIDEmpleado.Text + "," + txtIDCliente.Text + ")", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Diagnostico registrado con exito");
                    txtIDDiagnostico.Clear();
                    txtIDEmpleado.Clear();
                    txtIDCliente.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
            }
            conectar.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtIDDiagnostico.Enabled = false;
            txtIDDiagnostico.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtIDEmpleado.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtIDCliente.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnMostrarDiag_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM diagnostico", conectar);

                MySqlDataAdapter con = new MySqlDataAdapter(comandom);
                ds = new DataSet();
                con.Fill(ds);

                dataGrid.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
            conectar.Close();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM empleado", conectar);

                MySqlDataAdapter con = new MySqlDataAdapter(comandom);
                ds = new DataSet();
                con.Fill(ds);

                dataGrid.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
            conectar.Close();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM cliente", conectar);

                MySqlDataAdapter con = new MySqlDataAdapter(comandom);
                ds = new DataSet();
                con.Fill(ds);

                dataGrid.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
            conectar.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDDiagnostico.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                try
                {
                    conectar.Open();
                    MySqlCommand comandoE = new MySqlCommand("DELETE FROM diagnostico WHERE idDiagnostico=" + txtIDDiagnostico.Text + "", conectar);
                    comandoE.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado  ", "OK");
                    txtIDDiagnostico.Clear();
                    txtIDEmpleado.Clear();
                    txtIDCliente.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }
            conectar.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtIDDiagnostico.Enabled = false;
            if (txtIDDiagnostico.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    conectar.Open();
                    MySqlCommand comandoA = new MySqlCommand("UPDATE diagnostico SET idEmpleado=" + txtIDEmpleado.Text + ", idCliente=" + txtIDCliente.Text + " WHERE idDiagnostico=" + txtIDDiagnostico.Text + "", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDDiagnostico.Clear();
                    txtIDEmpleado.Clear();
                    txtIDCliente.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }

            
            conectar.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDiagDesc llamar = new frmDiagDesc();
            llamar.Show();
            this.Hide();
        }
    }
}
