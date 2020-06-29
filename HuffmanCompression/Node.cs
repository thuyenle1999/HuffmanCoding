using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCompression
{
    public class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> left_path = new List<bool>();
                    left_path.AddRange(data);
                    left_path.Add(false);

                    left = Left.Traverse(symbol, left_path);
                }

                if (Right != null)
                {
                    List<bool> right_path = new List<bool>();
                    right_path.AddRange(data);
                    right_path.Add(true);
                    right = Right.Traverse(symbol, right_path);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
