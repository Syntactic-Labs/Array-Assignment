using System;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };

            var lowest = 0;
            var highest = 9999;
            var sum = 0;

            
            foreach (var nbr2 in nbrs2)
            {
                if (nbr2 > highest) highest = nbr2;
                if (nbr2 < lowest) lowest = nbr2;
                sum = sum + nbr2;
            }
            var max = sum - highest;
            var min = sum - lowest;

            Console.WriteLine($"The largest sum is {max} and the smallest sum is {min}");
            
            //int[] nbrs = {

            //754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

            //187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

            //460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

            //690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

            //435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            //};
            //var highest = int.MinValue;
            //var lowest = int.MaxValue;
            
            //foreach(var nbr in nbrs)
            //{
            //    if (nbr > highest)
            //        highest = nbr;
            //    if (nbr < lowest)
            //        lowest = nbr;
                
            //}
            //Console.WriteLine($"The highest number is {highest}! The lowest number is {lowest}!!");

        }
    }
}
