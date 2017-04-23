using Blackjack.Cartas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.Vistas
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
            Prueba();
        }


        private void Prueba()
        {
            Carta carta = new Carta();
            Dictionary<string, string> datos = carta.BarajarYRepartir();
            string direccion = datos.Where(i => i.Key.Equals("cards")).Select(i => i.Value).First().ToString();


            string[] h = direccion.Split('"');

            string s = h[3];
            string k = h[29];



            CartasCasa(pnlCartasCasa, new String[] { s, k });
            CrearCartas(panel1, new String[] { s, k });



            //Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            //t.add(pictureBox1, "Top", 260);
            // t.run();
            /*
            Transition ts = new Transition(new TransitionType_EaseInEaseOut(2000));
            ts.add(pictureBox2, "Top", 260);
            ts.run();
            /*/


        }


        private void CartasCasa(Panel panelCartas, string[] cartas = null)
        {
            int count = panelCartas.Controls.OfType<PictureBox>().Count();

            int x = 137, y = 22; // x+32
            int j = count + cartas.Length;
            if (j == 3)
                x = x - 32;


            if (count == 4)
                return;

            PictureBox[] pics = new PictureBox[cartas.Length];
            ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i] = new PictureBox();
                pics[i].Anchor = AnchorStyles.Top;
                pics[i].Size = new Size(87, 117);
                pics[i].Location = new Point(x = ((count == 0) ? x : x - (32 * count)), y);
                pics[i].BringToFront();
                pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                panelCartas.Controls.Add(pics[i]);
                if (count == 0)
                    x = x - 32;
            }
        }

        private void CrearCartas(Panel panelCartas, string[] cartas = null)
        {
            int count = panelCartas.Controls.OfType<PictureBox>().Count();

            int x = 137, y = 15; // x+32
            int j = count + cartas.Length;
            if (j == 3)
                x = x - 32;


            if (count == 4)
                return;

            PictureBox[] pics = new PictureBox[cartas.Length];
            ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i] = new PictureBox();
                pics[i].Anchor = AnchorStyles.Top;
                pics[i].Size = new Size(87, 117);
                pics[i].Location = new Point(x = ((count == 0) ? x : x - (32 * count)), y);
                pics[i].BringToFront();
                pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                panelCartas.Controls.Add(pics[i]);
                if (count == 0)
                    x = x - 32;
            }
        }

        private void pnlCartasCasa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
