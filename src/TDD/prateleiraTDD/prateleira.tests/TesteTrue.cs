using System.Collections.Generic;
using NUnit.Framework;
using Prateleira;
using Prateleira.Ferramentas;
using Prateleira.Insumos;
using Prateleira.Prateleiras;

namespace PrateleiraTest
{
    public class TesteTrue
    {
        [Test]
        public void VerificarFerramentas()
        {
            Furadeira furadeira = new Furadeira(true, true);
            Nivel nivel = new Nivel(true);
            ChaveFenda chaveFenda = new ChaveFenda(true);
            Lapis lapis = new Lapis(true);
            Regua regua = new Regua(1.0);

            Assert.AreEqual(true, furadeira.EstaFuncionando(), "Furadeira funcionando corretamente.");
            Assert.AreEqual(true, nivel.EstaFuncionando(), "Nível funcionando corretamente.");
            Assert.AreEqual(true, chaveFenda.EstaFuncionando(), "Chave de fenda funcionando corretamente.");
            Assert.AreEqual(true, lapis.EstaFuncionando(), "Lápis funcionando corretamente.");
            Assert.AreEqual(true, regua.EstaFuncionando(), "Régua funcionando corretamente.");
        }

        [Test]
        public void VerificarSeAParedeSuportaAPrateleira()
        {
            PrateleiraObj prateleira = new PrateleiraObj(0.20, 1.0, new Suporte(6.0, 4, null));
            Parede parede = new Parede(2.7, 3.0, prateleira);           

            Assert.AreEqual(true, parede.SuportaPrateleira(), "Parede suporta prateleira - altura e largura compatíveis.");
        }

        [Test]
        public void VerificarQuantidadeDeBuchasEParafusos()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(6.0, 4);

            Assert.AreEqual(true, buchas.VerificarQuantidade(parafusos.Quantidade), "Quantidade de parafusos e buchas equivalente.");
        }

        [Test]
        public void VerificarCompatibilidadeDeParafusosEBuchas()
        {
            Buchas buchas = new Buchas(6.0, 4);
            Parafusos parafusos = new Parafusos(6.0, 4);

            Assert.AreEqual(true, buchas.VerificarCompatibilidade(parafusos.Diametro, parafusos.Quantidade), "Parafusos e buchas compatíveis.");
        }

        [Test]
        public void VerificarMarcacaoLocalFuracao()
        {
            List<Furacao> listaFuros = new List<Furacao>();
            listaFuros.Add(new Furacao(0.20, 1)); // posição do primeiro furo - horizontal e vertical
            listaFuros.Add(new Furacao(0.40, 1)); // posição do segundo furo
            listaFuros.Add(new Furacao(0.60, 1)); // posição do terceiro furo
            listaFuros.Add(new Furacao(0.80, 1)); // posição do quarto furo

            Suporte suporte = new Suporte(0.20, 4, listaFuros);

            PrateleiraObj prateleira = new PrateleiraObj(0.20, 1.0, suporte);

            Parede parede = new Parede(2.7, 3.0, prateleira);

            Assert.AreEqual(true, parede.FuracaoOk(), "Furação compatível com a parede");
        }
    }
}
