using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Appvam.Mobile
{
    public class AcessoWebService
    {
        HttpClient WebService;

        private string UrlWebService = "http://192.168.0.8/api/";

        public AcessoWebService()
        {
            WebService = new HttpClient();
            WebService.MaxResponseContentBufferSize = 256000;
        }

        /// <summary>
        /// Metodo que executa um endereco do WebService
        /// </summary>
        /// <param name="Url">Classe / Metodo que sera executado no webService</param>
        /// <param name="Corpo">Corpo em json da requisicao que sera executada</param>
        /// <returns>Retorna a resposta da requisicao executada</returns>
        public ObjResposta<string> Executar(string Url, object Corpo)
        {
            ObjResposta<string> retorno = new ObjResposta<string>();
            string enderecoCompleto = UrlWebService + Url;
            string respostaCorpo = JsonConvert.SerializeObject(Corpo);
            StringContent stringContent = new StringContent(respostaCorpo, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = WebService.PostAsync(enderecoCompleto, stringContent).Result;
            retorno.Corpo = resposta.Content.ReadAsStringAsync().Result;
            retorno.StatusResposta = resposta.StatusCode;

            return retorno;

        }


    }
}
