namespace WindowsFormsApplication1
{
    partial class product_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.GroupBox();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_cost = new System.Windows.Forms.TextBox();
            this.product_nums = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.product_find = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.general = new System.Windows.Forms.DataGridView();
            this.details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // details
            // 
            this.details.Controls.Add(this.supplier);
            this.details.Controls.Add(this.product_type);
            this.details.Controls.Add(this.label6);
            this.details.Controls.Add(this.label5);
            this.details.Controls.Add(this.label4);
            this.details.Controls.Add(this.label3);
            this.details.Controls.Add(this.label2);
            this.details.Controls.Add(this.product_cost);
            this.details.Controls.Add(this.product_nums);
            this.details.Controls.Add(this.product_name);
            this.details.Location = new System.Drawing.Point(13, 28);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(587, 102);
            this.details.TabIndex = 2;
            this.details.TabStop = false;
            this.details.Text = "Thông tin chi tiết";
            // 
            // supplier
            // 
            this.supplier.FormattingEnabled = true;
            this.supplier.Location = new System.Drawing.Point(420, 46);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(121, 21);
            this.supplier.TabIndex = 11;
            // 
            // product_type
            // 
            this.product_type.FormattingEnabled = true;
            this.product_type.Location = new System.Drawing.Point(420, 19);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(121, 21);
            this.product_type.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // product_cost
            // 
            this.product_cost.Location = new System.Drawing.Point(99, 71);
            this.product_cost.Name = "product_cost";
            this.product_cost.Size = new System.Drawing.Size(135, 20);
            this.product_cost.TabIndex = 2;
            // 
            // product_nums
            // 
            this.product_nums.Location = new System.Drawing.Point(99, 45);
            this.product_nums.Name = "product_nums";
            this.product_nums.Size = new System.Drawing.Size(135, 20);
            this.product_nums.TabIndex = 1;
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(99, 18);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(135, 20);
            this.product_name.TabIndex = 0;
            this.product_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tìm tên sản phẩm:";
            // 
            // product_find
            // 
            this.product_find.Location = new System.Drawing.Point(112, 155);
            this.product_find.Name = "product_find";
            this.product_find.Size = new System.Drawing.Size(135, 20);
            this.product_find.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Location = new System.Drawing.Point(265, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(249, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 64);
            this.exit.TabIndex = 7;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(168, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 64);
            this.edit.TabIndex = 6;
            this.edit.Text = "Sửa";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(87, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 64);
            this.delete.TabIndex = 6;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 64);
            this.add.TabIndex = 0;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.general);
            this.groupBox2.Location = new System.Drawing.Point(24, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // general
            // 
            this.general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.general.Location = new System.Drawing.Point(6, 19);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(559, 170);
            this.general.TabIndex = 0;
            // 
            // product_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.product_find);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label1);
            this.Name = "product_list";
            this.Text = "DANH MỤC SẢN PHẨM";
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.general)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_cost;
        private System.Windows.Forms.TextBox product_nums;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.ComboBox supplier;
        private System.Windows.Forms.ComboBox product_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox product_find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView general;
    }
}