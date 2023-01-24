namespace RMS_V5.Forms
{
    partial class FrmRouteData
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gvStations = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.lblRouteCargoPrice = new System.Windows.Forms.Label();
            this.lblRouteTrainName = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.lblCargoPrice = new System.Windows.Forms.Label();
            this.lblRouteTicketPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStations)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.lblTitle.Location = new System.Drawing.Point(186, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 57);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "RAILWAY MANAGMENT SYSTEM ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 423);
            this.panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(0, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(728, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 423);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.gvStations);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(156, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 423);
            this.panel4.TabIndex = 3;
            // 
            // gvStations
            // 
            this.gvStations.AllowUserToResizeColumns = false;
            this.gvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStations.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStations.Location = new System.Drawing.Point(0, 151);
            this.gvStations.Name = "gvStations";
            this.gvStations.ReadOnly = true;
            this.gvStations.RowTemplate.Height = 25;
            this.gvStations.Size = new System.Drawing.Size(572, 272);
            this.gvStations.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTrainName);
            this.panel5.Controls.Add(this.lblRouteCargoPrice);
            this.panel5.Controls.Add(this.lblRouteTrainName);
            this.panel5.Controls.Add(this.lblTicketPrice);
            this.panel5.Controls.Add(this.lblCargoPrice);
            this.panel5.Controls.Add(this.lblRouteTicketPrice);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 151);
            this.panel5.TabIndex = 6;
            // 
            // lblTrainName
            // 
            this.lblTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(165, 23);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(97, 19);
            this.lblTrainName.TabIndex = 0;
            this.lblTrainName.Text = "Train Name :";
            // 
            // lblRouteCargoPrice
            // 
            this.lblRouteCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRouteCargoPrice.AutoSize = true;
            this.lblRouteCargoPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblRouteCargoPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRouteCargoPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteCargoPrice.Location = new System.Drawing.Point(268, 103);
            this.lblRouteCargoPrice.Name = "lblRouteCargoPrice";
            this.lblRouteCargoPrice.Size = new System.Drawing.Size(13, 19);
            this.lblRouteCargoPrice.TabIndex = 5;
            this.lblRouteCargoPrice.Text = " ";
            // 
            // lblRouteTrainName
            // 
            this.lblRouteTrainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRouteTrainName.AutoSize = true;
            this.lblRouteTrainName.BackColor = System.Drawing.SystemColors.Control;
            this.lblRouteTrainName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRouteTrainName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteTrainName.Location = new System.Drawing.Point(268, 23);
            this.lblRouteTrainName.Name = "lblRouteTrainName";
            this.lblRouteTrainName.Size = new System.Drawing.Size(13, 19);
            this.lblRouteTrainName.TabIndex = 3;
            this.lblRouteTrainName.Text = " ";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketPrice.Location = new System.Drawing.Point(159, 62);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(103, 19);
            this.lblTicketPrice.TabIndex = 1;
            this.lblTicketPrice.Text = "Ticket Price  :";
            // 
            // lblCargoPrice
            // 
            this.lblCargoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCargoPrice.AutoSize = true;
            this.lblCargoPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargoPrice.Location = new System.Drawing.Point(159, 103);
            this.lblCargoPrice.Name = "lblCargoPrice";
            this.lblCargoPrice.Size = new System.Drawing.Size(101, 19);
            this.lblCargoPrice.TabIndex = 2;
            this.lblCargoPrice.Text = "Cargo Price  :";
            // 
            // lblRouteTicketPrice
            // 
            this.lblRouteTicketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRouteTicketPrice.AutoSize = true;
            this.lblRouteTicketPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblRouteTicketPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRouteTicketPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteTicketPrice.Location = new System.Drawing.Point(268, 62);
            this.lblRouteTicketPrice.Name = "lblRouteTicketPrice";
            this.lblRouteTicketPrice.Size = new System.Drawing.Size(13, 19);
            this.lblRouteTicketPrice.TabIndex = 4;
            this.lblRouteTicketPrice.Text = " ";
            // 
            // FrmRouteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRouteData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Route Data";
            this.Load += new System.EventHandler(this.FrmRouteData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStations)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblTitle;
        private Label lblRouteCargoPrice;
        private Label lblRouteTicketPrice;
        private Label lblRouteTrainName;
        private Label lblCargoPrice;
        private Label lblTicketPrice;
        private Label lblTrainName;
        private DataGridView gvStations;
        private Panel panel5;
        private Button btnBack;
    }
}