using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Programmed by: Michael Wagner
 * ULID: MJWAGN3
 * Date: 4/24/2024
 * Assignment Automotive, Semestor Exam
 * Description:
 * Simple automotive industry
 */
namespace SemesterProject
{
    public partial class Form1 : Form
    {
        //const global varibles for the services 
        const int OIL_CHANGE = 26, LUBE_JOB = 18, RADUATIR_FLUSH = 30, TRANSMISSION_FLUSH = 80, INSPECTION = 15, MUFFLER_REPLACEMENT = 100, TIRE_ROTATION = 20;
        const double SALES_TAX = 0.06;
        bool error = false;

        //parts and labor subTotal and total code
        double parts = 0,labor = 0;
        double subTotal = 0;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OilChangeCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LubeJobCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ReplaceMufflerCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TireRotationCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadiatorFlushCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TransmissionFlushCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PartsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaborTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServiceChargeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdditionalPartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdditionalLaborLabel_Click(object sender, EventArgs e)
        {

        }

        private void TaxOnPartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalFeesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ItemizedSelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //calculates the total
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            subTotal = OilLubeCharges() + MiscCharges() + FlushCharges();
            double laborPlusParts = OtherCharges();
            if (!error)
            {
                ServiceChargeLabel.Text = subTotal.ToString("c");
                AdditionalPartsLabel.Text = parts.ToString("c");
                AdditionalLaborLabel.Text = labor.ToString("c");
                TaxOnPartsLabel.Text = TaxCharges().ToString("c");
                total = subTotal + laborPlusParts + TaxCharges();
                TotalFeesLabel.Text = total.ToString("c");

                if (OilChangeCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(OilChangeCheckedBox.Text);
                }
                if (LubeJobCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(LubeJobCheckedBox.Text);
                }
                if (RadiatorFlushCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(RadiatorFlushCheckedBox.Text);
                }
                if (TransmissionFlushCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(TransmissionFlushCheckedBox.Text);
                }
                if (InspectionCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(InspectionCheckedBox.Text);
                }
                if (ReplaceMufflerCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(ReplaceMufflerCheckedBox.Text);
                }
                if (TireRotationCheckedBox.Checked)
                {
                    ItemizedSelectedListBox.Items.Add(TireRotationCheckedBox.Text);
                }
                ItemizedSelectedListBox.Items.Add(" ");
                ItemizedSelectedListBox.Items.Add("\nThank you!");
            }
            
        }
        //clear text and data
        private void ClearButton_Click(object sender, EventArgs e)
        {
            parts = 0;
            labor = 0;
            subTotal = 0;
            total = 0;
            error = false;
            OilChangeCheckedBox.Checked = false;
            LubeJobCheckedBox.Checked = false;
            RadiatorFlushCheckedBox.Checked = false;
            TransmissionFlushCheckedBox.Checked = false;
            InspectionCheckedBox.Checked = false;
            ReplaceMufflerCheckedBox.Checked = false;
            TireRotationCheckedBox.Checked = false;
            ServiceChargeLabel.Text = "";
            AdditionalLaborLabel.Text = "";
            AdditionalPartsLabel.Text = "";
            TaxOnPartsLabel.Text = "";
            TotalFeesLabel.Text = "";
            ItemizedSelectedListBox.Items.Clear();
            PartsTextBox.Text = "";
            LaborTextbox.Text = "";
        }


        //exits the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void InspectionCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        //checks the if user wants an oil or lube charge and returns total 
        private int OilLubeCharges()
        {
            int charge = 0;
            if (OilChangeCheckedBox.Checked)
            {
                charge += OIL_CHANGE;
            }
            if (LubeJobCheckedBox.Checked)
            {
                charge += LUBE_JOB;
            }
            return charge;
        }
        //checks if the user wants flushed and returns the cost of it
        private int FlushCharges()
        {
            int charge = 0;
            if (RadiatorFlushCheckedBox.Checked)
            {
                charge += RADUATIR_FLUSH;
            }
            if (TransmissionFlushCheckedBox.Checked)
            {
                charge += TRANSMISSION_FLUSH;
            }
            return charge; 
        }

        //checks what other serivces the user wants and returns total
        private int MiscCharges()
        {
            int charge = 0;
            if (InspectionCheckedBox.Checked)
            {
                charge += INSPECTION;
            }
            if (ReplaceMufflerCheckedBox.Checked)
            {
                charge += MUFFLER_REPLACEMENT;
            }
            if (TireRotationCheckedBox.Checked)
            {
                charge += TIRE_ROTATION;
            }
            return charge;
        }
        //gets parts for other charges and returns it
        private double OtherCharges()
        {

            
            double charges = 0;
            
            try
            {
                parts = double.Parse(PartsTextBox.Text);
                try
                {
                    labor = double.Parse(LaborTextbox.Text);
                    if (parts < 0)
                    {
                        parts = 0;
                        MessageBox.Show("No negative numbers for parts!");
                        PartsTextBox.Focus();
                        PartsTextBox.SelectAll();
                        error = true;
                    }
                    else
                    {
                        if (labor < 0)
                        {
                            labor = 0;
                            MessageBox.Show("No negative numbers for parts");
                            LaborTextbox.Focus();
                            LaborTextbox.SelectAll();
                            error = true;
                        }
                        else
                        {
                            charges = labor + parts;
                            error = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LaborTextbox.Focus();
                    LaborTextbox.SelectAll();
                    error = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PartsTextBox.Focus();
                PartsTextBox.SelectAll();
                error = true;
            }
            return charges;
        }
        //calculates tax and returns it for only on parts
        private double TaxCharges()
        {
            return parts * SALES_TAX;
        }
    }

}
