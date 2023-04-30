using FactoryMethodApproach.Factories;
using FactoryMethodApproach.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntityCreator creator = new EntityCreator();
            FactoryTest tester = new FactoryTest(creator);
            tester.RunTest();
            Console.ReadLine();
        }
    }
}
