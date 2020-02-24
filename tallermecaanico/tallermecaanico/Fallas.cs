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
    public partial class frmFallas : Form
    {
        public frmFallas()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiagnostico llamar = new frmDiagnostico();
            llamar.Show();
            this.Hide();
        }

        private void frmFallas_Load(object sender, EventArgs e)
        {
            txtIDFalla.Enabled = false;
        }

        private void btnMostrarFallas_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM descripcion", conectar);

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

        private void btnMostrarDep_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM departamento", conectar);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM refaccionaria", conectar);

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            txtIDFalla.Enabled = true;
            if (txtDescripcion.Text == "" || txtIDDepartamento.Text == "" || txtPrecio.Text == "" || txtGarantia.Text == "" )
            {
                MessageBox.Show("Error... debe ingresar todos los campos (opcional el campo de ID Refaccionaria)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                   
                    MySqlCommand comando = new MySqlCommand("INSERT INTO descripcion VALUES(null,'" + txtDescripcion.Text + "'," + txtIDDepartamento.Text + "," + txtPrecio.Text + ",'" + txtGarantia.Text + "',null)", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Falla registrada con exito");
                    txtIDFalla.Clear();
                    txtDescripcion.Clear();
                    txtIDDepartamento.Clear();
                    txtPrecio.Clear();
                    txtGarantia.Clear();
                  


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
            txtIDFalla.Enabled = false;
            txtIDFalla.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtIDDepartamento.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtGarantia.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDFalla.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                try
                {
                    conectar.Open();
                    MySqlCommand comandoE = new MySqlCommand("DELETE FROM descripcion WHERE idDescripcion=" +txtIDFalla.Text + "", conectar);
                    comandoE.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado  ", "OK");
                    txtIDFalla.Clear();
                    txtDescripcion.Clear();
                    txtIDDepartamento.Clear();
                    txtPrecio.Clear();
                    txtGarantia.Clear();
                  
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
            txtIDFalla.Clear();
            txtDescripcion.Clear();
            txtIDDepartamento.Clear();
            txtPrecio.Clear();
            txtGarantia.Clear();
            
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIDDepartamento.Focus();
            }
        }

        private void txtDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecio.Focus();
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGarantia.Focus();
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            frmModFallas llamar = new frmModFallas();
            llamar.Show();
            this.Hide();
        }

        
    }
}
