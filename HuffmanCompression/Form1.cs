using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace HuffmanCompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc cây Huffman");
            }

            return objectOut;
        }

        private void new_tree_select_CheckedChanged(object sender, EventArgs e)
        {
            if (new_tree_select.Checked)
            {
                tree_path.Enabled = false;
                get_tree_path.Enabled = false;
                tree_name.Enabled = true;
            }
        }

        private void use_tree_select_CheckedChanged(object sender, EventArgs e)
        {
            if (use_tree_select.Checked)
            {
                tree_path.Enabled = true;
                get_tree_path.Enabled = true;
                tree_name.Enabled = false;
            }
        }

        private void enter_text_select_CheckedChanged(object sender, EventArgs e)
        {
            input_string_entry.ReadOnly = false;
        }

        private void enter_file_select_CheckedChanged(object sender, EventArgs e)
        {
            input_string_entry.ReadOnly = true;
        }

        private void encode_select_CheckedChanged(object sender, EventArgs e)
        {
            output_file_name.Enabled = true;
            tree_path.Enabled = true;
            get_tree_path.Enabled = true;
            input_file_path.Enabled = true;
            get_input_file_path.Enabled = true;
            tree_source_panel.Enabled = true;
            string_source_panel.Enabled = true;
            input_label.Text = "Chuỗi cần mã hóa";
            output_label.Text = "Chuỗi bit đã mã hóa";
            code.Text = "Mã hóa";
            if (new_tree_select.Checked)
            {
                tree_path.Enabled = false;
                get_tree_path.Enabled = false;
                tree_name.Enabled = true;
            }
            else
            {
                tree_path.Enabled = true;
                get_tree_path.Enabled = true;
                tree_name.Enabled = false;
            }
            table_building_group.Enabled = false;
        }

        private void decode_select_CheckedChanged(object sender, EventArgs e)
        {
            output_file_name.Enabled = true;
            tree_path.Enabled = true;
            get_tree_path.Enabled = true;
            input_file_path.Enabled = true;
            get_input_file_path.Enabled = true;
            tree_source_panel.Enabled = false;
            string_source_panel.Enabled = false;
            input_label.Text = "Chuỗi bit cần giải mã";
            output_label.Text = "Chuỗi đã giải mã";
            code.Text = "Giải mã";
            tree_path.Enabled = true;
            get_tree_path.Enabled = true;
            tree_name.Enabled = false;
            table_building_group.Enabled = false;
        }

        private void tree_building_select_CheckedChanged(object sender, EventArgs e)
        {
            table_building_group.Enabled = true;
            string_source_panel.Enabled = false;
            tree_source_panel.Enabled = false;
            tree_path.Enabled = false;
            get_tree_path.Enabled = false;
            input_file_path.Enabled = false;
            get_input_file_path.Enabled = false;
            tree_name.Enabled = true;
            output_file_name.Enabled = false;
            code.Text = "Tạo cây Huffman";
            while (codeword_table.ColumnCount > 0)
            {
                codeword_table.Columns.RemoveAt(0);
            }
            codeword_table.ColumnCount = 2;
            codeword_table.Columns[0].Name = "Ký tự";
            codeword_table.Columns[1].Name = "Số lần xuất hiện";
            codeword_table.Columns[1].ValueType = typeof(int);
        }

        private void get_input_file_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input_file_path.Text = openFileDialog1.FileName;
            }
        }

        private void get_output_folder_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                output_folder_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void get_tree_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tree_path.Text = openFileDialog1.FileName;
            }
        }

        private void code_Click(object sender, EventArgs e)
        {
            if (encode_select.Checked)
            {
                if (enter_file_select.Checked)
                {
                    try
                    {
                        input_string_entry.Text = System.IO.File.ReadAllText(input_file_path.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Huffman_tree tree = new Huffman_tree();
                key key = new key();
                string text = input_string_entry.Text;
                if (new_tree_select.Checked)
                {
                    tree.build_from_string(text);
                    string output_tree_path = output_folder_path.Text + "/" + tree_name.Text;
                    key.Root = tree.Root;
                    SerializeObject<key>(key, output_tree_path);
                }
                else
                {
                    try
                    {
                        key = DeSerializeObject<key>(tree_path.Text);
                        tree.Root = key.Root;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                BitArray encoded = tree.encode(text);
                output_string_display.Text = "";
                string output_file_path = output_folder_path.Text + "/" + output_file_name.Text;
                string display="";
                foreach (bool bit in encoded)
                {
                    display += ((bit ? 1 : 0) + "");
                }
                output_string_display.Text = display;
                try
                {
                    byte[] bytes = new byte[encoded.Length / 8 + (encoded.Length % 8 == 0 ? 0 : 1)];
                    encoded.CopyTo(bytes, 0);
                    File.WriteAllBytes(output_file_path, bytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //display codeword table
                while (codeword_table.ColumnCount > 0)
                {
                    codeword_table.Columns.RemoveAt(0);
                }
                if (new_tree_select.Checked)
                {
                    codeword_table.ColumnCount = 3;
                    codeword_table.Columns[0].Name = "Ký tự";
                    codeword_table.Columns[1].Name = "Số lần xuất hiện";
                    codeword_table.Columns[2].Name = "Từ mã";
                    codeword_table.Columns[1].ValueType = typeof(int);
                }
                else
                {
                    codeword_table.ColumnCount = 2;
                    codeword_table.Columns[0].Name = "Ký tự";
                    codeword_table.Columns[1].Name = "Từ mã";
                }
                foreach (row row in tree.table)
                {
                    if (row.symbol == " ")
                    {
                        row.symbol = "dấu cách";
                    }
                    if (row.symbol == "\n")
                    {
                        row.symbol = "xuống dòng";
                    }
                    if (new_tree_select.Checked)
                    {
                        codeword_table.Rows.Add(row.symbol, row.frequency, row.codeword);
                    }
                    else
                    {
                        codeword_table.Rows.Add(row.symbol, row.codeword);
                    }
                }
            }
            else if (decode_select.Checked)
            {
                Huffman_tree tree = new Huffman_tree();
                key key = new key();
                try
                {
                    key = DeSerializeObject<key>(tree_path.Text);
                    tree.Root = key.Root;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                byte[] bytes = File.ReadAllBytes(input_file_path.Text);
                BitArray encoded = new BitArray(bytes);
                string decoded = tree.decode(encoded);
                string output_file_path = output_folder_path.Text + "/" + output_file_name.Text;
                using (StreamWriter sw = new StreamWriter(output_file_path))
                {
                    sw.WriteLine(decoded);
                }
                output_string_display.Text = decoded;
                //display codeword table
                while (codeword_table.ColumnCount > 0)
                {
                    codeword_table.Columns.RemoveAt(0);
                }
                codeword_table.ColumnCount = 2;
                codeword_table.Columns[0].Name = "Ký tự";
                codeword_table.Columns[1].Name = "Từ mã";
                foreach (row row in tree.table)
                {
                    if (row.symbol == " ")
                    {
                        row.symbol = "dấu cách";
                    }
                    if (row.symbol == "\n")
                    {
                        row.symbol = "xuống dòng";
                    }
                    codeword_table.Rows.Add(row.symbol,row.codeword);
                }
            }
            else if(tree_building_select.Checked)
            {
                Huffman_tree tree = new Huffman_tree();
                tree.Frequencies = Frequencies;
                tree.build_from_frequency();
                tree.create_table();
                key key = new key();
                key.Root = tree.Root;
                string output_tree_path = output_folder_path.Text + "/" + tree_name.Text;
                SerializeObject<key>(key, output_tree_path);
                while (codeword_table.ColumnCount > 0)
                {
                    codeword_table.Columns.RemoveAt(0);
                }
                codeword_table.ColumnCount = 3;
                codeword_table.Columns[0].Name = "Ký tự";
                codeword_table.Columns[1].Name = "Số lần xuất hiện";
                codeword_table.Columns[2].Name = "Từ mã";
                codeword_table.Columns[1].ValueType = typeof(int);
                foreach (row row in tree.table)
                {
                    if (row.symbol == " ")
                    {
                        row.symbol = "dấu cách";
                    }
                    if (row.symbol == "\n")
                    {
                        row.symbol = "xuống dòng";
                    }
                    codeword_table.Rows.Add(row.symbol, row.frequency, row.codeword);
                }
            }
        }

        private void add_row_button_Click(object sender, EventArgs e)
        {
            if (codeword_table.ColumnCount != 2)
            {
                codeword_table.ColumnCount = 2;
            }
            char symbol='*';
            int frequency=0;
            try
            {
                frequency = Convert.ToInt32(frequency_entry.Text);
                if (symbol_entry.Text.Equals("\\n"))
                {
                    symbol = '\n';
                }
                else
                    symbol = Convert.ToChar(symbol_entry.Text);
                try
                {
                    Frequencies.Add(symbol, frequency);
                    if (symbol == '\n')
                    {
                        codeword_table.Rows.Add("xuống dòng", frequency);
                    }
                    else if (symbol == ' ')
                    {
                        codeword_table.Rows.Add("dấu cách", frequency);
                    }
                    else
                    {
                        codeword_table.Rows.Add(symbol, frequency);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Equals("An item with the same key has already been added."))
                    {
                        Frequencies.Remove(symbol);
                        for (int i = 0; i < codeword_table.Rows.Count; i++)
                        {
                            if (codeword_table[0, i].Value != null && codeword_table[0, i].Value.Equals(symbol))
                            {
                                codeword_table.Rows.RemoveAt(i);
                            }
                        }
                        if (symbol == '\n')
                        {
                            codeword_table.Rows.Add("xuống dòng", frequency);
                        }
                        else if (symbol == ' ')
                        {
                            codeword_table.Rows.Add("dấu cách", frequency);
                        }
                        else
                        {
                            codeword_table.Rows.Add(symbol, frequency);
                        }
                        Frequencies.Add(symbol, frequency);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            while (codeword_table.ColumnCount > 0)
            {
                codeword_table.Columns.RemoveAt(0);
            }
            codeword_table.ColumnCount = 2;
            codeword_table.Columns[0].Name = "Ký tự";
            codeword_table.Columns[1].Name = "Số lần xuất hiện";
            codeword_table.Columns[1].ValueType = typeof(int);
            Frequencies.Clear();
        }
    }
}
