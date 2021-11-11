using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Assessment
{
    public partial class AddProductForm : Form
    {
        public enum FormType { Add, Edit}
        public FormType formType;
        public BindingList<Part> newProdParts = new BindingList<Part>();

        private bool nameValid = false;
        private bool invValid = false;
        private bool priceValid = false;
        private bool minValid = false;
        private bool maxValid = false;
        private bool minMaxValid = false;
        public AddProductForm()
        {
            InitializeComponent();
            formType = FormType.Add;
            idTxtBox.Text = Product.GetNewProductId().ToString();
        }

        public AddProductForm(Product productToModify)
        {
            InitializeComponent();
            formType = FormType.Edit;
            idTxtBox.Text = productToModify.ProductID.ToString();
            nameTxtBox.Text = productToModify.Name;
            invTxtBox.Text = productToModify.InStock.ToString();
            priceTxtBox.Text = productToModify.Price.ToString();
            minTxtBox.Text = productToModify.Min.ToString();
            maxTxtBox.Text = productToModify.Max.ToString();        
        }


        private void AddProductForm_Load(object sender, EventArgs e)
        {
            addPartDataGridView.DataSource = Inventory.AllParts;
            if (formType == FormType.Add)
            {
                associatedPartsDataGridView.DataSource = newProdParts;
            }
            else
            {
                productsLabel.Text = "Modify Product";
                Text = "Modify Product";
                associatedPartsDataGridView.DataSource = Product.AssociatedParts;
            }
            addPartDataGridView.ClearSelection();
            associatedPartsDataGridView.ClearSelection();
            addPartToProdBtn.Enabled = false;
            delBtn.Enabled = false;
            saveBtn.Enabled = false;
            ValidateStringTextBox(nameTxtBox);
            ValidateIntTextBox(invTxtBox);
            ValidateDecimalTextBox(priceTxtBox);
            ValidateIntTextBox(minTxtBox);
            ValidateIntTextBox(maxTxtBox);

        }
        private void PartFilter()
        {
            try
            {
                Part searchedPart = Inventory.LookupPart(int.Parse(partSearchTxtBox.Text));
                if (searchedPart != null)
                {
                    int id = searchedPart.PartID;
                    foreach (DataGridViewRow row in addPartDataGridView.Rows)
                    {
                        if ((int)row.Cells["PartID"].Value == id)
                        {
                            addPartDataGridView.Rows[row.Index].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Part not found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Search term not correct format, input Part ID only");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prodSearchBtn_Click(object sender, EventArgs e)
        {
            PartFilter();
        }

        private void addPartToProdBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addPartDataGridView.SelectedRows)
            {
                int partIdToAddToProduct = Convert.ToInt32(row.Cells["PartID"].Value);
                Part partToAddToProduct = Inventory.LookupPart(partIdToAddToProduct);

                if(formType == FormType.Add)
                {
                    newProdParts.Add(partToAddToProduct);
                }
                else
                {
                    Product.AddAssociatedPart(partToAddToProduct);
                }                
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTxtBox.Text);
            string name = nameTxtBox.Text;
            decimal price = decimal.Parse(priceTxtBox.Text);
            int inStock = int.Parse(invTxtBox.Text);
            int min = int.Parse(minTxtBox.Text);
            int max = int.Parse(maxTxtBox.Text);

            if (formType == FormType.Add)
            {
                Product newProduct = new Product(newProdParts, id, name, price, inStock, min, max);
                Save(newProduct);
            }
            else
            {
                Product newProduct = new Product(Product.AssociatedParts, id, name, price, inStock, min, max);
                Save(newProduct.ProductID, newProduct);
            }            
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var deleteConfirm = MessageBox.Show("Are you sure you wish to remove part?","Confirm Removal", MessageBoxButtons.YesNo);
            if(deleteConfirm == DialogResult.Yes)
            {
                DataGridViewRow row = associatedPartsDataGridView.SelectedRows[0];
                int partIdToRemove = Convert.ToInt32(row.Cells["PartID"].Value);
                if (formType == FormType.Add)
                {
                    for (int i = 0; i < newProdParts.Count; i++)
                    {
                        if (newProdParts[i].PartID == partIdToRemove)
                        {
                            newProdParts.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    Part partToRemove = Product.LookupAssociatedPart(partIdToRemove);
                    Product.RemoveAssociatedPart(partIdToRemove);
                }
                FormComplete();
            }
        }

        private void addPartDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(addPartDataGridView.SelectedRows.Count > 0)
            {
                addPartToProdBtn.Enabled = true;
            }
        }

        private void associatedPartsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (associatedPartsDataGridView.SelectedRows.Count > 0)
            {
                delBtn.Enabled = true;
            }
            else
            {
                delBtn.Enabled = false;
            }
        }


        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            PartFilter();
        }
         

        private void partSearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PartFilter();
                e.SuppressKeyPress = true;
            }
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            nameValid = ValidateStringTextBox(nameTxtBox);
            FormComplete();
        }
        private void invTxtBox_TextChanged(object sender, EventArgs e)
        {
            invValid = CompareInStock();
            FormComplete();
        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {
            priceValid = ValidateDecimalTextBox(priceTxtBox);
            FormComplete();
        }
        private void minTxtBox_TextChanged(object sender, EventArgs e)
        {
            minValid = ValidateIntTextBox(minTxtBox);
            minMaxValid = CompareMinMax();
            invValid = CompareInStock();
            FormComplete();

        }

        private void maxTxtBox_TextChanged(object sender, EventArgs e)
        {
            maxValid = ValidateIntTextBox(maxTxtBox);
            minMaxValid = CompareMinMax();
            invValid = CompareInStock();
            FormComplete();
        }

        protected bool ValidateIntTextBox(TextBox boxToValidate)
        {
            if (!int.TryParse(boxToValidate.Text, out int result))
            {
                boxToValidate.BackColor = Color.Red;
                return false;

            }
            else
            {
                boxToValidate.BackColor = Color.White;
                return true;
            }
        }
        protected bool ValidateDecimalTextBox(TextBox boxToValidate)
        {
            if (!decimal.TryParse(boxToValidate.Text, out decimal result))
            {
                boxToValidate.BackColor = Color.Red;
                return false;
            }
            else
            {
                boxToValidate.BackColor = Color.White;
                return true;
            }
        }
        protected bool ValidateStringTextBox(TextBox boxToValidate)
        {
            if (boxToValidate.Text == "")
            {
                boxToValidate.BackColor = Color.Red;
                return false;
            }
            else
            {
                boxToValidate.BackColor = Color.White;
                return true;
            }
        }

        private void FormComplete()
        {
            if (nameValid && invValid && priceValid && minValid && maxValid && minMaxValid)
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }
        private bool CompareMinMax()
        {
            
            if (minTxtBox.Text == "" || maxTxtBox.Text == "")
            {
                return false;
            }
            else
            {
                try
                {
                    int min = int.Parse(minTxtBox.Text);
                    int max = int.Parse(maxTxtBox.Text);

                    if (min > max)
                    {
                        ToolTip minMaxFail = new ToolTip();
                        minMaxFail.Show("Min value must be less than max value.", maxLabel, -20, 20, 5000);
                        minValid = false;
                        maxValid = false;
                        minTxtBox.BackColor = Color.Red;
                        maxTxtBox.BackColor = Color.Red;

                        return false;
                    }
                    else
                    {
                        minValid = ValidateIntTextBox(minTxtBox);
                        maxValid = ValidateIntTextBox(maxTxtBox);
                        return true;
                    }

                }
                catch (FormatException)
                {
                    return false;
                }
                
            }
        }
        private bool CompareInStock()
        {
            if (minTxtBox.Text == "" || maxTxtBox.Text == "" || invTxtBox.Text == "")
            {
                return false;
            }
            else
            {
                try
                {
                    int min = int.Parse(minTxtBox.Text);
                    int max = int.Parse(maxTxtBox.Text);
                    int inStock = int.Parse(invTxtBox.Text);

                    if (inStock > max || inStock < min)
                    {
                        ToolTip inStockFail = new ToolTip();
                        inStockFail.Show("InStock value must be greater than Min and less than Max.", invTxtBox, -20, 20, 5000);
                        invValid = false;
                        invTxtBox.BackColor = Color.Red;
                        return false;
                    }
                    else
                    {
                        invValid = ValidateIntTextBox(invTxtBox);
                        return true;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
                
            }
        }
        private void Save(Product newProduct)
        {
            Inventory.AddProduct(newProduct);
        }
        private void Save(int prodIdToUpdate, Product newProduct)
        {
            Inventory.UpdateProduct(prodIdToUpdate, newProduct);
        }

    }
}
