using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    class Proxy : Subject
    {
        private RealSubject _realsubject;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realsubject == null)
            {
                _realsubject = new RealSubject();
            }
            _realsubject.Request();
        }
    }
}
