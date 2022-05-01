namespace A1GurpreetKhokher
{
    partial class restaurantBillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restaurantBillCalculator));
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblSTotal1 = new System.Windows.Forms.Label();
            this.lblTax1 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMainCourse = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.cmbBeverages = new System.Windows.Forms.ComboBox();
            this.lblChooseAppetizers = new System.Windows.Forms.Label();
            this.lblChooseMainCourse = new System.Windows.Forms.Label();
            this.lblChooseDessert = new System.Windows.Forms.Label();
            this.lblChooseBeverages = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBoxStudentInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(328, 70);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(156, 173);
            this.lstItems.TabIndex = 5;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // lblSTotal1
            // 
            this.lblSTotal1.AutoSize = true;
            this.lblSTotal1.Location = new System.Drawing.Point(325, 271);
            this.lblSTotal1.Name = "lblSTotal1";
            this.lblSTotal1.Size = new System.Drawing.Size(56, 13);
            this.lblSTotal1.TabIndex = 6;
            this.lblSTotal1.Text = "Sub Total:";
            this.lblSTotal1.Click += new System.EventHandler(this.lblSTotal1_Click);
            // 
            // lblTax1
            // 
            this.lblTax1.AutoSize = true;
            this.lblTax1.Location = new System.Drawing.Point(325, 304);
            this.lblTax1.Name = "lblTax1";
            this.lblTax1.Size = new System.Drawing.Size(65, 13);
            this.lblTax1.TabIndex = 7;
            this.lblTax1.Text = "Tax @ 13%:";
            this.lblTax1.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(325, 343);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(34, 13);
            this.lblTotal1.TabIndex = 8;
            this.lblTotal1.Text = "Total:";
            // 
            // btnClearBill
            // 
            this.btnClearBill.Location = new System.Drawing.Point(410, 390);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(75, 23);
            this.btnClearBill.TabIndex = 12;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(51, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(446, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restaurant Bill Calculator";
            // 
            // grpBoxStudentInfo
            // 
            this.grpBoxStudentInfo.Controls.Add(this.label12);
            this.grpBoxStudentInfo.Controls.Add(this.label11);
            this.grpBoxStudentInfo.Controls.Add(this.label10);
            this.grpBoxStudentInfo.Controls.Add(this.label9);
            this.grpBoxStudentInfo.Location = new System.Drawing.Point(48, 271);
            this.grpBoxStudentInfo.Name = "grpBoxStudentInfo";
            this.grpBoxStudentInfo.Size = new System.Drawing.Size(254, 142);
            this.grpBoxStudentInfo.TabIndex = 17;
            this.grpBoxStudentInfo.TabStop = false;
            this.grpBoxStudentInfo.Text = "Student Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "991434458";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Gurpreet Kaur Khokher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Student ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name: ";
            // 
            // cmbMainCourse
            // 
            this.cmbMainCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCourse.FormattingEnabled = true;
            this.cmbMainCourse.Items.AddRange(new object[] {
            "Seafood Alfredo   $15.95",
            "Chicken Alfredo   $13.95",
            "Turkey Club    $11.95",
            "Lobster Pie   $19.95",
            "Prime Rib    $20.95",
            "Shrimp Scampi   $18.95",
            "Turkey Dinner   $13.95",
            "Stuffed Chicken   $14.95"});
            this.cmbMainCourse.Location = new System.Drawing.Point(133, 96);
            this.cmbMainCourse.Name = "cmbMainCourse";
            this.cmbMainCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbMainCourse.TabIndex = 2;
            this.cmbMainCourse.SelectedIndexChanged += new System.EventHandler(this.cmbMainCourse_SelectedIndexChanged);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Items.AddRange(new object[] {
            "Buffalo Wings   $5.95",
            "Buffalo Fingers   $6.95",
            "Potato Skins   $8.95",
            "Nachos    $8.95",
            "Mushroom Caps   $10.95",
            "Shrimp Coxktail     $12.95",
            "Chips and Salsa    $6.95"});
            this.cmbAppetizers.Location = new System.Drawing.Point(133, 58);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(121, 21);
            this.cmbAppetizers.TabIndex = 1;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.cmbAppetizers_SelectedIndexChanged);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "Apple Pie    $5.95",
            "Sundae       $3.95",
            "Carrot Cake  $5.95",
            "Mud Pie   $4.95",
            "Apple Crisp    $5.95"});
            this.cmbDesserts.Location = new System.Drawing.Point(133, 132);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(121, 21);
            this.cmbDesserts.TabIndex = 3;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.cmbDesserts_SelectedIndexChanged);
            // 
            // cmbBeverages
            // 
            this.cmbBeverages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeverages.FormattingEnabled = true;
            this.cmbBeverages.Items.AddRange(new object[] {
            "Soda       $1.95",
            "Tea        $1.50",
            "Coffee   $1.25",
            "Mineral Water $2.95",
            "Juice   $2.50",
            "Milk     $1.50"});
            this.cmbBeverages.Location = new System.Drawing.Point(133, 19);
            this.cmbBeverages.Name = "cmbBeverages";
            this.cmbBeverages.Size = new System.Drawing.Size(121, 21);
            this.cmbBeverages.TabIndex = 0;
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.cmbBeverages_SelectedIndexChanged);
            // 
            // lblChooseAppetizers
            // 
            this.lblChooseAppetizers.AutoSize = true;
            this.lblChooseAppetizers.Location = new System.Drawing.Point(6, 66);
            this.lblChooseAppetizers.Name = "lblChooseAppetizers";
            this.lblChooseAppetizers.Size = new System.Drawing.Size(98, 13);
            this.lblChooseAppetizers.TabIndex = 5;
            this.lblChooseAppetizers.Text = "Choose Appetizers:";
            // 
            // lblChooseMainCourse
            // 
            this.lblChooseMainCourse.AutoSize = true;
            this.lblChooseMainCourse.Location = new System.Drawing.Point(6, 104);
            this.lblChooseMainCourse.Name = "lblChooseMainCourse";
            this.lblChooseMainCourse.Size = new System.Drawing.Size(108, 13);
            this.lblChooseMainCourse.TabIndex = 6;
            this.lblChooseMainCourse.Text = "Choose Main Course:";
            // 
            // lblChooseDessert
            // 
            this.lblChooseDessert.AutoSize = true;
            this.lblChooseDessert.Location = new System.Drawing.Point(6, 140);
            this.lblChooseDessert.Name = "lblChooseDessert";
            this.lblChooseDessert.Size = new System.Drawing.Size(85, 13);
            this.lblChooseDessert.TabIndex = 7;
            this.lblChooseDessert.Text = "Choose Dessert:";
            // 
            // lblChooseBeverages
            // 
            this.lblChooseBeverages.AutoSize = true;
            this.lblChooseBeverages.Location = new System.Drawing.Point(6, 27);
            this.lblChooseBeverages.Name = "lblChooseBeverages";
            this.lblChooseBeverages.Size = new System.Drawing.Size(100, 13);
            this.lblChooseBeverages.TabIndex = 8;
            this.lblChooseBeverages.Text = "Choose Beverages:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblChooseDessert);
            this.groupBox2.Controls.Add(this.lblChooseAppetizers);
            this.groupBox2.Controls.Add(this.lblChooseBeverages);
            this.groupBox2.Controls.Add(this.lblChooseMainCourse);
            this.groupBox2.Controls.Add(this.cmbBeverages);
            this.groupBox2.Controls.Add(this.cmbDesserts);
            this.groupBox2.Controls.Add(this.cmbAppetizers);
            this.groupBox2.Controls.Add(this.cmbMainCourse);
            this.groupBox2.Location = new System.Drawing.Point(48, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 173);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Items";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(406, 261);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(78, 23);
            this.lblSubTotal.TabIndex = 19;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubTotal.Click += new System.EventHandler(this.lblSubTotal_Click);
            // 
            // lblTax
            // 
            this.lblTax.Location = new System.Drawing.Point(406, 304);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(78, 23);
            this.lblTax.TabIndex = 20;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(406, 338);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 23);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // restaurantBillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(532, 432);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxStudentInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearBill);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.lblTax1);
            this.Controls.Add(this.lblSTotal1);
            this.Controls.Add(this.lstItems);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "restaurantBillCalculator";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.restaurantBillCalculator_Load);
            this.grpBoxStudentInfo.ResumeLayout(false);
            this.grpBoxStudentInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblSTotal1;
        private System.Windows.Forms.Label lblTax1;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBoxStudentInfo;
        private System.Windows.Forms.ComboBox cmbMainCourse;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.ComboBox cmbBeverages;
        private System.Windows.Forms.Label lblChooseAppetizers;
        private System.Windows.Forms.Label lblChooseMainCourse;
        private System.Windows.Forms.Label lblChooseDessert;
        private System.Windows.Forms.Label lblChooseBeverages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

