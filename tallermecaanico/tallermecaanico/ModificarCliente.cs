using MySql.Data.MySqlClient;
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
    public partial class frmModCliente : Form
    {
        public frmModCliente()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            frmcliente llamar = new frmcliente();
            llamar.Show();
            this.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtID.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtPromo.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();

        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                    MySqlCommand comandoA = new MySqlCommand("UPDATE cliente SET nombres='" + txtNombre.Text + "', apellidos='" + txtApellido.Text + "', telefono=" + txtTelefono.Text + ", promocion=" + txtPromo.Text + " WHERE idCliente=" + txtID.Text + "", conectar);
                    comandoA.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado con exito !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();
                    txtPromo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                }
            }


            conectar.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtPromo.Clear();
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
                txtPromo.Focus();
            }
        }
    }
}
