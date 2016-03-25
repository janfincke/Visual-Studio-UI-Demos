using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isoprojekti
{
    class MyItem
    {
        public int Birthyear { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Birthyear;
        }
    }
}
