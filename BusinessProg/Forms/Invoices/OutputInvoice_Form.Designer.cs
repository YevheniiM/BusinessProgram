namespace BusinessProg.Forms.Invoices
{
    partial class OutputInvoice_Form
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
            this.LB_Product_List = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.BUT_AddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PriceWithDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_ProductKey = new System.Windows.Forms.ComboBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_ProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_Exit = new System.Windows.Forms.Button();
            this.BUT_Save = new System.Windows.Forms.Button();
            this.BUT_Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_ClientKey = new System.Windows.Forms.ComboBox();
            this.DTM_SaleProduct = new System.Windows.Forms.DateTimePicker();
            this.CB_Client = new System.Windows.Forms.ComboBox();
            this.LB_ProductCount = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.LB_Product_List.Location = new System.Drawing.Point(8, 56);
            this.LB_Product_List.Margin = new System.Windows.Forms.Padding(4);
            this.LB_Product_List.Name = "LB_Product_List";
            this.LB_Product_List.Size = new System.Drawing.Size(452, 388);
            this.LB_Product_List.TabIndex = 21;
            this.LB_Product_List.SelectedIndexChanged += new System.EventHandler(this.LB_Product_List_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.NUD_Count);
            this.groupBox3.Controls.Add(this.BUT_AddProduct);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TB_PriceWithDiscount);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TB_Discount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CB_ProductKey);
            this.groupBox3.Controls.Add(this.TB_Price);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CB_ProductName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(16, 222);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(920, 295);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adding the good";
            // 
            // NUD_Count
            // 
            this.NUD_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NUD_Count.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.NUD_Count.ForeColor = System.Drawing.Color.Maroon;
            this.NUD_Count.Location = new System.Drawing.Point(227, 184);
            this.NUD_Count.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_Count.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUD_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(93, 31);
            this.NUD_Count.TabIndex = 26;
            this.NUD_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BUT_AddProduct
            // 
            this.BUT_AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BUT_AddProduct.BackColor = System.Drawing.Color.Coral;
            this.BUT_AddProduct.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_AddProduct.ForeColor = System.Drawing.Color.White;
            this.BUT_AddProduct.Location = new System.Drawing.Point(13, 244);
            this.BUT_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_AddProduct.Name = "BUT_AddProduct";
            this.BUT_AddProduct.Size = new System.Drawing.Size(896, 42);
            this.BUT_AddProduct.TabIndex = 24;
            this.BUT_AddProduct.Text = "Add";
            this.BUT_AddProduct.UseVisualStyleBackColor = false;
            this.BUT_AddProduct.Click += new System.EventHandler(this.BUT_AddProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Amount";
            // 
            // TB_PriceWithDiscount
            // 
            this.TB_PriceWithDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_PriceWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_PriceWithDiscount.Location = new System.Drawing.Point(758, 142);
            this.TB_PriceWithDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.TB_PriceWithDiscount.Name = "TB_PriceWithDiscount";
            this.TB_PriceWithDiscount.Size = new System.Drawing.Size(125, 31);
            this.TB_PriceWithDiscount.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(543, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Price with discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(887, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // TB_Discount
            // 
            this.TB_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Discount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_Discount.Location = new System.Drawing.Point(758, 183);
            this.TB_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Discount.Name = "TB_Discount";
            this.TB_Discount.Size = new System.Drawing.Size(125, 31);
            this.TB_Discount.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(543, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(8, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Price";
            // 
            // CB_ProductKey
            // 
            this.CB_ProductKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_ProductKey.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_ProductKey.FormattingEnabled = true;
            this.CB_ProductKey.Location = new System.Drawing.Point(227, 95);
            this.CB_ProductKey.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ProductKey.Name = "CB_ProductKey";
            this.CB_ProductKey.Size = new System.Drawing.Size(680, 32);
            this.CB_ProductKey.TabIndex = 14;
            this.CB_ProductKey.SelectedIndexChanged += new System.EventHandler(this.CB_ProductKey_SelectedIndexChanged);
            // 
            // TB_Price
            // 
            this.TB_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Price.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_Price.Location = new System.Drawing.Point(227, 142);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(93, 31);
            this.TB_Price.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Good name";
            // 
            // CB_ProductName
            // 
            this.CB_ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_ProductName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_ProductName.FormattingEnabled = true;
            this.CB_ProductName.Location = new System.Drawing.Point(227, 53);
            this.CB_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ProductName.Name = "CB_ProductName";
            this.CB_ProductName.Size = new System.Drawing.Size(680, 32);
            this.CB_ProductName.TabIndex = 16;
            this.CB_ProductName.SelectedIndexChanged += new System.EventHandler(this.CB_ProductName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(8, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Good code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date";
            // 
            // BUT_Exit
            // 
            this.BUT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Exit.BackColor = System.Drawing.Color.Coral;
            this.BUT_Exit.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Exit.ForeColor = System.Drawing.Color.White;
            this.BUT_Exit.Location = new System.Drawing.Point(1298, 526);
            this.BUT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Exit.Name = "BUT_Exit";
            this.BUT_Exit.Size = new System.Drawing.Size(214, 37);
            this.BUT_Exit.TabIndex = 35;
            this.BUT_Exit.Text = "Exit";
            this.BUT_Exit.UseVisualStyleBackColor = false;
            this.BUT_Exit.Click += new System.EventHandler(this.BUT_Exit_Click);
            // 
            // BUT_Save
            // 
            this.BUT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Save.BackColor = System.Drawing.Color.Coral;
            this.BUT_Save.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Save.ForeColor = System.Drawing.Color.White;
            this.BUT_Save.Location = new System.Drawing.Point(952, 526);
            this.BUT_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Save.Name = "BUT_Save";
            this.BUT_Save.Size = new System.Drawing.Size(338, 37);
            this.BUT_Save.TabIndex = 31;
            this.BUT_Save.Text = "Save";
            this.BUT_Save.UseVisualStyleBackColor = false;
            this.BUT_Save.Click += new System.EventHandler(this.BUT_Save_Click);
            // 
            // BUT_Remove
            // 
            this.BUT_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Remove.BackColor = System.Drawing.Color.Coral;
            this.BUT_Remove.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Remove.ForeColor = System.Drawing.Color.White;
            this.BUT_Remove.Location = new System.Drawing.Point(7, 452);
            this.BUT_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Remove.Name = "BUT_Remove";
            this.BUT_Remove.Size = new System.Drawing.Size(544, 42);
            this.BUT_Remove.TabIndex = 15;
            this.BUT_Remove.Text = "Delete";
            this.BUT_Remove.UseVisualStyleBackColor = false;
            this.BUT_Remove.Click += new System.EventHandler(this.BUT_Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Client";
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_PhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_PhoneNumber.Location = new System.Drawing.Point(227, 132);
            this.TB_PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TB_PhoneNumber.Mask = "(999) 000-00-00";
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(378, 31);
            this.TB_PhoneNumber.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_ClientKey);
            this.groupBox1.Controls.Add(this.DTM_SaleProduct);
            this.groupBox1.Controls.Add(this.CB_Client);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_PhoneNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(920, 186);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(651, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Client code";
            // 
            // CB_ClientKey
            // 
            this.CB_ClientKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_ClientKey.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_ClientKey.FormattingEnabled = true;
            this.CB_ClientKey.Location = new System.Drawing.Point(789, 44);
            this.CB_ClientKey.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ClientKey.Name = "CB_ClientKey";
            this.CB_ClientKey.Size = new System.Drawing.Size(118, 32);
            this.CB_ClientKey.TabIndex = 12;
            this.CB_ClientKey.SelectedIndexChanged += new System.EventHandler(this.CB_ClientKey_SelectedIndexChanged);
            // 
            // DTM_SaleProduct
            // 
            this.DTM_SaleProduct.CalendarForeColor = System.Drawing.Color.Maroon;
            this.DTM_SaleProduct.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DTM_SaleProduct.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.DTM_SaleProduct.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.DTM_SaleProduct.Location = new System.Drawing.Point(227, 45);
            this.DTM_SaleProduct.Margin = new System.Windows.Forms.Padding(4);
            this.DTM_SaleProduct.Name = "DTM_SaleProduct";
            this.DTM_SaleProduct.Size = new System.Drawing.Size(378, 31);
            this.DTM_SaleProduct.TabIndex = 27;
            // 
            // CB_Client
            // 
            this.CB_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_Client.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.CB_Client.FormattingEnabled = true;
            this.CB_Client.Location = new System.Drawing.Point(227, 88);
            this.CB_Client.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Client.Name = "CB_Client";
            this.CB_Client.Size = new System.Drawing.Size(378, 32);
            this.CB_Client.TabIndex = 29;
            this.CB_Client.SelectedIndexChanged += new System.EventHandler(this.CB_Client_SelectedIndexChanged);
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
            this.LB_ProductCount.Location = new System.Drawing.Point(458, 56);
            this.LB_ProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.LB_ProductCount.Name = "LB_ProductCount";
            this.LB_ProductCount.Size = new System.Drawing.Size(93, 388);
            this.LB_ProductCount.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LB_Product_List);
            this.groupBox2.Controls.Add(this.LB_ProductCount);
            this.groupBox2.Controls.Add(this.BUT_Remove);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(944, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(568, 503);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding the good";
            // 
            // OutputInvoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1523, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BUT_Exit);
            this.Controls.Add(this.BUT_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1541, 618);
            this.Name = "OutputInvoice_Form";
            this.Text = "OutputInvoice_Form";
            this.Load += new System.EventHandler(this.OutputInvoice_Form_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Product_List;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BUT_AddProduct;
        private System.Windows.Forms.TextBox TB_PriceWithDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_ProductKey;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_ProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUT_Exit;
        private System.Windows.Forms.Button BUT_Save;
        private System.Windows.Forms.Button BUT_Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TB_PhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_ClientKey;
        public System.Windows.Forms.ListBox LB_ProductCount;
        private System.Windows.Forms.ComboBox CB_Client;
        private System.Windows.Forms.DateTimePicker DTM_SaleProduct;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}