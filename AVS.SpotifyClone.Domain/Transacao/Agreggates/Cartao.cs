using AVS.SpotifyClone.Domain.Core.DomainObjects;
using AVS.SpotifyClone.Domain.Core.VaueObjects;
using AVS.SpotifyClone.Domain.Transacao.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Domain.Transacao.Agreggates
{
    public class Cartao : Entity
    {
        private const int INTERVALO_TRANSACAO = -2;
        private const int REPETICAO_TRANSACAO_MERCHANT = 1;

        public string? Numero { get; set; }
        public string? Nome { get; set; }
        public string? Expiracao { get; set; }
        public string? Cvv { get; set; }
        public bool Ativo { get; set; }
        public Monetario? Limite { get; set; }
        public List<Transacao>? Transacoes { get; set; }

        public void CriarTransacao(Merchant merchant, Monetario? valor, string Decricao)
        {
            IsCartaoAtivo();
            var tran = new Transacao
            {
                Merchant= merchant,
                Valor= valor,
                Descricao = Decricao,
                DtTransacao= DateTime.Now
            };

            VerifcarLimite(tran);
            ValidarTransacao(tran);
            Limite = Limite - tran.Valor;
            Transacoes.Add(tran);

        }

        private void ValidarTransacao(Transacao transacao) 
        {
            var ultimasTransacoes = Transacoes.Where(x => x.DtTransacao >= DateTime.Now.AddMinutes(INTERVALO_TRANSACAO)).ToList();
            if (ultimasTransacoes?.Count() >= 3)
            {
                throw new Exception("Cartão utilizado muitas vezes em um período curto");
            }           

        }

        private void VerifcarLimite(Transacao transacao) 
        {
            if (Limite < transacao.Valor)
            {
                throw new Exception("Cartão não possui limite para esta transação");
            }
        }

        private void IsCartaoAtivo()
        {
            if (Ativo == false) 
            {
                throw new Exception("Cartao nao esta ativo");
            }
        }

    }
}
