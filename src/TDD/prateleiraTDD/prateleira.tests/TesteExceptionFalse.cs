using System;
using System.Collections.Generic;
using NUnit.Framework;
using Prateleira;
using Prateleira.Ferramentas;
using Prateleira.Insumos;
using Prateleira.Prateleiras;

namespace PrateleiraTest
{
    public class TesteExceptionFalse
    {
        [Test]
        public void VerificarFuradeiraLigadaException()
        {
            Furadeira furadeira = new Furadeira(false, true);
            var furadeiraEx = Assert.Throws<Exception>(() => furadeira.EstaFuncionando());
            Assert.AreEqual(furadeiraEx.Message, Furadeira.MensagemFuradeiraNaoLigada);
        }

        [Test]
        public void VerificarFuradeiraRotacaoException()
        {
            Furadeira furadeira = new Furadeira(true, false);
            var furadeiraEx = Assert.Throws<Exception>(() => furadeira.EstaFuncionando());
            Assert.AreEqual(furadeiraEx.Message, Furadeira.MensagemFuradeiraRotacaoIncorreta);
        }

        [Test]
        public void VerificarDemaisFerramentasNaoOk()
        {

            Nivel nivel = new Nivel(false);
            ChaveFenda chaveFenda = new ChaveFenda(false);
            Lapis lapis = new Lapis(false);
            Regua regua = new Regua(0);

            Assert.AreEqual(false, nivel.EstaFuncionando(), "Nível não está funcionando corretamente.");
            Assert.AreEqual(false, chaveFenda.EstaFuncionando(), "Chave de fenda não está funcionando corretamente.");
            Assert.AreEqual(false, lapis.EstaFuncionando(), "Lápis funcionando não está funcionando corretamente.");
            Assert.AreEqual(false, regua.EstaFuncionando(), "Régua funcionando não está funcionando corretamente.");
        }

        [Test]
        public void VerificarSeAParedeSuportaAPrateleiraException()
        {
            PrateleiraObj prateleira = new PrateleiraObj(3, 1.0, new Suporte(6.0, 4, null));
            Parede parede = new Parede(2.7, 3.0, prateleira);

            var paredeEx = Assert.Throws<Exception>(() => parede.SuportaPrateleira());
            Assert.AreEqual(paredeEx.Message, Parede.MensagemParedeNaoSuportaPrateleira);
        }

        [Test]
        public void VerificarQuantidadeDeBuchasEParafusosException()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(6.0, 5);

            var buchasEx = Assert.Throws<Exception>(() => buchas.VerificarQuantidade(parafusos.Quantidade));

            Assert.AreEqual(buchasEx.Message, Insumo.MensagemQuantidadeSuperior);
        }

        [Test]
        public void VerificarCompatibilidadeDeParafusosEBuchasDiametroInferiorException()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(7.0, 6);

            var buchasEx = Assert.Throws<Exception>(() => buchas.VerificarCompatibilidade(parafusos.Diametro, parafusos.Quantidade));

            Assert.AreEqual(buchasEx.Message,Insumo.MensagemDiametroInferior);
        }

        [Test]
        public void VerificarCompatibilidadeDeParafusosEBuchasDiametroSuperiorException()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(5.0, 6);

            var buchasEx = Assert.Throws<Exception>(() => buchas.VerificarCompatibilidade(parafusos.Diametro, parafusos.Quantidade));

            Assert.AreEqual(buchasEx.Message, Insumo.MensagemDiametroSuperior);
        }

        [Test]
        public void VerificarCompatibilidadeDeParafusosEBuchasQuantidadeException()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(6.0, 6);

            var buchasEx = Assert.Throws<Exception>(() => buchas.VerificarCompatibilidade(parafusos.Diametro, parafusos.Quantidade));

            Assert.AreEqual(buchasEx.Message, Insumo.MensagemQuantidadeSuperior);
        }

        [Test]
        public void VerificarMarcacaoLocalFuracaoException()
        {
            List<Furacao> listaFuros = new List<Furacao>();
            listaFuros.Add(new Furacao(3.20, 1)); // posição do primeiro furo - horizontal e vertical
            listaFuros.Add(new Furacao(3.40, 1)); // posição do segundo furo
            listaFuros.Add(new Furacao(3.60, 1)); // posição do terceiro furo
            listaFuros.Add(new Furacao(3.80, 1)); // posição do quarto furo

            Suporte suporte = new Suporte(0.20, 4, listaFuros);

            PrateleiraObj prateleira = new PrateleiraObj(0.20, 1.0, suporte);

            Parede parede = new Parede(2.7, 3.0, prateleira);

            var paredeEx = Assert.Throws<Exception>(() => parede.FuracaoOk());

            Assert.AreEqual(paredeEx.Message, Parede.MensagemFuracaoIncompativel);
        }
    }
}
