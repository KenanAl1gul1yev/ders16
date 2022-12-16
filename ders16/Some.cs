using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders16
{
    public class Some:Iface
    {
        public string Kenan(string name)
        {
            return name;
        }
        public void World()
        {
            Console.WriteLine("Hello World!");
        }
        protected virtual void Main()
        {
            Console.WriteLine("Some");
        }

        public void ad(int age)
        {
            throw new NotImplementedException();
        }

        public Some(int id,string name)
        {
            Console.WriteLine(id +" "+ name+"Some");
        }
    }
}
