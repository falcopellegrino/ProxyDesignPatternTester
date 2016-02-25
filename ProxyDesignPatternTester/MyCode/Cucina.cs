using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class Cucina : ICucina
    {
        ICameriere _cameriere;

        public Cucina(ICameriere cameriere)
        {
            _cameriere = cameriere;
        }

        public void PreparaUnPiatto(string qualePiatto)
        {
            Console.WriteLine("Sono la cucina e sto preparando il piatto ''" + qualePiatto + "'' richiesto attraverso il cameriere ''" + _cameriere.NomeCompleto() + "''.");
        }
    }
}
