using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Utils
{
    class Constantes
    {
        public static string BASE_URL = "https://deckofcardsapi.com/api/deck/";

        public static string BARAJAR_CARTAS = "new/shuffle/?deck_count={0}";

        public static string REBAJARAR_CARTAS = "{0}/shuffle/";

        public static string BARAJAR_Y_REPARTIR = "new/draw/?count={0}";

        public static string REPARTIR_CARTAS = "{0}/draw/?count={1}";


    }
}
