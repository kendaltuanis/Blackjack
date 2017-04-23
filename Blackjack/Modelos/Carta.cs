using Blackjack.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Modelos
{
    class Carta
    {
       
        private RestClient client;
        private RestRequest restRequest;

        public Carta()
        {
           client = new RestClient(Constantes.BASE_URL);
           restRequest = new RestRequest(Method.GET);
         }

        // Retorna el id del mazo barajado
        public string Barajar(int mazo) {
            restRequest.Resource = string.Format(Constantes.BARAJAR_CARTAS, mazo);

            IRestResponse response = client.Execute(restRequest);

            return client.Execute<Dictionary<object, object>>(restRequest).Data.Where(i => i.Key.Equals("deck_id")).Select(i => i.Value).First().ToString();
        }

        // Retorna si fue satisfactorio el rebarajar
        public bool ReBarajar(string id) {
            restRequest.Resource = string.Format(Constantes.REBAJARAR_CARTAS, id);

            IRestResponse response = client.Execute(restRequest);

            return (client.Execute<Dictionary<object, object>>(restRequest).Data.Where(i => i.Key.Equals("success")).Select(i => i.Value).First().ToString().Equals("true") ? true : false);
        }

        // Retorna las cartas que quiera conforme al id del mazo
        public string[] Repartir(string id, int iniciales) {
            restRequest.Resource = string.Format(Constantes.REPARTIR_CARTAS, id, iniciales);

            IRestResponse response = client.Execute(restRequest);

            return SacaCartas();
        }

        public string[] BarajarYRepartir(int iniciales,ref string deck_id)
        {
            restRequest.Resource = string.Format(Constantes.BARAJAR_Y_REPARTIR, iniciales);

            IRestResponse response = client.Execute(restRequest);
            deck_id = client.Execute<Dictionary<object, object>>(restRequest).Data.Where(i => i.Key.Equals("deck_id")).Select(i => i.Value).First().ToString();

            return SacaCartas();
        }


        private string[] SacaCartas() {
            string carta_1 = null, carta_2 = null;
            string[] direccion = (client.Execute<Dictionary<object, object>>(restRequest).Data.Where(i => i.Key.Equals("cards")).Select(i => i.Value).First().ToString()).Split('"');

            try
            {
                carta_1 = direccion[3]; // espacio de la carta 1
                carta_2 = direccion[29]; // espacio de la carta 2
            }
            catch { }

            return new string[] { carta_1, carta_2 };
        }

    }
}
