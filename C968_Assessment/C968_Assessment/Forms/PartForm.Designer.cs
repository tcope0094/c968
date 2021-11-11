namespace C968_Assessment
{
    partial class PartForm
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
            System.Windows.Forms.Label idLabel;
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.invTxtBox = new System.Windows.Forms.TextBox();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.invLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxTxtBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.machineIdLabel = new System.Windows.Forms.Label();
            this.machineIdTxtBox = new System.Windows.Forms.TextBox();
            this.partTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.outsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.inHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameTxtBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            this.partTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(69, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(94, 69);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(170, 20);
            this.idTxtBox.TabIndex = 1;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(94, 95);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(170, 20);
            this.nameTxtBox.TabIndex = 2;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // invTxtBox
            // 
            this.invTxtBox.Location = new System.Drawing.Point(94, 121);
            this.invTxtBox.Name = "invTxtBox";
            this.invTxtBox.Size = new System.Drawing.Size(170, 20);
            this.invTxtBox.TabIndex = 3;
            this.invTxtBox.TextChanged += new System.EventHandler(this.invTxtBox_TextChanged);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(94, 147);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(170, 20);
            this.priceTxtBox.TabIndex = 4;
            this.priceTxtBox.TextChanged += new System.EventHandler(this.priceTxtBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(57, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // invLabel
            // 
            this.invLabel.AutoSize = true;
            this.invLabel.Location = new System.Drawing.Point(37, 124);
            this.invLabel.Name = "invLabel";
            this.invLabel.Size = new System.Drawing.Size(51, 13);
            this.invLabel.TabIndex = 8;
            this.invLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(57, 150);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price";
            // 
            // maxTxtBox
            // 
            this.maxTxtBox.Location = new System.Drawing.Point(202, 173);
            this.maxTxtBox.Name = "maxTxtBox";
            this.maxTxtBox.Size = new System.Drawing.Size(62, 20);
            this.maxTxtBox.TabIndex = 6;
            this.maxTxtBox.TextChanged += new System.EventHandler(this.maxTxtBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(64, 176);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(169, 176);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // minTxtBox
            // 
            this.minTxtBox.Location = new System.Drawing.Point(94, 173);
            this.minTxtBox.Name = "minTxtBox";
            this.minTxtBox.Size = new System.Drawing.Size(62, 20);
            this.minTxtBox.TabIndex = 5;
            this.minTxtBox.TextChanged += new System.EventHandler(this.minTxtBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(94, 234);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(188, 234);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // machineIdLabel
            // 
            this.machineIdLabel.AutoSize = true;
            this.machineIdLabel.Location = new System.Drawing.Point(10, 202);
            this.machineIdLabel.Name = "machineIdLabel";
            this.machineIdLabel.Size = new System.Drawing.Size(77, 13);
            this.machineIdLabel.TabIndex = 19;
            this.machineIdLabel.Text = "     Machine ID";
            // 
            // machineIdTxtBox
            // 
            this.machineIdTxtBox.Location = new System.Drawing.Point(93, 199);
            this.machineIdTxtBox.Name = "machineIdTxtBox";
            this.machineIdTxtBox.Size = new System.Drawing.Size(170, 20);
            this.machineIdTxtBox.TabIndex = 7;
            this.machineIdTxtBox.TextChanged += new System.EventHandler(this.machineIdTxtBox_TextChanged);
            // 
            // partTypeGroupBox
            // 
            this.partTypeGroupBox.Controls.Add(this.outsourcedRadioBtn);
            this.partTypeGroupBox.Controls.Add(this.inHouseRadioBtn);
            this.partTypeGroupBox.Location = new System.Drawing.Point(84, 13);
            this.partTypeGroupBox.Name = "partTypeGroupBox";
            this.partTypeGroupBox.Size = new System.Drawing.Size(200, 50);
            this.partTypeGroupBox.TabIndex = 0;
            this.partTypeGroupBox.TabStop = false;
            this.partTypeGroupBox.Text = "Part Type";
            // 
            // outsourcedRadioBtn
            // 
            this.outsourcedRadioBtn.AutoSize = true;
            this.outsourcedRadioBtn.Location = new System.Drawing.Point(104, 20);
            this.outsourcedRadioBtn.Name = "outsourcedRadioBtn";
            this.outsourcedRadioBtn.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioBtn.TabIndex = 1;
            this.outsourcedRadioBtn.Text = "Outsourced";
            this.outsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.outsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.outsourcedRadioBtn_CheckedChanged);
            // 
            // inHouseRadioBtn
            // 
            this.inHouseRadioBtn.AutoSize = true;
            this.inHouseRadioBtn.Checked = true;
            this.inHouseRadioBtn.Location = new System.Drawing.Point(10, 20);
            this.inHouseRadioBtn.Name = "inHouseRadioBtn";
            this.inHouseRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadioBtn.TabIndex = 0;
            this.inHouseRadioBtn.TabStop = true;
            this.inHouseRadioBtn.Text = "In-House";
            this.inHouseRadioBtn.UseVisualStyleBackColor = true;
            this.inHouseRadioBtn.CheckedChanged += new System.EventHandler(this.inHouseRadioBtn_CheckedChanged);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(5, 273);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.companyNameLabel.TabIndex = 22;
            this.companyNameLabel.Text = "Company Name";
            this.companyNameLabel.Visible = false;
            // 
            // companyNameTxtBox
            // 
            this.companyNameTxtBox.Location = new System.Drawing.Point(93, 270);
            this.companyNameTxtBox.Name = "companyNameTxtBox";
            this.companyNameTxtBox.Size = new System.Drawing.Size(170, 20);
            this.companyNameTxtBox.TabIndex = 7;
            this.companyNameTxtBox.Visible = false;
            this.companyNameTxtBox.TextChanged += new System.EventHandler(this.companyNameTxtBox_TextChanged);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 316);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyNameTxtBox);
            this.Controls.Add(this.partTypeGroupBox);
            this.Controls.Add(this.machineIdLabel);
            this.Controls.Add(this.machineIdTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.minTxtBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTxtBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.invLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.invTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.partTypeGroupBox.ResumeLayout(false);
            this.partTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox invTxtBox;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label invLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox maxTxtBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox minTxtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label machineIdLabel;
        private System.Windows.Forms.TextBox machineIdTxtBox;
        private System.Windows.Forms.GroupBox partTypeGroupBox;
        private System.Windows.Forms.RadioButton outsourcedRadioBtn;
        private System.Windows.Forms.RadioButton inHouseRadioBtn;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameTxtBox;
    }
}