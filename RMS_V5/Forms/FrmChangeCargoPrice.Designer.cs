namespace RMS_V5.Forms
{
    partial class FrmChangeCargoPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeCargoPrice));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.txtOLdPrice = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(10, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 32);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblOldPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOldPrice.Location = new System.Drawing.Point(31, 130);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(98, 22);
            this.lblOldPrice.TabIndex = 25;
            this.lblOldPrice.Text = "Old Price :";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNewPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPrice.Location = new System.Drawing.Point(24, 171);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(105, 22);
            this.lblNewPrice.TabIndex = 24;
            this.lblNewPrice.Text = "New Price :";
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTrainName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainName.Location = new System.Drawing.Point(11, 89);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(118, 22);
            this.lblTrainName.TabIndex = 23;
            this.lblTrainName.Text = "Train Name :";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(192, 268);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(83, 32);
            this.btnChange.TabIndex = 22;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(135, 170);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(100, 23);
            this.txtNewPrice.TabIndex = 19;
            // 
            // txtOLdPrice
            // 
            this.txtOLdPrice.Location = new System.Drawing.Point(135, 129);
            this.txtOLdPrice.Name = "txtOLdPrice";
            this.txtOLdPrice.ReadOnly = true;
            this.txtOLdPrice.Size = new System.Drawing.Size(100, 23);
            this.txtOLdPrice.TabIndex = 20;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(135, 88);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(144, 23);
            this.txtTrainName.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 26);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Change Cargo Price";
            // 
            // FrmChangeCargoPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 311);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.lblTrainName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.txtOLdPrice);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChangeCargoPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo Price";
            this.Load += new System.EventHandler(this.FrmChangeCargoPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblOldPrice;
        private Label lblNewPrice;
        private Label lblTrainName;
        private Button btnChange;
        private TextBox txtNewPrice;
        private TextBox txtOLdPrice;
        private TextBox txtTrainName;
        private Label lblTitle;
    }
}