namespace HuffmanCompression
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input_string_entry = new System.Windows.Forms.RichTextBox();
            this.output_string_display = new System.Windows.Forms.RichTextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.new_tree_select = new System.Windows.Forms.RadioButton();
            this.use_tree_select = new System.Windows.Forms.RadioButton();
            this.tree_source_panel = new System.Windows.Forms.Panel();
            this.string_source_panel = new System.Windows.Forms.Panel();
            this.enter_file_select = new System.Windows.Forms.RadioButton();
            this.enter_text_select = new System.Windows.Forms.RadioButton();
            this.input_file_path = new System.Windows.Forms.TextBox();
            this.output_folder_path = new System.Windows.Forms.TextBox();
            this.get_input_file_path = new System.Windows.Forms.Button();
            this.get_output_folder_path = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.output_file_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tree_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tree_path = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tree_building_select = new System.Windows.Forms.RadioButton();
            this.decode_select = new System.Windows.Forms.RadioButton();
            this.encode_select = new System.Windows.Forms.RadioButton();
            this.get_tree_path = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.codeword_table = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.frequency_entry = new System.Windows.Forms.TextBox();
            this.symbol_entry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_row_button = new System.Windows.Forms.Button();
            this.table_building_group = new System.Windows.Forms.GroupBox();
            this.tree_source_panel.SuspendLayout();
            this.string_source_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeword_table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.table_building_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_string_entry
            // 
            this.input_string_entry.Location = new System.Drawing.Point(44, 36);
            this.input_string_entry.Name = "input_string_entry";
            this.input_string_entry.Size = new System.Drawing.Size(421, 202);
            this.input_string_entry.TabIndex = 0;
            this.input_string_entry.Text = "";
            // 
            // output_string_display
            // 
            this.output_string_display.Location = new System.Drawing.Point(44, 285);
            this.output_string_display.Name = "output_string_display";
            this.output_string_display.ReadOnly = true;
            this.output_string_display.Size = new System.Drawing.Size(421, 202);
            this.output_string_display.TabIndex = 1;
            this.output_string_display.Text = "";
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(41, 20);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(93, 13);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "Chuỗi cần mã hóa";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(41, 269);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(102, 13);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "Chuỗi bit đã mã hóa";
            // 
            // new_tree_select
            // 
            this.new_tree_select.AutoSize = true;
            this.new_tree_select.Location = new System.Drawing.Point(3, 12);
            this.new_tree_select.Name = "new_tree_select";
            this.new_tree_select.Size = new System.Drawing.Size(126, 17);
            this.new_tree_select.TabIndex = 4;
            this.new_tree_select.TabStop = true;
            this.new_tree_select.Text = "Tạo cây Huffman mới";
            this.new_tree_select.UseVisualStyleBackColor = true;
            this.new_tree_select.CheckedChanged += new System.EventHandler(this.new_tree_select_CheckedChanged);
            // 
            // use_tree_select
            // 
            this.use_tree_select.AutoSize = true;
            this.use_tree_select.Location = new System.Drawing.Point(3, 35);
            this.use_tree_select.Name = "use_tree_select";
            this.use_tree_select.Size = new System.Drawing.Size(149, 17);
            this.use_tree_select.TabIndex = 5;
            this.use_tree_select.TabStop = true;
            this.use_tree_select.Text = "Dùng cây Huffman có sẵn";
            this.use_tree_select.UseVisualStyleBackColor = true;
            this.use_tree_select.CheckedChanged += new System.EventHandler(this.use_tree_select_CheckedChanged);
            // 
            // tree_source_panel
            // 
            this.tree_source_panel.Controls.Add(this.new_tree_select);
            this.tree_source_panel.Controls.Add(this.use_tree_select);
            this.tree_source_panel.Location = new System.Drawing.Point(19, 28);
            this.tree_source_panel.Name = "tree_source_panel";
            this.tree_source_panel.Size = new System.Drawing.Size(157, 61);
            this.tree_source_panel.TabIndex = 6;
            // 
            // string_source_panel
            // 
            this.string_source_panel.Controls.Add(this.enter_file_select);
            this.string_source_panel.Controls.Add(this.enter_text_select);
            this.string_source_panel.Location = new System.Drawing.Point(182, 28);
            this.string_source_panel.Name = "string_source_panel";
            this.string_source_panel.Size = new System.Drawing.Size(157, 61);
            this.string_source_panel.TabIndex = 7;
            // 
            // enter_file_select
            // 
            this.enter_file_select.AutoSize = true;
            this.enter_file_select.Location = new System.Drawing.Point(3, 35);
            this.enter_file_select.Name = "enter_file_select";
            this.enter_file_select.Size = new System.Drawing.Size(77, 17);
            this.enter_file_select.TabIndex = 9;
            this.enter_file_select.TabStop = true;
            this.enter_file_select.Text = "Mã hóa file";
            this.enter_file_select.UseVisualStyleBackColor = true;
            this.enter_file_select.CheckedChanged += new System.EventHandler(this.enter_file_select_CheckedChanged);
            // 
            // enter_text_select
            // 
            this.enter_text_select.AutoSize = true;
            this.enter_text_select.Location = new System.Drawing.Point(3, 12);
            this.enter_text_select.Name = "enter_text_select";
            this.enter_text_select.Size = new System.Drawing.Size(132, 17);
            this.enter_text_select.TabIndex = 8;
            this.enter_text_select.TabStop = true;
            this.enter_text_select.Text = "Nhập chuỗi từ text box";
            this.enter_text_select.UseVisualStyleBackColor = true;
            this.enter_text_select.CheckedChanged += new System.EventHandler(this.enter_text_select_CheckedChanged);
            // 
            // input_file_path
            // 
            this.input_file_path.Location = new System.Drawing.Point(19, 95);
            this.input_file_path.Name = "input_file_path";
            this.input_file_path.Size = new System.Drawing.Size(157, 20);
            this.input_file_path.TabIndex = 8;
            // 
            // output_folder_path
            // 
            this.output_folder_path.Location = new System.Drawing.Point(182, 95);
            this.output_folder_path.Name = "output_folder_path";
            this.output_folder_path.Size = new System.Drawing.Size(157, 20);
            this.output_folder_path.TabIndex = 9;
            // 
            // get_input_file_path
            // 
            this.get_input_file_path.Location = new System.Drawing.Point(19, 121);
            this.get_input_file_path.Name = "get_input_file_path";
            this.get_input_file_path.Size = new System.Drawing.Size(157, 23);
            this.get_input_file_path.TabIndex = 10;
            this.get_input_file_path.Text = "Chọn file cần mã hóa";
            this.get_input_file_path.UseVisualStyleBackColor = true;
            this.get_input_file_path.Click += new System.EventHandler(this.get_input_file_path_Click);
            // 
            // get_output_folder_path
            // 
            this.get_output_folder_path.Location = new System.Drawing.Point(182, 121);
            this.get_output_folder_path.Name = "get_output_folder_path";
            this.get_output_folder_path.Size = new System.Drawing.Size(157, 23);
            this.get_output_folder_path.TabIndex = 11;
            this.get_output_folder_path.Text = "Chọn thư mục xuất file";
            this.get_output_folder_path.UseVisualStyleBackColor = true;
            this.get_output_folder_path.Click += new System.EventHandler(this.get_output_folder_path_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // output_file_name
            // 
            this.output_file_name.Location = new System.Drawing.Point(185, 163);
            this.output_file_name.Name = "output_file_name";
            this.output_file_name.Size = new System.Drawing.Size(154, 20);
            this.output_file_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên file xuất ra";
            // 
            // tree_name
            // 
            this.tree_name.Location = new System.Drawing.Point(22, 163);
            this.tree_name.Name = "tree_name";
            this.tree_name.Size = new System.Drawing.Size(154, 20);
            this.tree_name.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên file cây Huffman";
            // 
            // tree_path
            // 
            this.tree_path.Location = new System.Drawing.Point(345, 95);
            this.tree_path.Name = "tree_path";
            this.tree_path.Size = new System.Drawing.Size(157, 20);
            this.tree_path.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tree_building_select);
            this.panel3.Controls.Add(this.decode_select);
            this.panel3.Controls.Add(this.encode_select);
            this.panel3.Location = new System.Drawing.Point(345, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 70);
            this.panel3.TabIndex = 17;
            // 
            // tree_building_select
            // 
            this.tree_building_select.AutoSize = true;
            this.tree_building_select.Location = new System.Drawing.Point(4, 49);
            this.tree_building_select.Name = "tree_building_select";
            this.tree_building_select.Size = new System.Drawing.Size(107, 17);
            this.tree_building_select.TabIndex = 2;
            this.tree_building_select.TabStop = true;
            this.tree_building_select.Text = "Tạo cây Huffman";
            this.tree_building_select.UseVisualStyleBackColor = true;
            this.tree_building_select.CheckedChanged += new System.EventHandler(this.tree_building_select_CheckedChanged);
            // 
            // decode_select
            // 
            this.decode_select.AutoSize = true;
            this.decode_select.Location = new System.Drawing.Point(4, 26);
            this.decode_select.Name = "decode_select";
            this.decode_select.Size = new System.Drawing.Size(60, 17);
            this.decode_select.TabIndex = 1;
            this.decode_select.TabStop = true;
            this.decode_select.Text = "Giải mã";
            this.decode_select.UseVisualStyleBackColor = true;
            this.decode_select.CheckedChanged += new System.EventHandler(this.decode_select_CheckedChanged);
            // 
            // encode_select
            // 
            this.encode_select.AutoSize = true;
            this.encode_select.Location = new System.Drawing.Point(4, 3);
            this.encode_select.Name = "encode_select";
            this.encode_select.Size = new System.Drawing.Size(61, 17);
            this.encode_select.TabIndex = 0;
            this.encode_select.TabStop = true;
            this.encode_select.Text = "Mã hóa";
            this.encode_select.UseVisualStyleBackColor = true;
            this.encode_select.CheckedChanged += new System.EventHandler(this.encode_select_CheckedChanged);
            // 
            // get_tree_path
            // 
            this.get_tree_path.Location = new System.Drawing.Point(345, 121);
            this.get_tree_path.Name = "get_tree_path";
            this.get_tree_path.Size = new System.Drawing.Size(157, 23);
            this.get_tree_path.TabIndex = 18;
            this.get_tree_path.Text = "Chọn cây Huffman";
            this.get_tree_path.UseVisualStyleBackColor = true;
            this.get_tree_path.Click += new System.EventHandler(this.get_tree_path_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(345, 150);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(157, 33);
            this.code.TabIndex = 19;
            this.code.Text = "Mã hóa";
            this.code.UseVisualStyleBackColor = true;
            this.code.Click += new System.EventHandler(this.code_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bảng mã";
            // 
            // codeword_table
            // 
            this.codeword_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeword_table.Location = new System.Drawing.Point(488, 226);
            this.codeword_table.Name = "codeword_table";
            this.codeword_table.Size = new System.Drawing.Size(386, 261);
            this.codeword_table.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Controls.Add(this.get_tree_path);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.tree_path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tree_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.output_file_name);
            this.groupBox1.Controls.Add(this.get_output_folder_path);
            this.groupBox1.Controls.Add(this.get_input_file_path);
            this.groupBox1.Controls.Add(this.output_folder_path);
            this.groupBox1.Controls.Add(this.input_file_path);
            this.groupBox1.Controls.Add(this.string_source_panel);
            this.groupBox1.Controls.Add(this.tree_source_panel);
            this.groupBox1.Location = new System.Drawing.Point(479, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 198);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giải mã/Mã hóa";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(14, 132);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 23);
            this.clear_button.TabIndex = 29;
            this.clear_button.Text = "Xóa bảng";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // frequency_entry
            // 
            this.frequency_entry.Location = new System.Drawing.Point(14, 78);
            this.frequency_entry.Name = "frequency_entry";
            this.frequency_entry.Size = new System.Drawing.Size(100, 20);
            this.frequency_entry.TabIndex = 24;
            // 
            // symbol_entry
            // 
            this.symbol_entry.Location = new System.Drawing.Point(14, 39);
            this.symbol_entry.Name = "symbol_entry";
            this.symbol_entry.Size = new System.Drawing.Size(100, 20);
            this.symbol_entry.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nhập ký tự";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nhập tần số";
            // 
            // add_row_button
            // 
            this.add_row_button.Location = new System.Drawing.Point(14, 104);
            this.add_row_button.Name = "add_row_button";
            this.add_row_button.Size = new System.Drawing.Size(101, 23);
            this.add_row_button.TabIndex = 28;
            this.add_row_button.Text = "Thêm vào bảng";
            this.add_row_button.UseVisualStyleBackColor = true;
            this.add_row_button.Click += new System.EventHandler(this.add_row_button_Click);
            // 
            // table_building_group
            // 
            this.table_building_group.Controls.Add(this.clear_button);
            this.table_building_group.Controls.Add(this.add_row_button);
            this.table_building_group.Controls.Add(this.label5);
            this.table_building_group.Controls.Add(this.label4);
            this.table_building_group.Controls.Add(this.symbol_entry);
            this.table_building_group.Controls.Add(this.frequency_entry);
            this.table_building_group.Location = new System.Drawing.Point(885, 247);
            this.table_building_group.Name = "table_building_group";
            this.table_building_group.Size = new System.Drawing.Size(121, 163);
            this.table_building_group.TabIndex = 28;
            this.table_building_group.TabStop = false;
            this.table_building_group.Text = "Tạo bảng Huffman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 499);
            this.Controls.Add(this.table_building_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.codeword_table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.output_string_display);
            this.Controls.Add(this.input_string_entry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tree_source_panel.ResumeLayout(false);
            this.tree_source_panel.PerformLayout();
            this.string_source_panel.ResumeLayout(false);
            this.string_source_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeword_table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.table_building_group.ResumeLayout(false);
            this.table_building_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_string_entry;
        private System.Windows.Forms.RichTextBox output_string_display;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.RadioButton new_tree_select;
        private System.Windows.Forms.RadioButton use_tree_select;
        private System.Windows.Forms.Panel tree_source_panel;
        private System.Windows.Forms.Panel string_source_panel;
        private System.Windows.Forms.RadioButton enter_file_select;
        private System.Windows.Forms.RadioButton enter_text_select;
        private System.Windows.Forms.TextBox input_file_path;
        private System.Windows.Forms.TextBox output_folder_path;
        private System.Windows.Forms.Button get_input_file_path;
        private System.Windows.Forms.Button get_output_folder_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox output_file_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tree_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tree_path;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton decode_select;
        private System.Windows.Forms.RadioButton encode_select;
        private System.Windows.Forms.Button get_tree_path;
        private System.Windows.Forms.Button code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView codeword_table;
        private System.Windows.Forms.RadioButton tree_building_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox frequency_entry;
        private System.Windows.Forms.TextBox symbol_entry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_row_button;
        private System.Windows.Forms.GroupBox table_building_group;
    }
}

