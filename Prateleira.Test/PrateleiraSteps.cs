using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Prateleira.Test
{
    [Binding]
    public class PrateleiraSteps
    {
        [Given(@"Possuo (.*) Regua Grande")]
        public void GivenPossuoReguaGrande(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [Given(@"(.*) Nivel")]
        public void GivenNivel(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [Given(@"(.*) Parafusos e Buchas")]
        public void GivenParafusosEBuchas(int p0)
        {
            Assert.Equals(p0, 4);
        }
        
        [Given(@"(.*) Chave de Fenda")]
        public void GivenChaveDeFenda(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [Given(@"(.*) Furadeira")]
        public void GivenFuradeira(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [Given(@"(.*) Lapis")]
        public void GivenLapis(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [Given(@"(.*) Prateleira")]
        public void GivenPrateleira(int p0)
        {
            Assert.Equals(p0, 1);
        }
        
        [When(@"Com o Nivel, nivelar os furos e medir com a Regua Grande, e marcar com o Lapis")]
        public void WhenComONivelNivelarOsFurosEMedirComAReguaGrandeEMarcarComOLapis()
        {
            Assert.IsTrue(true);
        }
        
        [When(@"Feito procedimento, pegue a furadeira aonde está marcado com o lapis e faça os furos")]
        public void WhenFeitoProcedimentoPegueAFuradeiraAondeEstaMarcadoComOLapisEFacaOsFuros()
        {
            Assert.IsTrue(true);
        }
        
        [When(@"Feito os furos, coloque as Buchas")]
        public void WhenFeitoOsFurosColoqueAsBuchas()
        {
            Assert.IsTrue(true);
        }
        
        [When(@"Coloque a prateleira, e pegue os (.*) parafusos e a chave de fenda, parafuse\.")]
        public void WhenColoqueAPrateleiraEPegueOsParafusosEAChaveDeFendaParafuse_(int p0)
        {
            Assert.IsTrue(true);
        }
        
        [Then(@"Prateleira foi pendura")]
        public void ThenPrateleiraFoiPendura()
        {
            Assert.IsTrue(true);
        }
    }
}
