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
    public partial class FilmeDesc : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public FilmeDesc()
        {
            InitializeComponent();
        }

        private void Filme_categoria_Load(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            av1.Image = Properties.Resources.rate_fill;
            av2.Image = Properties.Resources.rate;
            av3.Image = Properties.Resources.rate;
            av4.Image = Properties.Resources.rate;
            av5.Image = Properties.Resources.rate;

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");


            if (label12.Text == "Terrifier 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 1";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Sorria")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 2";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não! Não Olhe!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 3";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Órfã 2: A Origem")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 4";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não Se Preocupe, Querida")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 5";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Marcas da Maldição")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 6";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "A Mulher Rei")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 7";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Trem-Bala")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 8";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Top Gun: Maverick")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 9";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Thor Amor e Trovão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 10";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Pantera Negra: Wakanda Para Sempre")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 11";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Adão Negro")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 12";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "My Policeman")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 13";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "After - Depois da Promessa")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 14";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor de Redenção")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 15";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Persuasão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 16";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor & Gelato")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 17";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Continência ao Amor")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 18";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Umma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 19";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Resurrection")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 20";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Naquele Fim de Semana")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 21";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 22";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Fuja")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 23";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Buscando...")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 24";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ghostbusters - Mais Além")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 25";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "De Férias da Família")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 26";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Te Peguei!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 27";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Central de Inteligência")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 28";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Alerta Vermelho")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 29";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Policial em Apuros 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 1 WHERE filme_id = 30";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("1", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }




        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            av1.Image = Properties.Resources.rate_fill;
            av2.Image = Properties.Resources.rate_fill;
            av3.Image = Properties.Resources.rate;
            av4.Image = Properties.Resources.rate;
            av5.Image = Properties.Resources.rate;

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");


            if (label12.Text == "Terrifier 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 1";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Sorria")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 2";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não! Não Olhe!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 3";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Órfã 2: A Origem")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 4";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não Se Preocupe, Querida")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 5";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Marcas da Maldição")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 6";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "A Mulher Rei")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 7";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Trem-Bala")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 8";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Top Gun: Maverick")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 9";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Thor Amor e Trovão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 10";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Pantera Negra: Wakanda Para Sempre")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 11";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Adão Negro")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 12";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "My Policeman")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 13";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "After - Depois da Promessa")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 14";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor de Redenção")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 15";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Persuasão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 16";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor & Gelato")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 17";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Continência ao Amor")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 18";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Umma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 19";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Resurrection")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 20";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Naquele Fim de Semana")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 21";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 22";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Fuja")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 23";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Buscando...")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 24";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ghostbusters - Mais Além")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 25";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "De Férias da Família")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 26";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Te Peguei!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 27";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Central de Inteligência")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 28";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Alerta Vermelho")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 29";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Policial em Apuros 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 2 WHERE filme_id = 30";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("2", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            av1.Image = Properties.Resources.rate_fill;
            av2.Image = Properties.Resources.rate_fill;
            av3.Image = Properties.Resources.rate_fill;
            av4.Image = Properties.Resources.rate;
            av5.Image = Properties.Resources.rate;

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");


            if (label12.Text == "Terrifier 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 1";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Sorria")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 2";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não! Não Olhe!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 3";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Órfã 2: A Origem")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 4";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não Se Preocupe, Querida")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 5";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Marcas da Maldição")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 6";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "A Mulher Rei")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 7";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Trem-Bala")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 8";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Top Gun: Maverick")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 9";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Thor Amor e Trovão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 10";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Pantera Negra: Wakanda Para Sempre")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 11";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Adão Negro")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 12";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "My Policeman")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 13";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "After - Depois da Promessa")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 14";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor de Redenção")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 15";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Persuasão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 16";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor & Gelato")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 17";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Continência ao Amor")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 18";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Umma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 19";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Resurrection")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 20";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Naquele Fim de Semana")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 21";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 22";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Fuja")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 23";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Buscando...")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 24";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ghostbusters - Mais Além")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 25";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "De Férias da Família")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 26";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Te Peguei!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 27";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Central de Inteligência")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 28";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Alerta Vermelho")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 29";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Policial em Apuros 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 3 WHERE filme_id = 30";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("3", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            av1.Image = Properties.Resources.rate_fill;
            av2.Image = Properties.Resources.rate_fill;
            av3.Image = Properties.Resources.rate_fill;
            av4.Image = Properties.Resources.rate_fill;
            av5.Image = Properties.Resources.rate;

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");


            if (label12.Text == "Terrifier 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 1";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Sorria")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 2";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não! Não Olhe!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 3";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Órfã 2: A Origem")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 4";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não Se Preocupe, Querida")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 5";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Marcas da Maldição")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 6";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "A Mulher Rei")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 7";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Trem-Bala")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 8";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Top Gun: Maverick")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 9";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Thor Amor e Trovão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 10";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Pantera Negra: Wakanda Para Sempre")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 11";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Adão Negro")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 12";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "My Policeman")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 13";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "After - Depois da Promessa")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 14";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor de Redenção")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 15";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Persuasão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 16";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor & Gelato")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 17";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Continência ao Amor")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 18";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Umma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 19";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Resurrection")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 20";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Naquele Fim de Semana")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 21";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 22";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Fuja")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 23";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Buscando...")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 24";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ghostbusters - Mais Além")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 25";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "De Férias da Família")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 26";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Te Peguei!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 27";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Central de Inteligência")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 28";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Alerta Vermelho")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 29";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Policial em Apuros 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 4 WHERE filme_id = 30";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("4", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            av1.Image = Properties.Resources.rate_fill;
            av2.Image = Properties.Resources.rate_fill;
            av4.Image = Properties.Resources.rate_fill;
            av3.Image = Properties.Resources.rate_fill;
            av5.Image = Properties.Resources.rate_fill;

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");


            if (label12.Text == "Terrifier 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 1";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Sorria")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 2";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não! Não Olhe!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 3";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Órfã 2: A Origem")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 4";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Não Se Preocupe, Querida")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 5";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Marcas da Maldição")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 6";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "A Mulher Rei")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 7";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Trem-Bala")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 8";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Top Gun: Maverick")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 9";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Thor Amor e Trovão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 10";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Pantera Negra: Wakanda Para Sempre")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 11";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Adão Negro")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 12";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "My Policeman")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 13";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "After - Depois da Promessa")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 14";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor de Redenção")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 15";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Persuasão")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 16";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Amor & Gelato")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 17";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Continência ao Amor")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 18";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Umma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 19";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Resurrection")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 20";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Naquele Fim de Semana")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 21";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ma")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 22";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Fuja")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 23";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Buscando...")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 24";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Ghostbusters - Mais Além")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 25";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "De Férias da Família")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 26";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Te Peguei!")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 27";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Central de Inteligência")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 28";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Alerta Vermelho")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 29";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            else if (label12.Text == "Policial em Apuros 2")
            {
                strSQL = "UPDATE filme SET filme_avaliacao = 5 WHERE filme_id = 30";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("5", av1.Image);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tendencias main = new Tendencias();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil main = new Perfil();
            main.Show();
            this.Hide();
        }

        private void FilmeDesc_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "UPDATE filme SET filme_avaliacao = 0";

            comando = new MySqlCommand(strSQL, conexao);
            conexao.Open();

            comando.ExecuteNonQuery();

            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Tendencias main = new Tendencias();
            main.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Avaliacoes main = new Avaliacoes();
            main.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            Categorias main = new Categorias();
            main.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Avaliacoes main = new Avaliacoes();
            main.Show();
            this.Hide();
        }
    }
}
