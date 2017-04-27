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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blackjack.Utils;
using MetroFramework.Forms;

namespace Blackjack.Vistas
{
    public partial class Juego : MetroForm
    {

        ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
        private CartaControl ocartacontrol;
        private string deck_id_actual, carta_tapada;
        private PictureBox pBCasa;
        int casa, jugador,tipo,cartas_jugador=2;
        Boolean casa_As=false, jugador_As=false;


        public Juego()
        {
            InitializeComponent();
            this.ocartacontrol = new CartaControl();
            Prueba();
        }


        private void Prueba()
        {



            //Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            //t.add(pictureBox1, "Top", 260);
            // t.run();
            /*
            Transition ts = new Transition(new TransitionType_EaseInEaseOut(2000));
            ts.add(pictureBox2, "Top", 260);
            ts.run();
            /*/


        }

        private void CartasIniciales(Panel panelCartas,bool isCasa=false) {

            int x = 137, y = 22; // x+32
            string[] cartas = this.ocartacontrol.BarajarYRepartir(ref deck_id_actual);
            tipo = 0;

            PictureBox[] pics = new PictureBox[cartas.Length];
            ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
            for (int i = 0; i < pics.Length; i++)
            {
                this.Invoke((MethodInvoker)delegate {
                    pics[i] = new PictureBox();
                    pics[i].Anchor = AnchorStyles.Top;
                    pics[i].Size = new Size(87, 117);
                    pics[i].Location = new Point(x, y);
                    pics[i].BringToFront();
                    pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    panelCartas.Controls.Add(pics[i]);

                    if (i == 1 && isCasa)
                    {
                        pics[i].Image = (Image)rm.GetObject("BA");
                        tipo += ConvertirNumeros(cartas[i], isCasa);
                        carta_tapada = string.Format("_{0}", cartas[i]);
                        pBCasa = pics[i];
                    }
                    else
                    {
                        pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                        tipo += ConvertirNumeros(cartas[i],isCasa);
                    }
                    x = x - 32;
                });
                
                }
            }

        private void PedirCarta(Panel panelCartas, bool isCasa=false)
        {
            int count = panelCartas.Controls.OfType<PictureBox>().Count();
            int x = 137-(32*count), y = 22; // x+32
            string[] cartas = this.ocartacontrol.Repartir(deck_id_actual,1);

            PictureBox[] pics = new PictureBox[cartas.Length];
            for (int i = 0; i < pics.Length; i++)
            {
                if (cartas[i] != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        pics[i] = new PictureBox();
                        pics[i].Anchor = AnchorStyles.Top;
                        pics[i].Size = new Size(87, 117);
                        pics[i].Location = new Point(x, y);
                        pics[i].BringToFront();
                        pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                        tipo = ConvertirNumeros(cartas[i], isCasa);

                        panelCartas.Controls.Add(pics[i]);
                        x = x - 32;
                    });
            }
            }
        }

        private void pnlCartasCasa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(ExecuteInForegroundCartas).Start();
        }

        private void Resultado(bool isPlanto=false) {
            Reglas r = new Reglas();
            switch (r.resultado(casa, jugador, casa_As, jugador_As, cartas_jugador, isPlanto,ref jugador,ref casa))
            {
                case 'c':
                    Console.WriteLine("GANO CASA");
                    break;
                case 'j':
                    Console.WriteLine("GANO JUGADOR");
                    break;
                case 'e':
                    Console.WriteLine("EMPATO");
                    break;
                case 'n':
                    Console.WriteLine("NADA");
                    break;
            }

            Console.WriteLine("Casa{0} ",casa);
            Console.WriteLine("Jugador{0} ", jugador);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(ExecuteInForeground).Start();
        }

        private void ExecuteInForeground()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Invoke((MethodInvoker)delegate {
                    lblPensando.Text =lblPensando.Text+".";
                });
                Thread.Sleep(1000);
            }

        }

        private void ExecuteInForegroundCartas()

        {

            CartasIniciales(pnlCartasCasa,true);
            casa = tipo;

            CartasIniciales(panel1);
            jugador = tipo;

            Resultado();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PedirCarta(pnlCartasCasa,casa_As);
            casa += tipo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PedirCarta(panel1);
            cartas_jugador +=1;
            jugador += tipo;
            Resultado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblPensando.Visible = true;
            new Thread(ExecuteInForeground).Start();
            new Thread(ExecuteInForegroundPedirCarta).Start();

        }


        private void ExecuteInForegroundPedirCarta()

        {
            while (true) {
                if (casa < 17)
                {
                    PedirCarta(pnlCartasCasa, true);
                    casa += tipo;
                    pBCasa.Image = (Image)rm.GetObject(carta_tapada);
                }
                Resultado(true);
                Thread.Sleep(2000);
                if (casa >= 17) {
                    this.Invoke((MethodInvoker)delegate {
                        lblPensando.Visible = false;
                    });
                    return;
                }

            }

        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Juego j = new Juego();
            j.Show();
        }

        private int ConvertirNumeros(string carta, Boolean isCasa) {

            string[] letras = new string[] { "Q","K","J"};
            string letra = "";
            int num;

            try
            {
                 num = Convert.ToInt32(carta.Substring(0, 1));
                if (num == 0)
                    return 10;

            }
            catch (Exception)
            {
                letra = carta.Substring(0, 1);

                foreach (string item in letras)
                {
                    if (item.Equals(letra)) {
                        return 10;
                    }                      
                }
                if (isCasa)
                    casa_As = true;
                else
                    jugador_As = true;

                return 11;
            }
            return num;
            
        }
    }
}
