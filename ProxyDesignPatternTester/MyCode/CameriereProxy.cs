using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    class CameriereProxy : ICameriere, ICucina
    {
        private string _nome;
        private string _cognome;
        private static Cucina _cucina;

        public CameriereProxy(string nome, string cognome)
        {
            _nome = nome;
            _cognome = cognome;
            _cucina = new Cucina(this);
        }

        public string NomeCompleto()
        {
            return _nome + " " + _cognome;
        }

        public void PreparaUnPiatto(string qualePiatto)
        {
            _cucina.PreparaUnPiatto(qualePiatto);
        }
    }
}
