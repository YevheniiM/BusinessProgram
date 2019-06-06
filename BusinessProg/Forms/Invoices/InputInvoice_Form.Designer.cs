namespace BusinessProg.Forms.Invoices
{
    partial class InputInvoice_Form
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
            this.BUT_Add_Product = new System.Windows.Forms.Button();
            this.NUD_Product_Count = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Product_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Product_Name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Product_Code = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Provider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTM_ArrivalProduct = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_ProductCount = new System.Windows.Forms.ListBox();
            this.BUT_Del_Product = new System.Windows.Forms.Button();
            this.BUT_Save = new System.Windows.Forms.Button();
            this.BUT_Close = new System.Windows.Forms.Button();
            this.LB_Product_List = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Product_Count)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUT_Add_Product
            // 
            this.BUT_Add_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BUT_Add_Product.BackColor = System.Drawing.Color.Coral;
            this.BUT_Add_Product.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Add_Product.ForeColor = System.Drawing.Color.White;
            this.BUT_Add_Product.Location = new System.Drawing.Point(20, 325);
            this.BUT_Add_Product.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Add_Product.Name = "BUT_Add_Product";
            this.BUT_Add_Product.Size = new System.Drawing.Size(777, 39);
            this.BUT_Add_Product.TabIndex = 32;
            this.BUT_Add_Product.Text = "Add";
            this.BUT_Add_Product.UseVisualStyleBackColor = false;
            this.BUT_Add_Product.Click += new System.EventHandler(this.BUT_Add_Product_Click);
            // 
            // NUD_Product_Count
            // 
            this.NUD_Product_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NUD_Product_Count.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NUD_Product_Count.Location = new System.Drawing.Point(223, 272);
            this.NUD_Product_Count.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_Product_Count.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_Product_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Product_Count.Name = "NUD_Product_Count";
            this.NUD_Product_Count.Size = new System.Drawing.Size(150, 31);
            this.NUD_Product_Count.TabIndex = 30;
            this.NUD_Product_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(14, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 29);
            this.label10.TabIndex = 29;
            this.label10.Text = "Amount";
            // 
            // TB_Product_Price
            // 
            this.TB_Product_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Product_Price.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_Product_Price.Location = new System.Drawing.Point(221, 227);
            this.TB_Product_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Product_Price.Name = "TB_Product_Price";
            this.TB_Product_Price.Size = new System.Drawing.Size(150, 31);
            this.TB_Product_Price.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(14, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "Price";
            // 
            // CB_Product_Name
            // 
            this.CB_Product_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_Product_Name.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_Product_Name.FormattingEnabled = true;
            this.CB_Product_Name.Location = new System.Drawing.Point(221, 136);
            this.CB_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Product_Name.Name = "CB_Product_Name";
            this.CB_Product_Name.Size = new System.Drawing.Size(573, 32);
            this.CB_Product_Name.TabIndex = 26;
            this.CB_Product_Name.SelectedIndexChanged += new System.EventHandler(this.CB_Product_Name_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(14, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Good name";
            // 
            // CB_Product_Code
            // 
            this.CB_Product_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_Product_Code.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_Product_Code.FormattingEnabled = true;
            this.CB_Product_Code.Location = new System.Drawing.Point(221, 182);
            this.CB_Product_Code.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Product_Code.Name = "CB_Product_Code";
            this.CB_Product_Code.Size = new System.Drawing.Size(573, 32);
            this.CB_Product_Code.TabIndex = 24;
            this.CB_Product_Code.SelectedIndexChanged += new System.EventHandler(this.CB_Product_Code_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(14, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Good code";
            // 
            // CB_Provider
            // 
            this.CB_Provider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_Provider.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_Provider.FormattingEnabled = true;
            this.CB_Provider.Location = new System.Drawing.Point(221, 94);
            this.CB_Provider.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Provider.Name = "CB_Provider";
            this.CB_Provider.Size = new System.Drawing.Size(573, 32);
            this.CB_Provider.TabIndex = 22;
            this.CB_Provider.SelectedIndexChanged += new System.EventHandler(this.CB_Provider_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Producer";
            // 
            // DTM_ArrivalProduct
            // 
            this.DTM_ArrivalProduct.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.DTM_ArrivalProduct.CalendarForeColor = System.Drawing.Color.Maroon;
            this.DTM_ArrivalProduct.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.DTM_ArrivalProduct.Location = new System.Drawing.Point(223, 50);
            this.DTM_ArrivalProduct.Margin = new System.Windows.Forms.Padding(4);
            this.DTM_ArrivalProduct.Name = "DTM_ArrivalProduct";
            this.DTM_ArrivalProduct.Size = new System.Drawing.Size(573, 31);
            this.DTM_ArrivalProduct.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.BUT_Add_Product);
            this.groupBox2.Controls.Add(this.NUD_Product_Count);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DTM_ArrivalProduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TB_Product_Price);
            this.groupBox2.Controls.Add(this.CB_Provider);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CB_Product_Name);
            this.groupBox2.Controls.Add(this.CB_Product_Code);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 380);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding the good";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LB_ProductCount
            // 
            this.LB_ProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ProductCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_ProductCount.Enabled = false;
            this.LB_ProductCount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_ProductCount.ForeColor = System.Drawing.Color.Maroon;
            this.LB_ProductCount.FormattingEnabled = true;
            this.LB_ProductCount.ItemHeight = 24;
            this.LB_ProductCount.Location = new System.Drawing.Point(479, 50);
            this.LB_ProductCount.Name = "LB_ProductCount";
            this.LB_ProductCount.Size = new System.Drawing.Size(67, 268);
            this.LB_ProductCount.TabIndex = 40;
            // 
            // BUT_Del_Product
            // 
            this.BUT_Del_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Del_Product.BackColor = System.Drawing.Color.Coral;
            this.BUT_Del_Product.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Del_Product.ForeColor = System.Drawing.Color.White;
            this.BUT_Del_Product.Location = new System.Drawing.Point(12, 325);
            this.BUT_Del_Product.Name = "BUT_Del_Product";
            this.BUT_Del_Product.Size = new System.Drawing.Size(539, 39);
            this.BUT_Del_Product.TabIndex = 37;
            this.BUT_Del_Product.Text = "Remove";
            this.BUT_Del_Product.UseVisualStyleBackColor = false;
            this.BUT_Del_Product.Click += new System.EventHandler(this.BUT_Del_Product_Click);
            // 
            // BUT_Save
            // 
            this.BUT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Save.BackColor = System.Drawing.Color.Coral;
            this.BUT_Save.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Save.ForeColor = System.Drawing.Color.White;
            this.BUT_Save.Location = new System.Drawing.Point(834, 407);
            this.BUT_Save.Name = "BUT_Save";
            this.BUT_Save.Size = new System.Drawing.Size(270, 41);
            this.BUT_Save.TabIndex = 39;
            this.BUT_Save.Text = "Save";
            this.BUT_Save.UseVisualStyleBackColor = false;
            this.BUT_Save.Click += new System.EventHandler(this.BUT_Save_Click);
            // 
            // BUT_Close
            // 
            this.BUT_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Close.BackColor = System.Drawing.Color.Coral;
            this.BUT_Close.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Close.ForeColor = System.Drawing.Color.White;
            this.BUT_Close.Location = new System.Drawing.Point(1110, 407);
            this.BUT_Close.Name = "BUT_Close";
            this.BUT_Close.Size = new System.Drawing.Size(263, 41);
            this.BUT_Close.TabIndex = 38;
            this.BUT_Close.Text = "Exit";
            this.BUT_Close.UseVisualStyleBackColor = false;
            this.BUT_Close.Click += new System.EventHandler(this.BUT_Close_Click);
            // 
            // LB_Product_List
            // 
            this.LB_Product_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Product_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_Product_List.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_Product_List.ForeColor = System.Drawing.Color.Maroon;
            this.LB_Product_List.FormattingEnabled = true;
            this.LB_Product_List.ItemHeight = 24;
            this.LB_Product_List.Location = new System.Drawing.Point(12, 50);
            this.LB_Product_List.Name = "LB_Product_List";
            this.LB_Product_List.Size = new System.Drawing.Size(466, 268);
            this.LB_Product_List.TabIndex = 41;
            this.LB_Product_List.SelectedIndexChanged += new System.EventHandler(this.LB_Product_List_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BUT_Del_Product);
            this.groupBox1.Controls.Add(this.LB_Product_List);
            this.groupBox1.Controls.Add(this.LB_ProductCount);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(822, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 380);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of goods";
            // 
            // InputInvoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1382, 452);
            this.Controls.Add(this.BUT_Save);
            this.Controls.Add(this.BUT_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 499);
            this.Name = "InputInvoice_Form";
            this.Text = "InputInvoice_Form";
            this.Load += new System.EventHandler(this.InputInvoice_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Product_Count)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUT_Add_Product;
        private System.Windows.Forms.NumericUpDown NUD_Product_Count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Product_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Product_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Product_Code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Provider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTM_ArrivalProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox LB_ProductCount;
        private System.Windows.Forms.Button BUT_Del_Product;
        private System.Windows.Forms.Button BUT_Save;
        private System.Windows.Forms.Button BUT_Close;
        private System.Windows.Forms.ListBox LB_Product_List;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}