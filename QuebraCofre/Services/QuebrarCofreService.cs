using QuebraCofre.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuebraCofre.Services
{
    public class QuebrarCofreService
    { 
        private readonly long _maxDigitoNumerico = 16;
        private List<long> combinacoes = new List<long>();

        private readonly FibonacciService _fibonacciService;

        public QuebrarCofreService()
        {
            _fibonacciService = new FibonacciService();
        }

        public long Quebrar(long codigo)
        {
            var result = _fibonacciService.CalculoBase(codigo);

            combinacoes.Add(result);

            return result;
        }


        public bool ContainsCodigo(long codigo)
        {
            return combinacoes.Any(x => x == codigo);
        }
        public bool IsDigitoValido(long digito)
        {
            return digito.Length() == _maxDigitoNumerico;
        }
    }
}
