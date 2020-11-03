using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CART
{
    class Tree
    {
        DataTable dt;
        int levels;
        string[] classes;
        int[] attributes;
        Node root;
        int classColumn;

        public Tree(DataTable dt, int levels)
        {
            this.dt = dt;
            this.levels = levels;

            classes = GetClasses(dt);
            attributes = GetAttributes(dt);
            root = CreateTree();
        }

        private int[] GetAttributes(DataTable dt)
        {
            List<int> res = new List<int>();
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName != "class")
                    res.Add(dt.Columns.IndexOf(col));
            }
            return res.ToArray();
        }

        private string[] GetClasses(DataTable dt)
        {
            List<string> classes = new List<string>(0);
            classColumn = dt.Columns.IndexOf("class");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var category = dt.Rows[i][classColumn];
                if (!classes.Contains(category.ToString()))
                    classes.Add(category.ToString());
            }
            return classes.ToArray();
        }

        private Node CreateTree()
        {
            int[] rows = new int[dt.Rows.Count];
            for (int i = 0; i < rows.Length; i++)
                rows[i] = i;

            Node root = new Node(GetSplit(rows));

            return DecisionTree(root, 1);
        }

        private Node DecisionTree(Node node, int depth)
        {
            if (node.left != null && node.left.rows.Length == 0 || node.right != null && node.right.rows.Length == 0)
            {
                int[] rows = node.left.rows.Concat(node.right.rows).ToArray();
                string cls = GetMostCommonClass(rows);
                int wrong = getWrongClassified(rows, cls);
                node.AssignClass(cls, wrong, rows);
                return node;
            }

            if (depth >= levels)
            {
                string leftClass = GetMostCommonClass(node.left.rows);
                string rightClass = GetMostCommonClass(node.right.rows);
                if (leftClass == rightClass)
                {
                    int[] rows = node.left.rows.Concat(node.left.rows).ToArray();
                    int wrong = getWrongClassified(rows, leftClass);
                    node.AssignClass(leftClass, wrong, rows);
                }
                else
                {
                    int wrongLeft = getWrongClassified(node.left.rows, leftClass);
                    int wrongRight = getWrongClassified(node.right.rows, rightClass);
                    node.left.AssignClass(leftClass, wrongLeft);
                    node.right.AssignClass(rightClass, wrongRight);
                }
                return node;
            }
            
            node.left = new Node(GetSplit(node.left.rows));
            DecisionTree(node.left, depth + 1);
            
            node.right = new Node(GetSplit(node.right.rows));
            DecisionTree(node.right, depth + 1);

            return node;
        }

        public void Predict(DataTable dt_test, DataGridView dataGridView2, Label label)
        {
            if (!dt_test.Columns.Contains("prediction"))
                dt_test.Columns.Add("prediction");
            int right = 0, wrong = 0;
            double accuracy = 0.0;
            for (int i=0; i<dt_test.Rows.Count; i++)
            {
                dt_test.Rows[i]["prediction"] = GetPrediction(root, dt_test, i);
                if (dt_test.Rows[i]["class"].ToString() == dt_test.Rows[i]["prediction"].ToString())
                    right++;
                else
                    wrong++;
            }
            dataGridView2.DataSource = dt_test;
            accuracy = right * 100.0 / (right + wrong);
            label.Text = "Right classified: " + right.ToString() + ". Wrong clasified: " + wrong.ToString() + ". Accuracy: " + accuracy.ToString() + "%.";
        }

        private string GetPrediction(Node node, DataTable dt_test, int i)
        {
            if (node.isLeaf)
                return node.cls;
            double value = double.Parse(dt_test.Rows[i][node.split.attribute].ToString().Replace('.', ','));
            if (value <= node.split.separator)
                return GetPrediction(node.left, dt_test, i);
            return GetPrediction(node.right, dt_test, i);
        }

        private string GetMostCommonClass(int[] rows)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string cls in classes)
                dict.Add(cls, 0);

            foreach (int row in rows)
            {
                foreach (string cls in classes)
                {
                    if (dt.Rows[row][classColumn].ToString() == cls)
                    {
                        dict[cls]++;
                        break;
                    }
                }
            }

            return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }

        private List<int[]> TestSplit(int attribute, double separator, int[] Rows)
        {
            List<int[]> result = new List<int[]>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            foreach (int row in Rows)
            {
                double value = double.Parse(dt.Rows[row][attribute].ToString().Replace('.', ','));
                if (value <= separator)
                    left.Add(row);
                else
                    right.Add(row);
            }

            result.Add(left.ToArray());
            result.Add(right.ToArray());

            return result;
        }

        private Split GetSplit(int[] Rows)
        {
            Split split = new Split();

            foreach (int i in attributes)
            {
                double[] separators = GetSeparators(Rows, i);
                foreach (double separator in separators)
                {
                    List<int[]> groups = TestSplit(i, separator, Rows);
                    double gini = GetGini(groups);

                    if (!split.gini.HasValue || gini < split.gini)
                    {
                        split.attribute = dt.Columns[i].ColumnName;
                        split.gini = gini;
                        split.groups = groups;
                        split.separator = separator;
                    }
                }
            }
            return split;
        }

        private double[] GetSeparators(int[] rows, int column)
        {
            List<double> values = new List<double>();
            for (int i = 0; i < rows.Length; i++)
            {
                double value = double.Parse(dt.Rows[rows[i]][column].ToString().Replace('.', ','));
                if (!values.Contains(value))
                    values.Add(value);
            }
            values.Sort();
            double minVal = values[0];

            for (int i = 1; i < values.Count; i++)
                values[i - 1] += (values[i] - values[i - 1]) / 2;

            values[values.Count - 1] += 1;
            values.Insert(0, minVal - 1);

            return values.ToArray();
        }

        private double GetGini(List<int[]> groups)
        {
            int total = 0;
            foreach (int[] group in groups)
                total += group.Length;

            double sum = 0.0;

            foreach (var group in groups)
            {
                if (group.Length == 0)
                    continue;

                double score = 0;
                foreach (var cls in classes)
                {
                    double prob = getProbability(group, cls);
                    score += prob * prob;
                }
                sum += (1.0 - score) * group.Length / total;
            }
            return sum;
        }

        private double getProbability(int[] group, string cls)
        {
            double count = 0;
            foreach (int row in group)
                if (dt.Rows[row][classColumn].ToString() == cls)
                    count++;
            return count / group.Length;
        }

        private int getWrongClassified(int[] group, string cls)
        {
            int count = 0;
            foreach (int row in group)
                if (dt.Rows[row][classColumn].ToString() != cls)
                    count++;
            return count;
        }
        
        public void Display(TreeView treeView)
        {
            treeView.Nodes.Clear();
            ShowNode(root, treeView.Nodes.Add("Root: "));
        }

        private void ShowNode(Node node, TreeNode treeNode)
        {
            treeNode.Text += node.data;
            if (node.left != null)
            {
                TreeNode left = treeNode.Nodes.Add("Yes: ");
                left.ForeColor = Color.DarkGreen;
                ShowNode(node.left, left);
            }
            if (node.right != null)
            {
                TreeNode right = treeNode.Nodes.Add("No: ");
                right.ForeColor = Color.DarkRed;
                ShowNode(node.right, right);
            }
        }
    }
}
