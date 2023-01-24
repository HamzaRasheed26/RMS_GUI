namespace RMS_V5.Forms.CustomerForms
{
    partial class FrmBuyTicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblToStation = new System.Windows.Forms.Label();
            this.lblFromStation = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 111);
            this.panel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(180, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 57);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "RAILWAY MANAGMENT SYSTEM ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(729, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 423);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 423);
            this.panel2.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.numYear);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numMonth);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numDay);
            this.panel4.Controls.Add(this.cbTo);
            this.panel4.Controls.Add(this.cbFrom);
            this.panel4.Controls.Add(this.btnBuy);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.numQuantity);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lblToStation);
            this.panel4.Controls.Add(this.lblFromStation);
            this.panel4.Controls.Add(this.txtTicketPrice);
            this.panel4.Controls.Add(this.lblTicketPrice);
            this.panel4.Controls.Add(this.txtTrainName);
            this.panel4.Controls.Add(this.lblTrainName);
            this.panel4.Location = new System.Drawing.Point(155, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 423);
            this.panel4.TabIndex = 9;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.Location = new System.Drawing.Point(413, 348);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(118, 32);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Buy Ticket";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(255, 300);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 23);
            this.txtPrice.TabIndex = 9;
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantity.Location = new System.Drawing.Point(255, 255);
            this.numQuantity.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 23);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(139, 301);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Total Price :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(158, 256);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 22);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(190, 201);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 22);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date :";
            // 
            // lblToStation
            // 
            this.lblToStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToStation.AutoSize = true;
            this.lblToStation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToStation.Location = new System.Drawing.Point(145, 132);
            this.lblToStation.Name = "lblToStation";
            this.lblToStation.Size = new System.Drawing.Size(104, 22);
            this.lblToStation.TabIndex = 5;
            this.lblToStation.Text = "To Station :";
            // 
            // lblFromStation
            // 
            this.lblFromStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromStation.AutoSize = true;
            this.lblFromStation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFromStation.Location = new System.Drawing.Point(121, 90);
            this.lblFromStation.Name = "lblFromStation";
            this.lblFromStation.Size = new System.Drawing.Size(128, 22);
            this.lblFromStation.TabIndex = 4;
            this.lblFromStation.Text = "From Station :";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketPrice.Location = new System.Drawing.Point(432, 22);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.ReadOnly = true;
            this.txtTicketPrice.Size = new System.Drawing.Size(84, 23);
            this.txtTicketPrice.TabIndex = 3;
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketPrice.Location = new System.Drawing.Point(305, 23);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(121, 22);
            this.lblTicketPrice.TabIndex = 2;
            this.lblTicketPrice.Text = "Ticket Price :";
            // 
            // txtTrainName
            // 
            this.txtTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrainName.Location = new System.Drawing.Point(149, 22);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(131, 23);
            this.txtTrainName.TabIndex = 1;
            // 
            // lblTrainName
            // 
            this.lblTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(25, 23);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(118, 22);
            this.lblTrainName.TabIndex = 0;
            this.lblTrainName.Text = "Train Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(388, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Year";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(388, 200);
            this.numYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(56, 23);
            this.numYear.TabIndex = 40;
            this.numYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(326, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Month";
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(326, 200);
            this.numMonth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(56, 23);
            this.numMonth.TabIndex = 38;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.ValueChanged += new System.EventHandler(this.numMonth_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Day";
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(264, 200);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(56, 23);
            this.numDay.TabIndex = 36;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTo
            // 
            this.cbTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(263, 131);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(146, 23);
            this.cbTo.TabIndex = 35;
            // 
            // cbFrom
            // 
            this.cbFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(264, 89);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(145, 23);
            this.cbFrom.TabIndex = 34;
            // 
            // FrmBuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBuyTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Ticket";
            this.Load += new System.EventHandler(this.FrmBuyTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel3;
        private Panel panel2;
        private Button btnBack;
        private Panel panel4;
        private TextBox txtTicketPrice;
        private Label lblTicketPrice;
        private TextBox txtTrainName;
        private Label lblTrainName;
        private Label lblFromStation;
        private Label lblToStation;
        private Label lblDate;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnBuy;
        private Label label3;
        private NumericUpDown numYear;
        private Label label2;
        private NumericUpDown numMonth;
        private Label label1;
        private NumericUpDown numDay;
        private ComboBox cbTo;
        private ComboBox cbFrom;
    }
}