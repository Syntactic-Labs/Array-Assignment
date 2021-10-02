using System;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   //Finding the largest and smallest sum of 4 of 5 ints
            int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };
            //This var will be used to find the lowest by working your way down
            var lowest = 9999;
            //This var will be used to find the highest by working your way up
            var highest = 0;
            //sum of all numbers in the array
            var sum = 0;
            foreach (var nbr2 in nbrs2)
            {
                //establishes the highest nbr so far
                if (nbr2 > highest) highest = nbr2;
                //establishes the lowest nbr so far
                if (nbr2 < lowest) lowest = nbr2;
                //contributes to sum to use later
                sum = sum + nbr2;
            }
            //basic math :p
            var min = sum - highest;
            var max = sum - lowest;
            Console.WriteLine($"The largest sum is {max} and the smallest sum is {min}");
            //================================================================================================================
            //Finding the avg of all the nbrs in this array
            int[] nbrs = {

            754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

            187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

            460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

            690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

            435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };
            //create what you are looking for
            var total = 0;
            var count = 0;
            //travel though the nbrs array nbr by nbr
            foreach (var nbr in nbrs)
            {   //add each nbr to var total
                total += nbr;
                //add 1 to count everytime foreach loop executes
                count++;
            }
            //basic math :p
            var avg = total / count;
            Console.WriteLine($"The average for array nbrs is {avg}");

        }
    }
}
