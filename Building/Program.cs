using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Fontanka emb.", 300, 78, 89);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Hook str. 32", 200, 700, 800, 8);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();



        }
    }
}
