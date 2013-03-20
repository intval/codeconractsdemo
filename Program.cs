using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeContractsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void bla(string s)
        {
            // basic check
            // this check put a lot of garbage in our code
            if (null == s)
                throw new ArgumentException("argh");
        }
    }
}
