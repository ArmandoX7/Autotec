using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace tallermecaanico
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=cuentas; Uid=root; pwd=jaai96");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conactamos = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("select * from usuario where nombre = '"+txtusuario.Text+"' and password= '"+txtpass.Text+"' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if(leer.Read())
            {
                MessageBox.Show("Bienvenido");
                frmPrincipal llamar = new frmPrincipal();
                llamar.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtusuario.Text = "";
                txtpass.Text = "";
                txtusuario.Focus();

            }
            conectar.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void btnregistroc_Click(object sender, EventArgs e)
        {

        }


        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=cuentas; Uid=root; pwd=jaai96");
                conectar.Open();

                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conactamos = new MySqlConnection();
                codigo.Connection = conectar;

                codigo.CommandText = ("select * from usuario where nombre = '" + txtusuario.Text + "' and password= '" + txtpass.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("Bienvenido");
                    frmPrincipal llamar = new frmPrincipal();
                    llamar.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    txtusuario.Text = "";
                    txtpass.Text = "";
                    txtusuario.Focus();

                }
                conectar.Close();
            }

        }
    }
}
