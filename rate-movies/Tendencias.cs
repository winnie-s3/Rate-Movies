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
    public partial class Tendencias : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Tendencias()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;

            label26.Visible = false;
            label26.BringToFront();

            label27.Visible = false;
            label27.BringToFront();

            label28.Visible = false;
            label28.BringToFront();

            label29.Visible = false;
            label29.BringToFront();

            label30.Visible = false;
            label30.BringToFront();

            label32.Visible = false;
            label32.BringToFront();

            label33.Visible = false;
            label33.BringToFront();

            label34.Visible = false;
            label34.BringToFront();

            label35.Visible = false;
            label35.BringToFront();

            label36.Visible = false;
            label36.BringToFront();

            next2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil main = new Perfil();
            Cadastro mainCad = new Cadastro();

            conexao = new MySqlConnection("Server=localhost;database=cinema;uid=root;Pwd=root;");

            strSQL = "SELECT * FROM usuario WHERE usuario_id = @usuario_id";

            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@usuario_id", mainCad.txtCodigo.Text);
            comando.Parameters.AddWithValue("@aluno_nome", main.txtNome.Text);
            comando.Parameters.AddWithValue("@aluno_email", main.txtEmail.Text);
            comando.Parameters.AddWithValue("@aluno_senha", main.txtSenha.Text);

            conexao.Open();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                main.txtCodigo.Text = Convert.ToString(dr["usuario_id"]);
                main.txtNome.Text = Convert.ToString(dr["usuario_nome"]);
                main.txtEmail.Text = Convert.ToString(dr["usuario_email"]);
                main.txtSenha.Text = Convert.ToString(dr["usuario_senha"]);
            }

            main.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.pantera_negra_wakanda_para_sempre;
            main.label12.Text = "Pantera Negra: Wakanda Para Sempre";
            main.label13.Text = "Ryan Coogler";
            main.label14.Text = "Rainha Ramonda, Shuri, M'Baku, Okoye e Dora Milaje lutam para proteger sua nação das potências mundiais intervenientes após a morte do rei T'Challa.";

            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.adao_negro;
            main.label12.Text = "Adão Negro";
            main.label13.Text = "Jaume Collet-Serra";
            main.label14.Text = "O poderoso Adão Negro é libertado de sua tumba para lançar sua justiça cruel sobre a Terra.";

            main.Show();
            this.Hide();
        }


        private void next1_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;

            next1.Visible = false;
            next2.Visible = true;

            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;

            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
        }

        private void next2_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;

            next1.Visible = true;

            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;

            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;

            next2.Visible = false;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.terrifier2;
            main.label12.Text = "Terrifier 2";
            main.label13.Text = "Damien Leone";
            main.label14.Text = "Depois de ser ressuscitado por uma entidade maligna, o palhaço Art está de volta ao condado de Miles. Agora, ele tenta caçar uma adolescente e seu irmão mais novo durante o Halloween.";

            main.Show();
            this.Hide();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.top_gun_maverick;
            main.label12.Text = "Top Gun: Maverick";
            main.label13.Text = "Joseph Kosinski";
            main.label14.Text = "Depois de mais de 30 anos de serviço como um dos principais aviadores da Marinha, Pete 'Maverick' Mitchell está de volta, rompendo os limites como um piloto de testes corajoso.";

            main.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.a_mulher_rei;
            main.label12.Text = "A Mulher Rei";
            main.label13.Text = "Gina Prince-Bythewood";
            main.label14.Text = "Em 1800, o general Nanisca treina um grupo de mulheres guerreiras para proteger o reino africano de Dahomey de um inimigo estrangeiro.";

            main.Show();
            this.Hide();
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.thor_amor_e_trovao;
            main.label12.Text = "Thor: Amor e Trovão";
            main.label13.Text = "Taika Waititi";
            main.label14.Text = "Thor busca por paz, mas seus planos são interrompidos por Gorr, o Carniceiro dos Deuses, um assassino galáctico. Para combater esta ameaça, ele pede que Rei Valquíria, Korg e Jane Foster o ajudem.";

            main.Show();
            this.Hide();
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.nao_se_preocupe_querida;
            main.label12.Text = "Não se Preocupe: Querida";
            main.label13.Text = "Olivia Wilde";
            main.label14.Text = "Uma dona de casa que vive em uma comunidade experimental começa a suspeitar que a empresa de seu marido está escondendo segredos perturbadores.";

            main.Show();
            this.Hide();
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.nao_nao_olhe;
            main.label12.Text = "Não! Não Olhe!";
            main.label13.Text = "Jordan Peele";
            main.label14.Text = "Os cuidadores de um rancho de cavalos na Califórnia encontram uma força misteriosa que afeta o comportamento humano e animal.";

            main.Show();
            this.Hide();
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.continencia_ao_amor;
            main.label12.Text = "Continência ao Amor";
            main.label13.Text = "Elizabeth Allen Rosenbaum";
            main.label14.Text = "Uma cantora se casa por conveniência com um militar que está prestes a ir para a guerra, mas uma tragédia transforma esse relacionamento de fachada em realidade.";

            main.Show();
            this.Hide();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.sorria;
            main.label12.Text = "Sorria";
            main.label13.Text = "Parker Finn";
            main.label14.Text = "Após um paciente cometer um suicídio brutal em sua frente, a psiquiatra Rose é perseguida por uma entidade maligna que muda de forma. Enquanto tenta escapar desse pesadelo, Rose também precisa enfrentar seu passado conturbado para sobreviver.";

            main.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.orfa2;
            main.label12.Text = "Órfã 2";
            main.label13.Text = "William Brent Bell";
            main.label14.Text = "Esther consegue escapar de um centro psiquiátrico onde está confinada e viaja para os Estados Unidos se passando por filha desaparecida de uma família rica. No entanto, uma mãe superprotetora fará de tudo por sua família, não importando os meios.";

            main.Show();
            this.Hide();
        }

        private void Tendencias_FormClosed(object sender, FormClosedEventArgs e)
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Categorias main = new Categorias();
            main.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Avaliacoes main = new Avaliacoes();
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
