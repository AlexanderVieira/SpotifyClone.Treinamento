using AVS.SpotifyClone.Domain.Streaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Core.VaueObjects
{
    public record Monetario
    {
        public decimal Valor { get; set; }
        public static implicit operator decimal(Monetario d) => d.Valor;
        public static implicit operator Monetario(decimal valor) => new Monetario(valor);

        public Monetario(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor monetário não pode ser negativo");
                Valor = valor;
            }

        }

        public string Formatar()
        {
            return $"R$ {Valor.ToString("N2")}";
        }
    }
}
