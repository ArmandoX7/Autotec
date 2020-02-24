using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tallermecaanico
{
    public partial class frmauto : Form
    {
        public frmauto()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcliente llamar = new frmcliente();
            llamar.Show();
            this.Hide();
        }

        private void frmauto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarC_Click(object sender, EventArgs e)
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

        private void btnguardarA_Click(object sender, EventArgs e)
        {
            if (txtSerie.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtColor.Text=="" || txtID.Text=="")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO automovil VALUES('" + txtSerie.Text + "','" + txtMarca.Text + "','" + txtModelo.Text + "',"+ txtAno.Text +",'"+ txtColor.Text +"',"+ txtID.Text +")", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Automovil registrado con exito");
                    txtSerie.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAno.Clear();
                    txtColor.Clear();
                    txtID.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
            }
            conectar.Close();
        }

        private void btnMostrarA_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                MySqlCommand comandom = new MySqlCommand("SELECT * FROM automovil", conectar);

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
            txtSerie.Enabled = false;
            txtSerie.Text= this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtModelo.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtAno.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtColor.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            txtID.Text= this.dataGrid.CurrentRow.Cells[5].Value.ToString();

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
                    MySqlCommand comandoE = new MySqlCommand("DELETE FROM automovil WHERE NumSerie='" + txtSerie.Text + "'", conectar);
                    comandoE.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado  ", "OK");
                    txtSerie.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAno.Clear();
                    txtColor.Clear();
                    txtID.Clear();
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
            txtSerie.Enabled = false;
            if (txtSerie.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    conectar.Open();
                    MySqlCommand comandoA = new MySqlCommand("UPDATE automovil SET Marca='" + txtMarca.Text + "', Modelo='" + txtModelo.Text + "', Año=" + txtAno.Text + ", Color='" + txtColor.Text + "' WHERE NumSerie='" + txtSerie.Text + "'", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSerie.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAno.Clear();
                    txtColor.Clear();
                    txtID.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }

            txtSerie.Enabled = true;
            conectar.Close();
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
            }
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModelo.Focus();
            }
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAno.Focus();
            }
        }

        private void txtAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtColor.Focus();
            }
        }

        private void txtColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtID.Focus();
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerie.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtColor.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO automovil VALUES('" + txtSerie.Text + "','" + txtMarca.Text + "','" + txtModelo.Text + "'," + txtAno.Text + ",'" + txtColor.Text + "'," + txtID.Text + ")", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado con exito");
                    txtSerie.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAno.Clear();
                    txtColor.Clear();
                    txtID.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
            }
            conectar.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSerie.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtColor.Clear();
            txtID.Clear();
        }
    }
}
