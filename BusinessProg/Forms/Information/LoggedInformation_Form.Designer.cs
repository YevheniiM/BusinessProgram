namespace BusinessProg.Forms.Information
{
    partial class LoggedInformation_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.HourChecked = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_InputInvoices = new System.Windows.Forms.ListBox();
            this.LB_OutputInvoices = new System.Windows.Forms.ListBox();
            this.LB_ClientsAdded = new System.Windows.Forms.ListBox();
            this.LB_ProvidersAdded = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalInput = new System.Windows.Forms.TextBox();
            this.TotalOutput = new System.Windows.Forms.TextBox();
            this.TotalClients = new System.Windows.Forms.TextBox();
            this.TotalProviders = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_AverageInput = new System.Windows.Forms.TextBox();
            this.TB_AverageOutput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_AverageClients = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_AverageProviders = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // BUT_Exit
            // 
            this.BUT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Exit.BackColor = System.Drawing.Color.Coral;
            this.BUT_Exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.BUT_Exit.ForeColor = System.Drawing.Color.White;
            this.BUT_Exit.Location = new System.Drawing.Point(1010, 529);
            this.BUT_Exit.Name = "BUT_Exit";
            this.BUT_Exit.Size = new System.Drawing.Size(169, 39);
            this.BUT_Exit.TabIndex = 7;
            this.BUT_Exit.Text = "Exit";
            this.BUT_Exit.UseVisualStyleBackColor = false;
            this.BUT_Exit.Click += new System.EventHandler(this.BUT_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "From";
            // 
            // From
            // 
            this.From.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.From.CalendarForeColor = System.Drawing.Color.Maroon;
            this.From.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.From.Location = new System.Drawing.Point(83, 8);
            this.From.Margin = new System.Windows.Forms.Padding(4);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(311, 31);
            this.From.TabIndex = 21;
            this.From.Value = new System.DateTime(2019, 1, 1, 17, 31, 0, 0);
            // 
            // To
            // 
            this.To.CalendarFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.To.CalendarForeColor = System.Drawing.Color.Maroon;
            this.To.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.To.Location = new System.Drawing.Point(514, 8);
            this.To.Margin = new System.Windows.Forms.Padding(4);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(311, 31);
            this.To.TabIndex = 23;
            this.To.Value = new System.DateTime(2019, 12, 30, 17, 31, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(455, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "To";
            // 
            // Hour
            // 
            this.Hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Hour.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.Hour.Location = new System.Drawing.Point(1021, 9);
            this.Hour.Margin = new System.Windows.Forms.Padding(4);
            this.Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(150, 31);
            this.Hour.TabIndex = 31;
            this.Hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(900, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Day Hour";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HourChecked
            // 
            this.HourChecked.AutoSize = true;
            this.HourChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourChecked.Location = new System.Drawing.Point(875, 18);
            this.HourChecked.Name = "HourChecked";
            this.HourChecked.Size = new System.Drawing.Size(18, 17);
            this.HourChecked.TabIndex = 33;
            this.HourChecked.UseVisualStyleBackColor = true;
            this.HourChecked.CheckedChanged += new System.EventHandler(this.HourChecked_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(59, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Input invoices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(358, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Output invoices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(671, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Clients added";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(968, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Providers added";
            // 
            // LB_InputInvoices
            // 
            this.LB_InputInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_InputInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_InputInvoices.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_InputInvoices.ForeColor = System.Drawing.Color.Maroon;
            this.LB_InputInvoices.FormattingEnabled = true;
            this.LB_InputInvoices.ItemHeight = 24;
            this.LB_InputInvoices.Location = new System.Drawing.Point(18, 125);
            this.LB_InputInvoices.Name = "LB_InputInvoices";
            this.LB_InputInvoices.Size = new System.Drawing.Size(232, 292);
            this.LB_InputInvoices.TabIndex = 42;
            // 
            // LB_OutputInvoices
            // 
            this.LB_OutputInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_OutputInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_OutputInvoices.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_OutputInvoices.ForeColor = System.Drawing.Color.Maroon;
            this.LB_OutputInvoices.FormattingEnabled = true;
            this.LB_OutputInvoices.ItemHeight = 24;
            this.LB_OutputInvoices.Location = new System.Drawing.Point(324, 125);
            this.LB_OutputInvoices.Name = "LB_OutputInvoices";
            this.LB_OutputInvoices.Size = new System.Drawing.Size(232, 292);
            this.LB_OutputInvoices.TabIndex = 43;
            // 
            // LB_ClientsAdded
            // 
            this.LB_ClientsAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ClientsAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_ClientsAdded.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_ClientsAdded.ForeColor = System.Drawing.Color.Maroon;
            this.LB_ClientsAdded.FormattingEnabled = true;
            this.LB_ClientsAdded.ItemHeight = 24;
            this.LB_ClientsAdded.Location = new System.Drawing.Point(636, 125);
            this.LB_ClientsAdded.Name = "LB_ClientsAdded";
            this.LB_ClientsAdded.Size = new System.Drawing.Size(232, 292);
            this.LB_ClientsAdded.TabIndex = 44;
            // 
            // LB_ProvidersAdded
            // 
            this.LB_ProvidersAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ProvidersAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LB_ProvidersAdded.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LB_ProvidersAdded.ForeColor = System.Drawing.Color.Maroon;
            this.LB_ProvidersAdded.FormattingEnabled = true;
            this.LB_ProvidersAdded.ItemHeight = 24;
            this.LB_ProvidersAdded.Location = new System.Drawing.Point(939, 125);
            this.LB_ProvidersAdded.Name = "LB_ProvidersAdded";
            this.LB_ProvidersAdded.Size = new System.Drawing.Size(232, 292);
            this.LB_ProvidersAdded.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(24, 427);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(331, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 29);
            this.label9.TabIndex = 47;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(642, 427);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 48;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(945, 427);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 29);
            this.label11.TabIndex = 49;
            this.label11.Text = "Total";
            // 
            // TotalInput
            // 
            this.TotalInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalInput.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TotalInput.Location = new System.Drawing.Point(95, 428);
            this.TotalInput.Margin = new System.Windows.Forms.Padding(4);
            this.TotalInput.Name = "TotalInput";
            this.TotalInput.ReadOnly = true;
            this.TotalInput.Size = new System.Drawing.Size(155, 31);
            this.TotalInput.TabIndex = 50;
            // 
            // TotalOutput
            // 
            this.TotalOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalOutput.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TotalOutput.Location = new System.Drawing.Point(402, 428);
            this.TotalOutput.Margin = new System.Windows.Forms.Padding(4);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.ReadOnly = true;
            this.TotalOutput.Size = new System.Drawing.Size(155, 31);
            this.TotalOutput.TabIndex = 51;
            // 
            // TotalClients
            // 
            this.TotalClients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalClients.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TotalClients.Location = new System.Drawing.Point(713, 428);
            this.TotalClients.Margin = new System.Windows.Forms.Padding(4);
            this.TotalClients.Name = "TotalClients";
            this.TotalClients.ReadOnly = true;
            this.TotalClients.Size = new System.Drawing.Size(155, 31);
            this.TotalClients.TabIndex = 52;
            // 
            // TotalProviders
            // 
            this.TotalProviders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalProviders.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TotalProviders.Location = new System.Drawing.Point(1016, 428);
            this.TotalProviders.Margin = new System.Windows.Forms.Padding(4);
            this.TotalProviders.Name = "TotalProviders";
            this.TotalProviders.ReadOnly = true;
            this.TotalProviders.Size = new System.Drawing.Size(155, 31);
            this.TotalProviders.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(986, 39);
            this.button1.TabIndex = 54;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(24, 479);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 29);
            this.label12.TabIndex = 55;
            this.label12.Text = "Average";
            // 
            // TB_AverageInput
            // 
            this.TB_AverageInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TB_AverageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_AverageInput.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_AverageInput.Location = new System.Drawing.Point(135, 480);
            this.TB_AverageInput.Margin = new System.Windows.Forms.Padding(4);
            this.TB_AverageInput.Name = "TB_AverageInput";
            this.TB_AverageInput.ReadOnly = true;
            this.TB_AverageInput.Size = new System.Drawing.Size(115, 31);
            this.TB_AverageInput.TabIndex = 56;
            // 
            // TB_AverageOutput
            // 
            this.TB_AverageOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TB_AverageOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_AverageOutput.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_AverageOutput.Location = new System.Drawing.Point(442, 480);
            this.TB_AverageOutput.Margin = new System.Windows.Forms.Padding(4);
            this.TB_AverageOutput.Name = "TB_AverageOutput";
            this.TB_AverageOutput.ReadOnly = true;
            this.TB_AverageOutput.Size = new System.Drawing.Size(115, 31);
            this.TB_AverageOutput.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(331, 479);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 29);
            this.label13.TabIndex = 57;
            this.label13.Text = "Average";
            // 
            // TB_AverageClients
            // 
            this.TB_AverageClients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TB_AverageClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_AverageClients.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_AverageClients.Location = new System.Drawing.Point(753, 480);
            this.TB_AverageClients.Margin = new System.Windows.Forms.Padding(4);
            this.TB_AverageClients.Name = "TB_AverageClients";
            this.TB_AverageClients.ReadOnly = true;
            this.TB_AverageClients.Size = new System.Drawing.Size(115, 31);
            this.TB_AverageClients.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(642, 479);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 29);
            this.label14.TabIndex = 59;
            this.label14.Text = "Average";
            // 
            // TB_AverageProviders
            // 
            this.TB_AverageProviders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TB_AverageProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_AverageProviders.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.TB_AverageProviders.Location = new System.Drawing.Point(1056, 480);
            this.TB_AverageProviders.Margin = new System.Windows.Forms.Padding(4);
            this.TB_AverageProviders.Name = "TB_AverageProviders";
            this.TB_AverageProviders.ReadOnly = true;
            this.TB_AverageProviders.Size = new System.Drawing.Size(115, 31);
            this.TB_AverageProviders.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(945, 479);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 29);
            this.label15.TabIndex = 61;
            this.label15.Text = "Average";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(870, 44);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 25);
            this.label16.TabIndex = 63;
            this.label16.Text = "(average per day is displayed)";
            // 
            // LoggedInformation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1187, 574);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TB_AverageProviders);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TB_AverageClients);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TB_AverageOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TB_AverageInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalProviders);
            this.Controls.Add(this.TotalClients);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.TotalInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_ProvidersAdded);
            this.Controls.Add(this.LB_ClientsAdded);
            this.Controls.Add(this.LB_OutputInvoices);
            this.Controls.Add(this.LB_InputInvoices);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HourChecked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BUT_Exit);
            this.MaximumSize = new System.Drawing.Size(1205, 9999);
            this.MinimumSize = new System.Drawing.Size(1205, 621);
            this.Name = "LoggedInformation_Form";
            this.Text = "LoggedInformation_Form";
            this.Load += new System.EventHandler(this.LoggedInformation_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LB_InputInvoices;
        private System.Windows.Forms.ListBox LB_OutputInvoices;
        private System.Windows.Forms.ListBox LB_ClientsAdded;
        private System.Windows.Forms.ListBox LB_ProvidersAdded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TotalInput;
        private System.Windows.Forms.TextBox TotalOutput;
        private System.Windows.Forms.TextBox TotalClients;
        private System.Windows.Forms.TextBox TotalProviders;
        private System.Windows.Forms.CheckBox HourChecked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_AverageInput;
        private System.Windows.Forms.TextBox TB_AverageOutput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_AverageClients;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_AverageProviders;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}