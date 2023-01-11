using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rate_movies
{
    public partial class CategoriaTerror : Form
    {
        public CategoriaTerror()
        {
            InitializeComponent();
        }

        private void CategoriaTerror_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.terrifier2;
            main.label12.Text = "Terrifier 2";
            main.label13.Text = "Damien Leone";
            main.label14.Text = "Depois de ser ressuscitado por uma entidade maligna, o palhaço Art está de volta ao condado de Miles. Agora, ele tenta caçar uma adolescente e seu irmão mais novo durante o Halloween.";

            main.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.orfa2;
            main.label12.Text = "Órfã 2";
            main.label13.Text = "William Brent Bell";
            main.label14.Text = "Esther consegue escapar de um centro psiquiátrico onde está confinada e viaja para os Estados Unidos se passando por filha desaparecida de uma família rica. No entanto, uma mãe superprotetora fará de tudo por sua família, não importando os meios.";

            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.sorria;
            main.label12.Text = "Sorria";
            main.label13.Text = "Parker Finn";
            main.label14.Text = "Após um paciente cometer um suicídio brutal em sua frente, a psiquiatra Rose é perseguida por uma entidade maligna que muda de forma. Enquanto tenta escapar desse pesadelo, Rose também precisa enfrentar seu passado conturbado para sobreviver.";

            main.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.nao_nao_olhe;
            main.label12.Text = "Não! Não Olhe!";
            main.label13.Text = "Jordan Peele";
            main.label14.Text = "Os cuidadores de um rancho de cavalos na Califórnia encontram uma força misteriosa que afeta o comportamento humano e animal.";

            main.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.nao_se_preocupe_querida;
            main.label12.Text = "Não se Preocupe: Querida";
            main.label13.Text = "Olivia Wilde";
            main.label14.Text = "Uma dona de casa que vive em uma comunidade experimental começa a suspeitar que a empresa de seu marido está escondendo segredos perturbadores.";

            main.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.marcas_da_maldição;
            main.label12.Text = "Marcas da Maldição";
            main.label13.Text = "Kevin Ko";
            main.label14.Text = "No passado, Li Ronan quebrou um tabu religioso e foi amaldiçoada. Agora, ela precisa proteger a filha das consequências de seus atos.";

            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorias main = new Categorias();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil main = new Perfil();
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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Avaliacoes main = new Avaliacoes();
            main.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Tendencias main = new Tendencias();
            main.Show();
            this.Hide();
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
    }
}
