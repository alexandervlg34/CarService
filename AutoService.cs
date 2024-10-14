using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class AutoService
    {
        public int Money {  get; set; }
        public List<Detail> Details = new List<Detail>();

        private Detail Detail1 = new Detail(1, "Brakes", 10);
        private Detail Detail2 = new Detail(2, "Headlight", 15);
        private Detail Detail3 = new Detail(3, "Hood", 18);
        private Detail Detail4 = new Detail(4, "Dashboard", 24);
        private Detail Detail5 = new Detail(5, "Engine", 50);

        public AutoService()
        {
            AddDetails();
        }

        private void AddDetails()
        {
            Details.Add(Detail1);
            Details.Add(Detail2);
            Details.Add(Detail3);
        }

        /* public void AddCar()
        {
            Car car = new Car(Detail1, Detail2, Detail3, Detail4, Detail5);
        }
        */
    }
}
