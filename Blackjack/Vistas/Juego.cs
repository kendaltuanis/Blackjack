using Blackjack.Controladores;
using Blackjack.Modelos;
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

        private CartaControl ocartacontrol;
        private string deck_id_actual;


        public Juego()
        {
            InitializeComponent();
            this.ocartacontrol = new CartaControl();
            Prueba();
        }


        private void Prueba()
        {



            CartasIniciales(pnlCartasCasa,true);
            CartasIniciales(panel1);
            // CartasCasa(pnlCartasCasa, new String[] { s, k ,s,k,s,k});

            //CrearCartas(panel1, TraerCarta(1));



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


        private void CartasIniciales(Panel panelCartas, bool isCasa=false) {

            int x = 137, y = 22; // x+32
            string[] cartas = this.ocartacontrol.BarajarYRepartir(ref deck_id_actual); 

            PictureBox[] pics = new PictureBox[cartas.Length];
            ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i] = new PictureBox();
                pics[i].Anchor = AnchorStyles.Top;
                pics[i].Size = new Size(87, 117);
                pics[i].Location = new Point(x,y);
                pics[i].BringToFront();
                pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                if(i==1 && isCasa)
                    pics[i].Image = (Image)rm.GetObject("BA");
                else
                    pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));

                panelCartas.Controls.Add(pics[i]);

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
