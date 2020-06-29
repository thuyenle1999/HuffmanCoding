using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCompression
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;

    public class row
    {
        public string symbol;
        public int frequency;
        public string codeword;
    }
    [Serializable] public class key
    {
        public Node Root { get; set; }
    }
    public class Huffman_tree
    {
        private List<Node> nodes = new List<Node>();
        public Node Root { get; set; }
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();
        public List<row> table = new List<row>();
        public void build_from_string(string source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            }

            build_from_frequency();

        }
        public void build_from_frequency()
        {
            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();

                    // Create a parent node by combining the frequencies
                    Node parent = new Node()
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }

                this.Root = nodes.FirstOrDefault();

            }
        }

        public void create_table()
        {
            foreach (KeyValuePair<char, int> pair in Frequencies)
            {
                row row = new row();
                Node node = this.Root;
                row.symbol += pair.Key;
                row.frequency = pair.Value;
                List<bool> codeword = node.Traverse(pair.Key, new List<bool>());
                foreach (bool char_bit in codeword)
                {
                    row.codeword += (char_bit ? 1 : 0) + "";
                }
                table.Add(row);
            }
        }
        public BitArray encode(string source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> codeword = this.Root.Traverse(source[i], new List<bool>());
                encodedSource.AddRange(codeword);
                bool existed = false;
                string symbol = "";
                symbol += source[i];
                // check if current symbol existed in the table
                foreach (row reference in table)
                {
                    if (symbol == reference.symbol)
                    {
                        existed = true;
                    }
                }
                //if current row doesn't exist in the table, add it
                if (!existed)
                {
                    row row = new row();
                    row.symbol = symbol;
                    Frequencies.TryGetValue(source[i], out row.frequency);
                    row.codeword = "";
                    foreach (bool char_bit in codeword)
                    {
                        row.codeword+= (char_bit ? 1 : 0) + "";
                    }
                    table.Add(row);
                }
            }

            BitArray bits = new BitArray(encodedSource.ToArray());

            return bits;
        }

        public string decode(BitArray bits)
        {
            Node current = this.Root;
            string decoded = "";

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    //save row into table
                    bool existed = false;
                    //check if current symbol exist in table
                    foreach (row reference in table)
                    {
                        if (Convert.ToString(current.Symbol) == reference.symbol)
                        {
                            existed = true;
                        }
                    }
                    if (!existed)
                    {
                        row row = new row();
                        row.symbol += current.Symbol;
                        row.codeword = "";
                        row.frequency = current.Frequency;
                        List<bool> codeword = this.Root.Traverse(current.Symbol, new List<bool>());
                        foreach (bool char_bit in codeword)
                        {
                            row.codeword += (char_bit ? 1 : 0) + "";
                        }
                        table.Add(row);
                    }
                    //reset current node
                    current = this.Root;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

    }
}
