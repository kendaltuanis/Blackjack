using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Utils
{
    class Casa
    {

        public Boolean PedirCarta(int casa)
        {

            if (casa >= 17) {
                return false;
            }

            return true;
        }

    }
}
