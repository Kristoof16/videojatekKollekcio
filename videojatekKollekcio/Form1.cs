using System.IO;
using System.Windows.Forms;

namespace videojatekKollekcio
{
    public partial class Form1 : Form
    {
        public List<Jatek> jatekPeldanyok = new List<Jatek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jatekokLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = jatekPeldanyok[jatekokLista.SelectedIndex].Cim;
            textBox3.Text = jatekPeldanyok[jatekokLista.SelectedIndex].Fejleszto;
            textBox1.Text = jatekPeldanyok[jatekokLista.SelectedIndex].Platform;
            textBox2.Text = jatekPeldanyok[jatekokLista.SelectedIndex].KiadasEv.ToString();
        }

        private void megnyit�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            beolvasas(openFileDialog.FileName);
        }

        private void beolvasas(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);

            jatekokLista.Items.Clear();
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Jatek jatek = new Jatek(sr.ReadLine());
                jatekPeldanyok.Add(jatek);
                jatekokLista.Items.Add(jatek.Cim);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Nincs megadva fejleszt� a keres�shez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Jatek elem in jatekPeldanyok)
            {
                if (elem.Fejleszto.Equals(textBox3.Text) && elem.Cim.Equals(textBox4.Text) == false)
                {
                    listBox2.Items.Add(elem.Cim);
                }
            }

            if (textBox3.Text.Length != 0 && listBox2.Items.Count == 0)
            {
                MessageBox.Show("Az adott fejleszt�nek nincs t�bb j�t�ka a list�ban!", "Inform�ci�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

//jatekokLista.Add(jatek);


