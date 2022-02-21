using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    class Usuario : IdentityUser<string>
    {
        public int CPF { get; set; }

        public string Profissao { get; set; }

        public byte[] foto { get; set; }

        public virtual ICollection<Cartao> Cartoes { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
