using AVS.SpotifyClone.Domain.Conta.Agreggates;
using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Core.VaueObjects;
using AVS.SpotifyClone.Domain.Transacao.Agreggates;

namespace AVS.SpotifyClone.Domain.Conta.Aggregates
{
    public class Usuario : Entity
    {        
        public string? Nome { get; set; }
        public Email? Email { get; set; }
        public Cpf? Cpf { get; set; }
        public string? Senha { get; set; }
        public string? Foto { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtNascimento { get; set; }
        public List<Cartao> Cartoes { get; set; } = new List<Cartao>();
        public List<Assinatura> Assinaturas { get; set; } = new List<Assinatura>();        
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
