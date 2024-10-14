using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Detail
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public int Price { get; private set; }

        public Detail()
        {
            
        }
        public Detail(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

    }
}
