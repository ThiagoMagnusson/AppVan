using Banco.DAL.Repositorios;
using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public HttpResponseMessage Teste()
        {
            HttpResponseMessage resposta;
            Login login = this.Request.Content.ReadAsAsync<Login>().Result;        
            

            if (true)
            {
                resposta = Request.CreateResponse<string>(HttpStatusCode.OK, "Usuario Autenticado com Sucesso");
            }
            else
            {
                resposta = Request.CreateResponse<string>(HttpStatusCode.Forbidden, "Login ou Senha invalidos");
            }

            return resposta;
        }

    }
}
