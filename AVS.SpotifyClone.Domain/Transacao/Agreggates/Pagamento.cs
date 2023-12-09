using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Core.VaueObjects;
using AVS.SpotifyClone.Domain.Transacao.Enums;

namespace AVS.SpotifyClone.Domain.Transacao.Agreggates
{
    public class Pagamento : Entity
    {        
        public Monetario? Valor { get; set; }
        public SituacaoPagamento? Situacao { get; set; }
        public Cartao? Cartao { get; set; }
        public Transacao? Transacao { get; set; }
    }
}
