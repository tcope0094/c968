namespace C968_Assessment
{
    partial class MainForm
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
            this.partSearchBtn = new System.Windows.Forms.Button();
            this.partSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.partModifyBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.prodDeleteBtn = new System.Windows.Forms.Button();
            this.prodModifyBtn = new System.Windows.Forms.Button();
            this.prodAddBtn = new System.Windows.Forms.Button();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.productsLabel = new System.Windows.Forms.Label();
            this.prodSearchTxtBox = new System.Windows.Forms.TextBox();
            this.prodSearchBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partSearchBtn
            // 
            this.partSearchBtn.Location = new System.Drawing.Point(521, 92);
            this.partSearchBtn.Name = "partSearchBtn";
            this.partSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.partSearchBtn.TabIndex = 0;
            this.partSearchBtn.Text = "Search";
            this.partSearchBtn.UseVisualStyleBackColor = true;
            this.partSearchBtn.Click += new System.EventHandler(this.partSearchBtn_Click);
            // 
            // partSearchTxtBox
            // 
            this.partSearchTxtBox.Location = new System.Drawing.Point(317, 92);
            this.partSearchTxtBox.Name = "partSearchTxtBox";
            this.partSearchTxtBox.Size = new System.Drawing.Size(198, 20);
            this.partSearchTxtBox.TabIndex = 1;
            this.partSearchTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.partSearchTxtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToResizeRows = false;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partDataGridView.Location = new System.Drawing.Point(17, 133);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.RowHeadersVisible = false;
            this.partDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(577, 253);
            this.partDataGridView.TabIndex = 4;
            this.partDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partDataGridView_CellContentDoubleClick);
            this.partDataGridView.SelectionChanged += new System.EventHandler(this.partDataGridView_SelectionChanged);
            // 
            // partAddBtn
            // 
            this.partAddBtn.Location = new System.Drawing.Point(17, 392);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 23);
            this.partAddBtn.TabIndex = 5;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = true;
            this.partAddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // partModifyBtn
            // 
            this.partModifyBtn.Location = new System.Drawing.Point(98, 392);
            this.partModifyBtn.Name = "partModifyBtn";
            this.partModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.partModifyBtn.TabIndex = 6;
            this.partModifyBtn.Text = "Modify";
            this.partModifyBtn.UseVisualStyleBackColor = true;
            this.partModifyBtn.Click += new System.EventHandler(this.partModifyBtn_Click);
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Location = new System.Drawing.Point(179, 392);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.partDeleteBtn.TabIndex = 7;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            this.partDeleteBtn.Click += new System.EventHandler(this.partDeleteBtn_Click);
            // 
            // prodDeleteBtn
            // 
            this.prodDeleteBtn.Location = new System.Drawing.Point(855, 392);
            this.prodDeleteBtn.Name = "prodDeleteBtn";
            this.prodDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.prodDeleteBtn.TabIndex = 14;
            this.prodDeleteBtn.Text = "Delete";
            this.prodDeleteBtn.UseVisualStyleBackColor = true;
            this.prodDeleteBtn.Click += new System.EventHandler(this.prodDeleteBtn_Click);
            // 
            // prodModifyBtn
            // 
            this.prodModifyBtn.Location = new System.Drawing.Point(774, 392);
            this.prodModifyBtn.Name = "prodModifyBtn";
            this.prodModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.prodModifyBtn.TabIndex = 13;
            this.prodModifyBtn.Text = "Modify";
            this.prodModifyBtn.UseVisualStyleBackColor = true;
            this.prodModifyBtn.Click += new System.EventHandler(this.prodModifyBtn_Click);
            // 
            // prodAddBtn
            // 
            this.prodAddBtn.Location = new System.Drawing.Point(693, 392);
            this.prodAddBtn.Name = "prodAddBtn";
            this.prodAddBtn.Size = new System.Drawing.Size(75, 23);
            this.prodAddBtn.TabIndex = 12;
            this.prodAddBtn.Text = "Add";
            this.prodAddBtn.UseVisualStyleBackColor = true;
            this.prodAddBtn.Click += new System.EventHandler(this.prodAddBtn_Click);
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.AllowUserToResizeRows = false;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.prodDataGridView.Location = new System.Drawing.Point(693, 133);
            this.prodDataGridView.MultiSelect = false;
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersVisible = false;
            this.prodDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.prodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDataGridView.Size = new System.Drawing.Size(577, 253);
            this.prodDataGridView.TabIndex = 11;
            this.prodDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentDoubleClick);
            this.prodDataGridView.SelectionChanged += new System.EventHandler(this.prodDataGridView_SelectionChanged);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(689, 87);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(92, 24);
            this.productsLabel.TabIndex = 10;
            this.productsLabel.Text = "Products";
            // 
            // prodSearchTxtBox
            // 
            this.prodSearchTxtBox.Location = new System.Drawing.Point(990, 93);
            this.prodSearchTxtBox.Name = "prodSearchTxtBox";
            this.prodSearchTxtBox.Size = new System.Drawing.Size(198, 20);
            this.prodSearchTxtBox.TabIndex = 9;
            this.prodSearchTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prodSearchTxtBox_KeyDown);
            // 
            // prodSearchBtn
            // 
            this.prodSearchBtn.Location = new System.Drawing.Point(1194, 93);
            this.prodSearchBtn.Name = "prodSearchBtn";
            this.prodSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.prodSearchBtn.TabIndex = 8;
            this.prodSearchBtn.Text = "Search";
            this.prodSearchBtn.UseVisualStyleBackColor = true;
            this.prodSearchBtn.Click += new System.EventHandler(this.prodSearchBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1195, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prodDeleteBtn);
            this.Controls.Add(this.prodModifyBtn);
            this.Controls.Add(this.prodAddBtn);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.prodSearchTxtBox);
            this.Controls.Add(this.prodSearchBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.partModifyBtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.partDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partSearchTxtBox);
            this.Controls.Add(this.partSearchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button partSearchBtn;
        private System.Windows.Forms.TextBox partSearchTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView partDataGridView;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button partModifyBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button prodDeleteBtn;
        private System.Windows.Forms.Button prodModifyBtn;
        private System.Windows.Forms.Button prodAddBtn;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.TextBox prodSearchTxtBox;
        private System.Windows.Forms.Button prodSearchBtn;
        private System.Windows.Forms.Button exitButton;
    }
}

