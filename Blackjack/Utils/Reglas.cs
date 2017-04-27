using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Utils
{
    public class Reglas
    {

        public Char resultado(int casa,int jugador,bool AS_casa,bool AS_jugador,int cartas_jugador,bool isPlanto,ref int juga,ref int casaa) {

           // if (cartas > 5)
             //   return 'c';

            if (Perdio(jugador,AS_jugador,ref jugador,ref juga))
                return 'c';

            if (Perdio(casa,AS_casa,ref casa,ref casaa))
                return 'j';

            if (Empate(casa, jugador) && casa>=17 && isPlanto)
                return 'e';

            if (jugador == 21 && cartas_jugador == 2)
                return 'j';

            if (jugador == 21 && cartas_jugador > 2 && casa < 17)
                return 'n';

            if (casa == 21)
                return 'c';

            if (jugador>casa && casa>=17)
                return 'j';

            if (casa > jugador && isPlanto)
                return 'c';

            return 'n';
        }


        private Boolean Perdio(int suma,bool isAs,ref int sumaN,ref int sumaT,bool isCasa=false) {

            if ((isAs && (suma - 10) < 21) && suma >21) {

                sumaN = (suma - 10);
                return false;
            }              

            if (suma > 21)
                return true;

            return false;
        }

        private Boolean Empate(int casa,int jugador) {
            if (casa == jugador)
                return true;
            return false;
        }
    }
}
