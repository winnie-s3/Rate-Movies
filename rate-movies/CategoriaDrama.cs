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
    public partial class CategoriaDrama : Form
    {
        public CategoriaDrama()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.continencia_ao_amor;
            main.label12.Text = "Continência ao Amor";
            main.label13.Text = "Elizabeth Allen Rosenbaum";
            main.label14.Text = "Uma cantora se casa por conveniência com um militar que está prestes a ir para a guerra, mas uma tragédia transforma esse relacionamento de fachada em realidade.";

            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.amor_e_gelato;
            main.label12.Text = "Amor e Gelato";
            main.label13.Text = "Brandon Camp";
            main.label14.Text = "Atendendo ao último desejo da mãe, Lina decide passar o último verão antes da faculdade em Roma, onde descobre o amor, muitas aventuras e a paixão pelo gelato.";

            main.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.after_depois_da_promessa;
            main.label12.Text = "After - Depois da Promessa";
            main.label13.Text = "Castille Landon";
            main.label14.Text = "Enquanto Hardin confronta seu passado e Tessa sofre uma tragédia, os dois devem decidir se continuam seu relacionamento apaixonado, mas tóxico, ou fazem mudanças dramáticas em suas vidas.";

            main.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.my_policeman;
            main.label12.Text = "My Policeman";
            main.label13.Text = "Michael Grandage";
            main.label14.Text = "Tom, um policial na Grã-Bretanha dos anos 1950, se apaixona por uma professora na costa de Brighton. No entanto, ele logo começa um caso com um curador de museu, apesar da homossexualidade ser ilegal.";

            main.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.amor_de_redencao;
            main.label12.Text = "Amor de Redenção";
            main.label13.Text = "D. J. Caruso";
            main.label14.Text = "O relacionamento de um jovem casal se choca com as duras realidades da Corrida do Ouro na Califórnia de 1850. Angel, experimentando o amor pela primeira vez e enfrentando demônios que parecem insuperáveis, foge da nova vida que ela acha que não merece. No entanto, durante a busca de Michael pela sua amada, Angel descobre que ela tem o poder de escolher a vida que quer.";

            main.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.persuasao;
            main.label12.Text = "Persuasão";
            main.label13.Text = "Carrie Cracknell";
            main.label14.Text = "Anne Elliot é persuadida a não se casar com o homem que ama por causa de suas origens humildes. Oito anos depois, ele reaparece em sua vida e a moça deve decidir se dá uma segunda chance para esse amor.";

            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil main = new Perfil();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
