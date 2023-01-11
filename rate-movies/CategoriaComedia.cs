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
    public partial class CategoriaComedia : Form
    {
        public CategoriaComedia()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.ghostbusters_mais_alem;
            main.label12.Text = "Ghostbuster - Mais Além";
            main.label13.Text = "Jason Reitman";
            main.label14.Text = "Uma mãe solo e seus dois filhos se mudam para uma nova cidade e descobrem que têm uma conexão com os Caça-Fantasmas originais e o legado secreto de seu avô.";

            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.policial_em_apuros_2;
            main.label12.Text = "Policial em Apuros 2";
            main.label13.Text = "Tim Story";
            main.label14.Text = "Ben Barber deseja tornar-se um detetive, assim como James Payton, seu futuro cunhado. Relutantemente, James leva Ben para Miami em busca de pistas sobre um cartel de drogas.";

            main.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.te_peguei;
            main.label12.Text = "Te Peguei!";
            main.label13.Text = "Jeff Tomsic";
            main.label14.Text = "Desde a primeira série na escola, um grupo de cinco amigos tem um hábito curioso que realiza pelo menos uma vez ao ano: brincar enlouquecidamente de pega-pega, correndo em uma competição alucinante para ser o último homem de pé ao final da brincadeira, arriscando seus empregos e relacionamentos.";

            main.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.alerta_vermelho;
            main.label12.Text = "Alerta Vermelho";
            main.label13.Text = "Rawson Marshall Thurber";
            main.label14.Text = "Um alerta vermelho da Interpol é emitido e o agente do FBI John Hartley assume o caso. Durante sua busca, ele se vê diante de um assalto ousado e é forçado a se aliar ao maior ladrão de arte da história, Nolan Booth, para capturar a ladra de arte mais procurada do mundo atualmente, Sarah Black.";

            main.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.central_de_inteligencia;
            main.label12.Text = "Central de Inteligência";
            main.label13.Text = "Rawson Marshall Thurber";
            main.label14.Text = "Antes de se tornar um agente da CIA, Bob sofria bullying na época do colégio. Na agência, ele precisa resolver um caso ultrassecreto e recorre a um antigo colega, popular nos tempos da escola, hoje contador.";

            main.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilmeDesc main = new FilmeDesc();

            main.pictureBox5.Image = Properties.Resources.de_ferias_com_a_familia;
            main.label12.Text = "De Férias da Família";
            main.label13.Text = "John Hamburg";
            main.label14.Text = "De férias sem a família pela primeira vez em anos, um pai dedicado parte para o aniversário alucinante de um velho amigo festeiro.";

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

        private void CategoriaComedia_Load(object sender, EventArgs e)
        {

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
