using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = ProxyDesignPatternTester.StructuralCode;
using Real = ProxyDesignPatternTester.RealWorldCode;
//using My = ProxyDesignPatternTester.MyCode;

namespace ProxyDesignPatternTester
{
    // Definition
    // Provide a surrogate or placeholder for another object to control access to it. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Proxy (MathProxy)
    //      --> maintains a reference that lets the proxy access the real subject.
    //          Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
    //      --> provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
    //      --> controls access to the real subject and may be responsible for creating and deleting it.
    //      --> other responsibilites depend on the kind of proxy:
    //              --> remote proxies are responsible for encoding a request and its arguments
    //                  and for sending the encoded request to the real subject in a different address space.
    //              --> virtual proxies may cache additional information about the real subject so that they can postpone accessing it.
    //                  For example, the ImageProxy from the Motivation caches the real images's extent.
    //              --> protection proxies check that the caller has the access permissions required to perform a request. 
    //  - Subject (IMath)
    //      --> defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected. 
    //  - RealSubject (Math)
    //      --> defines the real object that the proxy represents. 

    /// <summary>
    /// MainApp startup class for
    /// Proxy Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Proxy pattern which provides a representative object (proxy)
            // that controls access to another similar object.

            // Create proxy and request a service
            Structural.Proxy proxy = new Structural.Proxy();
            proxy.Request();

            //Wait for user
            Console.ReadKey();
            #endregion

            #region RealWorld code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Proxy pattern for a Math object represented by a MathProxy object. 
            
            // Create math proxy
            Real.MathProxy mathProxy = new Real.MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + mathProxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + mathProxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + mathProxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + mathProxy.Div(4, 2));
            
            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            #endregion
        }
    }
}
