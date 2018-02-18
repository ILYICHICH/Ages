using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите ваш возраст?");
            int Childhood = int.Parse(Console.ReadLine());


            if (Childhood == 1 || Childhood == 2 || Childhood == 3 || Childhood == 4 || Childhood == 5 || Childhood == 6 || Childhood == 8 || Childhood == 9 || Childhood == 10 || Childhood == 11 || Childhood == 12)


            {
                Console.WriteLine("Ребёнок");
            }
            if (Childhood == 13 || Childhood == 14 || Childhood == 15 || Childhood == 16 || Childhood == 17)
            {
                Console.WriteLine("Подросток");

            }
            if (Childhood == 18 || Childhood == 19 || Childhood == 20 || Childhood == 21 || Childhood == 22 || Childhood == 23 || Childhood == 24 || Childhood == 25 || Childhood == 26 || Childhood == 27 || Childhood == 28 || Childhood == 29 || Childhood == 30 || Childhood == 31 || Childhood == 32 || Childhood == 33 || Childhood == 34 || Childhood == 35 || Childhood == 36 || Childhood == 37 || Childhood == 38 || Childhood == 39 || Childhood == 40 || Childhood == 41 || Childhood == 42 || Childhood == 43 || Childhood == 44 || Childhood == 45 || Childhood == 46 || Childhood == 47 || Childhood == 48 || Childhood == 49 || Childhood == 50 || Childhood == 51 || Childhood == 52 || Childhood == 53 || Childhood == 54 || Childhood == 55 || Childhood == 56 || Childhood == 57)
            {
                Console.WriteLine("Взрослый");
            }
            if (Childhood == 58 || Childhood == 59 || Childhood == 60 || Childhood == 61 || Childhood == 62 || Childhood == 63 || Childhood == 64 || Childhood == 65 || Childhood == 66 || Childhood == 67 || Childhood == 68 || Childhood == 69 || Childhood == 70)
            {
                Console.WriteLine("Пожилой");
            }
        }
    }
}
