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
    public partial class PartForm : Form
    {
        public enum FormType { Add, Edit }
        public enum PartType { Inhouse, Outsourced }
        public FormType formType;
        public PartType partType;
        private bool nameValid = false;
        private bool invValid = false;        
        private bool priceValid = false;
        private bool minValid = false;
        private bool maxValid = false;
        private bool minMaxValid = false;
        private bool machineIdValid = false;
        private bool companyNameValid = false;
        
        public PartForm()
        {
            InitializeComponent();
            partType = PartType.Inhouse;
            formType = FormType.Add;
            idTxtBox.Text = Part.GetNewPartID().ToString();
        }

        //overloaded constructor for if its an existing part to modify
        public PartForm(Part partToModify)
        {
            InitializeComponent();
            formType = FormType.Edit;
            if (partToModify is Inhouse)
            {
                Inhouse inhousePartToModify = (Inhouse)partToModify;
                
                inHouseRadioBtn.Checked = true;
                companyNameLabel.Visible = false;
                companyNameTxtBox.Visible = false;
                machineIdLabel.Visible = true;
                machineIdTxtBox.Visible = true;
                machineIdTxtBox.Text = inhousePartToModify.MachineID.ToString();
                
            }
            else
            {
                Outsourced outsourcedPartToModify = (Outsourced)partToModify;
                companyNameTxtBox.Text = outsourcedPartToModify.CompanyName;
                outsourcedRadioBtn.Checked = true;
                companyNameLabel.Visible = true;
                companyNameTxtBox.Visible = true;
                machineIdLabel.Visible = false;
                machineIdTxtBox.Visible = false;
                companyNameLabel.Location = machineIdLabel.Location;
                companyNameTxtBox.Location = machineIdTxtBox.Location;
            }

            idTxtBox.Text = partToModify.PartID.ToString();
            nameTxtBox.Text = partToModify.Name;
            invTxtBox.Text = partToModify.InStock.ToString();
            priceTxtBox.Text = partToModify.Price.ToString();
            minTxtBox.Text = partToModify.Min.ToString();
            maxTxtBox.Text = partToModify.Max.ToString();
            FormComplete();
        }
        private void AddPartForm_Load(object sender, EventArgs e)
        {
            if (formType == FormType.Add)
            {
                Text = "Add Part";
            }
            else
            {
                Text = "Modify Part";
            }
            saveBtn.Enabled = false;
            ValidateStringTextBox(nameTxtBox);
            ValidateIntTextBox(invTxtBox);
            ValidateDecimalTextBox(priceTxtBox);
            ValidateIntTextBox(minTxtBox);
            ValidateIntTextBox(maxTxtBox);
            ValidateIntTextBox(machineIdTxtBox);
            ValidateStringTextBox(companyNameTxtBox);
            
        }

        ////////////////////
        // event handlers //
        ////////////////////
        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == inHouseRadioBtn)
            {
                PartType partType = PartType.Inhouse;
                companyNameLabel.Visible = false;
                companyNameTxtBox.Visible = false;
                machineIdLabel.Visible = true;
                machineIdTxtBox.Visible = true;
                companyNameValid = false;
                FormComplete();
            }
        }

        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == outsourcedRadioBtn)
            {
                PartType partType = PartType.Outsourced;
                machineIdLabel.Visible = false;
                machineIdTxtBox.Visible = false;
                companyNameLabel.Location = machineIdLabel.Location;
                companyNameTxtBox.Location = machineIdTxtBox.Location;
                companyNameLabel.Visible = true;
                companyNameTxtBox.Visible = true;
                machineIdValid = false;
                FormComplete();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (inHouseRadioBtn.Checked == true)
            {
                Inhouse newPart = new Inhouse(int.Parse(machineIdTxtBox.Text), int.Parse(idTxtBox.Text), nameTxtBox.Text, decimal.Parse(priceTxtBox.Text), int.Parse(invTxtBox.Text), int.Parse(minTxtBox.Text), int.Parse(maxTxtBox.Text));
                if(formType == FormType.Add)
                {
                    Save(newPart);
                }
                else
                {
                    Save(int.Parse(idTxtBox.Text), newPart);
                }
            }
            else
            {
                Outsourced newPart = new Outsourced(companyNameTxtBox.Text, int.Parse(idTxtBox.Text), nameTxtBox.Text, decimal.Parse(priceTxtBox.Text), int.Parse(invTxtBox.Text), int.Parse(minTxtBox.Text), int.Parse(maxTxtBox.Text));
                if (formType == FormType.Add)
                {
                    Save(newPart);
                }
                else
                {
                    Save(int.Parse(idTxtBox.Text), newPart);
                }
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void machineIdTxtBox_TextChanged(object sender, EventArgs e)
        {
            machineIdValid = ValidateIntTextBox(machineIdTxtBox);
            FormComplete();
        }
        private void companyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            companyNameValid = ValidateStringTextBox(companyNameTxtBox);
            FormComplete();
        }

        //////////////////
        // form methods //
        //////////////////
        
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
            if (nameValid && invValid && priceValid && minValid && maxValid && minMaxValid && (machineIdValid || companyNameValid))
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }
        private void Save(Part newPart)
        {
            Inventory.AddPart(newPart);
        }
        private void Save(int partIdToUpdate, Part newPart)
        {
            Inventory.UpdatePart(partIdToUpdate, newPart);
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
            if(minTxtBox.Text == "" || maxTxtBox.Text == "" || invTxtBox.Text == "")
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
    }
}
