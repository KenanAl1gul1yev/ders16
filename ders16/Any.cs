using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders16
{
    internal class Any:Some
    {
        protected override void Main()
        {
            base.Main();
        }
        public Any(int n,string k):base(n,k)
        {
            Console.WriteLine(n+" "+k+" "+"any");
        }
    }
}
