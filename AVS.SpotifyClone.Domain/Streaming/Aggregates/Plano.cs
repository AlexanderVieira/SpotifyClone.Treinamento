using AVS.SpotifyClone.Domain.Conta.Aggregates;
using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Core.VaueObjects;
using AVS.SpotifyClone.Domain.Streaming.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Streaming.Aggregates
{
    public class Plano : Entity
    {        
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Monetario? Valor { get; set; }
        public TipoPlano TipoPlano { get; set; }
        public Assinatura? Assinatura { get; set; }
    }
}
