using AVS.SpotifyClone.Domain.Conta.Agreggates;
using AVS.SpotifyClone.Domain.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Streaming.Aggregates
{
    public class Musica : Entity
    {        
        public string? Nome { get; set; }
        public Duracao? Duracao { get; set; }
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();

    }
}
