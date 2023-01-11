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

namespace rate_movies
{
    public partial class Perfil : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        public Perfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "DELETE FROM usuario WHERE usuario_id = @usuario_id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tendencias main = new Tendencias();
            main.Show();
            this.Hide();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "UPDATE usuario SET usuario_nome = @usuario_nome WHERE usuario_id = @usuario_id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);
                comando.Parameters.AddWithValue("@usuario_nome", txtNome.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "UPDATE usuario SET usuario_email = @usuario_email WHERE usuario_id = @usuario_id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);
                comando.Parameters.AddWithValue("@usuario_email", txtEmail.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "UPDATE usuario SET usuario_senha = @usuario_senha WHERE usuario_id = @usuario_id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);
                comando.Parameters.AddWithValue("@usuario_senha", txtSenha.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void Perfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "UPDATE filme SET filme_avaliacao = 0";

            comando = new MySqlCommand(strSQL, conexao);
            conexao.Open();

            comando.ExecuteNonQuery();

            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "SELECT * FROM usuario WHERE usuario_id = @usuario_id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);
                comando.Parameters.AddWithValue("@usuario_nome", txtNome.Text);
                comando.Parameters.AddWithValue("@usuario_email", txtEmail.Text);
                comando.Parameters.AddWithValue("@usuario_senha", txtSenha.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtCodigo.Text = Convert.ToString(dr["usuario_id"]);
                    txtNome.Text = Convert.ToString(dr["usuario_nome"]);
                    txtEmail.Text = Convert.ToString(dr["usuario_email"]);
                    txtSenha.Text = Convert.ToString(dr["usuario_senha"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;
            }
        }
    }
}
