using Lists.Models;
using Lists.Repository;
using System;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop HP = new Laptop();
            HP.RAM = 8;
            HP.Name = "VAIO";
            HP.Brand = "HP";
            HP.Price = 500;
            HP.Processor = "Core I7";
            Laptop laptop2 = new Laptop();
            laptop2.RAM = 8;
            laptop2.Name = "DIEGOEDUARDO";
            laptop2.Brand = "HP";
            laptop2.Price = 500;
            laptop2.Processor = "Core I7";
            Laptop laptop3 = new Laptop();
            laptop3.RAM = 8;
            laptop3.Name = "SEBAS";
            laptop3.Brand = "HP";
            laptop3.Price = 500;
            laptop3.Processor = "Core I7";
            ListLaptops list = new ListLaptops();
            list.AddData(HP);
            list.AddData(laptop2);
            list.AddData(laptop3);

            Console.WriteLine("Introduce el nombre de Laptop que quieres buscar: ");
            string name=Console.ReadLine();
            var result = list.GetByName(name);
            Console.WriteLine(result);
        }
    }
}
