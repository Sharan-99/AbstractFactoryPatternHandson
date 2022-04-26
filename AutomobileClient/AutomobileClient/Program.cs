using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AutomobileManufacturer;

namespace AutomobileClient
{
    class Program
    {
        static Factory GetFactory(string factoryName)
        {
            Assembly assembly = typeof(Factory).Assembly;
            object instance = assembly.CreateInstance(factoryName);
            return instance as Factory;
        }
        static void Main(string[] args)
        {
            //Validating output using MercedesFactory
            Factory factory = GetFactory("AutomobileManufacturer.MercedesFactory");
            Headlight h = factory.MakeHeadlight();
            Tire t = factory.MakeTire();
            h.ManufacturedHeadlight();
            t.ManufacturedTire();

            Console.WriteLine("-------------------------");

            //Validating output using AudiFactory
            Factory factory1 = GetFactory("AutomobileManufacturer.AudiFactory");
            Headlight h1 = factory1.MakeHeadlight();
            Tire t1 = factory1.MakeTire();
            h1.ManufacturedHeadlight();
            t1.ManufacturedTire();

            Console.ReadKey();

        }
    }
}
