using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExternalClass ec = new ExternalClass();
            Console.WriteLine(ec.AFineMethod(1, "some kind of result"));
            Console.WriteLine(ec.ANotSoFineMethod(2, "three"));
        }
    }
}
