using Blackjack.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Cartas
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

        public Dictionary<object,object> Barajar(int mazo=1) {
            restRequest.Resource = string.Format(Constantes.BARAJAR_CARTAS, mazo);

            IRestResponse response = client.Execute(restRequest);

            return client.Execute<Dictionary<object, object>>(restRequest).Data;
        }

        public Dictionary<object, object> ReBarajar(int id) {
            restRequest.Resource = string.Format(Constantes.REBAJARAR_CARTAS, id);

            IRestResponse response = client.Execute(restRequest);

            return client.Execute<Dictionary<object, object>>(restRequest).Data;
        }

        public Dictionary<object, object> Repartir(int id, int iniciales=2) {
            restRequest.Resource = string.Format(Constantes.REPARTIR_CARTAS, id, iniciales);

            IRestResponse response = client.Execute(restRequest);

            return client.Execute<Dictionary<object, object>>(restRequest).Data;
        }

        public Dictionary<string, string> BarajarYRepartir(int iniciales = 2)
        {
            restRequest.Resource = string.Format(Constantes.BARAJAR_Y_REPARTIR, iniciales);

            IRestResponse response = client.Execute(restRequest);

            return client.Execute<Dictionary<string, string>>(restRequest).Data;
        }

    }
}
