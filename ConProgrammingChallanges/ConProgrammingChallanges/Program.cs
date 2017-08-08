using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConProgrammingChallanges
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdOne birdOne = new BirdOne();
            birdOne.Walk();
            birdOne.Fly();

            BirdTow birdTwo = new BirdTow();
            birdTwo.Walk();
            birdTwo.Sing();
        }
    }
}
