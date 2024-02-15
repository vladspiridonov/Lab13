using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Building
    {
        //string adress; 
        int length;
        int width;
        int height;
        public string Adress { get; set; }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length=0;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
            }
        }
        public Building(string adress, int length,int width,int height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string Print()
        {
            return $"Адрес: {Adress}   Длина: {Length}    Ширина: {Width}     Высота: {Height}";
        }
    }
}
