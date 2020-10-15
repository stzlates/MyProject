using System;
using Algoritem;
using ReadAndWriteData;

namespace MaimProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data dina= new Data();

            dina.name = "Esti";
            dina.lastName = "Zlates";
            dina.age = 19;
            Console.WriteLine(dina.name);
            dina.Print();


            Algo a= new Algo();
            a.problem=("Endless loop");
            a.level = (5);
            a.Print();
        }
    }
}
