namespace RMS_V5.Forms.CustomerForms
{
    partial class FrmBookCargo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.btnBookCargo = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblToStation = new System.Windows.Forms.Label();
            this.lblFromStation = new System.Windows.Forms.Label();
            this.txtCargoPrice = new System.Windows.Forms.TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(197, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 57);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "RAILWAY MANAGMENT SYSTEM ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 111);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(729, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 423);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 423);
            this.panel2.TabIndex = 9;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.numYear);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numMonth);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numDay);
            this.panel4.Controls.Add(this.cbTo);
            this.panel4.Controls.Add(this.cbFrom);
            this.panel4.Controls.Add(this.btnBookCargo);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.numWeight);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.lblWeight);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lblToStation);
            this.panel4.Controls.Add(this.lblFromStation);
            this.panel4.Controls.Add(this.txtCargoPrice);
            this.panel4.Controls.Add(this.lblTicketPrice);
            this.panel4.Controls.Add(this.txtTrainName);
            this.panel4.Controls.Add(this.lblTrainName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(155, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 423);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(396, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Year";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(396, 210);
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
            this.numYear.TabIndex = 32;
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
            this.label2.Location = new System.Drawing.Point(334, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Month";
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(334, 210);
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
            this.numMonth.TabIndex = 30;
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
            this.label1.Location = new System.Drawing.Point(272, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Day";
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(272, 210);
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
            this.numDay.TabIndex = 28;
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
            this.cbTo.Location = new System.Drawing.Point(271, 141);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(146, 23);
            this.cbTo.TabIndex = 27;
            // 
            // cbFrom
            // 
            this.cbFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(272, 99);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(145, 23);
            this.cbFrom.TabIndex = 26;
            // 
            // btnBookCargo
            // 
            this.btnBookCargo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBookCargo.Location = new System.Drawing.Point(413, 359);
            this.btnBookCargo.Name = "btnBookCargo";
            this.btnBookCargo.Size = new System.Drawing.Size(120, 32);
            this.btnBookCargo.TabIndex = 25;
            this.btnBookCargo.Text = "Book Cargo";
            this.btnBookCargo.UseVisualStyleBackColor = true;
            this.btnBookCargo.Click += new System.EventHandler(this.btnBookCargo_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(272, 304);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 23);
            this.txtPrice.TabIndex = 24;
            // 
            // numWeight
            // 
            this.numWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numWeight.Location = new System.Drawing.Point(272, 259);
            this.numWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 23);
            this.numWeight.TabIndex = 23;
            this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeight.ValueChanged += new System.EventHandler(this.numWeight_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(156, 305);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 22);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Total Price :";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(175, 260);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(78, 22);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "Weight :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(194, 211);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 22);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date :";
            // 
            // lblToStation
            // 
            this.lblToStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToStation.AutoSize = true;
            this.lblToStation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToStation.Location = new System.Drawing.Point(162, 142);
            this.lblToStation.Name = "lblToStation";
            this.lblToStation.Size = new System.Drawing.Size(104, 22);
            this.lblToStation.TabIndex = 19;
            this.lblToStation.Text = "To Station :";
            // 
            // lblFromStation
            // 
            this.lblFromStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromStation.AutoSize = true;
            this.lblFromStation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFromStation.Location = new System.Drawing.Point(138, 100);
            this.lblFromStation.Name = "lblFromStation";
            this.lblFromStation.Size = new System.Drawing.Size(128, 22);
            this.lblFromStation.TabIndex = 15;
            this.lblFromStation.Text = "From Station :";
            // 
            // txtCargoPrice
            // 
            this.txtCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCargoPrice.Location = new System.Drawing.Point(449, 32);
            this.txtCargoPrice.Name = "txtCargoPrice";
            this.txtCargoPrice.ReadOnly = true;
            this.txtCargoPrice.Size = new System.Drawing.Size(84, 23);
            this.txtCargoPrice.TabIndex = 14;
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketPrice.Location = new System.Drawing.Point(322, 33);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(115, 22);
            this.lblTicketPrice.TabIndex = 13;
            this.lblTicketPrice.Text = "CargoPrice :";
            // 
            // txtTrainName
            // 
            this.txtTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrainName.Location = new System.Drawing.Point(166, 32);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(131, 23);
            this.txtTrainName.TabIndex = 12;
            // 
            // lblTrainName
            // 
            this.lblTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(42, 33);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(118, 22);
            this.lblTrainName.TabIndex = 11;
            this.lblTrainName.Text = "Train Name :";
            // 
            // FrmBookCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBookCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Cargo";
            this.Load += new System.EventHandler(this.FrmBookCargo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnBack;
        private Panel panel4;
        private Button btnBookCargo;
        private TextBox txtPrice;
        private NumericUpDown numWeight;
        private Label lblPrice;
        private Label lblWeight;
        private Label lblDate;
        private Label lblToStation;
        private Label lblFromStation;
        private TextBox txtCargoPrice;
        private Label lblTicketPrice;
        private TextBox txtTrainName;
        private Label lblTrainName;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private Label label1;
        private NumericUpDown numDay;
        private Label label3;
        private NumericUpDown numYear;
        private Label label2;
        private NumericUpDown numMonth;
    }
}