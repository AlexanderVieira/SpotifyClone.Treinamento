using AVS.SpotifyClone.Domain.Conta.Aggregates;
using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Streaming.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Conta.Agreggates
{
    public class Playlist : Entity
    {        
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Foto { get; set; }
        public bool Publica { get; set; }
        public Usuario? Usuario { get; set; }
        public List<Musica> Musicas { get; set; } = new List<Musica>();
    }
}
