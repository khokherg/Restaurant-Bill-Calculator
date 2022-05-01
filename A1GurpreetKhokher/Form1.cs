using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1GurpreetKhokher
{
    public partial class restaurantBillCalculator : Form
    {
        static decimal subTotal = 0;
        static decimal tax = 0;
        static decimal total = 0;
        decimal itemPrice = 0;
        
        public restaurantBillCalculator()
        {
            InitializeComponent();
        }


        private void restaurantBillCalculator_Load(object sender, EventArgs e)
        {
            cmbBeverages.Items.Insert(0, "Select Beverages");
            cmbBeverages.SelectedIndex = 0;
            cmbAppetizers.Items.Insert(0, "Select Appetizers");
            cmbAppetizers.SelectedIndex = 0;
            cmbMainCourse.Items.Insert(0, "Select Main Course");
            cmbMainCourse.SelectedIndex = 0;
            cmbDesserts.Items.Insert(0, "Select Desserts");
            cmbDesserts.SelectedIndex = 0;
            lblSubTotal.Text = subTotal.ToString("C2");
            lblTax.Text = tax.ToString("C2");
            lblTotal.Text = total.ToString("C2");
        }


        //CLEAR BILL BUTTON FUNCTIONALITY CODE
        private void btnClearBill_Click(object sender, EventArgs e)
        {
            cmbBeverages.Items.Insert(0, "Select Beveraages");
            cmbBeverages.SelectedIndex = 0;
            cmbAppetizers.Items.Insert(0, "Select Appetizers");
            cmbAppetizers.SelectedIndex = 0;
            cmbMainCourse.Items.Insert(0, "Select Main Course");
            cmbMainCourse.SelectedIndex = 0;
            cmbDesserts.Items.Insert(0, "Select Dessert");
            cmbDesserts.SelectedIndex = 0;
            lblSubTotal.Text = "$0.00";
            lblTax.Text = "$0.00";
            lblTotal.Text = "$0.00";
            lstItems.Items.Clear();
            subTotal = 0;
            total = 0;
            tax = 0;
        }


        private void cmbBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if (cmbBeverages.SelectedIndex>0)
            {
                lstItems.Items.Add(cmbBeverages.Text);
            }

              CalculateBill(cmbBeverages.Text);     
        }
        

        private void cmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAppetizers.SelectedIndex > 0)
            {
                lstItems.Items.Add(cmbAppetizers.Text);
            }
              CalculateBill(cmbAppetizers.Text);
        }


        private void cmbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainCourse.SelectedIndex > 0)
            {
                lstItems.Items.Add(cmbMainCourse.Text);
            }
              CalculateBill(cmbMainCourse.Text);
        }


        private void cmbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesserts.SelectedIndex > 0)
            {
                lstItems.Items.Add(cmbDesserts.Text);
            }
              CalculateBill(cmbDesserts.Text);
        }


        //METHOD TO CALCULATE BILL
        private void CalculateBill(string itemType)
        {
            try
            {
                itemPrice = Convert.ToDecimal(itemType.Split('$')[1]);


                subTotal += itemPrice;
                tax = subTotal * 13 / 100;
                total = tax + subTotal;

                lblSubTotal.Text = subTotal.ToString("C2");
                lblTax.Text = tax.ToString("C2");
                lblTotal.Text = total.ToString("C2");
            }
            catch { }
        }


        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
         
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblSTotal1_Click(object sender, EventArgs e)
        {

        }
    }
}

