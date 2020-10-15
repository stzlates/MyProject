using System;

namespace Algoritem
{
    public class Algo
    {
        public string problem { get; set; }
        public int level { get; set; }
        public void Print()
        {
            Console.WriteLine("My problem  is:{0},\nMy level is:{1}",problem,level);
        }

    }
}
