using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    class Class1
    {
        public void Main(String[] args)
        {
            overloading obj = new overloading();
            Console.WriteLine(obj.add(4,5));

        }

    }

    public class overloading
    {
        public int add(int x, int y)
        {
            return (x + y);
        }

        public int add(int x, int y, int z)
        {
            return (x + y+z);
        }

        public string add(string x, string y)
        {
            return (x + y);
        }
    }
}
