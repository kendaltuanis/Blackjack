using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersSQL;
using System.Data;

namespace Blackjack.Modelos
{
    class Usuarios
    {

        private string user_id, nombre, apellido;
        private SqlHelper sqlhelper;
        private const string NOMBRE_TABLA= "usuarios";

        public Usuarios(string id_user,string nombre,string apellido)
        {
            this.user_id = id_user;
            this.nombre = nombre;
            this.apellido = apellido;

            this.sqlhelper = new SqlHelper(NOMBRE_TABLA);
            BaseDatos();
        }

        public Usuarios()
        {
            this.sqlhelper = new SqlHelper(NOMBRE_TABLA);
        }

        private void BaseDatos() {
            string sql = "CREATE TABLE if not exists `usuarios` ( `user_id` TEXT NOT NULL UNIQUE, `nombre` TEXT, `apellido` TEXT )";

            Program.connection.SqlStatement(sql, new Dictionary<string,object>());
            if (Program.connection.isError)
            {
                Console.WriteLine(Program.connection.errorDescription);
            }
        }

        public void Insertar() {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("user_id", user_id);
            parameters.Add("nombre", nombre);
            parameters.Add("apellido", apellido);

            string sql = sqlhelper.InsertSql(parameters.Select(i => i.Key).ToArray());
           
            Program.connection.SqlStatement(sql, parameters);
            if (Program.connection.isError) {
                Console.WriteLine(Program.connection.errorDescription) ;
            }

        }

        public DataTable Refrescar() {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("user_id", user_id);
            parameters.Add("nombre", nombre);
            parameters.Add("apellido", apellido);

            string sql = sqlhelper.SelectSql(parameters.Select(i => i.Key).ToArray());

            DataTable result =Program.connection.SqlQuery(sql, new Dictionary<string, object>());

            if (Program.connection.isError)
            {
                Console.WriteLine(Program.connection.errorDescription);
            }

            return result;

        }

    }
}
