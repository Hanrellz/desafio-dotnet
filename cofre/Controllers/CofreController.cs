using Microsoft.AspNetCore.Mvc;
using System;
namespace cofre.Controllers
{
    public class CofreController : Controller
    {
        /// <summary>
        /// Configurar o Visual studio Code
        /// </summary>
        /// <returns></returns>
        /// https://medium.com/danielpadua/vscode-asp-net-core-preparar-ambiente-de-desenvolvimento-adf30cefea07
        /// 
        /// Para rodar aplicativo entre na pasta Cofre
        ///  pelo cmd do visual studio code 
        ///  e informe dotnet run  
        /// ele te dara a porta que esta rodando.

        public string Index()
        {
            return "Cofre";
        }

        public IActionResult Senha()
        {
            return View();
        }
        /// <summary>
        /// Formula Fibonacci 
        /// </summary>
        public string ValidarSenha(string indice)
        {
            long atual = 0;
            long anterior = 1;
            long proximo;

            for (long i = 0; i <= Convert.ToInt32(indice); i++)
            {
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }

            return atual.ToString();
        }
    }
}