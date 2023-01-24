namespace RMS_V5.Forms
{
    partial class FrmEditRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditRoute));
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumAth = new System.Windows.Forms.NumericUpDown();
            this.btnEditRoute = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAtm)).BeginInit();
            this.SuspendLayout();
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
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Edit Route >>";
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
            this.panel2.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(193, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 65);
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
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(699, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 423);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.NumAth);
            this.panel4.Controls.Add(this.btnEditRoute);
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
            this.panel4.TabIndex = 7;
            // 
            // NumAth
            // 
            this.NumAth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumAth.Location = new System.Drawing.Point(148, 137);
            this.NumAth.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumAth.Name = "NumAth";
            this.NumAth.Size = new System.Drawing.Size(43, 23);
            this.NumAth.TabIndex = 32;
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRoute.Location = new System.Drawing.Point(433, 378);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoute.TabIndex = 31;
            this.btnEditRoute.Text = "Edit Route";
            this.btnEditRoute.UseVisualStyleBackColor = true;
            this.btnEditRoute.Click += new System.EventHandler(this.btnEditRoute_Click);
            // 
            // btnAddStattion
            // 
            this.btnAddStattion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStattion.Location = new System.Drawing.Point(382, 166);
            this.btnAddStattion.Name = "btnAddStattion";
            this.btnAddStattion.Size = new System.Drawing.Size(100, 23);
            this.btnAddStattion.TabIndex = 30;
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
            this.gvStations.Location = new System.Drawing.Point(0, 195);
            this.gvStations.Name = "gvStations";
            this.gvStations.RowTemplate.Height = 25;
            this.gvStations.Size = new System.Drawing.Size(514, 150);
            this.gvStations.TabIndex = 29;
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
            this.NumDtm.Location = new System.Drawing.Point(439, 137);
            this.NumDtm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumDtm.Name = "NumDtm";
            this.NumDtm.Size = new System.Drawing.Size(43, 23);
            this.NumDtm.TabIndex = 28;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTime.Location = new System.Drawing.Point(255, 141);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(121, 19);
            this.lblDepartureTime.TabIndex = 27;
            this.lblDepartureTime.Text = "DepartureTime :";
            // 
            // NumDth
            // 
            this.NumDth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumDth.Location = new System.Drawing.Point(382, 137);
            this.NumDth.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumDth.Name = "NumDth";
            this.NumDth.Size = new System.Drawing.Size(43, 23);
            this.NumDth.TabIndex = 26;
            // 
            // NumAtm
            // 
            this.NumAtm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumAtm.Location = new System.Drawing.Point(205, 137);
            this.NumAtm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumAtm.Name = "NumAtm";
            this.NumAtm.Size = new System.Drawing.Size(43, 23);
            this.NumAtm.TabIndex = 25;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrivalTime.Location = new System.Drawing.Point(39, 141);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(103, 19);
            this.lblArrivalTime.TabIndex = 24;
            this.lblArrivalTime.Text = "Arrival Time :";
            // 
            // txtStationName
            // 
            this.txtStationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStationName.Location = new System.Drawing.Point(148, 97);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(100, 23);
            this.txtStationName.TabIndex = 23;
            // 
            // lblStationName
            // 
            this.lblStationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStationName.Location = new System.Drawing.Point(33, 101);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(109, 19);
            this.lblStationName.TabIndex = 22;
            this.lblStationName.Text = "Station Name :";
            // 
            // lblCargoPrice
            // 
            this.lblCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCargoPrice.AutoSize = true;
            this.lblCargoPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargoPrice.Location = new System.Drawing.Point(279, 58);
            this.lblCargoPrice.Name = "lblCargoPrice";
            this.lblCargoPrice.Size = new System.Drawing.Size(97, 19);
            this.lblCargoPrice.TabIndex = 21;
            this.lblCargoPrice.Text = "Cargo Price :";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketPrice.Location = new System.Drawing.Point(277, 21);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(99, 19);
            this.lblTicketPrice.TabIndex = 20;
            this.lblTicketPrice.Text = "Ticket Price :";
            // 
            // txtCargoPrice
            // 
            this.txtCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCargoPrice.Location = new System.Drawing.Point(382, 58);
            this.txtCargoPrice.Name = "txtCargoPrice";
            this.txtCargoPrice.Size = new System.Drawing.Size(100, 23);
            this.txtCargoPrice.TabIndex = 18;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicketPrice.Location = new System.Drawing.Point(382, 21);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(100, 23);
            this.txtTicketPrice.TabIndex = 17;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrainName.Location = new System.Drawing.Point(148, 21);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(100, 23);
            this.txtTrainName.TabIndex = 19;
            // 
            // lblTrainName
            // 
            this.lblTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(45, 25);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(97, 19);
            this.lblTrainName.TabIndex = 16;
            this.lblTrainName.Text = "Train Name :";
            // 
            // FrmEditRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Route";
            this.Load += new System.EventHandler(this.FrmEditRoute_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Button btnBack;
        private Label label7;
        private Panel panel2;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown NumAth;
        private Button btnEditRoute;
        private Button btnAddStattion;
        private DataGridView gvStations;
        private NumericUpDown NumDtm;
        private Label lblDepartureTime;
        private NumericUpDown NumDth;
        private NumericUpDown NumAtm;
        private Label lblArrivalTime;
        private TextBox txtStationName;
        private Label lblStationName;
        private Label lblCargoPrice;
        private Label lblTicketPrice;
        private TextBox txtCargoPrice;
        private TextBox txtTicketPrice;
        private TextBox txtTrainName;
        private Label lblTrainName;
        private DataGridViewButtonColumn Delete;
    }
}