using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Streaming.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Conta.Aggregates
{
    public class Assinatura : Entity
    {        
        public string? Nome { get; set; }
        public Plano? Plano { get; set; }
        public bool Ativo { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
