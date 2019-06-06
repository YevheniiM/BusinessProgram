namespace BusinessProg.Forms.Information
{
    partial class AddClient_Form
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
            this.BUT_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Discount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ExtraData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BUT_Save
            // 
            this.BUT_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Save.BackColor = System.Drawing.Color.Coral;
            this.BUT_Save.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.BUT_Save.ForeColor = System.Drawing.Color.White;
            this.BUT_Save.Location = new System.Drawing.Point(17, 299);
            this.BUT_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BUT_Save.Name = "BUT_Save";
            this.BUT_Save.Size = new System.Drawing.Size(530, 39);
            this.BUT_Save.TabIndex = 0;
            this.BUT_Save.Text = "Save";
            this.BUT_Save.UseVisualStyleBackColor = false;
            this.BUT_Save.Click += new System.EventHandler(this.BUT_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Name.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_Name.Location = new System.Drawing.Point(249, 11);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(298, 31);
            this.TB_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone number";
            // 
            // TB_Discount
            // 
            this.TB_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_Discount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_Discount.Location = new System.Drawing.Point(249, 98);
            this.TB_Discount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TB_Discount.Name = "TB_Discount";
            this.TB_Discount.Size = new System.Drawing.Size(298, 31);
            this.TB_Discount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disount";
            // 
            // TB_ExtraData
            // 
            this.TB_ExtraData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ExtraData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_ExtraData.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_ExtraData.Location = new System.Drawing.Point(249, 143);
            this.TB_ExtraData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TB_ExtraData.Multiline = true;
            this.TB_ExtraData.Name = "TB_ExtraData";
            this.TB_ExtraData.Size = new System.Drawing.Size(298, 148);
            this.TB_ExtraData.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional information";
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_PhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_PhoneNumber.Location = new System.Drawing.Point(249, 54);
            this.TB_PhoneNumber.Mask = "(999) 000-00-00";
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(298, 31);
            this.TB_PhoneNumber.TabIndex = 9;
            // 
            // AddClient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(555, 343);
            this.Controls.Add(this.TB_PhoneNumber);
            this.Controls.Add(this.TB_ExtraData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Discount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BUT_Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(573, 390);
            this.Name = "AddClient_Form";
            this.Text = "AddClient_Form";
            this.Load += new System.EventHandler(this.AddClient_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Discount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_ExtraData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TB_PhoneNumber;
    }
}