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
    public partial class frmempleados : Form
    {
        public frmempleados()
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

        private void btnguardare_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtRango.Text== "")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO empleado VALUES(null,'" + txtNombre.Text + "','" + txtApellido.Text + "',"+txtTelefono.Text+",'" + txtRango.Text+ "')", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Empleado registrado con exito");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();

                    txtRango.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
            }
            conectar.Close();
        }

        private void frmempleados_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtID.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtRango.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                try
                {
                    conectar.Open();
                    MySqlCommand comandoE = new MySqlCommand("DELETE FROM empleado WHERE idEmpleado=" + txtID.Text + "", conectar);
                    comandoE.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado  ", "OK");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();
                    txtRango.Clear();


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
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comandoA = new MySqlCommand("UPDATE empleado SET Nombres='" + txtNombre.Text + "', Apellidos='" + txtApellido.Text + "', Telefono=" + txtTelefono.Text + ", Rango='" + txtRango.Text + "' WHERE idEmpleado=" + txtID.Text + "", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();
                    txtRango.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }


            conectar.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtRango.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("No escribio nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Focus();

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comandom = new MySqlCommand("SELECT * FROM empleado WHERE idEmpleado=" + txtBuscar.Text + "", conectar);

                    MySqlDataAdapter con = new MySqlDataAdapter(comandom);
                    ds = new DataSet();
                    con.Fill(ds);

                    dataGrid.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                }
            }

            conectar.Close();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRango.Focus();
            }
        }

        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtRango.Text == "")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO empleado VALUES(null,'" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",'" + txtRango.Text + "')", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Empleado registrado con exito");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();

                    txtRango.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
            }
            conectar.Close();
        }
    }
}
