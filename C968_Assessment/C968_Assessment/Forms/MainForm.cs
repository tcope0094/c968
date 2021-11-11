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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /////////////////////////
        // Form Event Handlers //
        /////////////////////////
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            var addPartForm = new PartForm();
            addPartForm.Show();
        }

        private void prodAddBtn_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            partDataGridView.DataSource = Inventory.AllParts;
            prodDataGridView.DataSource = Inventory.Products;
            MainForm.BuildInitialData();
            partDataGridView.ClearSelection();
            prodDataGridView.ClearSelection();
            partModifyBtn.Enabled = false;
            partDeleteBtn.Enabled = false;
            prodModifyBtn.Enabled = false;
            prodDeleteBtn.Enabled = false;
        }

        private void partModifyBtn_Click(object sender, EventArgs e)
        {
            PartModify();
        }

        private void prodDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = prodDataGridView.SelectedRows[0];
                int prodToRemove = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                if(Product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Product contains parts, remove all parts from product before removing product");
                }
                else
                {
                    var deleteConfirm = MessageBox.Show("Are you sure you wish to remove part?", "Confirm Removal", MessageBoxButtons.YesNo);
                    if (deleteConfirm == DialogResult.Yes)
                    {
                        Inventory.RemoveProduct(prodToRemove);
                    }                            
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Product Selected");
            }
        }

        private void prodModifyBtn_Click(object sender, EventArgs e)
        {
            ProductModify();
        }

        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            PartFilter();
        }

        private void partSearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PartFilter();
                e.SuppressKeyPress = true;
            }
        }

        private void partDeleteBtn_Click(object sender, EventArgs e)
        {
            var deleteConfirm = MessageBox.Show("Are you sure you wish to remove part?", "Confirm Removal", MessageBoxButtons.YesNo);
            if(deleteConfirm == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow selectedRow = partDataGridView.SelectedRows[0];
                    int partIdToRemove = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                    Part partToRemove = Inventory.LookupPart(partIdToRemove);
                    Inventory.DeletePart(partToRemove);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No Part Selected");
                }
            }
            
        }

        private void partDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PartModify();
        }



        //////////////////
        // Form Methods //
        //////////////////



        private static void BuildInitialData()
        {
            Inhouse part1 = new Inhouse(1, Part.GetNewPartID(), "hoop", 25.50M, 5, 2, 10);
            Inventory.AddPart(part1);

            Outsourced part2 = new Outsourced("Remo", Part.GetNewPartID(), "drum head", 10.50M, 5, 3, 15);
            Inventory.AddPart(part2);

            Inhouse part3 = new Inhouse(2, Part.GetNewPartID(), "shell", 99.99M, 10, 5, 25);
            Inventory.AddPart(part3);

            Outsourced part4 = new Outsourced("Vic Firth", Part.GetNewPartID(), "drum sticks", 12.50M, 10, 5, 50);
            Inventory.AddPart(part4);

            Inhouse part5 = new Inhouse(3, Part.GetNewPartID(), "hardware", 9.95M, 10, 5, 50);
            Inventory.AddPart(part5);

            Outsourced part6 = new Outsourced("Gator", Part.GetNewPartID(), "drum cases", 119.99M, 2, 1, 6);
            Inventory.AddPart(part6);

            BindingList<Part> redShellPackParts = new BindingList<Part>();
            redShellPackParts.Add(part1);
            redShellPackParts.Add(part3);
            redShellPackParts.Add(part5);
            Product redShellPack = new Product(redShellPackParts, Product.GetNewProductId(), "Red Shell Pack", 499.99M, 2, 1, 5);
            Inventory.AddProduct(redShellPack);

            BindingList<Part> completeKitParts = new BindingList<Part>();
            completeKitParts.Add(part1);
            completeKitParts.Add(part2);
            completeKitParts.Add(part3);
            completeKitParts.Add(part4);
            completeKitParts.Add(part5);
            Product completeKit = new Product(completeKitParts, Product.GetNewProductId(), "Complete Kit", 599.99M, 2, 1, 5);
            Inventory.AddProduct(completeKit);

        }
        private void PartFilter()
        {
            try
            {
                Part searchedPart = Inventory.LookupPart(int.Parse(partSearchTxtBox.Text));
                if (searchedPart != null)
                {
                    int id = searchedPart.PartID;
                    foreach (DataGridViewRow row in partDataGridView.Rows)
                    {
                        if ((int)row.Cells["PartID"].Value == id)
                        {
                            partDataGridView.Rows[row.Index].Selected = true;
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

        private void PartModify()
        {
            try
            {
                DataGridViewRow selectedRow = partDataGridView.SelectedRows[0];
                int partIdToModify = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Part partToModify = Inventory.LookupPart(partIdToModify);
                var modifyPartForm = new PartForm(partToModify);
                modifyPartForm.Show();
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Part Selected");
            }

        }

        private void ProductFilter()
        {
            try
            {
                Product searchedProduct = Inventory.LookupProduct(int.Parse(prodSearchTxtBox.Text));
                if (searchedProduct != null)
                {
                    int id = searchedProduct.ProductID;
                    foreach (DataGridViewRow row in prodDataGridView.Rows)
                    {
                        if ((int)row.Cells["ProductID"].Value == id)
                        {
                            prodDataGridView.Rows[row.Index].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Search term not correct format, input Part ID only");
            }

        }

        private void ProductModify()
        {
            DataGridViewRow selectedRow = prodDataGridView.SelectedRows[0];
            int prodIdToModify = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product prodToModify = Inventory.LookupProduct(prodIdToModify);

            var modifyProdForm = new AddProductForm(prodToModify);
            modifyProdForm.Show();
        }

        private void prodSearchBtn_Click(object sender, EventArgs e)
        {
            ProductFilter();
        }

        private void prodSearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProductFilter();
                e.SuppressKeyPress = true;
            }
        }

        private void partDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (partDataGridView.SelectedRows.Count > 0)
            {
                partModifyBtn.Enabled = true;
                partDeleteBtn.Enabled = true;
            }
            else
            {
                partModifyBtn.Enabled = false;
                partDeleteBtn.Enabled = false;
            }
        }

        private void prodDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductModify();
        }

        private void prodDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (prodDataGridView.SelectedRows.Count > 0)
            {
                prodModifyBtn.Enabled = true;
                prodDeleteBtn.Enabled = true;
            }
            else
            {
                prodModifyBtn.Enabled = false;
                prodDeleteBtn.Enabled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
