using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{

    enum Day {Mo,Tu,Wed,Th,Fr,Sa,Su }
    enum Mounth { Jan = 1,Feb,Mar,Apr,May,Jun = 10,Jul,Aug,Sep,Oct,Noe,Dec}

    enum Color { Red, Black, White}

    class Program
    {
        static void Main(string[] args)
        {

            Day fr = Day.Fr;
            

            Day a = Day.Fr;

            Console.WriteLine(a == fr);


            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Mounth.Jul);

            Color color = Color.Red;
            Console.WriteLine(color);

            Console.ReadLine();

        }
    }
}
