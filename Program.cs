using System;
using ElevaTest.Infra;

namespace ElevaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();
            Console.Read();
        }

    }
}
