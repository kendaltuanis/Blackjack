using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Modelos;
using System.Data;

namespace Blackjack.Controladores
{
    class UsuariosControl
    {

        public void Insertar(string user_id, string nombre, string apellido) {
            new Usuarios(user_id, nombre, apellido).Insertar();
        }

        public DataTable Refrescar() {
            return new Usuarios().Refrescar();
        }
    }
}
