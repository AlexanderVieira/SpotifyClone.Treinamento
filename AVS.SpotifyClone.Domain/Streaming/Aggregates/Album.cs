using AVS.SpotifyClone.Domain.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Streaming.Aggregates
{
    public class Album : Entity
    {        
        public string? Nome { get; set; }
        public List<Musica> Musicas { get; set; } = new List<Musica>();

        public void AdicionarMusica(Musica musica) => Musicas.Add(musica);

        public void AdiconarMusica(List<Musica> musicas) => Musicas.AddRange(musicas);

    }
}
