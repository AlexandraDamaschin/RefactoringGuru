using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new Builder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
