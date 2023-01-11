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
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

                strSQL = "INSERT INTO usuario (usuario_id, usuario_nome, usuario_email, usuario_senha) VALUES (@usuario_id, @usuario_nome, @usuario_email, @usuario_senha)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@usuario_id", txtCodigo.Text);
                comando.Parameters.AddWithValue("@usuario_nome", txtNome.Text);
                comando.Parameters.AddWithValue("@usuario_email", txtEmail.Text);
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
                conexao.Close();
                conexao = null;
                comando = null;

                Tendencias main = new Tendencias();
                main.Show();
                this.Hide();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "UPDATE filme SET filme_avaliacao = 0";

            comando = new MySqlCommand(strSQL, conexao);
            conexao.Open();

            comando.ExecuteNonQuery();

            Application.Exit();
        }
    }
}
