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
    public partial class Avaliacoes : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        string strSQL;

        public Avaliacoes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil main = new Perfil();
            main.Show();
            this.Hide();
        }

        private void Avaliacoes_Load(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "SELECT filme_nome, filme_avaliacao FROM filme WHERE filme_avaliacao > 0";

            da = new MySqlDataAdapter(strSQL, conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Avaliacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "UPDATE filme SET filme_avaliacao = 0";

            comando = new MySqlCommand(strSQL, conexao);
            conexao.Open();


            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Avaliacoes main = new Avaliacoes();
            main.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Categorias main = new Categorias();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tendencias main = new Tendencias();
            main.Show();
            this.Hide();
        }
    }
}
