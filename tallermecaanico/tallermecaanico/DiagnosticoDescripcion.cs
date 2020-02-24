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
    public partial class frmDiagDesc : Form
    {
        public frmDiagDesc()
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtIDDiagnostico.Enabled = true;
            txtIDDiagnostico.Clear();
            txtIDDescripcion.Clear();
        }

        private void btnMostrarDiagnosticos_Click(object sender, EventArgs e)
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

        private void btnMostrarDescripcion_Click(object sender, EventArgs e)
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM diagdesc", conectar);

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
            
            if (txtIDDiagnostico.Text == "" || txtIDDescripcion.Text == "" )
            {
                MessageBox.Show("Error... debe ingresar todos los campos (opcional el campo de ID Refaccionaria)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();

                    MySqlCommand comando = new MySqlCommand("INSERT INTO diagdesc VALUES(" + txtIDDiagnostico.Text + "," + txtIDDescripcion.Text + ")", conectar);


                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro con exito");
                    txtIDDiagnostico.Clear();
                    txtIDDescripcion.Clear();

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
            txtIDDescripcion.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDDiagnostico.Text == "" || txtIDDescripcion.Text=="")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                try
                {
                    conectar.Open();
                    MySqlCommand comandoE = new MySqlCommand("DELETE FROM diagdesc WHERE idDiagnostico=" + txtIDDiagnostico.Text + " AND idDescripcion="+txtIDDescripcion.Text+"", conectar);
                    comandoE.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado  ", "OK");
                    txtIDDiagnostico.Clear();
                    txtIDDescripcion.Clear();

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
            if (txtIDDiagnostico.Text=="" && txtIDDescripcion.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    conectar.Open();
                    MySqlCommand comandoA = new MySqlCommand("UPDATE diagdesc SET idDescripcion=" + txtIDDescripcion.Text + " WHERE idDiagnostico=" + txtIDDiagnostico.Text + "", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDDiagnostico.Clear();
                    txtIDDescripcion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }

            txtIDDiagnostico.Enabled = true;
            conectar.Close();
        }
    }
}
