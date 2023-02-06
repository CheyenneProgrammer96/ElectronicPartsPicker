namespace ElectronicPartsPicker
{
    partial class CustomerForm
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(304, 82);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 39);
            this.txtFName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(304, 333);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 39);
            this.txtAddress.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(304, 240);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(200, 39);
            this.txtOrderNumber.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(304, 420);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(200, 39);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(96, 82);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(129, 32);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "First Name";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(96, 240);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(170, 32);
            this.lblOrderNumber.TabIndex = 5;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(96, 322);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 32);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(89, 427);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(162, 32);
            this.lblEmailAddress.TabIndex = 7;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(89, 525);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(177, 32);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(304, 522);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 39);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(96, 153);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(126, 32);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(304, 153);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 39);
            this.txtLName.TabIndex = 10;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(279, 669);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(252, 78);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 819);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFName);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFName;
        private TextBox txtAddress;
        private TextBox txtOrderNumber;
        private TextBox txtEmailAddress;
        private Label lblFName;
        private Label lblOrderNumber;
        private Label lblAddress;
        private Label lblEmailAddress;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblLName;
        private TextBox txtLName;
        private Button btnPlaceOrder;
    }
}