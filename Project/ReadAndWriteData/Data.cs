using System;
using Algoritem;

namespace ReadAndWriteData
{
    public class Data
    {
        public string name { get; set; }
        public string  lastName { get; set; }
        public double age { get; set; }

        public void Print()
        {
            Console.WriteLine("My name is:{0},\nMy lastName is:{1},\nMy age is:{2}", name, lastName, age);
        }


      
   
        
       


    }
}
