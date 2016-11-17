using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [Table("login")]
    public class Login : EntidadeBase
    {

        public string Usuario { get; set; }

        public string Senha { get; set; }
    }
}
