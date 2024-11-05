using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleSquar
{
    internal class Square
    {
        public int SideLength;

        public Square()
        {
            SideLength = 1;
        }
        public Square(int sideLength)
        {
            SideLength = sideLength;
        }
        public int CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Square square2 = new Square(4);
            Console.WriteLine(square1.CalculateArea());
            Console.WriteLine(square2.CalculateArea());
        }
    }
}
