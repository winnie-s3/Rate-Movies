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
    public partial class CategoriaSuspense : Form
    {
        public CategoriaSuspense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categorias main = new Categorias();
            main.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.umma;
            main.label12.Text = "Umma";
            main.label13.Text = "Iris Shim";
            main.label14.Text = "Amanda e sua filha vivem uma vida tranquila em uma fazenda do interior dos Estados Unidos. Quando as cinzas de sua mãe chegam da Coreia, ela começa a ser assombrada pela ideia de que está se transformando nela.";

            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.ma;
            main.label12.Text = "Ma";
            main.label13.Text = "Tate Taylor";
            main.label14.Text = "Uma mulher solteira de meia-idade faz amizade com alguns adolescentes e decide deixá-los festejar em sua casa. Mas começam a acontecer coisas que fazem os garotos questionar a intenção da anfitriã.";

            main.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.fuja;
            main.label12.Text = "Fuja";
            main.label13.Text = "Aneesh Chaganty";
            main.label14.Text = "Após anos vivendo isolada do mundo e sendo cuidada por sua rígida mãe, Chloe começa a desconfiar que há algo extremamente errado em sua vida.";

            main.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.buscando;
            main.label12.Text = "Buscando...";
            main.label13.Text = "Aneesh Chaganty";
            main.label14.Text = "David Kim se desespera quando sua filha de 16 anos desaparece e as investigações policiais não levam a lugar nenhum. Decidido a descobrir o paradeiro da filha, ele usa o computador da menina para vasculhar suas fotos e vídeos em busca de pistas.";

            main.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.resurrection;
            main.label12.Text = "Resurrection";
            main.label13.Text = "Andrew Semans";
            main.label14.Text = "A vida de Margaret é extremamente organizada e ela é muito bem-sucedida e feliz. No entanto, seu mundo aparentemente perfeito começa a se desfazer quando ela percebe que uma figura aterrorizante de seu passado reaparece.";

            main.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.naquele_fim_de_semana;
            main.label12.Text = "Naquele Fim de Semana";
            main.label13.Text = "Kim Farrant";
            main.label14.Text = "A melhor amiga de Beth desaparece em uma viagem de férias na Croácia e a moça corre para tentar descobrir o que aconteceu. Aos poucos, ela se envolve em uma perigosa teia de mentiras.";

            main.Show();
            this.Hide();
        }

        private void CategoriaSuspense_Load(object sender, EventArgs e)
        {

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
