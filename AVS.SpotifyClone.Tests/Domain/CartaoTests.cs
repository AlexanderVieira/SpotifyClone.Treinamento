using AVS.SpotifyClone.Domain.Transacao.Agreggates;
using AVS.SpotifyClone.Domain.Transacao.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS.SpotifyClone.Tests.Domain
{
    public class CartaoTests
    {
        [Fact]
        public void Cartao_CriarTransacao_ComSucesso()
        {
            //Arange
            var cartao = new Cartao
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite= 1000M,
                Numero = "64656465"
            };

            var merchant = new Merchant
            {
                Nome = "Dummy"
            };

            //Act
            cartao.CriarTransacao(merchant, 19M, "Dummy Transacao");

            //Assert
            Assert.True(cartao.Transacoes.Count > 0);

        }

        [Fact]
        public void Cartao_CriarTransacao_SemLimite()
        {

        }

        [Fact]
        public void Cartao_CriarTransacao_Inativo()
        {

        }

        [Fact]
        public void Cartao_CriarTransacao_Duplicado()
        {

        }
    }
}
