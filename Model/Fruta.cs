using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos_ExProgreso33.Model
{
    public class Fruta
    {
        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public string name { get; set; }
            public int id { get; set; }
            public string family { get; set; }
            public string order { get; set; }
            public string genus { get; set; }
            public Nutritions nutritions { get; set; }
        }

        public class Nutritions
        {
            public int calories { get; set; }
            public float fat { get; set; }
            public float sugar { get; set; }
            public float carbohydrates { get; set; }
            public float protein { get; set; }
        }

    }
}
