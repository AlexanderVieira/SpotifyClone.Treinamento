using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Core.VaueObjects;
using AVS.SpotifyClone.Domain.Transacao.Enums;
using AVS.SpotifyClone.Domain.Transacao.ValueObjects;

namespace AVS.SpotifyClone.Domain.Transacao.Agreggates
{
    public class Transacao : Entity
    {         
        public DateTime DtTransacao { get; set; }
        public Monetario? Valor { get; set; }
        public Merchant? Merchant { get; set; }
        public string? Descricao { get; set; }
        public SituacaoTransacao Situacao { get; set; }         
        
    }
}
