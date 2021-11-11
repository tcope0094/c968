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
    public partial class ModifyPart : BasePartForm
    {
        public enum PartType { Inhouse, Outsourced }
        public PartType partType;
        public ModifyPart(Part partToModify)
        {
            InitializeComponent();
            if(partToModify is Inhouse)
            {
                Inhouse inhousePartToModify = (Inhouse)partToModify;
                machineIdTxtBox.Text = inhousePartToModify.MachineID.ToString();
            }
            else
            {
                Outsourced outsourcedPartToModify = (Outsourced)partToModify;
                companyNameTxtBox.Text = outsourcedPartToModify.CompanyName;
            }
            
            idTxtBox.Text = partToModify.PartID.ToString();
            nameTxtBox.Text = partToModify.Name;
            invTxtBox.Text = partToModify.InStock.ToString();
            priceTxtBox.Text = partToModify.Price.ToString();
            minTxtBox.Text = partToModify.Min.ToString();
            maxTxtBox.Text = partToModify.Max.ToString();

        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void inHouseRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender == inHouseRadioBtn)
            {
                partType = PartType.Inhouse;
                companyNameLabel.Visible = false;
                companyNameTxtBox.Visible = false;
                machineIdLabel.Visible = true;
                machineIdTxtBox.Visible = true;
                //FormComplete();
            }
        }

        private void outsourcedRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender == outsourcedRadioBtn)
            {
                partType = PartType.Outsourced;
                machineIdLabel.Visible = false;
                machineIdTxtBox.Visible = false;
                companyNameLabel.Location = machineIdLabel.Location;
                companyNameTxtBox.Location = machineIdTxtBox.Location;
                companyNameLabel.Visible = true;
                companyNameTxtBox.Visible = true;
                //FormComplete();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (partType == PartType.Inhouse)
            {
                Inhouse newPart = new Inhouse(int.Parse(machineIdTxtBox.Text), int.Parse(idTxtBox.Text), nameTxtBox.Text, decimal.Parse(priceTxtBox.Text), int.Parse(invTxtBox.Text), int.Parse(minTxtBox.Text), int.Parse(maxTxtBox.Text));
                Inventory.UpdatePart(int.Parse(idTxtBox.Text), newPart);
            }
            else
            {
                Outsourced newPart = new Outsourced(companyNameTxtBox.Text, int.Parse(idTxtBox.Text), nameTxtBox.Text, decimal.Parse(priceTxtBox.Text), int.Parse(invTxtBox.Text), int.Parse(minTxtBox.Text), int.Parse(maxTxtBox.Text));
                Inventory.UpdatePart(int.Parse(idTxtBox.Text), newPart);
            }
            this.Close();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            //nameValid = ValidateStringTextBox(nameTxtBox);
            //FormComplete();
        }

        private void invTxtBox_TextChanged(object sender, EventArgs e)
        {
            //invValid = ValidateIntTextBox(invTxtBox);
            //FormComplete();
        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {
            //priceValid = ValidateDecimalTextBox(priceTxtBox);
            //FormComplete();
        }

        private void minTxtBox_TextChanged(object sender, EventArgs e)
        {
            //minValid = ValidateIntTextBox(minTxtBox);
            //FormComplete();
        }

        private void maxTxtBox_TextChanged(object sender, EventArgs e)
        {
            //maxValid = ValidateIntTextBox(maxTxtBox);
            //FormComplete();
        }

        private void machineIdTxtBox_TextChanged(object sender, EventArgs e)
        {
            //machineIdValid =ValidateIntTextBox(machineIdTxtBox);
            //FormComplete();
        }

        private void companyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            //companyNameValid = ValidateStringTextBox(companyNameTxtBox);
            //FormComplete();
        }

        //////////////////////
        // method overrides //
        //////////////////////

        
    }
}
