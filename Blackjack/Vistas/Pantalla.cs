using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Transitions;
using System.Resources;
using System.Reflection;
using System.Threading;
using Blackjack.Controladores;
using Blackjack.Utils;
using MetroFramework;

namespace Blackjack.Vistas
{
    public partial class Pantalla : MetroForm
    {
        ResourceManager rm = new ResourceManager("Blackjack.Properties.Resources", Assembly.GetExecutingAssembly());
        private CartaControl ocartacontrol;
        private string deck_id_actual, carta_tapada;
        private PictureBox picCasa, picCartaSplit;
        int casa, jugador, jugador_split,tipo, cartas_jugador = 2,cartas_casa=2,cartas_jugador_split;
        Boolean casa_As = false, jugador_As = false;
        int casa_ganadas=0, jugador_ganadas=0,empates=0;

        public Pantalla()
        {
            InitializeComponent();
            this.ocartacontrol = new CartaControl();
        }

        private void CartasIniciales(bool isCasa = false)
        {
            int x, y=0;
            if (isCasa)
                x = 255;
            else
                x = 375;
            string[] cartas;

            if (deck_id_actual==null)
                cartas = this.ocartacontrol.BarajarYRepartir(ref deck_id_actual);
            else
                cartas = this.ocartacontrol.Repartir(deck_id_actual,2);

            tipo = 0;

            PictureBox[] pics = new PictureBox[cartas.Length];
            for (int i = 0; i < pics.Length; i++)
            {
                if (cartas[i] != null) {
                    this.Invoke((MethodInvoker)delegate
                    {
                        y = 53;
                        pics[i] = new PictureBox();
                        pics[i].Anchor = AnchorStyles.Top;
                        pics[i].Size = new Size(76, 103);
                        pics[i].Location = new Point(x, y);
                        pics[i].BringToFront();
                        pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        this.Controls.Add(pics[i]);
                        pnlCartasJugador.SendToBack();
                        pnlCartasCasa.SendToBack();
                        pnlMain.SendToBack();
                        Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                        if (isCasa)
                        {
                            //   t.add(pics[i], "Left", 250);

                        }
                        else
                        {
                            t.add(pics[i], "Top", 316);
                        }

                        t.run();

                        if (i == 1 && isCasa)
                        {
                            pics[i].Image = (Image)rm.GetObject("BA");
                            tipo += ConvertirNumeros(cartas[i], isCasa);
                            carta_tapada = string.Format("_{0}", cartas[i]);
                            picCasa = pics[i];
                        }
                        else
                        {
                            pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                            tipo += ConvertirNumeros(cartas[i], isCasa);
                        }
                        x = x - 20;
                    });
                    Thread.Sleep(500);
                    this.Invoke((MethodInvoker)delegate
                    {
                        if ((i + 1) == pics.Length && isCasa)
                        {
                            new Thread(TraerPanelBotones).Start();
                            pnlBotones.Visible = true;
                        }
                        if (i == 0 && isCasa)
                        {
                            isSeguro(cartas[i]);
                        }
                    if (i == 1 && !isCasa && cartas[0].Substring(0,1) == cartas[i].Substring(0, 1)) 
                            isSplit(pics[i]);
                    });
                    if (picCartaSplit != null && !isCasa) {
                        Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                        t.add(picCartaSplit, "Left", 230);
                        t.run();
                        cartas_jugador--; ;
                        tipo = tipo- ConvertirNumeros(cartas[i], isCasa);
                        jugador_split = tipo;
                        cartas_jugador_split++;
                        Console.WriteLine(picCartaSplit.Location.ToString());
                    }                        
                }

            }
        }

        private int ConvertirNumeros(string carta, Boolean isCasa)
        {

            string[] letras = new string[] { "Q", "K", "J" };
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
                    if (item.Equals(letra))
                    {
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

        private void ExecuteInForegroundCartasIniciales() {
            CartasIniciales();
            jugador = tipo;

            CartasIniciales(true);
            casa = tipo;

            Resultado();

        }

        private void ExecuteInForegroundPedirCarta()
        {
            PedirCarta(cartas_jugador);
            cartas_jugador += 1;
            jugador += tipo;
            Resultado();
        }

        private void ExecuteInForegroundPedirCartaSplit()
        {
            PedirCartaSplit(cartas_jugador_split);
            jugador_split++;
            cartas_jugador_split++;
            Resultado();
        }

        private void ExecuteInForegroundPedirCartaCasa()

        {
            while (true)
            {
                if (casa < 17)
                {
                    PedirCarta(cartas_casa, true);
                    casa += tipo;
                    picCasa.Image = (Image)rm.GetObject(carta_tapada);
                }
                Resultado(true);
                Thread.Sleep(500);
                if (casa >= 17)
                {
                    this.Invoke((MethodInvoker)delegate {
                        lblPensando.Visible = false;
                    });
                    return;
                }

            }

        }

        private void ExecuteInForeground()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Invoke((MethodInvoker)delegate {
                    lblPensando.Text = lblPensando.Text + ".";
                });
                Thread.Sleep(300);
            }

        }

        private void PedirCarta(int cartas_total,bool isCasa = false)
        {
            int count = cartas_total;

            int x = 0, y = 0;
            if (!isCasa)
                x = 375 - (20 * count); // x+25
            else
                x = 255 - (20*count);
            


            string[] cartas = this.ocartacontrol.Repartir(deck_id_actual, 1);

            PictureBox[] pics = new PictureBox[cartas.Length];
            for (int i = 0; i < pics.Length; i++)
            {
                if (cartas[i] != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {

                        y = 52;
                        pics[i] = new PictureBox();
                        pics[i].Anchor = AnchorStyles.Top;
                        pics[i].Size = new Size(76, 103);
                        pics[i].Location = new Point(x, y);
                        pics[i].BringToFront();
                        y = 316;
                        pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                        tipo = ConvertirNumeros(cartas[i], isCasa);
                        this.Controls.Add(pics[i]);
                        pnlCartasJugador.SendToBack();
                        pnlCartasCasa.SendToBack();
                        pnlMain.SendToBack();
                        if (!isCasa) { 
                        Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                        t.add(pics[i], "Top", y);
                        t.run();
                        }
                        x = x - 20;
                    });
                    Thread.Sleep(500);
                    this.Invoke((MethodInvoker)delegate
                    {
                        tilePedirCarta.Enabled = true;
                    });

                }
            }
        }

        private void PedirCartaSplit(int cartas_total, bool isCasa = false)
        {
            int count = cartas_total;

            int x = 230 - (20 * count), y = 0;


            string[] cartas = this.ocartacontrol.Repartir(deck_id_actual, 1);

            PictureBox[] pics = new PictureBox[cartas.Length];
            for (int i = 0; i < pics.Length; i++)
            {
                if (cartas[i] != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {

                        y = 316;
                        pics[i] = new PictureBox();
                        pics[i].Anchor = AnchorStyles.Top;
                        pics[i].Size = new Size(76, 103);
                        pics[i].Location = new Point(x, y);
                        pics[i].BringToFront();
                        pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pics[i].Image = (Image)rm.GetObject(string.Format("_{0}", cartas[i]));
                        tipo = ConvertirNumeros(cartas[i], isCasa);
                        this.Controls.Add(pics[i]);
                        pnlCartasJugador.SendToBack();
                        pnlCartasCasa.SendToBack();
                        pnlMain.SendToBack();
                        x = x - 20;
                    });
                    Thread.Sleep(500);
                    this.Invoke((MethodInvoker)delegate
                    {
                        tilePedirCarta.Enabled = true;
                    });

                }
            }
        }

        private void Resultado(bool isPlanto = false)
        {
            this.Invoke((MethodInvoker)delegate {
                lblDeck.Text = string.Format("Deck_id:   {0}", deck_id_actual);
            });


            Reglas r = new Reglas();
            switch (r.resultado(casa, jugador, casa_As, jugador_As, cartas_jugador, isPlanto,ref jugador,ref casa))
            {
                case 'c':
                    picCasa.Image = (Image)rm.GetObject(carta_tapada);
                    Console.WriteLine("GANO CASA");
                    casa_ganadas++;
                    break;
                case 'j':
                    picCasa.Image = (Image)rm.GetObject(carta_tapada);
                    Console.WriteLine("GANO JUGADOR");
                    jugador_ganadas++;
                    break;
                case 'e':
                    picCasa.Image = (Image)rm.GetObject(carta_tapada);
                    Console.WriteLine("EMPATO");
                    empates++;
                    break;
                case 'n':
                    Console.WriteLine("NADA");
                    break;
            }

            Console.WriteLine("Casa {0} ", casa);
            Console.WriteLine("Jugador {0} ", jugador);
            Console.WriteLine("Jugador Split {0} ", jugador_split);

            this.Invoke((MethodInvoker)delegate {
                if (jugador == 9 || jugador == 10 || jugador == 11 && cartas_jugador == 2)
                {
                    tileDoblar.BackColor = Color.LightGray;
                    tileDoblar.Enabled = true;
                }
            }); 

        }

        private void OcultarTrack()
        {
            Transition.run(tileApostar, "BackColor", Color.Gray, new TransitionType_Linear(500));
            Thread.Sleep(500);
            this.Invoke((MethodInvoker)delegate
            {
                trackFichas.Visible = false;
               // pnlBotones.Visible = true;
            });
        }

        private void OcultarControles() {
            Transition.run(tileApostar, "BackColor", Color.Gray, new TransitionType_Linear( 500));
            Thread.Sleep(500);
            this.Invoke((MethodInvoker)delegate
            {
                tileApostar.Visible = false;
                lblFichas.Visible = false;
            });
        }

        private void TraerPanelBotones() {
            Transition.run(pnlBotones, "BackColor", Color.DimGray, new TransitionType_Linear(1000));
            Thread.Sleep(500);

        }

        private void estadísticasDeLaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, string.Format("\nCasa: {0} \nJugador: {1} \nEmpates: {2}", casa_ganadas, jugador_ganadas,empates), "Partidas resultados", 160);
        }

        private void tileDoblar_Click(object sender, EventArgs e)
        {
            tileDoblar.Enabled = false;
            tileDoblar.BackColor = Color.DarkGray;
            new Thread(ExecuteInForegroundPedirCarta).Start();

            pickFichasDoblar.Visible = true;
            pickFichasDoblar.BringToFront();
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(pickFichasDoblar, "Left", 88);
            t.run();

        }

        private void rebarajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ocartacontrol.ReBarajar(deck_id_actual);
        }

        private void isSeguro(string carta) {

            if (carta.Substring(0, 1).Equals("A")) {

                DialogResult dr = MetroMessageBox.Show(this, "¿Deseas activar el seguro?", "Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question,100);
                if (dr == DialogResult.Yes)
                {
                    Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                    t.add(picSeguro, "Top", 250);
                    t.run();
                }
            }

        }

        private void isSplit(PictureBox pic) {

                DialogResult dr = MetroMessageBox.Show(this, "¿Deseas hacer split?", "Separar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);
                if (dr == DialogResult.Yes)
                {
                picCartaSplit = pic;

                }

        }

        private void tilePedirCarta_Click_1(object sender, EventArgs e)
        {
            tilePedirCarta.Enabled = false;

            if (picCartaSplit != null) {
                DialogResult dr = MetroMessageBox.Show(this, "¿A cual deseas apostar? (yes=derecha, no=izquierda)", "Split", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);
                if (dr != DialogResult.Yes)
                {
                    new Thread(ExecuteInForegroundPedirCarta).Start();
                    return;
                }
                new Thread(ExecuteInForegroundPedirCartaSplit).Start();
            }

        }

        private void tilePlantarse_Click(object sender, EventArgs e)
        {
            lblPensando.Visible = true;
            new Thread(ExecuteInForeground).Start();
            new Thread(ExecuteInForegroundPedirCartaCasa).Start();
        }

        private void tileApostar_Click(object sender, EventArgs e)
        {
            new Thread(OcultarControles).Start();
            new Thread(OcultarTrack).Start();

            picFichas.Visible = true;
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(picFichas, "Left", 88);
            t.run();

            new Thread(ExecuteInForegroundCartasIniciales).Start();
        }

        private void tilePedirCarta_Click(object sender, EventArgs e)
        {
            new Thread(ExecuteInForegroundPedirCarta).Start();
        }

        private void trackFichas_ValueChanged(object sender, EventArgs e)
                {
                    lblFichas.Text = "Fichas: " + trackFichas.Value;
                }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
