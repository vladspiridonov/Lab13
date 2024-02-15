using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class MultiBuilding:Building
    {
        int floor;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < 1)
                    floor = 1;
            }
        }
        public MultiBuilding(string adress, int length, int width, int height, int floor)
               :base (adress, length, width, height)
            {
                this.floor=floor;
            }
        public string Print()
        {
            return $"{base.Print()}     Этажность:{Floor}";
        }
       
    }
}
