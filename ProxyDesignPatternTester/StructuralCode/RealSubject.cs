﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class RealSubject: Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request");
        }
    }
}
