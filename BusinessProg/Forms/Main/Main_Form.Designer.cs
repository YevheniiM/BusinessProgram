namespace BusinessProg.Forms.Main
{
    partial class Main_Form
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
            this.BUT_Exit = new System.Windows.Forms.Button();
            this.BUT_Selling = new System.Windows.Forms.Button();
            this.BUT_Posting_Product = new System.Windows.Forms.Button();
            this.BUT_AddInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUT_Exit
            // 
            this.BUT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Exit.BackColor = System.Drawing.Color.Coral;
            this.BUT_Exit.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Exit.ForeColor = System.Drawing.Color.White;
            this.BUT_Exit.Location = new System.Drawing.Point(379, 149);
            this.BUT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Exit.Name = "BUT_Exit";
            this.BUT_Exit.Size = new System.Drawing.Size(182, 37);
            this.BUT_Exit.TabIndex = 7;
            this.BUT_Exit.Text = "Exit";
            this.BUT_Exit.UseVisualStyleBackColor = false;
            this.BUT_Exit.Click += new System.EventHandler(this.BUT_Exit_Click);
            // 
            // BUT_Selling
            // 
            this.BUT_Selling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Selling.BackColor = System.Drawing.Color.Coral;
            this.BUT_Selling.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BUT_Selling.ForeColor = System.Drawing.Color.White;
            this.BUT_Selling.Location = new System.Drawing.Point(13, 54);
            this.BUT_Selling.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Selling.Name = "BUT_Selling";
            this.BUT_Selling.Size = new System.Drawing.Size(548, 37);
            this.BUT_Selling.TabIndex = 5;
            this.BUT_Selling.Text = "Create a bill";
            this.BUT_Selling.UseVisualStyleBackColor = false;
            this.BUT_Selling.Click += new System.EventHandler(this.BUT_Selling_Click);
            // 
            // BUT_Posting_Product
            // 
            this.BUT_Posting_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Posting_Product.BackColor = System.Drawing.Color.Coral;
            this.BUT_Posting_Product.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BUT_Posting_Product.ForeColor = System.Drawing.Color.White;
            this.BUT_Posting_Product.Location = new System.Drawing.Point(13, 13);
            this.BUT_Posting_Product.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Posting_Product.Name = "BUT_Posting_Product";
            this.BUT_Posting_Product.Size = new System.Drawing.Size(548, 37);
            this.BUT_Posting_Product.TabIndex = 4;
            this.BUT_Posting_Product.Text = "Debit the good";
            this.BUT_Posting_Product.UseVisualStyleBackColor = false;
            this.BUT_Posting_Product.Click += new System.EventHandler(this.BUT_Posting_Product_Click);
            // 
            // BUT_AddInformation
            // 
            this.BUT_AddInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_AddInformation.BackColor = System.Drawing.Color.Coral;
            this.BUT_AddInformation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BUT_AddInformation.ForeColor = System.Drawing.Color.White;
            this.BUT_AddInformation.Location = new System.Drawing.Point(8, 99);
            this.BUT_AddInformation.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_AddInformation.Name = "BUT_AddInformation";
            this.BUT_AddInformation.Size = new System.Drawing.Size(548, 37);
            this.BUT_AddInformation.TabIndex = 8;
            this.BUT_AddInformation.Text = "Information";
            this.BUT_AddInformation.UseVisualStyleBackColor = false;
            this.BUT_AddInformation.Click += new System.EventHandler(this.BUT_AddInformation_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(569, 191);
            this.Controls.Add(this.BUT_AddInformation);
            this.Controls.Add(this.BUT_Exit);
            this.Controls.Add(this.BUT_Selling);
            this.Controls.Add(this.BUT_Posting_Product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUT_Exit;
        private System.Windows.Forms.Button BUT_Selling;
        private System.Windows.Forms.Button BUT_Posting_Product;
        private System.Windows.Forms.Button BUT_AddInformation;
    }
}