using AVS.SpotifyClone.Domain.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Streaming.Aggregates
{
    public class Banda : Entity
    {        
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Backdrop { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

        public void AdicionarAlbum(Album album) => Albums.Add(album);
    }
}
