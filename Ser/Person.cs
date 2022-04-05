using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ser
{
    public class Data
    {
        public int Num { get; set; }
        public string  Str { get; set; }


    }
    public class Person
    {
        public string Id { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        
        public Data AdditionalData { get; set; }

        public string GetId() { return Id; }

    }
}
