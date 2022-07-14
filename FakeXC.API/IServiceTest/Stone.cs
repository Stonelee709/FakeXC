using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.IServiceTest
{
    public class Stone:IStone
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine(Name+"is at age of "+ Age);
        }
    }
}
