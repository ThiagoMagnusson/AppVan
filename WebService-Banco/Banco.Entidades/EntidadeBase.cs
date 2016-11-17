using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class EntidadeBase
    {
        [Key]
        public int Id { get; set; }
    }
}
