using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CART
{
    class Node
    {
        public bool isLeaf;
        public Node left;
        public Node right;
        public Split split;
        public string cls;
        public int[] rows;
        public double impurity { get; set; }
        public string data { get; set; }

        public Node()
        {
            left = null;
            right = null;
            isLeaf = false;
            data = "";
        }

        public Node(int[] rows)
        {
            this.rows = rows;
            left = null;
            right = null;
            isLeaf = false;
            data = "";
        }

        public Node(Split split)
        {
            isLeaf = false;
            this.split = split;
            impurity = split.gini.Value;
            int samples = split.groups[0].Length + split.groups[1].Length;
            data = split.attribute + " <= " + split.separator.ToString() + "? Samples: "+ samples +". Impurity: " + Math.Round(impurity, 5).ToString();

            left = new Node(split.groups[0]);
            right = new Node(split.groups[1]);
            if (split.groups.Count > 2)
                throw new Exception("Tree is binary!");
        }

        public void AssignClass(string cls, int wrong, int[] rows=null)
        {
            left = null;
            right = null;
            isLeaf = true;
            this.cls = cls;
            if (rows != null)
                this.rows = rows;
            data = cls + ". Samples: " + this.rows.Length + ". Wrong classified: "+ wrong.ToString();
        }
    }
}
