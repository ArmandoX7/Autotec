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
    public partial class frmModFallas : Form
    {
        public frmModFallas()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            frmFallas llamar = new frmFallas();
            llamar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIDFalla.Clear();
            txtDescripcion.Clear();
            txtIDDepartamento.Clear();
            txtPrecio.Clear();
            txtGarantia.Clear();
            txtIDRefaccionaria.Clear();
        }

        private void frmModFallas_Load(object sender, EventArgs e)
        {
            txtIDFalla.Enabled = false;
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtIDFalla.Enabled = false;
            txtIDFalla.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtIDDepartamento.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtGarantia.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            txtIDRefaccionaria.Text = this.dataGrid.CurrentRow.Cells[5].Value.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {

            txtIDFalla.Enabled = false;
            if (txtIDFalla.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    conectar.Open();
                    MySqlCommand comandoA = new MySqlCommand("UPDATE descripcion SET Descripcion='" + txtDescripcion.Text + "', idDepartamento=" + txtIDDepartamento.Text + ", Precio=" + txtPrecio.Text + ", Garantia='" + txtGarantia.Text + "', idRefaccionaria=" + txtIDRefaccionaria.Text + " WHERE idDescripcion=" + txtIDFalla.Text + "", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDFalla.Clear();
                    txtDescripcion.Clear();
                    txtIDDepartamento.Clear();
                    txtPrecio.Clear();
                    txtGarantia.Clear();
                    txtIDRefaccionaria.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }
            conectar.Close();
        }

        private void txtIDFalla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIDDepartamento.Focus();
            }
        }

        private void txtIDDepartamento_KeyDown(object sender, KeyEventArgs e)
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

        private void txtGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIDRefaccionaria.Focus();
            }
        }

        private void txtIDRefaccionaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIDFalla.Enabled = false;
                if (txtIDFalla.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    try
                    {

                        conectar.Open();
                        MySqlCommand comandoA = new MySqlCommand("UPDATE descripcion SET Descripcion='" + txtDescripcion.Text + "', idDepartamento=" + txtIDDepartamento.Text + ", Precio=" + txtPrecio.Text + ", Garantia='" + txtGarantia.Text + "', idRefaccionaria=" + txtIDRefaccionaria.Text + " WHERE idDescripcion=" + txtIDFalla.Text + "", conectar);
                        comandoA.ExecuteNonQuery();
                        MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIDFalla.Clear();
                        txtDescripcion.Clear();
                        txtIDDepartamento.Clear();
                        txtPrecio.Clear();
                        txtGarantia.Clear();
                        txtIDRefaccionaria.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error... " + ex.Message);
                    }
                }
                conectar.Close();
            }
        }
    }
}
