using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14"); // hard coded -> zeer slecht

            #region Mine
            //for (int i = 0; i < 14; i++)
            //{
            //    int j = i + 1;
            //    Console.Write($"{j}, ");
            //}
            #endregion

            // int starNumber = 1;
            // int endNumber = 14;
            Console.WriteLine("Geen een getal in voor het begin");
            int starNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Geen een getal in voor het eind");

            int endNumber = Int32.Parse(Console.ReadLine());
            while (starNumber <= endNumber)
            {

                Console.WriteLine(starNumber);
                starNumber+=3; // --> starNumber = starNumber + 1;
            }
        }
    }
}
