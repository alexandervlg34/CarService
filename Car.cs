using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Car
    {
        private Detail Detail1 = new Detail();
        private Detail Detail2 = new Detail();
        private Detail Detail3 = new Detail();
        private Detail Detail4 = new Detail();
        private Detail Detail5 = new Detail();

        private List<Detail> Details = new List<Detail>();

        
        public Car(Detail detail1, Detail detail2, Detail detail3, Detail detail4, Detail detail5)
        {
            this.Detail1 = detail1;
            this.Detail2 = detail2;
            this.Detail3 = detail3;
            this.Detail4 = detail4;
            this.Detail5 = detail5;

            AddDetail();
            FindBrokenPart();
        }

        private void AddDetail()
        {
            Details.Add(Detail1);
            Details.Add(Detail2);
            Details.Add(Detail3);
            Details.Add(Detail4);
            Details.Add(Detail5);
        }

        private Detail FindBrokenPart()
        {
            Random random = new Random();
            int value = random.Next(1, Details.Count);

            Detail BrokenPart = new Detail();
            switch (value)
            {
                case 1:
                    BrokenPart = Detail1;
                    break;
                    case 2:
                    BrokenPart = Detail2;
                    break;
                    case 3:
                    BrokenPart = Detail3;
                    break;
                    case 4:
                    BrokenPart = Detail4;
                    break;
                    case 5:
                    BrokenPart = Detail5;
                    break;
            }
            return BrokenPart;
        }
    }
}
