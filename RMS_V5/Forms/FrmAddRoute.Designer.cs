namespace RMS_V5.Forms
{
    partial class FrmAddRoute
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumAth = new System.Windows.Forms.NumericUpDown();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnAddStattion = new System.Windows.Forms.Button();
            this.gvStations = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NumDtm = new System.Windows.Forms.NumericUpDown();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.NumDth = new System.Windows.Forms.NumericUpDown();
            this.NumAtm = new System.Windows.Forms.NumericUpDown();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblCargoPrice = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtCargoPrice = new System.Windows.Forms.TextBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAtm)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(189, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 65);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "RAILWAY MANAGMENT SYSTEM ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 423);
            this.panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 36);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Add New Route >>";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(699, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 423);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.NumAth);
            this.panel4.Controls.Add(this.btnAddRoute);
            this.panel4.Controls.Add(this.btnAddStattion);
            this.panel4.Controls.Add(this.gvStations);
            this.panel4.Controls.Add(this.NumDtm);
            this.panel4.Controls.Add(this.lblDepartureTime);
            this.panel4.Controls.Add(this.NumDth);
            this.panel4.Controls.Add(this.NumAtm);
            this.panel4.Controls.Add(this.lblArrivalTime);
            this.panel4.Controls.Add(this.txtStationName);
            this.panel4.Controls.Add(this.lblStationName);
            this.panel4.Controls.Add(this.lblCargoPrice);
            this.panel4.Controls.Add(this.lblTicketPrice);
            this.panel4.Controls.Add(this.txtCargoPrice);
            this.panel4.Controls.Add(this.txtTicketPrice);
            this.panel4.Controls.Add(this.txtTrainName);
            this.panel4.Controls.Add(this.lblTrainName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(185, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 423);
            this.panel4.TabIndex = 3;
            // 
            // NumAth
            // 
            this.NumAth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumAth.Location = new System.Drawing.Point(148, 147);
            this.NumAth.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumAth.Name = "NumAth";
            this.NumAth.Size = new System.Drawing.Size(43, 23);
            this.NumAth.TabIndex = 15;
            this.NumAth.ValueChanged += new System.EventHandler(this.NumAth_ValueChanged);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRoute.Location = new System.Drawing.Point(433, 388);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoute.TabIndex = 14;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnAddStattion
            // 
            this.btnAddStattion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStattion.Location = new System.Drawing.Point(382, 176);
            this.btnAddStattion.Name = "btnAddStattion";
            this.btnAddStattion.Size = new System.Drawing.Size(100, 23);
            this.btnAddStattion.TabIndex = 13;
            this.btnAddStattion.Text = "Add Station";
            this.btnAddStattion.UseVisualStyleBackColor = true;
            this.btnAddStattion.Click += new System.EventHandler(this.btnAddStattion_Click);
            // 
            // gvStations
            // 
            this.gvStations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStations.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.gvStations.Location = new System.Drawing.Point(0, 205);
            this.gvStations.Name = "gvStations";
            this.gvStations.RowTemplate.Height = 25;
            this.gvStations.Size = new System.Drawing.Size(514, 150);
            this.gvStations.TabIndex = 12;
            this.gvStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStations_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 46;
            // 
            // NumDtm
            // 
            this.NumDtm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumDtm.Location = new System.Drawing.Point(439, 147);
            this.NumDtm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumDtm.Name = "NumDtm";
            this.NumDtm.Size = new System.Drawing.Size(43, 23);
            this.NumDtm.TabIndex = 11;
            this.NumDtm.ValueChanged += new System.EventHandler(this.NumDtm_ValueChanged);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTime.Location = new System.Drawing.Point(255, 151);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(121, 19);
            this.lblDepartureTime.TabIndex = 10;
            this.lblDepartureTime.Text = "DepartureTime :";
            this.lblDepartureTime.Click += new System.EventHandler(this.lblDepartureTime_Click);
            // 
            // NumDth
            // 
            this.NumDth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumDth.Location = new System.Drawing.Point(382, 147);
            this.NumDth.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumDth.Name = "NumDth";
            this.NumDth.Size = new System.Drawing.Size(43, 23);
            this.NumDth.TabIndex = 9;
            this.NumDth.ValueChanged += new System.EventHandler(this.NumDth_ValueChanged);
            // 
            // NumAtm
            // 
            this.NumAtm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumAtm.Location = new System.Drawing.Point(205, 147);
            this.NumAtm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumAtm.Name = "NumAtm";
            this.NumAtm.Size = new System.Drawing.Size(43, 23);
            this.NumAtm.TabIndex = 8;
            this.NumAtm.ValueChanged += new System.EventHandler(this.NumAtm_ValueChanged);
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrivalTime.Location = new System.Drawing.Point(39, 151);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(103, 19);
            this.lblArrivalTime.TabIndex = 7;
            this.lblArrivalTime.Text = "Arrival Time :";
            this.lblArrivalTime.Click += new System.EventHandler(this.lblArrivalTime_Click);
            // 
            // txtStationName
            // 
            this.txtStationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStationName.Location = new System.Drawing.Point(148, 107);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(100, 23);
            this.txtStationName.TabIndex = 4;
            this.txtStationName.TextChanged += new System.EventHandler(this.txtStationName_TextChanged);
            // 
            // lblStationName
            // 
            this.lblStationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStationName.Location = new System.Drawing.Point(33, 111);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(109, 19);
            this.lblStationName.TabIndex = 3;
            this.lblStationName.Text = "Station Name :";
            this.lblStationName.Click += new System.EventHandler(this.lblStationName_Click);
            // 
            // lblCargoPrice
            // 
            this.lblCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCargoPrice.AutoSize = true;
            this.lblCargoPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargoPrice.Location = new System.Drawing.Point(279, 68);
            this.lblCargoPrice.Name = "lblCargoPrice";
            this.lblCargoPrice.Size = new System.Drawing.Size(97, 19);
            this.lblCargoPrice.TabIndex = 2;
            this.lblCargoPrice.Text = "Cargo Price :";
            this.lblCargoPrice.Click += new System.EventHandler(this.lblCargoPrice_Click);
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketPrice.Location = new System.Drawing.Point(277, 31);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(99, 19);
            this.lblTicketPrice.TabIndex = 2;
            this.lblTicketPrice.Text = "Ticket Price :";
            this.lblTicketPrice.Click += new System.EventHandler(this.lblTicketPrice_Click);
            // 
            // txtCargoPrice
            // 
            this.txtCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCargoPrice.Location = new System.Drawing.Point(382, 68);
            this.txtCargoPrice.Name = "txtCargoPrice";
            this.txtCargoPrice.Size = new System.Drawing.Size(100, 23);
            this.txtCargoPrice.TabIndex = 1;
            this.txtCargoPrice.TextChanged += new System.EventHandler(this.txtCargoPrice_TextChanged);
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketPrice.Location = new System.Drawing.Point(382, 31);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(100, 23);
            this.txtTicketPrice.TabIndex = 1;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrainName.Location = new System.Drawing.Point(148, 31);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(100, 23);
            this.txtTrainName.TabIndex = 1;
            this.txtTrainName.TextChanged += new System.EventHandler(this.txtTrainName_TextChanged);
            // 
            // lblTrainName
            // 
            this.lblTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(45, 35);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(97, 19);
            this.lblTrainName.TabIndex = 0;
            this.lblTrainName.Text = "Train Name :";
            this.lblTrainName.Click += new System.EventHandler(this.lblTrainName_Click);
            // 
            // FrmAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Route";
            this.Load += new System.EventHandler(this.FrmAddRoute_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDtm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAtm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblTitle;
        private TextBox txtTrainName;
        private Label lblTrainName;
        private Label lblCargoPrice;
        private Label lblTicketPrice;
        private TextBox txtCargoPrice;
        private TextBox txtTicketPrice;
        private TextBox txtStationName;
        private Label lblStationName;
        private NumericUpDown NumDtm;
        private Label lblDepartureTime;
        private NumericUpDown NumDth;
        private NumericUpDown NumAtm;
        private Label lblArrivalTime;
        private DataGridView gvStations;
        private Button btnAddStattion;
        private Label label7;
        private Button btnAddRoute;
        private NumericUpDown NumAth;
        private Button btnBack;
        private DataGridViewButtonColumn Delete;
    }
}