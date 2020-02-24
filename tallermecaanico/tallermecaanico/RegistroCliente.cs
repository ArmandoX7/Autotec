using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace tallermecaanico
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; database=autotec; Uid=root; pwd=jaai96");
        DataSet ds;
        
       
        private void frmcliente_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;


        }

       
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="" || txtApellido.Text=="" || txtTelefono.Text == "")
            {
                MessageBox.Show("Error... debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO cliente VALUES(null,'" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",null)", conectar);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado con exito");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
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


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO cliente VALUES(null,'" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",null)", conectar);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado con exito");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error... " + ex.Message);
                    conectar.Close();
                }
                
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try { 
            conectar.Open();
            MySqlCommand comandom = new MySqlCommand("SELECT * FROM cliente",conectar);

            MySqlDataAdapter con = new MySqlDataAdapter(comandom);
            ds = new DataSet();
            con.Fill(ds);

            dataGrid.DataSource = ds.Tables[0];
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
            conectar.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtID.Text= this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal llamar = new frmPrincipal();
            llamar.Show();
            this.Hide();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro y dar click en el boton selecionar","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else { 
            
            try
            {
                conectar.Open();
                MySqlCommand comandoE = new MySqlCommand("DELETE FROM cliente WHERE idCliente=" + txtID.Text + "", conectar);
                comandoE.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado  ", "OK");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtTelefono.Clear();
                   

                }
            catch(Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }
            }
            conectar.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmModCliente llamar = new frmModCliente();
            llamar.Show();
            this.Hide();
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
                    MySqlCommand comandom = new MySqlCommand("SELECT * FROM cliente WHERE idCliente=" + txtBuscar.Text + "", conectar);

                    MySqlDataAdapter con = new MySqlDataAdapter(comandom);
                    ds = new DataSet();
                    con.Fill(ds);

                    dataGrid.DataSource = ds.Tables[0];

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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmauto llamar = new frmauto();
            llamar.Show();
            this.Hide();
        }
    }
}
