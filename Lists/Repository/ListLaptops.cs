
using Lists.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lists.Repository
{
    public class ListLaptops
    {
        //Atributes
        private List<Laptop> laptops;

        //Method Constructor
        public ListLaptops()
        {
            laptops = new List<Laptop>();
        }

        //Methods and Functions

        public void AddData(Laptop laptop)
        {
            laptops.Add(laptop);
        }

        public Laptop GetByName(string NameToFind)
        {
            var resultado = laptops.Find(x=>x.Name== NameToFind);
            return resultado;
        }
    }
}
