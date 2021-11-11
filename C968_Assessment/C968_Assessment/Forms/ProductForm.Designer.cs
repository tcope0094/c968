namespace C968_Assessment
{
    partial class AddProductForm
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
            this.productsLabel = new System.Windows.Forms.Label();
            this.minTxtBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTxtBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.invLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.invTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.addPartDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.addPartToProdBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partSearchTxtBox = new System.Windows.Forms.TextBox();
            this.partSearchBtn = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(49, 120);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 20;
            idLabel.Text = "ID";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(70, 25);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(126, 24);
            this.productsLabel.TabIndex = 11;
            this.productsLabel.Text = "Add Product";
            // 
            // minTxtBox
            // 
            this.minTxtBox.Location = new System.Drawing.Point(74, 221);
            this.minTxtBox.Name = "minTxtBox";
            this.minTxtBox.Size = new System.Drawing.Size(62, 20);
            this.minTxtBox.TabIndex = 18;
            this.minTxtBox.TextChanged += new System.EventHandler(this.minTxtBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(44, 224);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 24;
            this.minLabel.Text = "Min";
            // 
            // maxTxtBox
            // 
            this.maxTxtBox.Location = new System.Drawing.Point(182, 221);
            this.maxTxtBox.Name = "maxTxtBox";
            this.maxTxtBox.Size = new System.Drawing.Size(62, 20);
            this.maxTxtBox.TabIndex = 19;
            this.maxTxtBox.TextChanged += new System.EventHandler(this.maxTxtBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(37, 198);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Price";
            // 
            // invLabel
            // 
            this.invLabel.AutoSize = true;
            this.invLabel.Location = new System.Drawing.Point(17, 172);
            this.invLabel.Name = "invLabel";
            this.invLabel.Size = new System.Drawing.Size(51, 13);
            this.invLabel.TabIndex = 22;
            this.invLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(74, 195);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(170, 20);
            this.priceTxtBox.TabIndex = 17;
            this.priceTxtBox.TextChanged += new System.EventHandler(this.priceTxtBox_TextChanged);
            // 
            // invTxtBox
            // 
            this.invTxtBox.Location = new System.Drawing.Point(74, 169);
            this.invTxtBox.Name = "invTxtBox";
            this.invTxtBox.Size = new System.Drawing.Size(170, 20);
            this.invTxtBox.TabIndex = 16;
            this.invTxtBox.TextChanged += new System.EventHandler(this.invTxtBox_TextChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(74, 143);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(170, 20);
            this.nameTxtBox.TabIndex = 15;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(74, 117);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(170, 20);
            this.idTxtBox.TabIndex = 14;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(149, 224);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 25;
            this.maxLabel.Text = "Max";
            // 
            // addPartDataGridView
            // 
            this.addPartDataGridView.AllowUserToResizeRows = false;
            this.addPartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addPartDataGridView.Location = new System.Drawing.Point(386, 85);
            this.addPartDataGridView.Name = "addPartDataGridView";
            this.addPartDataGridView.RowHeadersVisible = false;
            this.addPartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addPartDataGridView.Size = new System.Drawing.Size(379, 150);
            this.addPartDataGridView.TabIndex = 26;
            this.addPartDataGridView.SelectionChanged += new System.EventHandler(this.addPartDataGridView_SelectionChanged);
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.AllowUserToResizeRows = false;
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(386, 327);
            this.associatedPartsDataGridView.MultiSelect = false;
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.RowHeadersVisible = false;
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(379, 150);
            this.associatedPartsDataGridView.TabIndex = 27;
            this.associatedPartsDataGridView.SelectionChanged += new System.EventHandler(this.associatedPartsDataGridView_SelectionChanged);
            // 
            // addPartToProdBtn
            // 
            this.addPartToProdBtn.Location = new System.Drawing.Point(648, 241);
            this.addPartToProdBtn.Name = "addPartToProdBtn";
            this.addPartToProdBtn.Size = new System.Drawing.Size(117, 23);
            this.addPartToProdBtn.TabIndex = 28;
            this.addPartToProdBtn.Text = "Add Part To Product";
            this.addPartToProdBtn.UseVisualStyleBackColor = true;
            this.addPartToProdBtn.Click += new System.EventHandler(this.addPartToProdBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(594, 502);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 29;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(500, 502);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(690, 502);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "All Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // partSearchTxtBox
            // 
            this.partSearchTxtBox.Location = new System.Drawing.Point(485, 59);
            this.partSearchTxtBox.Name = "partSearchTxtBox";
            this.partSearchTxtBox.Size = new System.Drawing.Size(198, 20);
            this.partSearchTxtBox.TabIndex = 35;
            // 
            // partSearchBtn
            // 
            this.partSearchBtn.Location = new System.Drawing.Point(689, 59);
            this.partSearchBtn.Name = "partSearchBtn";
            this.partSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.partSearchBtn.TabIndex = 34;
            this.partSearchBtn.Text = "Search";
            this.partSearchBtn.UseVisualStyleBackColor = true;
            this.partSearchBtn.Click += new System.EventHandler(this.prodSearchBtn_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.partSearchTxtBox);
            this.Controls.Add(this.partSearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addPartToProdBtn);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.addPartDataGridView);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTxtBox);
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
            this.Controls.Add(this.productsLabel);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.TextBox minTxtBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTxtBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label invLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox invTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.DataGridView addPartDataGridView;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
        private System.Windows.Forms.Button addPartToProdBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partSearchTxtBox;
        private System.Windows.Forms.Button partSearchBtn;
    }
}