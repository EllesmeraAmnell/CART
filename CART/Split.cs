using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CART
{
    class Split
    {
        public List<int[]> groups { get; set; }
        public string attribute { get; set; }
        public double? gini { get; set; }
        public double? separator { get; set; }

        public Split()
        {
            groups = null;
            attribute = null;
            gini = null;
            separator = null;
        }
    }
}
