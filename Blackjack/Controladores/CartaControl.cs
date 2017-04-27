using Blackjack.Modelos; 

namespace Blackjack.Controladores
{
    class CartaControl
    {
        private Carta ocarta;

        public CartaControl()
        {
            this.ocarta = new Carta();
        }

        public string Barajar(int mazo = 1)
        {
            return this.ocarta.Barajar(mazo);
        }

        public bool ReBarajar(string id)
        {
            return this.ocarta.ReBarajar(id);
        }

        public string[] Repartir(string id, int iniciales)
        {
            return this.ocarta.Repartir(id,iniciales);
        }

        public string[] BarajarYRepartir(ref string deck_id,int iniciales = 2)
        {
            return this.ocarta.BarajarYRepartir(iniciales,ref deck_id);
        }
    }
}
